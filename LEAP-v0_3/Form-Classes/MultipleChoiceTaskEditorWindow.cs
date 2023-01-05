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
    public partial class MultipleChoiceTaskEditorWindow : Form
    {
        string answerOptionsStringRow_Auxiliary;
        List<string> UserSubjectsTaughtAuxiliary;
        int pointValueAuxiliary;
        public MultipleChoiceTaskEditorWindow()
        {
            InitializeComponent();
            answerOptionsStringRow_Auxiliary = "";
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
        private void ConvertAnswerOptionFromRTB_ToString(ref string __convertedAnswerOption, RichTextBox __answerOptionText, CheckBox __trueAnswer)
        {
            if (__answerOptionText.Text.Trim().Count() > 0)
            {
                __convertedAnswerOption += __answerOptionText.Text;
                __convertedAnswerOption += "▼";
                if (__trueAnswer.Checked.Equals(true))
                {
                    __convertedAnswerOption += "true";
                }
                else
                {
                    __convertedAnswerOption += "false";
                }
                __convertedAnswerOption += "▲";
            }
        }
        private void PointValueCalculation()
        {
            pointValueAuxiliary = 0;
            if ((AnswerOptionRTB_1.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_1.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_2.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_2.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_3.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_3.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_4.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_4.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_5.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_5.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_6.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_6.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_7.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_7.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_8.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_8.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_9.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_9.Checked.Equals(true))) pointValueAuxiliary++;
            if ((AnswerOptionRTB_10.Text.Trim().Count() > 0) && (TrueAnswerOptionCheckBox_10.Checked.Equals(true))) pointValueAuxiliary++;
            PointValueRTB.Text = pointValueAuxiliary.ToString();
        }
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MultipleChoiceTaskEditorWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_1, TrueAnswerOptionCheckBox_1);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_2, TrueAnswerOptionCheckBox_2);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_3, TrueAnswerOptionCheckBox_3);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_4, TrueAnswerOptionCheckBox_4);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_5, TrueAnswerOptionCheckBox_5);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_6, TrueAnswerOptionCheckBox_6);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_7, TrueAnswerOptionCheckBox_7);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_8, TrueAnswerOptionCheckBox_8);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_9, TrueAnswerOptionCheckBox_9);
            ConvertAnswerOptionFromRTB_ToString(ref answerOptionsStringRow_Auxiliary, AnswerOptionRTB_10, TrueAnswerOptionCheckBox_10);

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
                        commandToUploadTask.Parameters.AddWithValue("@taskTypeData", "MultipleChoice");
                        commandToUploadTask.Parameters.AddWithValue("@taskFormulationData", TaskFormulationRTB.Text);
                        commandToUploadTask.Parameters.AddWithValue("@pointValueData", pointValueAuxiliary.ToString());
                        commandToUploadTask.Parameters.AddWithValue("@attributesData", answerOptionsStringRow_Auxiliary);
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
        private void TrueAnswerOptionCheckBox_1_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_2_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_3_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_4_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_5_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_6_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_7_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_8_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_9_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        private void TrueAnswerOptionCheckBox_10_CheckedChanged(object sender, EventArgs e)
        {
            PointValueCalculation();
        }
        
    }
}
