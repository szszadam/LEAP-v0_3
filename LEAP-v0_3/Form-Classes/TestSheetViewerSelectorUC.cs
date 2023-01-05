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
    public partial class TestSheetViewerSelectorUC : UserControl
    {
        public TestSheetViewerSelectorUC()
        {
            InitializeComponent();
        }
        private void TestSheetCheckerSelectorUC_Load(object sender, EventArgs e)
        {
            FillTestSheetSelectorDGV();
        }
        private void FillTestSheetSelectorDGV()
        {
            int individualTestSheetID;
            string subject;
            string topic;
            string familyName;
            string firstName;
            int grade;
            int pointsAvailable;
            int pointsEarned;

            TestSheetSelectorDGV.Rows.Clear();

            if (UserIdentification.ActiveUser is Administrator)
            {
                EditedTestSheet CurrentEditedTestSheet;
                User CurrentUser;
                for (int i = 0; i < DB_Connection.IndividualTestSheetList.Count; i++)
                {
                    CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_editedTestSheet);
                    int CurrentUserID = DB_Connection.IndividualTestSheetList[i].SQL_ID_user;
                    if (DB_Connection.StudentList.Exists(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user))
                    {
                        CurrentUser = DB_Connection.StudentList.FirstOrDefault(x => x.SQL_ID == CurrentUserID);
                    }
                    else if (DB_Connection.TeacherList.Exists(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user))
                    {
                        CurrentUser = DB_Connection.TeacherList.FirstOrDefault(x => x.SQL_ID == CurrentUserID);
                    }
                    else
                    {
                        CurrentUser = DB_Connection.AdministratorList.FirstOrDefault(x => x.SQL_ID == CurrentUserID);
                    }
                    if (DB_Connection.IndividualTestSheetList[i].CheckedTestSheet == true)
                    {
                        individualTestSheetID = DB_Connection.IndividualTestSheetList[i].SQL_ID_individualTestSheet;
                        familyName = CurrentUser.FamilyName;
                        firstName = CurrentUser.FirstName;
                        subject = Convert.ToString(CurrentEditedTestSheet.Subject);
                        topic = Convert.ToString(CurrentEditedTestSheet.Topic);
                        grade = Convert.ToInt32(CurrentEditedTestSheet.Grade);
                        pointsAvailable = Convert.ToInt32(CurrentEditedTestSheet.TotalPointsAvailable);
                        pointsEarned = DB_Connection.IndividualTestSheetList[i].PointsEarnedArray.Sum();
                        TestSheetSelectorDGV.Rows.Add(individualTestSheetID, familyName, firstName, subject, topic, grade, pointsAvailable, pointsEarned);
                    }
                }
            }
            else if (UserIdentification.ActiveUser is Teacher)
            {
                EditedTestSheet CurrentEditedTestSheet;
                User CurrentUser;
                List<string> SubjectsTaughtList_Auxiliary = (UserIdentification.ActiveUser as Teacher).SubjectsTaughtList;
                for (int i = 0; i < DB_Connection.IndividualTestSheetList.Count; i++)
                {
                    CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_editedTestSheet);
                    int CurrentUserID = DB_Connection.IndividualTestSheetList[i].SQL_ID_user;
                    if (DB_Connection.StudentList.Exists(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user))
                    {
                        CurrentUser = DB_Connection.StudentList.FirstOrDefault(x => x.SQL_ID == CurrentUserID);
                    }
                    else if (DB_Connection.TeacherList.Exists(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_user))
                    {
                        CurrentUser = DB_Connection.TeacherList.FirstOrDefault(x => x.SQL_ID == CurrentUserID);
                    }
                    else
                    {
                        CurrentUser = DB_Connection.AdministratorList.FirstOrDefault(x => x.SQL_ID == CurrentUserID);
                    }
                    if ((SubjectsTaughtList_Auxiliary.Contains(CurrentEditedTestSheet.Subject, StringComparer.CurrentCultureIgnoreCase)) && (DB_Connection.IndividualTestSheetList[i].CheckedTestSheet == true))
                    {
                        individualTestSheetID = DB_Connection.IndividualTestSheetList[i].SQL_ID_individualTestSheet;
                        familyName = CurrentUser.FamilyName;
                        firstName = CurrentUser.FirstName;
                        subject = Convert.ToString(CurrentEditedTestSheet.Subject);
                        topic = Convert.ToString(CurrentEditedTestSheet.Topic);
                        grade = Convert.ToInt32(CurrentEditedTestSheet.Grade);
                        pointsAvailable = Convert.ToInt32(CurrentEditedTestSheet.TotalPointsAvailable);
                        pointsEarned = DB_Connection.IndividualTestSheetList[i].PointsEarnedArray.Sum();
                        TestSheetSelectorDGV.Rows.Add(individualTestSheetID, familyName, firstName, subject, topic, grade, pointsAvailable, pointsEarned);
                    }
                }
            }
            else
            {
                for (int i = 0; i < DB_Connection.IndividualTestSheetList.Count; i++)
                {
                    EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_editedTestSheet);
                    if ((DB_Connection.IndividualTestSheetList[i].SQL_ID_user == UserIdentification.ActiveUser.SQL_ID) && (DB_Connection.IndividualTestSheetList[i].CheckedTestSheet == true))
                    {
                        individualTestSheetID = DB_Connection.IndividualTestSheetList[i].SQL_ID_individualTestSheet;
                        familyName = UserIdentification.ActiveUser.FamilyName;
                        firstName = UserIdentification.ActiveUser.FirstName;
                        subject = Convert.ToString(CurrentEditedTestSheet.Subject);
                        topic = Convert.ToString(CurrentEditedTestSheet.Topic);
                        grade = Convert.ToInt32(CurrentEditedTestSheet.Grade);
                        pointsAvailable = Convert.ToInt32(CurrentEditedTestSheet.TotalPointsAvailable);
                        pointsEarned = DB_Connection.IndividualTestSheetList[i].PointsEarnedArray.Sum();
                        TestSheetSelectorDGV.Rows.Add(individualTestSheetID, familyName, firstName, subject, topic, grade, pointsAvailable, pointsEarned);
                    }
                }
            }
        }
        
        private void SelectTestSheetButton_Click(object sender, EventArgs e)
        {
            if (TestSheetSelectorDGV.Rows.Count != 0)
            {
                try
                {
                    int selectedIndividualTestSheetId = Convert.ToInt32(TestSheetSelectorDGV.CurrentRow.Cells["IndividualTestSheetID"].Value);
                    string selectedFamilyName = Convert.ToString(TestSheetSelectorDGV.CurrentRow.Cells["FamilyName"].Value);
                    string selectedFirstName = Convert.ToString(TestSheetSelectorDGV.CurrentRow.Cells["FirstName"].Value);
                    TestSheetViewerWindow testSheetViewerWindow1 = new TestSheetViewerWindow(selectedIndividualTestSheetId, selectedFamilyName, selectedFirstName);
                    testSheetViewerWindow1.ShowDialog();
                }
                catch (Exception)
                {

                }
            }
        }

        public void RefreshTableButton_Click(object sender, EventArgs e)
        {
            FillTestSheetSelectorDGV();
        }
    }
}
