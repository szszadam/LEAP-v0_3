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
    //      ***** Test Sheet Viewer Window Class *****
    //
    //
    //      *** Class description ***
    //
    //
    // This class is a descendant of the "Form" class, and it is created for viewing the individual test
    // sheets checked / scored by the teacher.In case of multiple-choice tasks, it gives the user the
    // opportunity r to review the correctness of the answers, and  in the case of essay tasks, to view the
    // points manually given by the teacher.It displays essay and/or multiple-choice tasks in its embedded
    // "FlowLayoutPanel" control.Another important element of this graphic interface is the label on the top,
    // which displays the data about the test sheet itself and the name of the person who solved this test
    // sheet.
    //
    //
    //      *** Fields ***
    //
    //
    // CurrentIndividualTestSheet: IndividualTestSheet – this field stores the reference of the checked/
    // scored individual test sheet, that can be viewed in this window.
    //
    //
    // CurrentEditedTestSheet: EditedTestSheet - this field stores the reference of the edited test sheet
    // which is the basis of the checked/scored individual test sheet, that can be viewed in this window.
    //
    //
    // familyName: string – auxiliary variable which stores the family name of the user who solved the
    // individual test sheet.
    //
    //
    // firstName: string –  auxiliary variable which stores the first name of the user who solved the
    // individual test sheet.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // TestSheetWindow_Load() event handler –  this method runs when the TestSheetViewerWindow is loaded.It
    // calls the FillTestSheetFlowLayoutPanel() method, and writes into the upper left label the data about
    // the test sheet itself (subject, topic) and the name of the person who solved this test sheet.
    //
    //
    // FillTestSheetFlowLayoutPanel() – this method fills the "FlowLayoutPanel" of the individual task sheet,
    // placed on the graphic interface, with the checked / corrected tasks.




    public partial class TestSheetViewerWindow : Form
    {
        IndividualTestSheet CurrentIndividualTestSheet;
        EditedTestSheet CurrentEditedTestSheet;
        string familyName;
        string firstName;
        public TestSheetViewerWindow(int __individualTestSheetId, string __familyName, string __firstName)
        {
            CurrentIndividualTestSheet = DB_Connection.IndividualTestSheetList.FirstOrDefault(x => x.SQL_ID_individualTestSheet == __individualTestSheetId);
            CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == CurrentIndividualTestSheet.SQL_ID_editedTestSheet);
            this.familyName = __familyName;
            this.firstName = __firstName;
            InitializeComponent();
        }
        public void TestSheetWindow_Load(object sender, EventArgs e)
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
                    Questions_FlowLP_1.Controls.Add(new EssayTaskCheckerUC(question_auxiliary, keywords_Auxiliary, pointsEarned_Auxiliary, answer_Auxiliary, taskPointValue_Auxiliary, true)); ;
                    k++;
                }
            }
            Questions_FlowLP_1.FlowDirection = FlowDirection.TopDown;
        }
    }
}
