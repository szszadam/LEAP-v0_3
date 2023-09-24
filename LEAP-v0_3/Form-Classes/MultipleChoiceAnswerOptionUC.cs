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
    //      ***** Multiple Choice Answer Option User Control Class *****
    //
    //      *** Class description ***
    //
    //
    // This class is a descendant of the "UserControl" class , and it displays the additional sub-
    // units, building blocks, and answer options of the multiple-choice tasks on the individual test
    // sheets.On one hand, the main element of the graphical interface are the "RichTextBox" control,
    // which displays the text of the answer option.And on the other hand, the "Mark answer" button,
    // which provides the opportunity for marking the answer and indicates its occurrence.It is
    // labeled with the character '?' (question mark) by default.
    //
    //
    //      *** Fields***
    //
    //
    // _answerMarking: bool – this variable stores the state of the answer mark, whether the user,
    // who is completing the task, marked this answer option as a correct one?
    //
    //
    // _option Text: string – stores the text formulation of the answer option.
    //
    //
    //      *** Methods and event handlers***

    // AnswerOptionButton_Click() event handler – by clicking on the "Mark answer" button, the value
    // of the logical variable „_answerMarking” changes to "true", and the background color of the
    // button and the answer option turn to yellow, indicating for the user this is one of the
    // answers, that he has marked correct. When the button is pressed again, the coloring returns to
    // the original and the logical variable "_answerMarking " takes on the value "false" again.


    public partial class MultipleChoiceAnswerOptionUC : UserControl
    {
        public bool _answerMarking = false;
        private string _answerOptionText;
        public MultipleChoiceAnswerOptionUC()
        {
            InitializeComponent();
        }
        public MultipleChoiceAnswerOptionUC(string __answerOption)
        {
            InitializeComponent();
            this._answerOptionText = __answerOption;
            answerOptionRTB.Text = _answerOptionText;
        }
        public bool AnswerMarking
        {
            get { return _answerMarking; }
            set { _answerMarking = value; }
        }
        private void AnswerOptionButton_Click(object sender, EventArgs e)
        {
            if (_answerMarking == false)
            {
                this.tableLayoutPanel1.BackColor = Color.Orange;
                this.answerOptionRTB.BackColor = Color.Gold;
                AnswerOptionButton.BackColor = Color.Gold;
                _answerMarking = true;
                AnswerOptionButton.Text = "🖝";
            }
            else if (_answerMarking == true)
            {
                this.tableLayoutPanel1.BackColor = Color.DimGray;
                AnswerOptionButton.BackColor = Color.FromArgb(192, 192, 255);
                this.answerOptionRTB.BackColor = Color.LightGray;
                _answerMarking = false;
                AnswerOptionButton.Text = "?";
            }
        }
    }
}
