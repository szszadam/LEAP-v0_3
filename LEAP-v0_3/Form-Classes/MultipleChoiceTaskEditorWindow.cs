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
    //      ***** Multiple Choice Task Editor Window Class *****
    //
    //
    //      *** Class description ***
    //
    //
    // This class provides the interface where the teacher or administrator can edit a new multiple-choice
    // task.The class is a descendant of the "Form" class and the following main elements can be found on its
    // graphical interface: subject selection "ComboBox", task formulation "RichTextBox", point value
    // "RichTextBox", further 10 "RichTextBoxes" for entering answer option texts.There are also the
    // corresponding "CheckBox" elements, in which the user can indicate the correctness of the
    // answer option, and lastly the "Create multiple choice task" button.
    //
    //
    //      *** Fields ***
    //
    //
    // answerOptionsStringRow_Auxiliary: string - when editing a multiple-choice task, it stores the answer
    // options and their correctnesses during uploading to the database.These answer options and their
    // correctnesses ("true" or "false") will be stored in a simple text field in the LEAP database, using
    // the separator characters '▲' and '▼'. The “record separator” character '▲' separates pairs of answers-
    // option+correctness from other such pairs.The “unit separator” '▼' character separates this answer
    // option and its boolean value indicating its correctness within this pair.
    //
    //
    // UserSubjectsTaughtAuxiliary: List<string> - the collection of subjects taught by the teacher or
    // administrator editing the task.In terms of subject matter, only such types of tasks can be created as
    // the subject taught by the active user.
    //
    //
    // pointValueAuxiliary: hint – it stores the point value of the task, which is automatically generated.
    // The task will be worth as many points as many is the number of correct answer options.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // ConvertAnswerOptionFromRTB_ToString () - For the process of uploading to the LEAP database, the
    // multiple choice answer markings and the indication of their correctness are combined into one text
    // according to the formal requirements of the field called "answerOptionsStringRow_Auxiliary" (described
    // above).
    //
    //
    // PointValueCalculation() – This method counts the number of answer options indicated as correct.This
    // value will be the maximum reachable point value of the task.
    //
    //
    // CreateTaskButton_Click() event handler –  Clicking on the "Create multiple choice task" button starts
    // the closing process of the window, thus indirectly calling the
    // MultipleChoiceTaskEditorWindow_FormClosing () method.
    //
    //
    // MultipleChoiceTaskEditorWindow_FormClosing() event handler – During running this method, each answer
    // option text fields are checked to see if it has any meaningful content, and whether the given answer
    // option has been marked as correct.After a user approval, these data are uploaded together with the
    // text of the question, the text of the subject and the point value to the LEAP database.Then the window
    // closes. This method also calls the following methods during runtime:
    // Program.ReadDataFromDatabase(),
    // ConvertAnswerOptionFromRTB_ToString(),
    // UploadDataToLEAP_DB()
    //
    //
    //
    // UploadDataToLEAP_DB() – This method uploads the data of the prepared multiple choice task to the LEAP
    // database.
    //
    //
    // TrueAnswerOptionCheckBox_*** _CheckedChanged() event handlers –  The status-changes of the
    // "CheckBoxes" indicating the possible correctness of the answer option are monitored, and if a change
    // occurres, the PointValueCalculation() method is called (again).

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
