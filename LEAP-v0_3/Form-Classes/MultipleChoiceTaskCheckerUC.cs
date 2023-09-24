using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LEAP_v0_3
{
    //      ***** Multiple Choice Task Checker User Control Class *****
    //
    //
    //      *** Class description***
    //
    //
    // The class that implements the display of multiple-choice questions on the correction and
    // viewing interfaces of the worksheet, which is a descendant of the "UserControl" class.
    //
    //
    //      *** Fields ***
    //
    //
    //_question: string – is used to store the formulation of the question / task.
    //
    //
    //_answerOptions: List<string> - a collection of answer choices.
    //
    //
    // _answerMarkingsRow: bool[] - It stores the answers of the user filling out the worksheet
    // regarding the correctness of the answer options of the task.
    //
    //
    // _truthTableRow: bool[] – It stores the marking of the correctness of the answer options of the
    // task for the teacher or administrator compiling the worksheet.
    //
    //
    // _pointEarned: int –Stores the user's score for the task.
    //
    //
    // _onlyPreview: bool – Since the same class is used to display the multiple-choice tasks both in
    // the preview during editing and in the case of correction, we use this logical variable to
    // indicate to the "ValaszhétosegJavitoUC" class in which mode it should display the answers.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // MultipleChoiceTaskUC_Load() event handler - When the MultipleChoiceTaskCheckerUC control is
    // loaded, it calls the LoadAnswerOptions_Preview () or the LoadAnswerOptions_Checker () method.
    // Depending on whether the user wants to display an editor preview or the checking/scoring view
    // of the completed and submitted individual worksheet question.
    //
    //
    // LoadAnswerOptions_Checker() - this method fills the "FlowLayoutPanel" control, which placed on
    // the graphical interface with the " MultipleChoiceTaskCheckerUC " control elements indicating
    // the answer options, in checking/scoring mode.
    //
    //
    // LoadAnswerOptions_Preview() - this method fills the "FlowLayoutPanel" control, which placed on
    // the graphical interface with the " MultipleChoiceTaskCheckerUC " control elements indicating
    // the answer options, in preview mode.
    //
    //
    // MultipleChoiceQuestionTextRTB_ContentsResized() event handler – sets the height of the
    // "RichTextBox" control, which displays the text of the question / task formulation, from a
    // lower value to a higher one, if the length of the text requires it.



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
