
namespace LEAP_v0_3
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SolveTestSheetButton = new System.Windows.Forms.Button();
            this.ViewResultsButton = new System.Windows.Forms.Button();
            this.EditingTasksButton = new System.Windows.Forms.Button();
            this.EditingTestSheetsButton = new System.Windows.Forms.Button();
            this.CheckingTestSheetsButton = new System.Windows.Forms.Button();
            this.SendingTestSheetsButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ManagingUsersButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userManagementSelectorUC1 = new LEAP_v0_3.UserManagementSelectorUC();
            this.testSheetAssemblerSelectorUC1 = new LEAP_v0_3.TestSheetAssemblerSelectorUC();
            this.testSheetViewerSelectorUC1 = new LEAP_v0_3.TestSheetViewerSelectorUC();
            this.testSheetSelectorUC1 = new LEAP_v0_3.TestSheetSelectorUC();
            this.testSheetCheckerSelectorUC1 = new LEAP_v0_3.TestSheetCheckerSelectorUC();
            this.taskSelectorAndEditorUC1 = new LEAP_v0_3.TaskSelectorAndEditorUC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CurrentUserLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 753);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.SolveTestSheetButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ViewResultsButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.EditingTasksButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditingTestSheetsButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CheckingTestSheetsButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.SendingTestSheetsButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.SignOutButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChangePasswordButton, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.ManagingUsersButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1175, 156);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SolveTestSheetButton
            // 
            this.SolveTestSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SolveTestSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolveTestSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SolveTestSheetButton.FlatAppearance.BorderSize = 2;
            this.SolveTestSheetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.SolveTestSheetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.SolveTestSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolveTestSheetButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.SolveTestSheetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SolveTestSheetButton.Location = new System.Drawing.Point(11, 5);
            this.SolveTestSheetButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.SolveTestSheetButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.SolveTestSheetButton.Name = "SolveTestSheetButton";
            this.SolveTestSheetButton.Size = new System.Drawing.Size(213, 68);
            this.SolveTestSheetButton.TabIndex = 14;
            this.SolveTestSheetButton.Text = "Solve\r\ntest sheet";
            this.SolveTestSheetButton.UseVisualStyleBackColor = false;
            this.SolveTestSheetButton.Click += new System.EventHandler(this.SolveTestSheetButton_Click);
            // 
            // ViewResultsButton
            // 
            this.ViewResultsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ViewResultsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewResultsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ViewResultsButton.FlatAppearance.BorderSize = 2;
            this.ViewResultsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.ViewResultsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.ViewResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewResultsButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.ViewResultsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ViewResultsButton.Location = new System.Drawing.Point(11, 83);
            this.ViewResultsButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.ViewResultsButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.ViewResultsButton.Name = "ViewResultsButton";
            this.ViewResultsButton.Size = new System.Drawing.Size(213, 68);
            this.ViewResultsButton.TabIndex = 15;
            this.ViewResultsButton.Text = "View\r\nresults";
            this.ViewResultsButton.UseVisualStyleBackColor = false;
            this.ViewResultsButton.Click += new System.EventHandler(this.ViewResultsButton_Click);
            // 
            // EditingTasksButton
            // 
            this.EditingTasksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EditingTasksButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditingTasksButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EditingTasksButton.FlatAppearance.BorderSize = 2;
            this.EditingTasksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.EditingTasksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.EditingTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditingTasksButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.EditingTasksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EditingTasksButton.Location = new System.Drawing.Point(246, 5);
            this.EditingTasksButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.EditingTasksButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.EditingTasksButton.Name = "EditingTasksButton";
            this.EditingTasksButton.Size = new System.Drawing.Size(213, 68);
            this.EditingTasksButton.TabIndex = 21;
            this.EditingTasksButton.Text = "Edit\r\ntasks";
            this.EditingTasksButton.UseVisualStyleBackColor = false;
            this.EditingTasksButton.Click += new System.EventHandler(this.EditTasksButton_Click);
            // 
            // EditingTestSheetsButton
            // 
            this.EditingTestSheetsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EditingTestSheetsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditingTestSheetsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EditingTestSheetsButton.FlatAppearance.BorderSize = 2;
            this.EditingTestSheetsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.EditingTestSheetsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.EditingTestSheetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditingTestSheetsButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.EditingTestSheetsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EditingTestSheetsButton.Location = new System.Drawing.Point(246, 83);
            this.EditingTestSheetsButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.EditingTestSheetsButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.EditingTestSheetsButton.Name = "EditingTestSheetsButton";
            this.EditingTestSheetsButton.Size = new System.Drawing.Size(213, 68);
            this.EditingTestSheetsButton.TabIndex = 19;
            this.EditingTestSheetsButton.Text = "Edit\r\ntest sheet";
            this.EditingTestSheetsButton.UseVisualStyleBackColor = false;
            this.EditingTestSheetsButton.Click += new System.EventHandler(this.EditTestSheetsButton_Click);
            // 
            // CheckingTestSheetsButton
            // 
            this.CheckingTestSheetsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckingTestSheetsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckingTestSheetsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CheckingTestSheetsButton.FlatAppearance.BorderSize = 2;
            this.CheckingTestSheetsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.CheckingTestSheetsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.CheckingTestSheetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckingTestSheetsButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.CheckingTestSheetsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CheckingTestSheetsButton.Location = new System.Drawing.Point(481, 83);
            this.CheckingTestSheetsButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.CheckingTestSheetsButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.CheckingTestSheetsButton.Name = "CheckingTestSheetsButton";
            this.CheckingTestSheetsButton.Size = new System.Drawing.Size(213, 68);
            this.CheckingTestSheetsButton.TabIndex = 18;
            this.CheckingTestSheetsButton.Text = "Check\r\ntest sheets";
            this.CheckingTestSheetsButton.UseVisualStyleBackColor = false;
            this.CheckingTestSheetsButton.Click += new System.EventHandler(this.CheckTestSheetsButton_Click);
            // 
            // SendingTestSheetsButton
            // 
            this.SendingTestSheetsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SendingTestSheetsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendingTestSheetsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SendingTestSheetsButton.FlatAppearance.BorderSize = 2;
            this.SendingTestSheetsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.SendingTestSheetsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.SendingTestSheetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendingTestSheetsButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.SendingTestSheetsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SendingTestSheetsButton.Location = new System.Drawing.Point(481, 5);
            this.SendingTestSheetsButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.SendingTestSheetsButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.SendingTestSheetsButton.Name = "SendingTestSheetsButton";
            this.SendingTestSheetsButton.Size = new System.Drawing.Size(213, 68);
            this.SendingTestSheetsButton.TabIndex = 20;
            this.SendingTestSheetsButton.Text = "Send\r\ntest sheets";
            this.SendingTestSheetsButton.UseVisualStyleBackColor = false;
            this.SendingTestSheetsButton.Click += new System.EventHandler(this.SendTestSheetsButton_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SignOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SignOutButton.FlatAppearance.BorderSize = 2;
            this.SignOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.SignOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.SignOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SignOutButton.Location = new System.Drawing.Point(951, 5);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.SignOutButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(213, 68);
            this.SignOutButton.TabIndex = 17;
            this.SignOutButton.Text = "Sign out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangePasswordButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ChangePasswordButton.FlatAppearance.BorderSize = 2;
            this.ChangePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.ChangePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ChangePasswordButton.Location = new System.Drawing.Point(951, 83);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.ChangePasswordButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(213, 68);
            this.ChangePasswordButton.TabIndex = 16;
            this.ChangePasswordButton.Text = "Change\r\npassword";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ManagingUsersButton
            // 
            this.ManagingUsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ManagingUsersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagingUsersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ManagingUsersButton.FlatAppearance.BorderSize = 2;
            this.ManagingUsersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.ManagingUsersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.ManagingUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagingUsersButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.ManagingUsersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ManagingUsersButton.Location = new System.Drawing.Point(716, 5);
            this.ManagingUsersButton.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.ManagingUsersButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.ManagingUsersButton.Name = "ManagingUsersButton";
            this.ManagingUsersButton.Size = new System.Drawing.Size(213, 68);
            this.ManagingUsersButton.TabIndex = 22;
            this.ManagingUsersButton.Text = "Manage\r\nusers";
            this.ManagingUsersButton.UseVisualStyleBackColor = false;
            this.ManagingUsersButton.Click += new System.EventHandler(this.ManageUsersButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userManagementSelectorUC1);
            this.panel1.Controls.Add(this.testSheetAssemblerSelectorUC1);
            this.panel1.Controls.Add(this.testSheetViewerSelectorUC1);
            this.panel1.Controls.Add(this.testSheetSelectorUC1);
            this.panel1.Controls.Add(this.testSheetCheckerSelectorUC1);
            this.panel1.Controls.Add(this.taskSelectorAndEditorUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 262);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 459);
            this.panel1.TabIndex = 1;
            // 
            // userManagementSelectorUC1
            // 
            this.userManagementSelectorUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManagementSelectorUC1.Location = new System.Drawing.Point(0, 0);
            this.userManagementSelectorUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userManagementSelectorUC1.Name = "userManagementSelectorUC1";
            this.userManagementSelectorUC1.Size = new System.Drawing.Size(1175, 459);
            this.userManagementSelectorUC1.TabIndex = 5;
            // 
            // testSheetAssemblerSelectorUC1
            // 
            this.testSheetAssemblerSelectorUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSheetAssemblerSelectorUC1.Location = new System.Drawing.Point(0, 0);
            this.testSheetAssemblerSelectorUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testSheetAssemblerSelectorUC1.Name = "testSheetAssemblerSelectorUC1";
            this.testSheetAssemblerSelectorUC1.Size = new System.Drawing.Size(1175, 459);
            this.testSheetAssemblerSelectorUC1.TabIndex = 4;
            // 
            // testSheetViewerSelectorUC1
            // 
            this.testSheetViewerSelectorUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSheetViewerSelectorUC1.Location = new System.Drawing.Point(0, 0);
            this.testSheetViewerSelectorUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testSheetViewerSelectorUC1.Name = "testSheetViewerSelectorUC1";
            this.testSheetViewerSelectorUC1.Size = new System.Drawing.Size(1175, 459);
            this.testSheetViewerSelectorUC1.TabIndex = 3;
            // 
            // testSheetSelectorUC1
            // 
            this.testSheetSelectorUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSheetSelectorUC1.Location = new System.Drawing.Point(0, 0);
            this.testSheetSelectorUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testSheetSelectorUC1.Name = "testSheetSelectorUC1";
            this.testSheetSelectorUC1.Size = new System.Drawing.Size(1175, 459);
            this.testSheetSelectorUC1.TabIndex = 2;
            // 
            // testSheetCheckerSelectorUC1
            // 
            this.testSheetCheckerSelectorUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSheetCheckerSelectorUC1.Location = new System.Drawing.Point(0, 0);
            this.testSheetCheckerSelectorUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testSheetCheckerSelectorUC1.Name = "testSheetCheckerSelectorUC1";
            this.testSheetCheckerSelectorUC1.Size = new System.Drawing.Size(1175, 459);
            this.testSheetCheckerSelectorUC1.TabIndex = 1;
            // 
            // taskSelectorAndEditorUC1
            // 
            this.taskSelectorAndEditorUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskSelectorAndEditorUC1.Location = new System.Drawing.Point(0, 0);
            this.taskSelectorAndEditorUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskSelectorAndEditorUC1.Name = "taskSelectorAndEditorUC1";
            this.taskSelectorAndEditorUC1.Size = new System.Drawing.Size(1175, 459);
            this.taskSelectorAndEditorUC1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 6);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 252);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1175, 6);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 172);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1175, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.CurrentUserLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 723);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1181, 30);
            this.panel4.TabIndex = 9;
            // 
            // CurrentUserLabel
            // 
            this.CurrentUserLabel.AutoSize = true;
            this.CurrentUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentUserLabel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentUserLabel.Location = new System.Drawing.Point(0, 0);
            this.CurrentUserLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentUserLabel.Name = "CurrentUserLabel";
            this.CurrentUserLabel.Size = new System.Drawing.Size(120, 29);
            this.CurrentUserLabel.TabIndex = 2;
            this.CurrentUserLabel.Text = "Active user";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1199, 800);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEAP: Lambda Exam Application";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentUserLabel;
        private System.Windows.Forms.Button SolveTestSheetButton;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Button SendingTestSheetsButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ViewResultsButton;
        private System.Windows.Forms.Button EditingTestSheetsButton;
        private System.Windows.Forms.Button CheckingTestSheetsButton;
       
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EditingTasksButton;
        private TaskSelectorAndEditorUC taskSelectorAndEditorUC1;
        private TestSheetViewerSelectorUC testSheetViewerSelectorUC1;
        private TestSheetSelectorUC testSheetSelectorUC1;
        private TestSheetCheckerSelectorUC testSheetCheckerSelectorUC1;
        private System.Windows.Forms.Button ManagingUsersButton;
        private TestSheetAssemblerSelectorUC testSheetAssemblerSelectorUC1;
        private UserManagementSelectorUC userManagementSelectorUC1;
        private System.Windows.Forms.Panel panel4;
    }
}

