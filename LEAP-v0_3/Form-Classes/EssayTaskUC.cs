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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Runtime.InteropServices;

namespace LEAP_v0_3
{
    //      ***** Essay Task User Control class *****
    //
    //
    //      *** Class description***
    //
    // This class implements the display of essay tasks on the test sheet filling
    // interfaces, which is a descendant of the "UserControl" class.
    //
    //
    //      *** Fields ***
    //
    //
    // _question: string –is used to store the formulation of the question / task.
    //
    //
    // _keywords: List<string> - is the collection of keywords.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // EssayTaskUC_Load() event handler - when the EssayTaskUC control is loaded, it calls
    // the LoadKeywords() method and sets the height of the "ListBox" control that stores
    // the keywords to the required size.
    //
    //
    // LoadKeywords() - places the keywords into the "ListBox" control placed on the
    // EssayTaskUC control.
    //
    //
    // EssayQuestionTextRTB_ContentsResized() event handler - the height of the "RichTextBox" control
    // used to display the text of the question / task formulation is set to a higher value, if the
    // length of the text requires it.


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
