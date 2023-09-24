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
    //      ***** Test Sheet Window class *****
    //
    //
    //      *** Class description ***
    //
    //
    // The class for solving the individual test sheets, which is a descendant of the "Form"
    // class and displays the essay and/or multiple-choice tasks in the embedded "FlowLayoutPanel"
    // control.Other important elements of the graphic interface are the "Submit test sheet"
    // button, the label displaying the data of the person filling out the worksheet, and the
    // countdown timer that shows the remaining time available for completion.
    //
    //
    //      *** Fields ***
    //
    //
    // CurrentIndividualTestSheet: IndividualTestSheet – It stores the reference of the individual
    // test sheet displayed on the graphical interface.
    //
    //
    // CurrentEditedTestSheet: EditedTestSheet - It stores the reference of the edited test sheet
    // that serves as the archetype of the individual test sheet displayed on the graphical
    // interface.
    //
    //
    // timer: System.Windows.Forms.Timer – An object that stores the timing, the scheduling,
    // and the tick time of the countdown timer.
    //
    //
    // essayTaskAnswersString_Auxiliary: string – it is used to temporarily store the answers to
    // the essay tasks on the individual test sheet for the time of uploading to the database.
    // These answers will be stored in one text field in the database, using the “unit separator”
    // character '▼'.
    //
    //
    // multipleChoiceTaskAnswersString_Auxiliary: string - it is used to temporarily store the
    // answers marked in the multiple-choice tasks on the individual test sheet, during the process
    // of uploading to the database.These answers will be stored in one text field in the database,
    // using the “unit” and “record” separator characters '▲' and '▼'. The “unit separator”
    // character '▼' separates the multiple-choice tasks from each other, and the “record separator”
    // character '▲' separates the answer marks within these tasks.When creating an individual
    // test sheet, each answer mark takes the value "false".
    //
    //
    // pointsEarnedString_Auxiliary: string - it is used to temporarily store the points achieved
    // per task, during the process of uploading to the database.These earned points will be stored
    // in one text field in the database, using the “unit separator” character '▼'.
    //
    //
    // remainingTime: int – the time set on the edited test sheet that is available to complete
    // the test sheet, here in seconds.After opening the individual test sheet this remaining
    // time will always decrease by 1 unit per second due to the "Timer_tick()" event handler.
    //
    //
    // stillGotTime: bool – shows whether there is still time available for solving the
    // individual test sheet?
    //
    //
    //      ***Methods and event handlers***
    //
    //
    // TestSheetWindow_Load() event handler – this method runs when the test sheet window is opened,
    // as a result of it, the FillTestSheetFlowLayoutPanel() and Countdown() methods are called,
    // and the current date and time are entered into the “_testSheetStartTime” variable in the
    // current instance of the "IndividualTestSheet" class. The name of the user solving the test
    // sheet and the test sheet data itself(subject, topic) will be showed on the data label.
    //
    //
    // FillTestSheetFlowLayoutPanel() – the method populates the "FlowLayoutPanel" control on
    // the graphic interface with the elements of the task list of the edited test sheet providing
    // the basis of the individual test sheet.
    //
    //
    // SubmitTestSheetButton_Click() event handler – clicking on the "Submit test sheet" button starts the
    // closing process of the window, thus indirectly calling the TestSheetWindow_FormClosing()
    // event.
    //
    //
    // TestSheetWindow_FormClosing() event handler – When this method is running, the personal values are
    // entered into the auxiliary variables belonging to the current individual test sheet.
    // And after a user approval, these data are uploaded to the database, and then the window
    // closes. This method calls the following methods while it is running:
    // ConvertMultipleChoiceAnswersFromFlowLP_ToString(),
    // ConvertEssayAnswersFromFlowLP_ToString(),
    // IndividualTestSheet.FillAnswerMarkingsTableWithCustomValues(),
    // IndividualTestSheet.AutomaticEvaluationOfMultipleChoiceTask(), 
    // UploadDataToLEAP_DB(),
    // ConvertEarnedPointsFromArrayToString(), 
    // Program.ReadDataFromDatabase()
    //
    //
    //
    // ConvertMultipleChoiceAnswersFromFlowLP_ToString() - It links together the multiple-choice
    // answer markings into one text in accordance with the formal requirements of the
    // “multipleChoiceTaskAnswersString_Auxiliary” field (described above), to be uploaded into
    // the database.
    //
    //
    //
    // ConvertEssayAnswersFromFlowLP_ToString() - It links together the essay task answers into
    // one text in accordance with the formal requirements of the “essayTaskAnswersString_Auxiliary”
    // field (described above), to be uploaded into the database.
    //
    //
    // ConvertEarnedPointsFromArrayToString() - It links together the earned points into one text
    // in accordance with the formal requirements of the “pointsEarnedString_Auxiliary” field
    // (described above), to be uploaded into the database.
    //
    //
    // UploadDataToLEAP_DB() – Uploading the data to the database, collected from the currently
    // completed individual test sheet.
    //
    //
    // Countdown() – start the countdown when the individual test sheet is opened. 
    //
    //
    // Timer_tick() event handler - as a result of it, the remaining time will always decrease by 1 per
    // second, and the new, reduced remaining time will be written in the header of the
    // individual test sheet.


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
