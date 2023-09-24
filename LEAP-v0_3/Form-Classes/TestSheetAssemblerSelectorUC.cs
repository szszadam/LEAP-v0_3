using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
namespace LEAP_v0_3
{
    //      ***** Test Sheet Assembler Selector User Control Class *****
    //
    //
    //      *** Class description ***
    //
    //
    // This graphic interface is a descendant of the "UserControl" class an it is used for editing
    // worksheets.Its main graphic elements are: the "DataGridView" control listing the edited test
    // sheets created so far, the " Create a new edited test sheet" " button, the "Modify selected
    // test sheet" button, the "Preview selected test sheet" button, the "Refresh table" button and
    // the "Delete selected test sheet" button.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // TestSheetAssemblerSelectorUC_Load () event handler - when the Test Sheet Assembler Selector
    // User Control is loaded, it calls the FillEditedTestSheetSelectorDGV() method.
    //
    //
    // FillEditedTestSheetSelectorDGV() – It fills the "DataGridView" control listing the edited test
    // sheets with data. This method uses some auxiliary variables during execution. After filling up
    // the controller, it sorts its rows by the "subject" property in ABC order.
    //
    //
    // RefreshTableButton_Click_1() event handler –  this method is executed when the "Refresh Table"
    // button is clicked, which calls the FillEditedTestSheetSelectorDGV() method.
    //
    //
    // CreateNewTestSheetButton_Click () event handler – this method is executed when the user clicks
    // on the "Create new edited test sheet" button, which creates an instance of the
    // "TestSheetAssemblerWindow" class and opens it in a new dialog window.
    //
    //
    // ModifyTestSheetButton_Click() event handler – by clicking the "Modify selected test sheet"
    // button, user can do further modification on the selected, not yet locked, edited test sheet.
    // If the test sheet is already locked, the user will receive an error message.
    //
    //
    // PreviewTestSheetButton_Click() event handler - this method is executed when the "Preview
    // selected test sheet" button is clicked, which creates an instance of the
    // "TestSheetViewerWindow" class, and passing it the ID of the selected test sheet, then opens it
    // in a new dialog.
    //
    //
    // DeleteTestSheetButton_Click() event handler - after a user’s approval, the selected test sheet
    // will be deleted from the "Edited Test Sheets" table of the database, provided that it is not
    // yet locked. At the end of this method it also calls the following methods:
    // Program.ReadDataFromDatabase(), FillEditedTestSheetSelectorDGV().

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
