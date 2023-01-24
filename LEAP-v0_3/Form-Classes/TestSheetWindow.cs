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
    public partial class TestSheetWindow : Form
    {
        IndividualTestSheet CurrentIndividualTestSheet;
        EditedTestSheet CurrentEditedTestSheet;
        System.Windows.Forms.Timer timer;
        string essayTaskAnswersString_Auxiliary;
        string multipleChoiceTaskAnswersString_Auxiliary;
        string pointsEarnedString_Auxiliary;
        int remainingTime;
        bool stillGotTime;
        public TestSheetWindow(int __individualTestSheetId)
        {
            CurrentIndividualTestSheet = DB_Connection.IndividualTestSheetList.FirstOrDefault(x => x.SQL_ID_individualTestSheet == __individualTestSheetId);
            CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == CurrentIndividualTestSheet.SQL_ID_editedTestSheet);
            stillGotTime = true;
            InitializeComponent();
        }
        public void TestSheetWindow_Load(object sender, EventArgs e)
        {
            Questions_FlowLP_1.Controls.Clear();
            FillTestSheetFlowLayoutPanel();
            CurrentIndividualTestSheet.TestSheetStartTime = System.DateTime.Now;
            Countdown(CurrentEditedTestSheet.AvailableTime);
            dataLabel.Text = $"Student and test sheet information:\n{UserIdentification.ActiveUser.FamilyName} {UserIdentification.ActiveUser.FirstName}\n{CurrentEditedTestSheet.Subject}, {CurrentEditedTestSheet.Topic}";
        }
        public void FillTestSheetFlowLayoutPanel()
        {
            for (int i = 0; i < CurrentIndividualTestSheet.IndividualTaskList.Count; i++)
            {
                if (CurrentIndividualTestSheet.IndividualTaskList[i] is MultipleChoiceTask)
                {
                    MultipleChoiceTask multipleChoiceTask_Auxiliary = CurrentIndividualTestSheet.IndividualTaskList[i] as MultipleChoiceTask;
                    string question_auxiliary = Convert.ToString(Questions_FlowLP_1.Controls.Count + 1) + ". Task:\n" + multipleChoiceTask_Auxiliary.TaskFormulation + " (" + multipleChoiceTask_Auxiliary.PointValue + " point(s))";
                    List<string> answerOptions_Auxiliary = multipleChoiceTask_Auxiliary.AnswerOptionsList.Select(x => x._answerOptionText).ToList();
                    Questions_FlowLP_1.Controls.Add(new MultipleChoiceTaskUC(question_auxiliary, answerOptions_Auxiliary));
                }
                else if (CurrentIndividualTestSheet.IndividualTaskList[i] is EssayTask)
                {
                    EssayTask essayTask_Auxiliary = CurrentIndividualTestSheet.IndividualTaskList[i] as EssayTask;
                    string question_auxiliary = Convert.ToString(Questions_FlowLP_1.Controls.Count + 1) + ". Task:\n" + essayTask_Auxiliary.TaskFormulation + " (" + essayTask_Auxiliary.PointValue + " point(s))";
                    List<string> keywords_Auxiliary = essayTask_Auxiliary.KeywordsList;
                    Questions_FlowLP_1.Controls.Add(new EssayTaskUC(question_auxiliary, keywords_Auxiliary));
                }
            }
            Questions_FlowLP_1.FlowDirection = FlowDirection.TopDown;
        }
        private void SubmitTestSheetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TestSheetWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentIndividualTestSheet.SubmittedTestSheet = true;
            CurrentIndividualTestSheet.TestSheetSubmitTime = System.DateTime.Now;
            ConvertMultipleChoiceAnswersFromFlowLP_ToString(out multipleChoiceTaskAnswersString_Auxiliary);
            ConvertEssayAnswersFromFlowLP_ToString(out essayTaskAnswersString_Auxiliary);
            CurrentIndividualTestSheet.AnswerMarkingsTable = IndividualTestSheet.FillAnswerMarkingsTableWithCustomValues(multipleChoiceTaskAnswersString_Auxiliary, CurrentIndividualTestSheet.AnswerMarkingsTable);
            CurrentIndividualTestSheet.PointsEarnedArray = IndividualTestSheet.AutomaticEvaluationOfMultipleChoiceTask(CurrentEditedTestSheet.MultipleChoiceTruthTable, CurrentIndividualTestSheet.AnswerMarkingsTable, CurrentIndividualTestSheet.IndividualTaskList, CurrentIndividualTestSheet.PointsEarnedArray);
            ConvertEarnedPointsFromArrayToString(out pointsEarnedString_Auxiliary);

            if (stillGotTime && (MessageBox.Show("Are you sure to submit (and close) the test sheet?", "Submitting test sheet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                e.Cancel = true;
            }
            else
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
        }
        private void ConvertMultipleChoiceAnswersFromFlowLP_ToString(out string __multipleChoiceAnswersStringRow)
        {
            __multipleChoiceAnswersStringRow = "";
            for (int i = 0; i < Questions_FlowLP_1.Controls.Count; i++)
            {
                if (Questions_FlowLP_1.Controls[i] is MultipleChoiceTaskUC)
                {
                    __multipleChoiceAnswersStringRow += "▲";
                    MultipleChoiceTaskUC multipleChoiceTaskUC_Auxiliary = Questions_FlowLP_1.Controls[i] as MultipleChoiceTaskUC;
                    for (int j = 0; j < multipleChoiceTaskUC_Auxiliary.AnswerOptions_FlowLP_1.Controls.Count; j++)
                    {
                        MultipleChoiceAnswerOptionUC answerOptionUC_Auxiliary = multipleChoiceTaskUC_Auxiliary.AnswerOptions_FlowLP_1.Controls[j] as MultipleChoiceAnswerOptionUC;
                        __multipleChoiceAnswersStringRow += "▼";
                        __multipleChoiceAnswersStringRow += Convert.ToString(answerOptionUC_Auxiliary.AnswerMarking);
                    }
                }
            }
        }
        private void ConvertEssayAnswersFromFlowLP_ToString(out string __essayAnswersStringRow)
        {
            __essayAnswersStringRow = "";
            for (int i = 0; i < Questions_FlowLP_1.Controls.Count; i++)
            {
                if (Questions_FlowLP_1.Controls[i] is EssayTaskUC)
                {
                    EssayTaskUC essayTaskUC_Auxiliary = Questions_FlowLP_1.Controls[i] as EssayTaskUC;
                    if (string.IsNullOrWhiteSpace(essayTaskUC_Auxiliary.AnswerFieldRTB.Text))
                    {
                        __essayAnswersStringRow += "///NO ANSWER▼";
                    }
                    else
                    {
                        __essayAnswersStringRow += (essayTaskUC_Auxiliary.AnswerFieldRTB.Text + "▼");
                    }
                }
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
                    string UpdateIndividualTestSheetStats = "UPDATE IndividualTestSheets SET PointsEarned=@pointsEarnedData, SubmittedTestSheet=@submittedTestSheetData, AnswerMarkingsTable=@answerMarkingsTableData, EssayTaskAnswers=@essayAnswersData, TestSheetStartTime=@testSheetStartTimeData, TestSheetSubmitTime=@testSheetSubmitTimeData WHERE Id=@idData";
                    using (SqlCommand OrderToUpdateIndividualTestSheetStats = new SqlCommand(UpdateIndividualTestSheetStats, connectingToLEAP_DB))
                    {
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@idData", CurrentIndividualTestSheet.SQL_ID_individualTestSheet);
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@pointsEarnedData", pointsEarnedString_Auxiliary);
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@submittedTestSheetData", CurrentIndividualTestSheet.SubmittedTestSheet);
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@answerMarkingsTableData", multipleChoiceTaskAnswersString_Auxiliary);
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@essayAnswersData", essayTaskAnswersString_Auxiliary);
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@testSheetStartTimeData", CurrentIndividualTestSheet.TestSheetStartTime.ToString("yyyy/MM/dd HH:mm:ss"));
                        OrderToUpdateIndividualTestSheetStats.Parameters.AddWithValue("@testSheetSubmitTimeData", CurrentIndividualTestSheet.TestSheetSubmitTime.ToString("yyyy/MM/dd HH:mm:ss"));
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
        private void Countdown(int __remainingTime_Minute)
        {
            timer = new System.Windows.Forms.Timer();
            remainingTime = __remainingTime_Minute * 60;
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += Timer_tick;
            timer.Start();
            countdownLabel.Text = "Remaining time: " + (Convert.ToString(remainingTime / 60).PadLeft(2, '0')) + ":" + (Convert.ToString(remainingTime % 60).PadLeft(2, '0'));
        }
        private void Timer_tick(object sender, EventArgs e)
        {
            countdownLabel.Text = "Remaining time: " + (Convert.ToString(remainingTime / 60).PadLeft(2, '0')) + ":" + (Convert.ToString(remainingTime % 60).PadLeft(2, '0'));
            remainingTime -= 1;
            if (remainingTime < 0)
            {
                stillGotTime = false;
                timer.Stop();
                SubmitTestSheetButton_Click(this, EventArgs.Empty);
            }
        }
    }
}
