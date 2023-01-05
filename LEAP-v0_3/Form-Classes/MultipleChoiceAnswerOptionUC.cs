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
