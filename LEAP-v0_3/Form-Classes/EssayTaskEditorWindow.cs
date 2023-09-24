using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
namespace LEAP_v0_3
{
    //      *****Essay Task Editor Window Class*****
    //
    //
    //      ***Class description***
    //
    //
    // This class displays the interface where the teacher or administrator can create a
    // new essay task.The class is a descendant of the "Form" class and the following main
    // control elements can be found on its graphical interface: subject selection
    // "ComboBox", task formulation "RichTextBox", point value "RichTextBox", 10
    // additional "RichTextBoxes" for entering keywords, and the "Creating essay task "
    // button.
    //
    //
    //      ***Fields***
    //
    //
    // keywordStringRowAuxiliary: string - when editing an essay task, it is used to store
    // keywords when uploading to the database.These keywords will be stored in one text
    // field in the database using the „unit separator” character '▼', which separates the
    // keywords belonging to the same task from each other within this text.
    //
    // UserSubjectsTaughtAuxiliary: List<string> - a collection of subjects taught by the
    // teacher or administrator, who is editing the task.Since from a subject based point
    // of view, only such tasks can be created as the subject taught by the active user.
    //
    // pointValueAuxiliary: int – the point value of the task is stored in this variable,
    // which is entered manually by the user editing the task.
    //
    //
    //      ***Methods and event handlers***
    //
    //
    // KeywordsConvertFromRTBToString() - It concatenates descriptive keywords to be
    // uploaded to the database into a text, in accordance with the formal requirements of
    // the field called "keywordStringRowAuxiliary" (described above).
    //
    //
    // CreateTaskButton_Click() event handler – clicking on the button "Create essay task"
    // starts the process of closing the window, thus indirectly calling the
    // EssayTaskEditorWindow_FormClosing() event.
    //
    //
    // EssayTaskEditorWindow_FormClosing() event handler - when this method runs, the
    // specified keywords are added to one line of text by calling the
    // KeywordsConvertFromRTBToString() method. After a user approval, these data are
    // uploaded to the database together with the formulation of the question, the text of
    // the subject and the scores, and then the window closes.The method also calls the
    // following methods while it is running: Program.ReadDataFromDatabase(),
    // KeywordsConvertFromRTBToString(), UploadDataToLEAP_DB()
    //
    //
    // UploadDataToLEAP_DB() - Upload the data of the completed new essay task to the
    // database.

    public partial class EssayTaskEditorWindow : Form
    {
        string keywordStringRowAuxiliary;
        List<string> UserSubjectsTaughtAuxiliary;
        int pointValueAuxiliary;
        public EssayTaskEditorWindow()
        {
            InitializeComponent();
            keywordStringRowAuxiliary = "";
            pointValueAuxiliary = 0;
            PointValueRTB.Text = pointValueAuxiliary.ToString();

            if (UserIdentification.ActiveUser is Administrator)
            {
                UserSubjectsTaughtAuxiliary = (UserIdentification.ActiveUser as Administrator).SubjectsTaughtList;
            }
            else if (UserIdentification.ActiveUser is Teacher)
            {
                UserSubjectsTaughtAuxiliary = (UserIdentification.ActiveUser as Teacher).SubjectsTaughtList;
            }
            else
            {
                UserSubjectsTaughtAuxiliary = new List<string>();
            }
            string[] UserSubjectsTaughtArray = UserSubjectsTaughtAuxiliary.ToArray();
            SubjectsComboBox1.Items.AddRange(UserSubjectsTaughtArray);
            SubjectsComboBox1.SelectedIndex = 0;
        }
        private void KeywordsConvertFromRTBToString(ref string __convertedKeyword, RichTextBox __keywordText)
        {
            if (__keywordText.Text.Trim().Count() > 0)
            {
                __convertedKeyword += __keywordText.Text;
                __convertedKeyword += "▼";
            }
        }
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UploadDataToLEAP_DB()
        {
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                {
                    string UploadTask = "INSERT INTO Tasks (Subject, TaskType, TaskFormulation, PointValue, Attributes, LockedTask) VALUES (@subjectData, @taskTypeData, @taskFormulationData, @pointValueData, @attributesData, @lockedTaskData)";
                    using (SqlCommand commandToUploadTask = new SqlCommand(UploadTask, connectingToLEAP_DB))
                    {
                        commandToUploadTask.Parameters.AddWithValue("@subjectData", (SubjectsComboBox1.Text).ToString());
                        commandToUploadTask.Parameters.AddWithValue("@taskTypeData", "Essay");
                        commandToUploadTask.Parameters.AddWithValue("@taskFormulationData", TaskFormulationRTB.Text);
                        commandToUploadTask.Parameters.AddWithValue("@pointValueData", pointValueAuxiliary.ToString());
                        commandToUploadTask.Parameters.AddWithValue("@attributesData", keywordStringRowAuxiliary);
                        commandToUploadTask.Parameters.AddWithValue("@lockedTaskData", "False");
                        connectingToLEAP_DB.Open();
                        commandToUploadTask.ExecuteNonQuery();
                        MessageBox.Show("Successful upload!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed", "Error");
            }
        }
        private void EssayTaskEditorWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_1);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_2);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_3);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_4);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_5);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_6);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_7);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_8);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_9);
            KeywordsConvertFromRTBToString(ref keywordStringRowAuxiliary, KeywordRTB_10);
            Int32.TryParse(PointValueRTB.Text, out pointValueAuxiliary);

            DialogResult ButtonSelect = MessageBox.Show("Can the task be saved before closing?", "Closing task", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ButtonSelect == DialogResult.No)
            {
                Program.ReadDataFromDatabase();
            }
            else if (ButtonSelect == DialogResult.Yes)
            {
                try
                {
                    UploadDataToLEAP_DB();
                    Program.ReadDataFromDatabase();
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection failed", "Error");
                }
            }
            else if (ButtonSelect == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
