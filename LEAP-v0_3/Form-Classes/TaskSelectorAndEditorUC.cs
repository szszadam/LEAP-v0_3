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
    //      *****Task Selector and Editor User Control class*****
    //
    //
    //      ***Class description*** 
    //
    //
    // The interface used for editing tasks, which is a descendant of the "UserControl" class.
    // Its main graphic elements: the "DataGridView" control listing the tasks created so far,
    // the "Create multiple choice task" button, the "Create essay task" button, the "Preview
    // selected task" button, the "Refresh table" button and the "Delete selected task" button.
    //
    //
    //      ***Methods and eventhandlers***
    //
    //
    // FillTaskSelectorDGV() – It fills the "DataGridView" control listing the tasks with data.
    // The method uses some auxiliary variables while it is running.After populating the controller,
    // it sorts the rows by the "subject" property in ABC order.
    //
    //
    // TestSheetCheckerSelectorUC_Load() event – When the Task Selector and Editor User Control
    // is loaded, it calls the FillTaskSelectorDGV() method.
    //
    //
    // RefreshTableButton_Click_1() event – An event that runs when the "Refresh Table" button is
    // clicked, which calls the FillTaskSelectorDGV() method.
    //
    //
    // CreateMultipleChoiceTaskButton_Click() event – the event that runs when the button "Create
    // multiple choice task" is clicked, which creates an instance of the
    // "MultipleChoiceTaskEditorWindow" class and opens it in a new dialog window.
    //
    //
    // CreateEssayTaskButton_Click() event – the event that runs when the button "Create essay task"
    // is clicked, which creates an instance of the "EssayTaskEditorWindow" class and opens it in
    // a new dialog window.
    //
    //
    // DeleteTaskButton_Click() – after a confirmation, the task selected in the "DataGridView"
    // control is deleted from the "Tasks" table of the database, if it is not yet locked.At the
    // end of its run, the method calls the following methods too:
    // Program.ReadDataFromDatabase(),
    // FillTaskSelectorDGV().
    //
    //
    // PreviewTaskButton_Click() event – the event that runs when the button "Preview selected task"
    // is clicked creates an instance of the "TaskPreviewWindow" class by passing it the ID of the
    // selected task and opens it in a new dialog.

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
