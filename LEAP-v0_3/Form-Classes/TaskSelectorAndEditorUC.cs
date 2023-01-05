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
    public partial class TaskSelectorAndEditorUC : UserControl
    {
        public TaskSelectorAndEditorUC()
        {
            InitializeComponent();
        }
        private void FillTaskSelectorDGV()
        {
            int taskId;
            string taskSubject;
            string taskType;
            string taskFormulation;
            int pointValue;
            string taskLocked;

            TaskSelectorDGV.Rows.Clear();

            List<string> UserSubjectsTaughtAuxiliary;

            if (UserIdentification.ActiveUser is Administrator)
            {
                UserSubjectsTaughtAuxiliary = (UserIdentification.ActiveUser as Administrator).SubjectsTaughtList;
                for (int i = 0; i < DB_Connection.MultipleChoiceTaskList.Count; i++)
                {
                    MultipleChoiceTask CurrentMultipleChoiceTask = DB_Connection.MultipleChoiceTaskList[i];
                    taskSubject = CurrentMultipleChoiceTask.Subject;
                    taskId = CurrentMultipleChoiceTask.SQL_ID;
                    taskType = CurrentMultipleChoiceTask.TaskType;
                    taskFormulation = CurrentMultipleChoiceTask.TaskFormulation;
                    pointValue = CurrentMultipleChoiceTask.PointValue;
                    taskLocked = CurrentMultipleChoiceTask.LockedTask ? "Yes" : "No";
                    TaskSelectorDGV.Rows.Add(taskId, taskSubject, taskType, taskFormulation, pointValue, taskLocked);
                }
                for (int i = 0; i < DB_Connection.EssayTaskList.Count; i++)
                {
                    EssayTask CurrentEssayTask = DB_Connection.EssayTaskList[i];
                    taskSubject = CurrentEssayTask.Subject;
                    taskId = CurrentEssayTask.SQL_ID;
                    taskType = CurrentEssayTask.TaskType;
                    taskFormulation = CurrentEssayTask.TaskFormulation;
                    pointValue = CurrentEssayTask.PointValue;
                    taskLocked = CurrentEssayTask.LockedTask ? "Yes" : "No";
                    TaskSelectorDGV.Rows.Add(taskId, taskSubject, taskType, taskFormulation, pointValue, taskLocked);
                }
            }
            else if (UserIdentification.ActiveUser is Teacher)
            {
                UserSubjectsTaughtAuxiliary = (UserIdentification.ActiveUser as Teacher).SubjectsTaughtList;
                for (int i = 0; i < DB_Connection.MultipleChoiceTaskList.Count; i++)
                {
                    MultipleChoiceTask CurrentMultipleChoiceTask = DB_Connection.MultipleChoiceTaskList[i];
                    taskSubject = CurrentMultipleChoiceTask.Subject;

                    if (UserSubjectsTaughtAuxiliary.Contains(taskSubject, StringComparer.CurrentCultureIgnoreCase))
                    {
                        taskId = CurrentMultipleChoiceTask.SQL_ID;
                        taskType = CurrentMultipleChoiceTask.TaskType;
                        taskFormulation = CurrentMultipleChoiceTask.TaskFormulation;
                        pointValue = CurrentMultipleChoiceTask.PointValue;
                        taskLocked = CurrentMultipleChoiceTask.LockedTask ? "Yes" : "No";
                        TaskSelectorDGV.Rows.Add(taskId, taskSubject, taskType, taskFormulation, pointValue, taskLocked);
                    }
                }
                for (int i = 0; i < DB_Connection.EssayTaskList.Count; i++)
                {
                    EssayTask CurrentEssayTask = DB_Connection.EssayTaskList[i];
                    taskSubject = CurrentEssayTask.Subject;

                    if (UserSubjectsTaughtAuxiliary.Contains(taskSubject, StringComparer.CurrentCultureIgnoreCase))
                    {
                        taskId = CurrentEssayTask.SQL_ID;
                        taskType = CurrentEssayTask.TaskType;
                        taskFormulation = CurrentEssayTask.TaskFormulation;
                        pointValue = CurrentEssayTask.PointValue;
                        taskLocked = CurrentEssayTask.LockedTask ? "Yes" : "No";
                        TaskSelectorDGV.Rows.Add(taskId, taskSubject, taskType, taskFormulation, pointValue, taskLocked);
                    }
                }

            }
            TaskSelectorDGV.Sort(TaskSelectorDGV.Columns[1], ListSortDirection.Ascending);
        }
        private void TestSheetCheckerSelectorUC_Load(object sender, EventArgs e)
        {
            FillTaskSelectorDGV();
        }
        public void RefreshTableButton_Click_1(object sender, EventArgs e)
        {
            FillTaskSelectorDGV();
        }
        private void CreateMultipleChoiceTaskButton_Click(object sender, EventArgs e)
        {
            MultipleChoiceTaskEditorWindow multipleChoiceTaskEditorWindow1 = new MultipleChoiceTaskEditorWindow();
            multipleChoiceTaskEditorWindow1.ShowDialog();
        }
        private void CreateEssayTaskButton_Click(object sender, EventArgs e)
        {
            EssayTaskEditorWindow essayTaskEditorWindow1 = new EssayTaskEditorWindow();
            essayTaskEditorWindow1.ShowDialog();
        }
        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskSelectorDGV.Rows.Count != 0)
            {
                DataGridViewRow SelectedRow = TaskSelectorDGV.CurrentRow;
                int selectedTaskId = Convert.ToInt32(SelectedRow.Cells["TaskID"].Value);

                if (Convert.ToString(SelectedRow.Cells["TaskLocked"].Value) == "No")
                {
                    if (MessageBox.Show("Are you sure to delete this task?", "Delete task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                            {
                                string DeleteTaskFromDB = "DELETE FROM Tasks WHERE Id=@idData";
                                using (SqlCommand commandToDeleteTask = new SqlCommand(DeleteTaskFromDB, connectingToLEAP_DB))
                                {
                                    commandToDeleteTask.Parameters.AddWithValue("@idData", selectedTaskId);
                                    connectingToLEAP_DB.Open();
                                    commandToDeleteTask.ExecuteNonQuery();
                                    MessageBox.Show("Task is successfully deleted!");
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Connection failed", "Error");
                        }
                        Program.ReadDataFromDatabase();
                        FillTaskSelectorDGV();
                    }
                }
                else
                {
                    MessageBox.Show("The task is locked, it can no longer be deleted!", "Error");
                }
            }
        }
        private void PreviewTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskSelectorDGV.Rows.Count != 0)
            {
                int selectedTaskId = Convert.ToInt32(TaskSelectorDGV.CurrentRow.Cells["TaskID"].Value);
                TaskPreviewWindow taskPreviewWindow1 = new TaskPreviewWindow(selectedTaskId);
                taskPreviewWindow1.ShowDialog();
            }
        }
    }
}
