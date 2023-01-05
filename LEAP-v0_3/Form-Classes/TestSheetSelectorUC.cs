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
    public partial class TestSheetSelectorUC : UserControl
    {
        public TestSheetSelectorUC()
        {
            InitializeComponent();
        }
        private void FillTestSheetSelectorDGV()
        {
            int individualTestSheetID;
            string familyName;
            string firstName;
            string subject;
            string topic;
            int grade;
            int pointsAvailable;
            int pointsEarned;
            string testSheetSubmitted;
            string testSheetChecked;
            int timeLimit;

            TestSheetSelectorDGV.Rows.Clear();

            for (int i = 0; i < DB_Connection.IndividualTestSheetList.Count; i++)
            {
                EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == DB_Connection.IndividualTestSheetList[i].SQL_ID_editedTestSheet);

                if ((DB_Connection.IndividualTestSheetList[i].SQL_ID_user == UserIdentification.ActiveUser.SQL_ID) && (DB_Connection.IndividualTestSheetList[i].SubmittedTestSheet == false) && (DB_Connection.IndividualTestSheetList[i].SentOutTestSheet == true))
                {
                    individualTestSheetID = DB_Connection.IndividualTestSheetList[i].SQL_ID_individualTestSheet;
                    familyName = UserIdentification.ActiveUser.FamilyName;
                    firstName = UserIdentification.ActiveUser.FirstName;
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
        public void TestSheetSelectorUC_Load(object sender, EventArgs e)
        {
            FillTestSheetSelectorDGV();
        }
        private void SelectTestSheetButton_Click(object sender, EventArgs e)
        {
            if (TestSheetSelectorDGV.Rows.Count!=0)
            {
                try
                {
                    DataGridViewRow SelectedRow = TestSheetSelectorDGV.CurrentRow;
                    int selectedIndividualTestSheetId = Convert.ToInt32(SelectedRow.Cells["IndividualTestSheetID"].Value);
                    TestSheetWindow testSheetWindow1 = new TestSheetWindow(selectedIndividualTestSheetId);
                    testSheetWindow1.ShowDialog();
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
