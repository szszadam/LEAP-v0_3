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
    // ****Test Sheet Preview class*****
    //
    // The class for opening the preview of tasks edited in the task editor, which is a
    // descendant of the "Form" class. It is equally suitable for displaying essay and
    // multiple-choice tasks.

    public partial class TestSheetPreviewWindow : Form
    {
        EditedTestSheet CurrentEditedTestSheet;
        public TestSheetPreviewWindow(int __editedTestSheetId)
        {
            CurrentEditedTestSheet = DB_Connection.EditedTestSheetList.FirstOrDefault(x => x.SQL_ID == __editedTestSheetId);
            InitializeComponent();
        }
        public void TestSheetWindow_Load(object sender, EventArgs e)
        {
            Questions_FlowLP_1.Controls.Clear();
            FillTestSheetFlowLayoutPanel();
            dataLabel.Text = $"Test sheet information:{CurrentEditedTestSheet.Subject}, {CurrentEditedTestSheet.Topic}";
        }
        public void FillTestSheetFlowLayoutPanel()
        {
            int j = 0; 
            int k = 0; 
            for (int i = 0; i < CurrentEditedTestSheet.EditorTaskList.Count; i++)
            {
                if (CurrentEditedTestSheet.EditorTaskList[i] is MultipleChoiceTask)
                {
                    bool[] truthTableRow_Auxiliary = CurrentEditedTestSheet.MultipleChoiceTruthTable[j];
                    MultipleChoiceTask multipleChoiceTask_Auxiliary = CurrentEditedTestSheet.EditorTaskList[i] as MultipleChoiceTask;
                    string question_auxiliary = Convert.ToString(Questions_FlowLP_1.Controls.Count + 1) + ". Task:\n" + multipleChoiceTask_Auxiliary.TaskFormulation + " (" + multipleChoiceTask_Auxiliary.PointValue + " point(s))";
                    List<string> answerOptions_Auxiliary = multipleChoiceTask_Auxiliary.AnswerOptionsList.Select(x => x._answerOptionText).ToList();
                    Questions_FlowLP_1.Controls.Add(new MultipleChoiceTaskCheckerUC(question_auxiliary, answerOptions_Auxiliary, truthTableRow_Auxiliary));
                    j++;
                }
                else if (CurrentEditedTestSheet.EditorTaskList[i] is EssayTask)
                {
                    EssayTask essayTask_Auxiliary = CurrentEditedTestSheet.EditorTaskList[i] as EssayTask;
                    string question_auxiliary = Convert.ToString(Questions_FlowLP_1.Controls.Count + 1) + ". Task:\n" + essayTask_Auxiliary.TaskFormulation + " (" + essayTask_Auxiliary.PointValue + " point(s))";
                    List<string> keywords_Auxiliary = essayTask_Auxiliary.KeywordsList;
                    int taskPointValue_Auxiliary = essayTask_Auxiliary.PointValue;
                    Questions_FlowLP_1.Controls.Add(new EssayTaskCheckerUC(question_auxiliary, keywords_Auxiliary, taskPointValue_Auxiliary));
                    k++;
                }
            }
            Questions_FlowLP_1.FlowDirection = FlowDirection.TopDown;
        }
    }
}
