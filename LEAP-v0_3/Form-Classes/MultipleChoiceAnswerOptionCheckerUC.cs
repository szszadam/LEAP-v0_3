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
