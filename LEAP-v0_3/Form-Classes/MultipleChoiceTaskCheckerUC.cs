using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAP_v0_3
{
    public partial class MultipleChoiceTaskCheckerUC : UserControl
    {
        string _question;
        List<string> _answerOptions = new List<string>();
        bool[] _answerMarkingsRow;
        bool[] _truthTableRow;
        int _pointEarned;
        bool _onlyPreview;
        public MultipleChoiceTaskCheckerUC()
        {
            InitializeComponent();
        }
        public MultipleChoiceTaskCheckerUC(string __question, List<string> __answerOptions, bool[] __answerMarkingsRow, bool[] __truthTableRow, int __pointEarned)
        {
            InitializeComponent();
            this._question = __question;
            this._answerOptions = __answerOptions;
            this._answerMarkingsRow = __answerMarkingsRow;
            this._truthTableRow = __truthTableRow;
            this._pointEarned = __pointEarned;
            this._onlyPreview = false;
            MultipleChoiceQuestionTextRTB.Text = __question;
            MultipleChoicePointsEarnedRTB.Text = Convert.ToString(_pointEarned);
        }
        public MultipleChoiceTaskCheckerUC(string __question, List<string> __answerOptions, bool[] __truthTableRow)
        {
            InitializeComponent();
            this._question = __question;
            this._answerOptions = __answerOptions;
            this._truthTableRow = __truthTableRow;
            this._onlyPreview = true;
            MultipleChoiceQuestionTextRTB.Text = __question;
            MultipleChoicePointsEarnedRTB.Text = Convert.ToString(_pointEarned);
        }
        private void MultipleChoiceTaskUC_Load(object sender, EventArgs e)
        {
            if (_onlyPreview) LoadAnswerOptions_Preview();
            else LoadAnswerOptions_Checker();
        }
        public void LoadAnswerOptions_Checker()
        {
            AnswerOptions_FlowLP_1.Controls.Clear();
            for (int i = 0; i < _answerOptions.Count; i++)
            {
                AnswerOptions_FlowLP_1.Controls.Add(new MultipleChoiceAnswerOptionCheckerUC(_answerOptions[i], _answerMarkingsRow[i], _truthTableRow[i]));
            }
            AnswerOptions_FlowLP_1.FlowDirection = FlowDirection.TopDown;
        }
        public void LoadAnswerOptions_Preview()
        {
            AnswerOptions_FlowLP_1.Controls.Clear();
            for (int i = 0; i < _answerOptions.Count; i++)
            {
                AnswerOptions_FlowLP_1.Controls.Add(new MultipleChoiceAnswerOptionCheckerUC(_answerOptions[i], _truthTableRow[i]));
            }
            AnswerOptions_FlowLP_1.FlowDirection = FlowDirection.TopDown;
        }
        private void MultipleChoiceQuestionTextRTB_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }
    }
}
