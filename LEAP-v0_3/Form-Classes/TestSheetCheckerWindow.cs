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
