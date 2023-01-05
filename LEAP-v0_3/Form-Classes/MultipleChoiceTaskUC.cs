using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace LEAP_v0_3
{
    public partial class MultipleChoiceTaskUC : UserControl
    {
        string _question;
        List<string> _answerOptions = new List<string>();
        public MultipleChoiceTaskUC()
        {
            InitializeComponent();
        }
        public MultipleChoiceTaskUC(string __question, List<string> __answerOptions)
        {
            InitializeComponent();
            this._question = __question;
            this._answerOptions = __answerOptions;
            MultipleChoiceQuestionTextRTB.Text = _question;
        }
        private void MultipleChoiceTaskUC_Load(object sender, EventArgs e)
        {
            LoadAnswerOptions();
        }
        public void LoadAnswerOptions()
        {
            AnswerOptions_FlowLP_1.Controls.Clear();
            for (int i = 0; i < _answerOptions.Count; i++)
            {
                AnswerOptions_FlowLP_1.Controls.Add(new MultipleChoiceAnswerOptionUC(_answerOptions[i]));
            }
            AnswerOptions_FlowLP_1.FlowDirection = FlowDirection.TopDown;
        }
        private void MultipleChoiceQuestionTextRTB_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }
    }
}
