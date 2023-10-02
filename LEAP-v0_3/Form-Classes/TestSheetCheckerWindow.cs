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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LEAP_v0_3
{


    //      ***** Test Sheet Checker Window Class *****
    //
    //
    //      *** Class description ***
    //
    //
    // A class is a descendant of the "Form" class and created for reviewing and manual scoring and
    // correcting(in the case of essay tasks) the test sheets filled and submitted by users.It displays essay
    // and/or multiple-choice tasks in its embedded "FlowLayoutPanel" control.Other important elements of its
    // graphical interface are the "Submit checked test sheet" button and the upper label displaying the data
    // of the person solving the test sheet.
    //
    //
    //      *** Fields ***
    //
    //
    // CurrentIndividualTestSheet: IndividualTestSheet – this variable if for storing a reference to the
    // individual test sheet to be checked / to be scored.
    //
    //
    // CurrentEditedTestSheet: EditedTestSheet - this variable is for storing a reference to the edited test
    // sheet that served as the basis for the individual test sheet to be checked / scored.
    //
    //
    // pointsEarnedString_Auxiliary: string - it is used to store the points achieved per task during
    // uploading to the LEAP database. These received points will be stored in a text field in the database,
    // using the separator character '▼'. When the individual test sheet is submitted, these points could
    // already have a value other than 0 for the multiple-choice tasks, when the algorithm for the automatic
    // evaluation of the multiple-choice tasks is running.The point values for the essay answers are entered
    // manually by the user correcting the worksheet.
    //
    //
    // familyName: string – auxiliary variable that stores the last name of the user filling out the
    // individual test sheet.
    //
    //
    // firstName: string – auxiliary variable that stores the first name of the user filling out the
    // individual test sheet.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // TestSheetCheckerWindow_Load() event handler – This method runs when the test sheet checking window is
    // opened, which causes the FillTestSheetFlowLayoutPanel() method to be called.Furthermore the name of
    // the user filling out the test sheet and the test sheet data (subject, topic) are written on the data
    // label.
    //
    //
    // FillTestSheetFlowLayoutPanel() – the method fills the "FlowLayoutPanel" control placed on the graphic
    // interface with the elements of the task list of the edited test sheet(that forms the basis of the
    // individual test sheet).
    //
    //
    // SubmitCheckedTestSheetButton_Click() event handler – clicking on the button "Submit checked test
    // sheet" starts the process of closing the current window, thus indirectly calling the
    // TestSheetWindow_FormClosing() method.
    //
    //
    // TestSheetWindow_FormClosing() event handler –  when this method is running, the points assigned to the
    // essay tasks by the user correcting the task will be also entered into the auxiliary variable
    // "pointsEarnedString_Auxiliary" belonging to the current individual test sheet. After a user approval,
    // these data are uploaded to the LEAP database, and then the window closes. The method also calls the
    // following methods during it’s runtime:
    // Program.ReadDataFromDatabase(),
    // ConvertEarnedPointsFromArrayToString(),
    // UploadDataToLEAP_DB().
    //
    //
    // ConvertEarnedPointsFromArrayToString() -   It concatenates the achieved points to be uploaded to the
    // database into a text in accordance with the formal requirements of the pointsEarnedString_Auxiliary
    // field (described above).
    //
    //
    // UploadDataToLEAP_DB() – this method uploads to the LEAP database the collection of achieved points as
    // a result of the manual checking / scoring process. In addition, the new "true" value of the
    // "CheckedTestSheet" field is also uploaded.


    public partial class TestSheetCheckerWindow : Form
    {
        IndividualTestSheet CurrentIndividualTestSheet;
        EditedTestSheet CurrentEditedTestSheet;
        string pointsEarnedString_Auxiliary;
        string familyName;
        string firstName;
        public TestSheetCheckerWindow(int __individualTestSheetId, string __familyName, string __firstName)
        {
            CurrentIndividualTestSheet = DB_Connection.IndividualTestSheetList.FirstOrDefault(x => x.SQL_ID_individualTestSheet == __individualTestSheetId);
            CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == CurrentIndividualTestSheet.SQL_ID_editedTestSheet);
            this.familyName = __familyName;
            this.firstName = __firstName;
            InitializeComponent();
        }
        private void TestSheetCheckerWindow_Load(object sender, EventArgs e)
        {
            Questions_FlowLP_1.Controls.Clear();
            FillTestSheetFlowLayoutPanel();
            dataLabel.Text = $"Student and test sheet information:\n{firstName} {familyName}\n{CurrentEditedTestSheet.Subject}, {CurrentEditedTestSheet.Topic}";
        }
        public void FillTestSheetFlowLayoutPanel()
        {
            int j = 0; 
            int k = 0; 
            int pointsEarned_Auxiliary;
            for (int i = 0; i < CurrentIndividualTestSheet.IndividualTaskList.Count; i++)
            {
                if (CurrentIndividualTestSheet.IndividualTaskList[i] is MultipleChoiceTask)
                {
                    bool[] answerMarkingsTableRow_Auxiliary = CurrentIndividualTestSheet.AnswerMarkingsTable[j];
                    bool[] truthTableRow_Auxiliary = CurrentEditedTestSheet.MultipleChoiceTruthTable[j];
                    MultipleChoiceTask multipleChoiceTask_Auxiliary = CurrentIndividualTestSheet.IndividualTaskList[i] as MultipleChoiceTask;
                    string question_auxiliary = Convert.ToString(Questions_FlowLP_1.Controls.Count + 1) + ". Task:\n" + multipleChoiceTask_Auxiliary.TaskFormulation + " (" + multipleChoiceTask_Auxiliary.PointValue + " point(s))";
                    List<string> answerOptions_Auxiliary = multipleChoiceTask_Auxiliary.AnswerOptionsList.Select(x => x._answerOptionText).ToList();
                    pointsEarned_Auxiliary = CurrentIndividualTestSheet.PointsEarnedArray[i];
                    Questions_FlowLP_1.Controls.Add(new MultipleChoiceTaskCheckerUC(question_auxiliary, answerOptions_Auxiliary, answerMarkingsTableRow_Auxiliary, truthTableRow_Auxiliary, pointsEarned_Auxiliary));
                    j++;
                }
                else if (CurrentIndividualTestSheet.IndividualTaskList[i] is EssayTask)
                {
                    EssayTask essayTask_Auxiliary = CurrentIndividualTestSheet.IndividualTaskList[i] as EssayTask;
                    string question_auxiliary = Convert.ToString(Questions_FlowLP_1.Controls.Count + 1) + ". Task:\n" + essayTask_Auxiliary.TaskFormulation + " (" + essayTask_Auxiliary.PointValue + " point(s))";
                    List<string> keywords_Auxiliary = essayTask_Auxiliary.KeywordsList;
                    pointsEarned_Auxiliary = CurrentIndividualTestSheet.PointsEarnedArray[i];
                    string answer_Auxiliary = CurrentIndividualTestSheet.EssayTaskAnswers[k];
                    int taskPointValue_Auxiliary = essayTask_Auxiliary.PointValue;
                    Questions_FlowLP_1.Controls.Add(new EssayTaskCheckerUC(question_auxiliary, keywords_Auxiliary, pointsEarned_Auxiliary, answer_Auxiliary, taskPointValue_Auxiliary, false)); ;
                    k++;
                }
            }
            Questions_FlowLP_1.FlowDirection = FlowDirection.TopDown;
        }
        private void SubmitCheckedTestSheetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TestSheetWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentIndividualTestSheet.CheckedTestSheet = true;
            for (int i = 0; i < Questions_FlowLP_1.Controls.Count; i++)
            {
                if (Questions_FlowLP_1.Controls[i] is EssayTaskCheckerUC)
                {
                    EssayTaskCheckerUC CurrentEssayTaskCheckerUC = Questions_FlowLP_1.Controls[i] as EssayTaskCheckerUC;
                    CurrentIndividualTestSheet.PointsEarnedArray[i] = CurrentEssayTaskCheckerUC.PointEarned;
                }
            }
            ConvertEarnedPointsFromArrayToString(out pointsEarnedString_Auxiliary);
            DialogResult ButtonSelect = MessageBox.Show("Can the test sheet check be saved before exiting?", "Closing test sheet check", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ButtonSelect == DialogResult.No)
            {
                Program.ReadDataFromDatabase();
            }
            else if (ButtonSelect == DialogResult.Yes)
            {
                try
                {
                    UploadDataToLEAP_DB();
                    Program.ReadDataFromDatabase();
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection failed", "Error");
                }
            }
            else if (ButtonSelect == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void ConvertEarnedPointsFromArrayToString(out string __pointsEarnedStringRow)
        {
            __pointsEarnedStringRow = "";
            for (int i = 0; i < CurrentIndividualTestSheet.PointsEarnedArray.Length; i++)
            {
                __pointsEarnedStringRow += Convert.ToString(CurrentIndividualTestSheet.PointsEarnedArray[i]);
                __pointsEarnedStringRow += "▼";
            }
        }
        private void UploadDataToLEAP_DB()
        {
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                {
                    string UpdateIndividualTestSheetStats = "UPDATE IndividualTestSheets SET PointsEarned=@pointsEarnedData, CheckedTestSheet=@CheckedTestSheetData WHERE Id=@idData";
                    using (SqlCommand OrderToUpdateIndividualTestSheetStats = new SqlCommand(UpdateIndividualTestSheetStats, connectingToLEAP_DB))
                    {
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@idData", CurrentIndividualTestSheet.SQL_ID_individualTestSheet);
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@pointsEarnedData", pointsEarnedString_Auxiliary);
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@CheckedTestSheetData", CurrentIndividualTestSheet.CheckedTestSheet);
                        connectingToLEAP_DB.Open();
                        OrderToUpdateIndividualTestSheetStats.ExecuteNonQuery();
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
}
