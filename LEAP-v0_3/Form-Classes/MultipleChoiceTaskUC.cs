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
using static System.Windows.Forms.AxHost;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace LEAP_v0_3
{
    public partial class MultipleChoiceTaskUC : UserControl
    {

    //      ***** Multiple Choice Task User Control Class *****
    //
    //
    //      *** Class description ***
    //
    //
    // This class is a descendant of the "UserControl" class and it provides the display of multiple-
    // choice tasks on the testsheet solving interface.
    //
    //
    //      *** Fields ***
    //
    //
    // _question: string –   is used to store the wording of the question / task
    //
    //
    // _answerOptions: List<string> - collection of response options
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // MultipleChoiceTaskUC_Load() event handler - when the Multiple Choice Task User Control is
    // loaded, it calls the LoadAnswerOptions() method.
    //
    //
    // LoadAnswerOptions() – it places the " MultipleChoiceAnswerOptionUC" instances in the
    // "FlowLayoutPanel" placed on the Multiple Choice Task User Control.
    //
    //
    // MultipleChoiceQuestionTextRTB_ContentsResized() event handler – it sets the height of the
    // "RichTextBox", which displays the text of the question / task formulation, from a lower value
    // to a higher one, if the length of the text requires it.



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
