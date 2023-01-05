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
    public partial class TaskPreviewWindow : Form
    {
        public TaskPreviewWindow(int __taskId)
        {
            InitializeComponent();
            if (DB_Connection.MultipleChoiceTaskList.Exists(x => x.SQL_ID == __taskId))
            {
                MultipleChoiceTask CurrentMultipleChoiceTask = DB_Connection.MultipleChoiceTaskList.FirstOrDefault(x => x.SQL_ID == __taskId);
                string question_auxiliary = CurrentMultipleChoiceTask.TaskFormulation + ". Task:\n" + CurrentMultipleChoiceTask.TaskFormulation + " (" + CurrentMultipleChoiceTask.PointValue + " point(s))";
                List<string> answerOptions_Auxiliary = CurrentMultipleChoiceTask.AnswerOptionsList.Select(x=>x.AnswerOptionText).ToList<string>();
                bool[] truthTableRow_Auxiliary= CurrentMultipleChoiceTask.AnswerOptionsList.Select(x => x.isThisAnswerCorrect).ToArray<bool>();
                QuestionDisplay_FlowLP_1.Controls.Add(new MultipleChoiceTaskCheckerUC(question_auxiliary, answerOptions_Auxiliary, truthTableRow_Auxiliary) { Dock = DockStyle.Fill, AutoScroll=true }) ;
            }
            else if (DB_Connection.EssayTaskList.Exists(x => x.SQL_ID == __taskId))
            {
                EssayTask CurrentEssayTask = DB_Connection.EssayTaskList.FirstOrDefault(x => x.SQL_ID == __taskId);
                string question_auxiliary = CurrentEssayTask.TaskFormulation + ". Task:\n" + CurrentEssayTask.TaskFormulation + " (" + CurrentEssayTask.PointValue + " point(s))";
                List<string> keywords_Auxiliary = CurrentEssayTask.KeywordsList;
                int taskPointValue_Auxiliary = CurrentEssayTask.PointValue;
                QuestionDisplay_FlowLP_1.Controls.Add(new EssayTaskCheckerUC(question_auxiliary, keywords_Auxiliary, taskPointValue_Auxiliary) { Dock = DockStyle.Fill });
            }
        }
    }
}
