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
    public partial class EssayTaskUC : UserControl
    {
        string _question;
        List<string> _keywords = new List<string>();
        public EssayTaskUC()
        {
            InitializeComponent();
        }
        public EssayTaskUC(string __question,List<string> __keywords)
        {
            InitializeComponent();
            this._question = __question;
            this._keywords = __keywords;
            EssayQuestionTextRTB.Text = __question;
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
    }
}
