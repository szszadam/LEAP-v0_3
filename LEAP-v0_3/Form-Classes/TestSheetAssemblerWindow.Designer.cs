
namespace LEAP_v0_3
{
    partial class TestSheetAssemblerWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSheetAssemblerWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TaskSelectorDGV = new System.Windows.Forms.DataGridView();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskFormulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LockedTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddTask = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderOfTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionDisplay_FlowLP_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateTestSheetPreviewButton = new System.Windows.Forms.Button();
            this.CreateTestSheetButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GradeNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TopicTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeNUD = new System.Windows.Forms.NumericUpDown();
            this.SubjectsComboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskSelectorDGV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.TaskSelectorDGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.QuestionDisplay_FlowLP_1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 654);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TaskSelectorDGV
            // 
            this.TaskSelectorDGV.AllowUserToAddRows = false;
            this.TaskSelectorDGV.AllowUserToDeleteRows = false;
            this.TaskSelectorDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TaskSelectorDGV.BackgroundColor = System.Drawing.Color.SlateGray;
            this.TaskSelectorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskSelectorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TaskSelectorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskSelectorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.Subject,
            this.TaskType,
            this.TaskFormulation,
            this.PointValue,
            this.LockedTask,
            this.AddTask,
            this.OrderOfTasks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskSelectorDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TaskSelectorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskSelectorDGV.Location = new System.Drawing.Point(3, 2);
            this.TaskSelectorDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskSelectorDGV.MultiSelect = false;
            this.TaskSelectorDGV.Name = "TaskSelectorDGV";
            this.TaskSelectorDGV.RowHeadersVisible = false;
            this.TaskSelectorDGV.RowHeadersWidth = 51;
            this.TaskSelectorDGV.RowTemplate.Height = 24;
            this.TaskSelectorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskSelectorDGV.Size = new System.Drawing.Size(1276, 277);
            this.TaskSelectorDGV.TabIndex = 21;
            this.TaskSelectorDGV.Click += new System.EventHandler(this.SelectingTaskDGV_Click);
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "Task ID";
            this.TaskID.MinimumWidth = 6;
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            this.TaskID.Width = 120;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 120;
            // 
            // TaskType
            // 
            this.TaskType.HeaderText = "Task type";
            this.TaskType.MinimumWidth = 6;
            this.TaskType.Name = "TaskType";
            this.TaskType.ReadOnly = true;
            this.TaskType.Width = 120;
            // 
            // TaskFormulation
            // 
            this.TaskFormulation.HeaderText = "Task formulation";
            this.TaskFormulation.MinimumWidth = 10;
            this.TaskFormulation.Name = "TaskFormulation";
            this.TaskFormulation.ReadOnly = true;
            this.TaskFormulation.Width = 140;
            // 
            // PointValue
            // 
            this.PointValue.HeaderText = "Point value";
            this.PointValue.MinimumWidth = 6;
            this.PointValue.Name = "PointValue";
            this.PointValue.ReadOnly = true;
            this.PointValue.Width = 125;
            // 
            // LockedTask
            // 
            this.LockedTask.HeaderText = "Locked task";
            this.LockedTask.MinimumWidth = 6;
            this.LockedTask.Name = "LockedTask";
            this.LockedTask.ReadOnly = true;
            this.LockedTask.Width = 80;
            // 
            // AddTask
            // 
            this.AddTask.HeaderText = "Add task";
            this.AddTask.MinimumWidth = 6;
            this.AddTask.Name = "AddTask";
            this.AddTask.Width = 125;
            // 
            // OrderOfTasks
            // 
            this.OrderOfTasks.HeaderText = "Order of tasks";
            this.OrderOfTasks.MinimumWidth = 6;
            this.OrderOfTasks.Name = "OrderOfTasks";
            this.OrderOfTasks.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 392);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 6);
            this.panel1.TabIndex = 2;
            // 
            // QuestionDisplay_FlowLP_1
            // 
            this.QuestionDisplay_FlowLP_1.AutoScroll = true;
            this.QuestionDisplay_FlowLP_1.AutoSize = true;
            this.QuestionDisplay_FlowLP_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionDisplay_FlowLP_1.Location = new System.Drawing.Point(3, 402);
            this.QuestionDisplay_FlowLP_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuestionDisplay_FlowLP_1.Name = "QuestionDisplay_FlowLP_1";
            this.QuestionDisplay_FlowLP_1.Size = new System.Drawing.Size(1276, 250);
            this.QuestionDisplay_FlowLP_1.TabIndex = 3;
            this.QuestionDisplay_FlowLP_1.WrapContents = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.UpdateTestSheetPreviewButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CreateTestSheetButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 332);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1276, 56);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateTestSheetPreviewButton
            // 
            this.UpdateTestSheetPreviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UpdateTestSheetPreviewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateTestSheetPreviewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UpdateTestSheetPreviewButton.FlatAppearance.BorderSize = 2;
            this.UpdateTestSheetPreviewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.UpdateTestSheetPreviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.UpdateTestSheetPreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTestSheetPreviewButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateTestSheetPreviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UpdateTestSheetPreviewButton.Location = new System.Drawing.Point(11, 0);
            this.UpdateTestSheetPreviewButton.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.UpdateTestSheetPreviewButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.UpdateTestSheetPreviewButton.Name = "UpdateTestSheetPreviewButton";
            this.UpdateTestSheetPreviewButton.Size = new System.Drawing.Size(363, 56);
            this.UpdateTestSheetPreviewButton.TabIndex = 22;
            this.UpdateTestSheetPreviewButton.Text = "Refresh preview of test sheet";
            this.UpdateTestSheetPreviewButton.UseVisualStyleBackColor = false;
            this.UpdateTestSheetPreviewButton.Click += new System.EventHandler(this.UpdateTestSheetPreviewButton_Click);
            // 
            // CreateTestSheetButton
            // 
            this.CreateTestSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CreateTestSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateTestSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CreateTestSheetButton.FlatAppearance.BorderSize = 2;
            this.CreateTestSheetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.CreateTestSheetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.CreateTestSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTestSheetButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateTestSheetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CreateTestSheetButton.Location = new System.Drawing.Point(902, 0);
            this.CreateTestSheetButton.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.CreateTestSheetButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.CreateTestSheetButton.Name = "CreateTestSheetButton";
            this.CreateTestSheetButton.Size = new System.Drawing.Size(363, 56);
            this.CreateTestSheetButton.TabIndex = 23;
            this.CreateTestSheetButton.Text = "Create test sheet";
            this.CreateTestSheetButton.UseVisualStyleBackColor = false;
            this.CreateTestSheetButton.Click += new System.EventHandler(this.CreateTestSheetButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 6);
            this.panel2.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 9;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.GradeNUD, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.TopicTextBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TimeNUD, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.SubjectsComboBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1276, 35);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(947, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available time [minute] :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GradeNUD
            // 
            this.GradeNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradeNUD.Font = new System.Drawing.Font("Gill Sans MT", 9.5F, System.Drawing.FontStyle.Bold);
            this.GradeNUD.Location = new System.Drawing.Point(867, 2);
            this.GradeNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GradeNUD.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.GradeNUD.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.GradeNUD.Name = "GradeNUD";
            this.GradeNUD.Size = new System.Drawing.Size(74, 26);
            this.GradeNUD.TabIndex = 7;
            this.GradeNUD.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(736, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopicTextBox
            // 
            this.TopicTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicTextBox.Font = new System.Drawing.Font("Gill Sans MT", 9.5F, System.Drawing.FontStyle.Bold);
            this.TopicTextBox.Location = new System.Drawing.Point(485, 2);
            this.TopicTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopicTextBox.Name = "TopicTextBox";
            this.TopicTextBox.Size = new System.Drawing.Size(245, 26);
            this.TopicTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(354, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Topic:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeNUD
            // 
            this.TimeNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeNUD.Font = new System.Drawing.Font("Gill Sans MT", 9.5F, System.Drawing.FontStyle.Bold);
            this.TimeNUD.Location = new System.Drawing.Point(1187, 2);
            this.TimeNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeNUD.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.TimeNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeNUD.Name = "TimeNUD";
            this.TimeNUD.Size = new System.Drawing.Size(74, 26);
            this.TimeNUD.TabIndex = 6;
            this.TimeNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SubjectsComboBox1
            // 
            this.SubjectsComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectsComboBox1.Font = new System.Drawing.Font("Gill Sans MT", 9.5F, System.Drawing.FontStyle.Bold);
            this.SubjectsComboBox1.FormattingEnabled = true;
            this.SubjectsComboBox1.Location = new System.Drawing.Point(103, 2);
            this.SubjectsComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectsComboBox1.Name = "SubjectsComboBox1";
            this.SubjectsComboBox1.Size = new System.Drawing.Size(245, 31);
            this.SubjectsComboBox1.TabIndex = 8;
            // 
            // TestSheetAssemblerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1281, 654);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1299, 701);
            this.Name = "TestSheetAssemblerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEAP: Assembling test sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestSheetAssemblerWindow_FormClosing);
            this.Load += new System.EventHandler(this.TestSheetAssemblerWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskSelectorDGV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel QuestionDisplay_FlowLP_1;
        public System.Windows.Forms.DataGridView TaskSelectorDGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button UpdateTestSheetPreviewButton;
        private System.Windows.Forms.Button CreateTestSheetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskFormulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn LockedTask;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderOfTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TopicTextBox;
        private System.Windows.Forms.NumericUpDown TimeNUD;
        private System.Windows.Forms.NumericUpDown GradeNUD;
        private System.Windows.Forms.ComboBox SubjectsComboBox1;
    }
}
