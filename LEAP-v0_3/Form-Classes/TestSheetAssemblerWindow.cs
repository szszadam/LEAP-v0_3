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
    public partial class TestSheetAssemblerWindow : Form
    {
        int[] editorTasksIdArray_Auxiliary;
        List<string> UserSubjectsTaughtAuxiliary;
        public TestSheetAssemblerWindow(int __editedTestSheetID)
        {
            InitializeComponent();
            int editedTestSheetId_Auxiliary = __editedTestSheetID;
            EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == editedTestSheetId_Auxiliary);
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
            string[] UserSubjectsTaughtArray = UserSubjectsTaughtAuxiliary.ToArray();
            SubjectsComboBox1.Items.AddRange(UserSubjectsTaughtArray);
            int subjectIndex = 0;
            for (int i = 0; i < SubjectsComboBox1.Items.Count; i++)
            {
                if ((SubjectsComboBox1.Items[i].ToString().ToLower()) == (CurrentEditedTestSheet.Subject).ToLower())
                {
                    subjectIndex = i;
                }
            }
            SubjectsComboBox1.SelectedIndex = subjectIndex;
            TopicTextBox.Text = CurrentEditedTestSheet.Topic;
            GradeNUD.Value = CurrentEditedTestSheet.Grade;
            TimeNUD.Value = CurrentEditedTestSheet.AvailableTime;
            editorTasksIdArray_Auxiliary = CurrentEditedTestSheet.EditorTaskList.Select(x => x.SQL_ID).ToArray();
        }
        public TestSheetAssemblerWindow()
        {
            InitializeComponent();

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
            string[] UserSubjectsTaughtArray = UserSubjectsTaughtAuxiliary.ToArray();
            SubjectsComboBox1.Items.AddRange(UserSubjectsTaughtArray);
            SubjectsComboBox1.SelectedIndex = 0;
            editorTasksIdArray_Auxiliary = new int[0];
        }
        private void TestSheetAssemblerWindow_Load(object sender, EventArgs e)
        {
            FillTaskSelectorDGV();
        }
        private void FillTaskSelectorDGV()
        {
            int taskId;
            string taskSubject;
            string taskType;
            string taskFormulation;
            int pointValue;
            string taskLocked;
            bool previouslyChosenTask;

            TaskSelectorDGV.Rows.Clear();
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
            for (int i = 0; i < DB_Connection.MultipleChoiceTaskList.Count; i++)
            {
                MultipleChoiceTask CurrentMultipleChoiceTask = DB_Connection.MultipleChoiceTaskList[i];
                taskSubject = CurrentMultipleChoiceTask.Subject;
                previouslyChosenTask = false;

                if (UserSubjectsTaughtAuxiliary.Contains(taskSubject, StringComparer.CurrentCultureIgnoreCase))
                {
                    taskId = CurrentMultipleChoiceTask.SQL_ID;
                    taskType = CurrentMultipleChoiceTask.TaskType;
                    taskFormulation = CurrentMultipleChoiceTask.TaskFormulation;
                    pointValue = CurrentMultipleChoiceTask.PointValue;
                    taskLocked = CurrentMultipleChoiceTask.LockedTask ? "Yes" : "No";

                    if (editorTasksIdArray_Auxiliary.Contains(CurrentMultipleChoiceTask.SQL_ID))
                    {
                        previouslyChosenTask = true;
                    }
                    TaskSelectorDGV.Rows.Add(taskId, taskSubject, taskType, taskFormulation, pointValue, taskLocked, previouslyChosenTask);
                }
            }
            for (int i = 0; i < DB_Connection.EssayTaskList.Count; i++)
            {
                EssayTask CurrentEssayTask = DB_Connection.EssayTaskList[i];
                taskSubject = CurrentEssayTask.Subject;
                previouslyChosenTask = false;

                if (UserSubjectsTaughtAuxiliary.Contains(taskSubject, StringComparer.CurrentCultureIgnoreCase))
                {
                    taskId = CurrentEssayTask.SQL_ID;
                    taskType = CurrentEssayTask.TaskType;
                    taskFormulation = CurrentEssayTask.TaskFormulation;
                    pointValue = CurrentEssayTask.PointValue;
                    taskLocked = CurrentEssayTask.LockedTask ? "Yes" : "No";

                    if (editorTasksIdArray_Auxiliary.Contains(CurrentEssayTask.SQL_ID))
                    {
                        previouslyChosenTask = true;
                    }
                    TaskSelectorDGV.Rows.Add(taskId, taskSubject, taskType, taskFormulation, pointValue, taskLocked, previouslyChosenTask);
                }
            }
            if (editorTasksIdArray_Auxiliary.Length == 0)
            {
                TaskSelectorDGV.Sort(TaskSelectorDGV.Columns[1], ListSortDirection.Ascending);
            }
            else
            {
                TaskSelectorDGV.Sort(TaskSelectorDGV.Columns[6], ListSortDirection.Descending);
            }

        }
        private void UpdateTestSheetPreviewButton_Click(object sender, EventArgs e)
        {
            QuestionDisplay_FlowLP_1.Controls.Clear();
            if (TaskSelectorDGV.Rows.Count != 0)
            {
                for (int i = 0; i < TaskSelectorDGV.Rows.Count; i++)
                {
                    DataGridViewRow CurrentRow_Auxiliary = TaskSelectorDGV.Rows[i];
                    bool CurrentTaskChosen = Convert.ToBoolean((CurrentRow_Auxiliary.Cells["AddTask"]).Value);
                    int CurrentTaskID = Convert.ToInt32(CurrentRow_Auxiliary.Cells["TaskID"].Value);
                    if (CurrentTaskChosen && (DB_Connection.MultipleChoiceTaskList.Exists(x => x.SQL_ID == CurrentTaskID)))
                    {
                        MultipleChoiceTask CurrentMultipleChoiceTask = DB_Connection.MultipleChoiceTaskList.FirstOrDefault(x => x.SQL_ID == CurrentTaskID);
                        string question_auxiliary = CurrentMultipleChoiceTask.TaskFormulation + ". Task:\n" + CurrentMultipleChoiceTask.TaskFormulation + " (" + CurrentMultipleChoiceTask.PointValue + " point(s))";
                        List<string> answerOptions_Auxiliary = CurrentMultipleChoiceTask.AnswerOptionsList.Select(x => x._answerOptionText).ToList<string>();
                        bool[] truthTableRow_Auxiliary = CurrentMultipleChoiceTask.AnswerOptionsList.Select(x => x._isThisAnswerCorrect).ToArray<bool>();
                        QuestionDisplay_FlowLP_1.Controls.Add(new MultipleChoiceTaskCheckerUC(question_auxiliary, answerOptions_Auxiliary, truthTableRow_Auxiliary) { Dock = DockStyle.Fill, AutoScroll = true });
                    }
                    else if (CurrentTaskChosen && DB_Connection.EssayTaskList.Exists(x => x.SQL_ID == CurrentTaskID))
                    {
                        EssayTask CurrentEssayTask = DB_Connection.EssayTaskList.FirstOrDefault(x => x.SQL_ID == CurrentTaskID);
                        string question_auxiliary = CurrentEssayTask.TaskFormulation + ". Task:\n" + CurrentEssayTask.TaskFormulation + " (" + CurrentEssayTask.PointValue + " point(s))";
                        List<string> keywords_Auxiliary = CurrentEssayTask.KeywordsList;
                        int taskPointValue_Auxiliary = CurrentEssayTask.PointValue;
                        QuestionDisplay_FlowLP_1.Controls.Add(new EssayTaskCheckerUC(question_auxiliary, keywords_Auxiliary, taskPointValue_Auxiliary) { Dock = DockStyle.Fill });
                    }
                }
                QuestionDisplay_FlowLP_1.FlowDirection = FlowDirection.TopDown;
                TaskSelectorDGV.Sort(TaskSelectorDGV.Columns[6], ListSortDirection.Descending);
            }
        }
        private void CreateTestSheetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TestSheetAssemblerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ButtonSelect = MessageBox.Show("Are you sure you want to close the editing of the test sheet?", "Close test sheet editing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ButtonSelect == DialogResult.No)
            {
                Program.ReadDataFromDatabase();
            }
            else if (ButtonSelect == DialogResult.Yes)
            {
                UploadDataToLEAP_DB();
                Program.ReadDataFromDatabase();
            }
            else if (ButtonSelect == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void UploadDataToLEAP_DB()
        {
            string subject_Auxiliary = SubjectsComboBox1.Text;
            string topic_Auxiliary = TopicTextBox.Text;
            int grade_Auxiliary = Convert.ToInt32(GradeNUD.Value);
            int timeLimit_Auxiliary = Convert.ToInt32(TimeNUD.Value);
            List<Task> editorTaskList_Auxiliary = new List<Task>();
            string editorTaskString_Auxiliary;
            bool[][] multipleChoiceTruthTable_Auxiliary;
            string multipleChoiceTruthTableString_Auxiliary;
            string[][] essayKeywordTable_Auxiliary;
            string essayKeywordTableString_Auxiliary;
            DateTime creationDate_Auxiliary;
            int totalPointsAvailable_Auxiliary = 0;
            creationDate_Auxiliary = System.DateTime.Now;
            if (TaskSelectorDGV.Rows.Count != 0)
            {
                for (int i = 0; i < TaskSelectorDGV.Rows.Count; i++)
                {
                    DataGridViewRow CurrentRow_Auxiliary = TaskSelectorDGV.Rows[i];
                    bool CurrentTaskChosen = Convert.ToBoolean((CurrentRow_Auxiliary.Cells["AddTask"]).Value);
                    int CurrentTaskID = Convert.ToInt32(CurrentRow_Auxiliary.Cells["TaskID"].Value);
                    if (CurrentTaskChosen && (DB_Connection.MultipleChoiceTaskList.Exists(x => x.SQL_ID == CurrentTaskID)))
                    {
                        MultipleChoiceTask CurrentMultipleChoiceTask = DB_Connection.MultipleChoiceTaskList.FirstOrDefault(x => x.SQL_ID == CurrentTaskID);
                        editorTaskList_Auxiliary.Add(CurrentMultipleChoiceTask);
                    }
                    else if (CurrentTaskChosen && DB_Connection.EssayTaskList.Exists(x => x.SQL_ID == CurrentTaskID))
                    {
                        EssayTask CurrentEssayTask = DB_Connection.EssayTaskList.FirstOrDefault(x => x.SQL_ID == CurrentTaskID);
                        editorTaskList_Auxiliary.Add(CurrentEssayTask);
                    }
                    TaskLocking(CurrentTaskID);
                }
                for (int i = 0; i < editorTaskList_Auxiliary.Count; i++)
                {
                    totalPointsAvailable_Auxiliary += editorTaskList_Auxiliary[i].PointValue;
                }
                EditedTestSheet.EditorTasksConvertFromListToString(editorTaskList_Auxiliary, out editorTaskString_Auxiliary);
                EditedTestSheet.FillMultipleChoiceTruthTable(editorTaskList_Auxiliary, out multipleChoiceTruthTable_Auxiliary);
                ConvertTruthTableFromArrayToString(multipleChoiceTruthTable_Auxiliary, out multipleChoiceTruthTableString_Auxiliary);
                EditedTestSheet.FillEssayKeywordTable(editorTaskList_Auxiliary, out essayKeywordTable_Auxiliary);
                ConvertKeywordTableFromArrayToString(essayKeywordTable_Auxiliary, out essayKeywordTableString_Auxiliary);
                try
                {
                    using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                    {
                        string UploadEditedTestSheet = "INSERT INTO EditedTestSheets (Subject, Topic, Grade, TotalPointsAvailable, Tasks, LockedTestSheet, MultipleChoiceTruthTable, EssayKeywordTable, AvailableTime, CreationDate ) VALUES (@subjectData, @topicData, @gradeData, @totalPointsAvailableData, @tasksData, @lockedTestSheetData, @multipleChoiceTruthTableData, @essayKeywordTableData, @availableTimeData,  @creationDate)";
                        using (SqlCommand commandToUploadEditedTestSheet = new SqlCommand(UploadEditedTestSheet, connectingToLEAP_DB))
                        {
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@subjectData", subject_Auxiliary);
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@topicData", topic_Auxiliary);
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@gradeData", grade_Auxiliary);
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@totalPointsAvailableData", totalPointsAvailable_Auxiliary);
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@tasksData", editorTaskString_Auxiliary);
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@lockedTestSheetData", "false");
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@multipleChoiceTruthTableData", multipleChoiceTruthTableString_Auxiliary);
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@essayKeywordTableData", essayKeywordTableString_Auxiliary);
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@availableTimeData", timeLimit_Auxiliary);
                            commandToUploadEditedTestSheet.Parameters.AddWithValue("@creationDate", creationDate_Auxiliary.ToString("yyyy/MM/dd HH:mm:ss"));
                            connectingToLEAP_DB.Open();
                            commandToUploadEditedTestSheet.ExecuteNonQuery();
                            MessageBox.Show("Successful upload!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection failed", "Error");
                }
            }
        }
        private void TaskLocking(int __currentTaskID)
        {
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                {
                    string LockTask = "UPDATE Tasks SET LockedTask=@lockedTaskData WHERE Id=@taskIdData";
                    using (SqlCommand commandToLockTask = new SqlCommand(LockTask, connectingToLEAP_DB))
                    {
                        commandToLockTask.Parameters.AddWithValue("@taskIdData", __currentTaskID);
                        commandToLockTask.Parameters.AddWithValue("@lockedTaskData", "True");
                        connectingToLEAP_DB.Open();
                        commandToLockTask.ExecuteNonQuery();
                        connectingToLEAP_DB.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed", "Error");
            }
        }
        private void ConvertTruthTableFromArrayToString(bool[][] __multipleChoiceTruthTable, out string __multipleChoiceTruthTableString)
        {
            __multipleChoiceTruthTableString = "";
            for (int i = 0; i < __multipleChoiceTruthTable.Length; i++)
            {
                for (int j = 0; j < __multipleChoiceTruthTable[i].Length; j++)
                {
                    if (__multipleChoiceTruthTable[i][j] == true)
                    {
                        __multipleChoiceTruthTableString += "true";
                    }
                    else
                    {
                        __multipleChoiceTruthTableString += "false";
                    }
                    __multipleChoiceTruthTableString += "▼";
                }
                __multipleChoiceTruthTableString += "▲";
            }
        }
        private void ConvertKeywordTableFromArrayToString(string[][] __essayKeywordTable, out string __essayKeywordTableString)
        {
            __essayKeywordTableString = "";
            for (int i = 0; i < __essayKeywordTable.Length; i++)
            {
                for (int j = 0; j < __essayKeywordTable[i].Length; j++)
                {
                    __essayKeywordTableString += __essayKeywordTable[i][j];
                    __essayKeywordTableString += "▼";
                }
                __essayKeywordTableString += "▲";
            }
        }
        private void SelectingTaskDGV_Click(object sender, EventArgs e)
        {
            TaskSelectorDGV.Sort(TaskSelectorDGV.Columns[6], ListSortDirection.Descending);
        }
    }
}
