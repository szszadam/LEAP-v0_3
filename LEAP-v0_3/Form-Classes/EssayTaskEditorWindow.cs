using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAP_v0_3
{
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
