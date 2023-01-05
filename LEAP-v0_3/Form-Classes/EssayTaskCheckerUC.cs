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
    public partial class EssayTaskCheckerUC : UserControl
    {
        string _question;
        List<string> _keywords = new List<string>();
        int _pointEarned;
        string _answer;
        int _taskPointValue;
        public int PointEarned
        {
            get { return _pointEarned; }
        }
        public string Question
        {
            get { return _question; }
            set { EssayQuestionTextRTB.Text = value; _question = value; }
        }
        public List<string> Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        public EssayTaskCheckerUC(string __question, List<string> __keywords, int __pointEarned, string __answer, int __taskPointValue, bool readOnlyEssayPointRTB)
        {
            InitializeComponent();
            this._question = __question;
            this._keywords = __keywords;
            this._pointEarned = __pointEarned;
            this._answer = __answer;
            this._taskPointValue = __taskPointValue;
            EssayQuestionTextRTB.Text = _question;
            EssayTaskPointsEarnedRTB.Text = Convert.ToString(_pointEarned);
            AnswerFieldRTB.Text = _answer;
            if (readOnlyEssayPointRTB == false)
            {
                EssayTaskPointsEarnedRTB.ReadOnly = false;
                EssayTaskPointsEarnedRTB.BackColor = Color.Orange;
            }
            else
            {
                EssayTaskPointsEarnedRTB.ReadOnly = true;
                EssayTaskPointsEarnedRTB.BackColor = Color.DeepSkyBlue;
            }
        }
        public EssayTaskCheckerUC(string __question, List<string> __keywords, int __taskPointValue)
        {
            InitializeComponent();
            this._question = __question;
            this._keywords = __keywords;
            this._taskPointValue = __taskPointValue;
            EssayQuestionTextRTB.Text = _question;
            EssayTaskPointsEarnedRTB.ReadOnly = true;
            EssayTaskPointsEarnedRTB.BackColor = Color.DeepSkyBlue;
        }
        private void EssayTaskUC_Load(object sender, EventArgs e)
        {
            LoadKeywords();
            KeywordsListbox.Height = KeywordsListbox.PreferredHeight;
        }
        public void LoadKeywords()
        {
            KeywordsListbox.Items.Clear();
            KeywordsListbox.Items.Add("Keywords:");
            for (int i = 0; i < _keywords.Count; i++)
            {
                KeywordsListbox.Items.Add(_keywords[i]);
            }
        }
        private void EssayQuestionTextRTB_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }
        private void EssayTaskPointsEarnedRTB_TextChanged(object sender, EventArgs e)
        {
            int typedPoint;
            if(!(Int32.TryParse(EssayTaskPointsEarnedRTB.Text,out typedPoint)))
            {
                EssayTaskPointsEarnedRTB.Text = Convert.ToString(_pointEarned);
                MessageBox.Show($"Only integer points are allowed!\nIn this case, the point value must be between 0 point and {_taskPointValue} points!");
            }
            else if (Convert.ToInt32(EssayTaskPointsEarnedRTB.Text) >_taskPointValue || Convert.ToInt32(EssayTaskPointsEarnedRTB.Text) < 0)
            {
                EssayTaskPointsEarnedRTB.Text = Convert.ToString(_pointEarned);
                MessageBox.Show($"In this case, the point value must be between 0 point and {_taskPointValue} points!");
            }
            else
            {
                _pointEarned = Convert.ToInt32(EssayTaskPointsEarnedRTB.Text);
            }
        }
    }
}
