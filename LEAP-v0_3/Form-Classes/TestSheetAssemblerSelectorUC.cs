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
    public partial class TestSheetAssemblerSelectorUC : UserControl
    {
        public TestSheetAssemblerSelectorUC()
        {
            InitializeComponent();
        }
        private void FillEditedTestSheetSelectorDGV()
        {
            int editedTestSheetID;
            string TestSheetSubject;
            string TestSheetTopic;
            int grade;
            int pointsAvailable_Auxiliary;
            int timeLimit;
            string taskLocked;
            EditedTestSheetSelectorDGV.Rows.Clear();
            List<string> UserSubjectsTaughtAuxiliary;

            if (UserIdentification.ActiveUser is Administrator)
            {
                UserSubjectsTaughtAuxiliary = (UserIdentification.ActiveUser as Administrator).SubjectsTaughtList;
                for (int i = 0; i < DB_Connection.EditedTestSheetList.Count; i++)
                {
                    EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList[i];
                    editedTestSheetID = CurrentEditedTestSheet.SQL_ID;
                    TestSheetSubject = CurrentEditedTestSheet.Subject;
                    TestSheetTopic = CurrentEditedTestSheet.Topic;
                    grade = CurrentEditedTestSheet.Grade;
                    pointsAvailable_Auxiliary = CurrentEditedTestSheet.TotalPointsAvailable;
                    timeLimit = CurrentEditedTestSheet.AvailableTime;
                    taskLocked = CurrentEditedTestSheet.LockedTestSheet ? "Yes" : "No";
                    EditedTestSheetSelectorDGV.Rows.Add(editedTestSheetID, TestSheetSubject, TestSheetTopic, grade, pointsAvailable_Auxiliary, timeLimit, taskLocked);
                }
            }
            else if (UserIdentification.ActiveUser is Teacher)
            {
                UserSubjectsTaughtAuxiliary = (UserIdentification.ActiveUser as Teacher).SubjectsTaughtList;
                for (int i = 0; i < DB_Connection.EditedTestSheetList.Count; i++)
                {
                    EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList[i];
                    if (UserSubjectsTaughtAuxiliary.Contains(CurrentEditedTestSheet.Subject, StringComparer.CurrentCultureIgnoreCase))
                    {
                        editedTestSheetID = CurrentEditedTestSheet.SQL_ID;
                        TestSheetSubject = CurrentEditedTestSheet.Subject;
                        TestSheetTopic = CurrentEditedTestSheet.Topic;
                        grade = CurrentEditedTestSheet.Grade;
                        pointsAvailable_Auxiliary = CurrentEditedTestSheet.TotalPointsAvailable;
                        timeLimit = CurrentEditedTestSheet.AvailableTime;
                        taskLocked = CurrentEditedTestSheet.LockedTestSheet ? "Yes" : "No";
                        EditedTestSheetSelectorDGV.Rows.Add(editedTestSheetID, TestSheetSubject, TestSheetTopic, grade, pointsAvailable_Auxiliary, timeLimit, taskLocked);
                    }
                }
            }
            EditedTestSheetSelectorDGV.Sort(EditedTestSheetSelectorDGV.Columns[1], ListSortDirection.Ascending);
        }
        private void TestSheetAssemblerSelectorUC_Load(object sender, EventArgs e)
        {
            FillEditedTestSheetSelectorDGV();
        }
        public void RefreshTableButton_Click_1(object sender, EventArgs e)
        {
            FillEditedTestSheetSelectorDGV();
        }
        private void CreateNewTestSheetButton_Click(object sender, EventArgs e)
        {
            TestSheetAssemblerWindow testSheetAssemblerWindow1 = new TestSheetAssemblerWindow();
            testSheetAssemblerWindow1.ShowDialog();
        }
        private void ModifyTestSheetButton_Click(object sender, EventArgs e)
        {
            if (EditedTestSheetSelectorDGV.Rows.Count != 0)
            {
                int selectedEditedTestSheetID = Convert.ToInt32(EditedTestSheetSelectorDGV.CurrentRow.Cells["EditedTestSheetID1"].Value);
                EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == selectedEditedTestSheetID);
                if (CurrentEditedTestSheet.LockedTestSheet == false)
                {
                    TestSheetAssemblerWindow testSheetAssemblerWindow1 = new TestSheetAssemblerWindow(selectedEditedTestSheetID);
                    testSheetAssemblerWindow1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The selected \"edited test sheet\" is already locked, so it cannot be modified!\n Locking is the result of creating a \"unique test sheet\" from the \"edited test sheet\"");
                }
            }
        }
        private void PreviewTestSheetButton_Click(object sender, EventArgs e)
        {
            int selectedEditedTestSheetID = Convert.ToInt32(EditedTestSheetSelectorDGV.CurrentRow.Cells["EditedTestSheetID1"].Value);
            TestSheetPreviewWindow testSheetPreviewWindow1 = new TestSheetPreviewWindow(selectedEditedTestSheetID);
            testSheetPreviewWindow1.ShowDialog();
        }
        private void DeleteTestSheetButton_Click(object sender, EventArgs e)
        {
            if (EditedTestSheetSelectorDGV.Rows.Count != 0)
            {
                int selectedEditedTestSheetID = Convert.ToInt32(EditedTestSheetSelectorDGV.CurrentRow.Cells["EditedTestSheetID1"].Value);
                EditedTestSheet CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == selectedEditedTestSheetID);
                if (CurrentEditedTestSheet.LockedTestSheet == false)
                {
                    if (MessageBox.Show("Are you sure to delete the selected test sheet?", "Delete test sheet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                            {
                                string DeleteTestSheetFromDB = "DELETE FROM EditedTestSheets WHERE Id=@idData";
                                using (SqlCommand commandToDeleteTestSheet = new SqlCommand(DeleteTestSheetFromDB, connectingToLEAP_DB))
                                {
                                    commandToDeleteTestSheet.Parameters.AddWithValue("@idData", selectedEditedTestSheetID);
                                    connectingToLEAP_DB.Open();
                                    commandToDeleteTestSheet.ExecuteNonQuery();
                                    MessageBox.Show("The test sheet is successfully deleted!");
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Connection failed", "Error");
                        }
                        Program.ReadDataFromDatabase();
                        FillEditedTestSheetSelectorDGV();
                    }
                }
                else
                {
                    MessageBox.Show("The selected \"edited test sheet\" is already locked, so it cannot be deleted!\n Locking is the result of creating a \"unique test sheet\" from the \"edited test sheet\"");
                }
            }
        }
    }
}
