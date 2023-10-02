using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LEAP_v0_3
{
    public partial class TestSheetCheckerSelectorUC : UserControl
    {
        //      ***** Test Sheet Checker Selector User Control Class *****
        //
        //
        //      *** Class description ***
        //
        //
        // This class is a descendant of the "UserControl" class, stands for selecting for checking/scoring
        // individual test sheets completed and submitted by users.The main elements of its graphical
        // interface are the following: the "DataGridView" control for selecting the submitted individual
        // test sheet, the "Check selected test sheet" button, and the "Refresh table" button.
        //
        //
        //      *** Methods and event handlers ***
        //
        //
        // FillTestSheetSelectorDGV() –  It fills with data the "DataGridView" control listing individual
        // test sheets.The method uses some auxiliary variables while it is running.
        //
        //
        // TestSheetCheckerSelectorUC_Load() event handler – When the Test Sheet Checker Selector User
        // Control is loaded, it calls the FillTestSheetSelectorDGV() method.
        //
        //
        // SelectTestSheetButton_Click() event handler - This method runs when the "Check selected test
        // sheet" button is clicked, which creates an instance of the " TestSheetCheckerWindow" class and
        // opens it in a new window.
        //
        //
        // RefreshTableButton_Click() event handler - This method runs when the "Update Table" button is
        // clicked, which calls the FillTestSheetSelectorDGV() method.

        public TestSheetCheckerSelectorUC()
        {
            InitializeComponent();
        }
        private void FillTestSheetSelectorDGV()
        {
            int individualTestSheetID;
            string subject;
            string topic;
            int grade;
            int pointsAvailable;
            int pointsEarned;
            string testSheetSubmitted;
            string testSheetChecked;
            int timeLimit;
            string testSheetSubject;

            TestSheetSelectorDGV.Rows.Clear();

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
            for (int i = 0; i < DB_Connection.IndividualTestSheetList.Count; i++)
            {
                EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_editedTestSheet);
                testSheetSubject = CurrentEditedTestSheet.Subject;

                string familyName="";
                string firstName="";

                if (DB_Connection.StudentList.Exists(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user))
                {
                    familyName = DB_Connection.StudentList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user).FamilyName;
                    firstName = DB_Connection.StudentList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user).FirstName;
                }
                else if (DB_Connection.TeacherList.Exists(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user))
                {
                    familyName = DB_Connection.TeacherList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user).FamilyName;
                    firstName = DB_Connection.TeacherList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user).FirstName;
                }
                else if (DB_Connection.AdministratorList.Exists(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user))
                {
                    familyName = DB_Connection.AdministratorList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user).FamilyName;
                    firstName = DB_Connection.AdministratorList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user).FirstName;
                }

                if (UserSubjectsTaughtAuxiliary.Contains(testSheetSubject, StringComparer.CurrentCultureIgnoreCase) && (DB_Connection.IndividualTestSheetList[i].SentOutTestSheet == true) && (DB_Connection.IndividualTestSheetList[i].SubmittedTestSheet == true) && (DB_Connection.IndividualTestSheetList[i].CheckedTestSheet == false))
                {
                    individualTestSheetID = DB_Connection.IndividualTestSheetList[i].SQL_ID_individualTestSheet;
                    subject = Convert.ToString(CurrentEditedTestSheet.Subject);
                    topic = Convert.ToString(CurrentEditedTestSheet.Topic);
                    grade = Convert.ToInt32(CurrentEditedTestSheet.Grade);
                    pointsAvailable = Convert.ToInt32(CurrentEditedTestSheet.TotalPointsAvailable);
                    pointsEarned = DB_Connection.IndividualTestSheetList[i].PointsEarnedArray.Sum();
                    testSheetSubmitted = DB_Connection.IndividualTestSheetList[i].SubmittedTestSheet ? "Yes" : "No";
                    testSheetChecked = DB_Connection.IndividualTestSheetList[i].CheckedTestSheet ? "Yes" : "No";
                    timeLimit = Convert.ToInt32(CurrentEditedTestSheet.AvailableTime);
                    TestSheetSelectorDGV.Rows.Add(individualTestSheetID, familyName, firstName, subject, topic, grade, pointsAvailable, pointsEarned, testSheetSubmitted, testSheetChecked, timeLimit);
                }
            }
        }
        private void TestSheetCheckerSelectorUC_Load(object sender, EventArgs e)
        {
            FillTestSheetSelectorDGV();
        }
        private void SelectTestSheetButton_Click(object sender, EventArgs e)
        {
            if (TestSheetSelectorDGV.Rows.Count!=0)
            {
                int selectedIndividualTestSheetId = Convert.ToInt32(TestSheetSelectorDGV.CurrentRow.Cells["IndividualTestSheetID"].Value);
                string selectedFamilyName = Convert.ToString(TestSheetSelectorDGV.CurrentRow.Cells["FamilyName"].Value);
                string selectedFirstName = Convert.ToString(TestSheetSelectorDGV.CurrentRow.Cells["FirstName"].Value);
                TestSheetCheckerWindow testSheetCheckerWindow1 = new TestSheetCheckerWindow(selectedIndividualTestSheetId, selectedFamilyName, selectedFirstName);
                testSheetCheckerWindow1.ShowDialog(); 
            }
        }
        public void RefreshTableButton_Click(object sender, EventArgs e)
        {
            FillTestSheetSelectorDGV();
        }
    }
}
