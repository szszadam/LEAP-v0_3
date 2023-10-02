using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAP_v0_3
{



    //      ***** Multiple Choice Answer Option Checker User Control Class *****
    //
    //
    // In the preview window of the task editor and in the preview window of the edited test sheets, this is
    // the class that displays the further subunits(building blocks), the answer options of the multiple-
    // choice tasks, which is a descendant of the "UserControl" class. On one hand the main elements of the
    // graphic interface are the "RichTextBox" controls, which displays the text of the answer option.And on
    // the other hand, there are the "Mark answer" buttons, which indicates the correctness of the answers,
    // which buttons are labeled with the character '?' (question mark) by default. In this case, this button
    // does not works only as a classic button, but only as a feedback control.The Multiple Choice Answer
    // Option Checker User Control can operate in two modes. First, it is able to work in such a way that
    // during editing the tasks and test sheet, it provides a preview display: It marks the answer options
    // that were also signed as a correct one during editing.Second, it is also able to function in such way,
    // that during checking / scoring the submitted test sheet by the teacher, or viewing the results by the
    // student, not only the correct answers are displayed , but the student’s answers are also indicated.
    //
    //
    //      *** Fields ***
    //
    //
    // _answerMarking: bool – the variable that stores the state of the answer mark, whether the user
    // completing the task marked the task as correct?
    //
    //
    // _answerOptionText: string  – stores the text formulation of the answer option
    //
    //
    // _truth: bool – is the answer option actually true?
    //
    //
    //      *** Methods and events ***
    //
    //
    // FieldColoring_Checker() – method is used in the checking / scoring mode when it colors the answer
    // option's indicator button and background as follows: 
    // If the user marked the answer as "false", but the answer option is actually "true" => yellow.
    // If the user marked the answer as "true", but the answer option is actually "false" => red.
    // If the user marked the answer as "true" and the answer option is indeed "true" => green.
    // In other cases, the original blue color remains.
    //
    //
    // FieldColoring_Preview() –  this method is used in preview mode, when it colors the indicator button
    // and the background of the answer option as follows: If the answer option was found to be true by the
    // editor => green.


    public partial class MultipleChoiceAnswerOptionCheckerUC : UserControl
    {
        private string _answerOptionText;
        bool _answerMarking;
        bool _truth;
        public MultipleChoiceAnswerOptionCheckerUC()
        {
            InitializeComponent();
        }
        public MultipleChoiceAnswerOptionCheckerUC(string __answerOption, bool __answerMarking, bool __truth)
        {
            InitializeComponent();
            this._answerOptionText = __answerOption;
            this._answerMarking = __answerMarking;
            this._truth = __truth;
            answerOptionRTB.Text = _answerOptionText;
            FieldColoring_Checker();
        }
        public MultipleChoiceAnswerOptionCheckerUC(string __answerOption, bool __truth)
        {
            InitializeComponent();
            this._answerOptionText = __answerOption;
            this._truth = __truth;
            answerOptionRTB.Text = _answerOptionText;
            FieldColoring_Preview();
        }
        private void FieldColoring_Checker()
        {
            if (_answerMarking == false && _truth == true)
            {
                this.tableLayoutPanel1.BackColor = Color.OrangeRed;
                this.answerOptionRTB.BackColor = Color.Tomato;
                AnswerOptionButton.BackColor = Color.Tomato;
                AnswerOptionButton.Text = "🖝";
            }
            else if (_answerMarking == true && _truth == false)
            {
                this.tableLayoutPanel1.BackColor = Color.DarkRed;
                AnswerOptionButton.BackColor = Color.Red;
                this.answerOptionRTB.BackColor = Color.Red;
                AnswerOptionButton.Text = "✖";
            }
            else if (_answerMarking == true && _truth == true)
            {
                this.tableLayoutPanel1.BackColor = Color.Green;
                AnswerOptionButton.BackColor = Color.LimeGreen;
                this.answerOptionRTB.BackColor = Color.LimeGreen;
                AnswerOptionButton.Text = "✔";
            }
            else
            {
                this.tableLayoutPanel1.BackColor = Color.DimGray;
                AnswerOptionButton.BackColor = Color.FromArgb(192, 192, 255);
                this.answerOptionRTB.BackColor = Color.LightGray;
                AnswerOptionButton.Text = "";
            }
        }
        public void FieldColoring_Preview()
        {
            if ( _truth == true)
            {
                this.tableLayoutPanel1.BackColor = Color.Green;
                this.answerOptionRTB.BackColor = Color.LimeGreen;
                AnswerOptionButton.BackColor = Color.LimeGreen;
                AnswerOptionButton.Text = "🖝";
            }
        }
    }
}
