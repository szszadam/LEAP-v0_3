using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAP_v0_3
{
    //      ***** Individual Test Sheet Sending Window class *****
    //
    //
    // The class for sending edited worksheets to users, which is a descendant of the "Form" class.
    // The main elements appearing on its graphical interface are the "DataGridView" control
    // for selecting the edited test sheet, the "DataGridView" control for selecting the targeted
    // users, and the checkboxes in the rows of users.As well as the "Send test sheets" button,
    // that finalizes the selections.
    //
    //     *** Fields ***
    //
    // UserId: int - it is used to temporarily store the ID of selected users during the iteration
    // process of uploading to the database.
    //
    //
    // EditedTestSheetID: int - is used to temporarily store the ID of the selected edited test
    // sheet during the iteration process of uploading to the database.
    //
    //
    // PointsEarned: string – an auxiliary variable that is used to store the achieved points per
    // task during the iteration process of uploading to the database.These earned points will be
    // stored in one text field in the database, using the “unit separator” character '▼'.
    // These earned points represent only 0-0-0... when creating the individual worksheet.
    //
    //
    // Tasks: string - it is used to temporarily store the IDs of the tasks on the selected
    // task sheet during the iteration process of uploading to the database.These IDs will be
    // stored in one text field in the database, using the “unit separator” character '▼'.
    //
    //
    // AnswerMarkingsTable: string - it is used to temporarily store the answer options marked in
    // the multiple-choice tasks on the selected test sheet, during the iteration process of
    // uploading to the database.These answers will be stored in one text field in the database,
    // using the “unit” and “record” separator characters '▲' and '▼'. The “unit separator”
    // character '▼' separates the multiple-choice tasks from each other, and the “record separator”
    // character '▲' separates the answer marks within these tasks.When creating an individual
    // test sheet, each answer mark takes the value "false".
    //
    //
    // EssayAnswers: string - it is used to temporarily store the answers to the essay tasks on
    // the selected test sheet during the iteration process of uploading to the database.These
    // answers will be stored in a text field in the database, using the “unit separator”
    // character '▼'. When creating an individual test sheet, there is only a " " (space) in place
    // of the answers.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // IndividualTestSheetSendingWindow_Load() – As a result of clicking on the "Send test sheets"
    // button on the graphic interface, the FillUserSelectorDGV()
    // and the FillEditedTestSheetSelectorDGV() methods will be are called.
    //
    //
    // FillEditedTestSheetSelectorDGV() – It populates the "DataGridView" control listing the
    // edited test sheets with data.The method uses some auxiliary variables while it is running.
    // After populating the controller, it sorts the rows by the "subject" property in ABC order.
    //
    //
    // FillUserSelectorDGV() - It populates the "DataGridView" control listing users with data.
    // The method uses some auxiliary variables while it is running.Each line (representing
    // one user) is supplemented with a check box, which allows you to select more users. At a
    // certain point of its run, it calls another method called
    // ConvertSubjectsTaughtFromListToString_Comma(). After uploading the controller,
    // it sorts the rows by the "grade" property in descending order.
    //
    //
    // SendTestSheetsButton_Click() event handler – As a result of clicking on the "Send test sheets" button,
    // new rows are created in the database in the table called "IndividualTestSheets", using the
    // appropriate data of the selected, edited test sheets and users.The method also uses
    // additional, internal auxiliary fields during the iteration process of uploading to the
    // database.Furthermore, the event also calls the following methods during its run:
    // ConvertEarnedPointsFromListToString(), 
    // LockEditedTestSheet(), 
    // ConvertEssayAnswersFromListToString(),
    // UploadDataToLEAP_DB(),
    // EditedTestSheet.EditorTasksConvertFromListToString(),
    // IndividualTestSheet.SetupAnswerMarkingsTableDimensions(),
    // ConvertAnswerMarkingsFromArrayToString_False(),
    // IndividualTestSheet.SetupKeywordFulfillmentTableDimensions(),
    // ConvertKeywordFulfillmentFromArrayToString_False(), 
    // Program.ReadDataFromDatabase()
    //
    //
    //
    // ConvertEarnedPointsFromListToString() – It links together the earned point values into a
    // text, in accordance with the formal requirements of the PointsEarned field(for uploading
    // to the database. Described above in the PointsEarned field paragraph).
    //
    //
    // ConvertAnswerMarkingsFromArrayToString_False() - The multiple-choice answer markings are
    // combined into one text in accordance with the formal requirements of the field named
    // AnswerMarkingsTable (for uploading to the database. Described above in the AnswerMarkingsTable
    // field paragraph), but here by default all answer markings are given the value "false" yet.
    //
    //
    // ConvertEssayAnswersFromListToString() – It links together the answers to the essay tasks
    // into one text in accordance with the formal requirements of the field called EssayAnswers
    // (for uploading to the database. Described above in the EssayAnswers field paragraph)
    //
    //
    // ConvertSubjectsTaughtFromListToString_Comma() – The teachers and administrators in the
    // "DataGridView" control, which lists the users, links together the taught subjects into a
    // comma-separated text.
    //
    //
    // UploadDataToLEAP_DB() – Individual test sheet are created by selecting an edited test sheet
    // and users and clicking the "Send test sheets" button.First it uploads the desired data into
    // the database into the "IndividualTestSheets" table.After successful uploading, returning
    // to the main window, the IndividualTestSheetList in the "DB_connection" class will be updated.
    //
    //
    // LockEditedTestSheet() – When the individual test sheet is created as described above, this
    // method locks the related edited test sheet (if it hasn't been done before). The method
    // rewrites the lock value of the related edited test sheet to "true" in the SQL database.

    public partial class IndividualTestSheetSendingWindow : Form
    {
        int UserId;
        int EditedTestSheetID;
        string PointsEarned;
        string Tasks;
        string AnswerMarkingsTable;
        string EssayAnswers;
        string KeywordFulfillmentTable;

        public IndividualTestSheetSendingWindow()
        {
            InitializeComponent();
        }

        private void IndividualTestSheetSendingWindow_Load(object sender, EventArgs e)
        {
            FillUserSelectorDGV();
            FillEditedTestSheetSelectorDGV();
        }
        private void FillEditedTestSheetSelectorDGV()
        {
            int EditedTestSheetID_Auxiliary;
            string testSheetSubject_Auxiliary;
            string testSheetTopic_Auxiliary;
            int taskGrade_Auxiliary;
            int pointsAvailable_Auxiliary;
            int timeLimit_Auxiliary;
            string taskLocked_Auxiliary;

            EditedTestSheetSelectorDGV.Rows.Clear();

            List<string> UserSubjectsTaughtAuxiliary;

            if (UserIdentification.ActiveUser is Administrator)
            {
                UserSubjectsTaughtAuxiliary = (UserIdentification.ActiveUser as Administrator).SubjectsTaughtList;
            }
            else if (UserIdentification.ActiveUser is Teacher)
            {
                UserSubjectsTaughtAuxiliary = (UserIdentification.ActiveUser as Teacher).SubjectsTaughtList;
            }
            else
            {
                UserSubjectsTaughtAuxiliary = new List<string>();
            }
            if (UserIdentification.ActiveUser is Administrator)
            {
                for (int i = 0; i < DB_Connection.EditedTestSheetList.Count; i++)
                {
                    EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList[i];
                    EditedTestSheetID_Auxiliary = CurrentEditedTestSheet.SQL_ID;
                    testSheetSubject_Auxiliary = CurrentEditedTestSheet.Subject;
                    testSheetTopic_Auxiliary = CurrentEditedTestSheet.Topic;
                    taskGrade_Auxiliary = CurrentEditedTestSheet.Grade;
                    pointsAvailable_Auxiliary = CurrentEditedTestSheet.TotalPointsAvailable;
                    timeLimit_Auxiliary = CurrentEditedTestSheet.AvailableTime;
                    taskLocked_Auxiliary = CurrentEditedTestSheet.LockedTestSheet ? "Yes" : "No";
                    EditedTestSheetSelectorDGV.Rows.Add(EditedTestSheetID_Auxiliary, testSheetSubject_Auxiliary, testSheetTopic_Auxiliary, taskGrade_Auxiliary, pointsAvailable_Auxiliary, timeLimit_Auxiliary, taskLocked_Auxiliary);
                }
            }
            else if (UserIdentification.ActiveUser is Teacher)
            {
                for (int i = 0; i < DB_Connection.EditedTestSheetList.Count; i++)
                {
                    EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList[i];
                    if ((UserIdentification.ActiveUser as Teacher).SubjectsTaughtList.Contains(CurrentEditedTestSheet.Subject, StringComparer.CurrentCultureIgnoreCase))
                    {
                        EditedTestSheetID_Auxiliary = CurrentEditedTestSheet.SQL_ID;
                        testSheetSubject_Auxiliary = CurrentEditedTestSheet.Subject;
                        testSheetTopic_Auxiliary = CurrentEditedTestSheet.Topic;
                        taskGrade_Auxiliary = CurrentEditedTestSheet.Grade;
                        pointsAvailable_Auxiliary = CurrentEditedTestSheet.TotalPointsAvailable;
                        timeLimit_Auxiliary = CurrentEditedTestSheet.AvailableTime;
                        taskLocked_Auxiliary = CurrentEditedTestSheet.LockedTestSheet ? "Yes" : "No";
                        EditedTestSheetSelectorDGV.Rows.Add(EditedTestSheetID_Auxiliary, testSheetSubject_Auxiliary, testSheetTopic_Auxiliary, taskGrade_Auxiliary, pointsAvailable_Auxiliary, timeLimit_Auxiliary, taskLocked_Auxiliary);
                    }
                }
            }
            EditedTestSheetSelectorDGV.Sort(EditedTestSheetSelectorDGV.Columns[1], ListSortDirection.Ascending);
        }
        private void FillUserSelectorDGV()
        {
            int userID_Auxiliary;
            string familyName_Auxiliary;
            string firstName_Auxiliary;
            string authorizationLevel_Auxiliary;
            List<string> subjectsTaughtList_Auxiliary;
            string subjectsTaughtString_Auxiliary;
            int userGrade_Auxiliary;
            string userClass_Auxiliary;

            UserSelectorDGV.Rows.Clear();

            for (int i = 0; i < DB_Connection.AdministratorList.Count; i++)
            {
                Administrator CurrentUser = DB_Connection.AdministratorList[i];
                userID_Auxiliary = CurrentUser.SQL_ID;
                familyName_Auxiliary = CurrentUser.FamilyName;
                firstName_Auxiliary = CurrentUser.FirstName;
                authorizationLevel_Auxiliary = "Administrator";
                subjectsTaughtList_Auxiliary = CurrentUser.SubjectsTaughtList;
                ConvertSubjectsTaughtFromListToString_Comma(subjectsTaughtList_Auxiliary, out subjectsTaughtString_Auxiliary);
                UserSelectorDGV.Rows.Add(userID_Auxiliary, familyName_Auxiliary, firstName_Auxiliary, authorizationLevel_Auxiliary, subjectsTaughtString_Auxiliary, null, null);
            }
            for (int i = 0; i < DB_Connection.TeacherList.Count; i++)
            {
                Teacher CurrentUser = DB_Connection.TeacherList[i];
                userID_Auxiliary = CurrentUser.SQL_ID;
                familyName_Auxiliary = CurrentUser.FamilyName;
                firstName_Auxiliary = CurrentUser.FirstName;
                authorizationLevel_Auxiliary = "Teacher";
                subjectsTaughtList_Auxiliary = CurrentUser.SubjectsTaughtList;
                ConvertSubjectsTaughtFromListToString_Comma(subjectsTaughtList_Auxiliary, out subjectsTaughtString_Auxiliary);
                UserSelectorDGV.Rows.Add(userID_Auxiliary, familyName_Auxiliary, firstName_Auxiliary, authorizationLevel_Auxiliary, subjectsTaughtString_Auxiliary, null, null);
            }
            for (int i = 0; i < DB_Connection.StudentList.Count; i++)
            {
                Student CurrentUser = DB_Connection.StudentList[i];
                userID_Auxiliary = CurrentUser.SQL_ID;
                familyName_Auxiliary = CurrentUser.FamilyName;
                firstName_Auxiliary = CurrentUser.FirstName;
                authorizationLevel_Auxiliary = "Student";
                userGrade_Auxiliary = CurrentUser.Grade;
                userClass_Auxiliary = CurrentUser.Class;
                UserSelectorDGV.Rows.Add(userID_Auxiliary, familyName_Auxiliary, firstName_Auxiliary, authorizationLevel_Auxiliary, null, userGrade_Auxiliary, userClass_Auxiliary);
            }
            UserSelectorDGV.Sort(UserSelectorDGV.Columns[5], ListSortDirection.Descending);

        }
        private void SendTestSheetsButton_Click(object sender, EventArgs e)
        {
            if (UserSelectorDGV.Rows.Count != 0 && EditedTestSheetSelectorDGV.Rows.Count != 0)
            {
                if (MessageBox.Show("Are you sure you will send the selected test sheet to the selected students?", "Send test sheets", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EditedTestSheetID = Convert.ToInt32(EditedTestSheetSelectorDGV.CurrentRow.Cells["EditedTestSheetID1"].Value);
                    EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == EditedTestSheetID);
                    bool[][] answerMarkingsTable_Auxiliary;
                    bool[][] keywordFulfillmentTable_Auxiliary;
                    for (int i = 0; i < UserSelectorDGV.Rows.Count; i++)
                    {
                        bool selectedUser = Convert.ToBoolean(UserSelectorDGV.Rows[i].Cells["AddUser"].Value);
                        if (selectedUser)
                        {
                            UserId = Convert.ToInt32(UserSelectorDGV.Rows[i].Cells["User_ID"].Value);
                            ConvertEarnedPointsFromListToString(CurrentEditedTestSheet.EditorTaskList, out PointsEarned);
                            EditedTestSheet.EditorTasksConvertFromListToString(CurrentEditedTestSheet.EditorTaskList, out Tasks);
                            IndividualTestSheet.SetupAnswerMarkingsTableDimensions(CurrentEditedTestSheet.MultipleChoiceTruthTable, out answerMarkingsTable_Auxiliary);
                            ConvertAnswerMarkingsFromArrayToString_False(answerMarkingsTable_Auxiliary, out AnswerMarkingsTable);
                            ConvertEssayAnswersFromListToString(CurrentEditedTestSheet.EditorTaskList, out EssayAnswers);
                            IndividualTestSheet.SetupKeywordFulfillmentTableDimensions(CurrentEditedTestSheet.EssayKeywordTable, out keywordFulfillmentTable_Auxiliary);
                            ConvertKeywordFulfillmentFromArrayToString_False(keywordFulfillmentTable_Auxiliary, out KeywordFulfillmentTable);

                            UploadDataToLEAP_DB(UserId, EditedTestSheetID, PointsEarned, Tasks, AnswerMarkingsTable, EssayAnswers, KeywordFulfillmentTable);
                            Program.ReadDataFromDatabase();
                        }
                    }
                    LockEditedTestSheet(EditedTestSheetID);
                }
            }
        }
        private void ConvertEarnedPointsFromListToString(List<Task> __taskList, out string __pointsAvailableStringRow)
        {
            __pointsAvailableStringRow = "";
            for (int i = 0; i < __taskList.Count; i++)
            {
                __pointsAvailableStringRow += "0";
                __pointsAvailableStringRow += "▼";
            }
        }
        public static void ConvertAnswerMarkingsFromArrayToString_False(bool[][] __answerMarkingsTable, out string __answerMarkingsString)
        {
            __answerMarkingsString = "";

            for (int i = 0; i < __answerMarkingsTable.Length; i++)
            {
                __answerMarkingsString += "▲";
                for (int j = 0; j < __answerMarkingsTable[i].Length; j++)
                {
                    __answerMarkingsString += "false";
                    __answerMarkingsString += "▼";
                }
            }
        }
        public static void ConvertKeywordFulfillmentFromArrayToString_False(bool[][] __keywordFulfillmentTable, out string __keywordFulfillmentString)
        {
            __keywordFulfillmentString = "";

            for (int i = 0; i < __keywordFulfillmentTable.Length; i++)
            {
                __keywordFulfillmentString += "▲";
                for (int j = 0; j < __keywordFulfillmentTable[i].Length; j++)
                {
                    __keywordFulfillmentString += "false";
                    __keywordFulfillmentString += "▼";
                }
            }
        }
        public static void ConvertEssayAnswersFromListToString(List<Task> __editorTaskList, out string __essayAnswers)
        {
            __essayAnswers = "";
            for (int i = 0; i < __editorTaskList.Count; i++)
            {
                if (__editorTaskList[i] is EssayTask)
                {
                    __essayAnswers += " ";
                    __essayAnswers += "▼";
                }
            }
        }
        private void ConvertSubjectsTaughtFromListToString_Comma(List<string> __subjectsTaughtList, out string __subjectsTaughtString)
        {
            __subjectsTaughtString = "";
            for (int i = 0; i < __subjectsTaughtList.Count; i++)
            {
                __subjectsTaughtString += __subjectsTaughtList[i];
                if ((i + 1) != __subjectsTaughtList.Count)
                {
                    __subjectsTaughtString += ", ";
                }
            }
        }
        private void UploadDataToLEAP_DB(int __userID, int __editedTestSheetID, string __pointsEarned, string __tasks, string __answerMarkingsTable, string __essayAnswers, string __keywordFulfillmentTable)
        {
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                {
                    string UploadIndividualTestSheet = "INSERT INTO IndividualTestSheets (UserID, EditedTestSheetID, PointsEarned, SentOutTestSheet, SubmittedTestSheet, CheckedTestSheet, Tasks, AnswerMarkingsTable, EssayTaskAnswers, KeywordFulfillmentTable, TestSheetStartTime, TestSheetSubmitTime ) VALUES (@userID_Data, @editedTestSheetID_Data, @pointsEarnedData, @sentOutTestSheetData, @submittedTestSheetData, @CheckedTestSheetData, @tasksData, @answerMarkingsTableData, @essayAnswersData, @keywordFulfillmentTableData, @testSheetStartTimeData, @testSheetSubmitTimeData)";
                    using (SqlCommand commandToUploadIndividualTestSheet = new SqlCommand(UploadIndividualTestSheet, connectingToLEAP_DB))
                    {
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@userID_Data", __userID);
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@editedTestSheetID_Data", __editedTestSheetID);
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@pointsEarnedData", __pointsEarned);
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@sentOutTestSheetData", "true");
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@submittedTestSheetData", "false");
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@CheckedTestSheetData", "false");
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@tasksData", __tasks);
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@answerMarkingsTableData", __answerMarkingsTable);
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@essayAnswersData", __essayAnswers);
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@keywordFulfillmentTableData", __keywordFulfillmentTable);
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@testSheetStartTimeData", "");
                        commandToUploadIndividualTestSheet.Parameters.AddWithValue("@testSheetSubmitTimeData", "");
                        connectingToLEAP_DB.Open();
                        commandToUploadIndividualTestSheet.ExecuteNonQuery();
                        connectingToLEAP_DB.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed", "Error");
            }
        }
        private void LockEditedTestSheet(int __editedTestSheetID)
        {
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                {
                    string LockEditedTestSheet = "UPDATE EditedTestSheets SET LockedTestSheet=@lockedTestSheetData WHERE Id=@editedTestSheetID_Data";
                    using (SqlCommand commandToLockEditedTestSheet = new SqlCommand(LockEditedTestSheet, connectingToLEAP_DB))
                    {
                        commandToLockEditedTestSheet.Parameters.AddWithValue("@editedTestSheetID_Data", __editedTestSheetID);
                        commandToLockEditedTestSheet.Parameters.AddWithValue("@lockedTestSheetData", "True");
                        connectingToLEAP_DB.Open();
                        commandToLockEditedTestSheet.ExecuteNonQuery();
                        connectingToLEAP_DB.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed", "Error");
            }
        }
    }
}
