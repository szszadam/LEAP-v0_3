
namespace LEAP_v0_3
{
    partial class IndividualTestSheetSendingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualTestSheetSendingWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.UserSelectorDGV = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizationLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectsTaught = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SendTestSheetsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TestSheetSelectorPanel = new System.Windows.Forms.Panel();
            this.EditedTestSheetSelectorDGV = new System.Windows.Forms.DataGridView();
            this.EditedTestSheetID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPointsAvailable1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LockedTestSheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSelectorDGV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TestSheetSelectorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditedTestSheetSelectorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.UserSelectorDGV, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TestSheetSelectorPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 653);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Melyik felhasználóknak:";
            // 
            // UserSelectorDGV
            // 
            this.UserSelectorDGV.AllowUserToAddRows = false;
            this.UserSelectorDGV.AllowUserToDeleteRows = false;
            this.UserSelectorDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UserSelectorDGV.BackgroundColor = System.Drawing.Color.SlateGray;
            this.UserSelectorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserSelectorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserSelectorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserSelectorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.FamilyName,
            this.FirstName,
            this.AuthorizationLevel,
            this.SubjectsTaught,
            this.Grade,
            this.Class,
            this.AddUser});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserSelectorDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserSelectorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSelectorDGV.Location = new System.Drawing.Point(3, 369);
            this.UserSelectorDGV.MultiSelect = false;
            this.UserSelectorDGV.Name = "UserSelectorDGV";
            this.UserSelectorDGV.RowHeadersVisible = false;
            this.UserSelectorDGV.RowHeadersWidth = 51;
            this.UserSelectorDGV.RowTemplate.Height = 24;
            this.UserSelectorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserSelectorDGV.Size = new System.Drawing.Size(1275, 281);
            this.UserSelectorDGV.TabIndex = 3;
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "User ID";
            this.User_ID.MinimumWidth = 6;
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            this.User_ID.Width = 120;
            // 
            // FamilyName
            // 
            this.FamilyName.HeaderText = "Family name";
            this.FamilyName.MinimumWidth = 6;
            this.FamilyName.Name = "FamilyName";
            this.FamilyName.ReadOnly = true;
            this.FamilyName.Width = 109;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 108;
            // 
            // AuthorizationLevel
            // 
            this.AuthorizationLevel.HeaderText = "Authorization level";
            this.AuthorizationLevel.MinimumWidth = 6;
            this.AuthorizationLevel.Name = "AuthorizationLevel";
            this.AuthorizationLevel.ReadOnly = true;
            this.AuthorizationLevel.Width = 109;
            // 
            // SubjectsTaught
            // 
            this.SubjectsTaught.HeaderText = "Taught subjects";
            this.SubjectsTaught.MinimumWidth = 6;
            this.SubjectsTaught.Name = "SubjectsTaught";
            this.SubjectsTaught.ReadOnly = true;
            this.SubjectsTaught.Width = 109;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 109;
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 109;
            // 
            // AddUser
            // 
            this.AddUser.HeaderText = "Add user";
            this.AddUser.MinimumWidth = 6;
            this.AddUser.Name = "AddUser";
            this.AddUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AddUser.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 4);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SendTestSheetsButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 259);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1275, 54);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // SendTestSheetsButton
            // 
            this.SendTestSheetsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SendTestSheetsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendTestSheetsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SendTestSheetsButton.FlatAppearance.BorderSize = 2;
            this.SendTestSheetsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.SendTestSheetsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.SendTestSheetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendTestSheetsButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendTestSheetsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SendTestSheetsButton.Location = new System.Drawing.Point(10, 0);
            this.SendTestSheetsButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SendTestSheetsButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.SendTestSheetsButton.Name = "SendTestSheetsButton";
            this.SendTestSheetsButton.Size = new System.Drawing.Size(365, 54);
            this.SendTestSheetsButton.TabIndex = 22;
            this.SendTestSheetsButton.Text = "Send test sheets";
            this.SendTestSheetsButton.UseVisualStyleBackColor = false;
            this.SendTestSheetsButton.Click += new System.EventHandler(this.SendTestSheetsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1275, 4);
            this.panel2.TabIndex = 23;
            // 
            // TestSheetSelectorPanel
            // 
            this.TestSheetSelectorPanel.Controls.Add(this.EditedTestSheetSelectorDGV);
            this.TestSheetSelectorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestSheetSelectorPanel.Location = new System.Drawing.Point(3, 43);
            this.TestSheetSelectorPanel.Name = "TestSheetSelectorPanel";
            this.TestSheetSelectorPanel.Size = new System.Drawing.Size(1275, 200);
            this.TestSheetSelectorPanel.TabIndex = 25;
            // 
            // EditedTestSheetSelectorDGV
            // 
            this.EditedTestSheetSelectorDGV.AllowUserToAddRows = false;
            this.EditedTestSheetSelectorDGV.AllowUserToDeleteRows = false;
            this.EditedTestSheetSelectorDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EditedTestSheetSelectorDGV.BackgroundColor = System.Drawing.Color.SlateGray;
            this.EditedTestSheetSelectorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EditedTestSheetSelectorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EditedTestSheetSelectorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditedTestSheetSelectorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditedTestSheetID1,
            this.Subject1,
            this.Topic1,
            this.Grade1,
            this.TotalPointsAvailable1,
            this.TimeLimit1,
            this.LockedTestSheet});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditedTestSheetSelectorDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.EditedTestSheetSelectorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditedTestSheetSelectorDGV.Location = new System.Drawing.Point(0, 0);
            this.EditedTestSheetSelectorDGV.MultiSelect = false;
            this.EditedTestSheetSelectorDGV.Name = "EditedTestSheetSelectorDGV";
            this.EditedTestSheetSelectorDGV.ReadOnly = true;
            this.EditedTestSheetSelectorDGV.RowHeadersVisible = false;
            this.EditedTestSheetSelectorDGV.RowHeadersWidth = 51;
            this.EditedTestSheetSelectorDGV.RowTemplate.Height = 24;
            this.EditedTestSheetSelectorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EditedTestSheetSelectorDGV.Size = new System.Drawing.Size(1275, 200);
            this.EditedTestSheetSelectorDGV.TabIndex = 24;
            // 
            // EditedTestSheetID1
            // 
            this.EditedTestSheetID1.HeaderText = "Edited test sheet ID";
            this.EditedTestSheetID1.MinimumWidth = 6;
            this.EditedTestSheetID1.Name = "EditedTestSheetID1";
            this.EditedTestSheetID1.ReadOnly = true;
            this.EditedTestSheetID1.Width = 125;
            // 
            // Subject1
            // 
            this.Subject1.HeaderText = "Subject";
            this.Subject1.MinimumWidth = 6;
            this.Subject1.Name = "Subject1";
            this.Subject1.ReadOnly = true;
            this.Subject1.Width = 125;
            // 
            // Topic1
            // 
            this.Topic1.HeaderText = "Topic";
            this.Topic1.MinimumWidth = 6;
            this.Topic1.Name = "Topic1";
            this.Topic1.ReadOnly = true;
            this.Topic1.Width = 125;
            // 
            // Grade1
            // 
            this.Grade1.HeaderText = "Grade";
            this.Grade1.MinimumWidth = 6;
            this.Grade1.Name = "Grade1";
            this.Grade1.ReadOnly = true;
            this.Grade1.Width = 90;
            // 
            // TotalPointsAvailable1
            // 
            this.TotalPointsAvailable1.HeaderText = "Total available points";
            this.TotalPointsAvailable1.MinimumWidth = 6;
            this.TotalPointsAvailable1.Name = "TotalPointsAvailable1";
            this.TotalPointsAvailable1.ReadOnly = true;
            this.TotalPointsAvailable1.Width = 125;
            // 
            // TimeLimit1
            // 
            this.TimeLimit1.HeaderText = "Time limit [minute]";
            this.TimeLimit1.MinimumWidth = 6;
            this.TimeLimit1.Name = "TimeLimit1";
            this.TimeLimit1.ReadOnly = true;
            this.TimeLimit1.Width = 90;
            // 
            // LockedTestSheet
            // 
            this.LockedTestSheet.HeaderText = "Is the test sheet locked?";
            this.LockedTestSheet.MinimumWidth = 6;
            this.LockedTestSheet.Name = "LockedTestSheet";
            this.LockedTestSheet.ReadOnly = true;
            this.LockedTestSheet.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Which test sheet:";
            // 
            // IndividualTestSheetSendingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1281, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1299, 700);
            this.Name = "IndividualTestSheetSendingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEAP: Send individual test sheets";
            this.Load += new System.EventHandler(this.IndividualTestSheetSendingWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSelectorDGV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TestSheetSelectorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditedTestSheetSelectorDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SendTestSheetsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TestSheetSelectorPanel;
        public System.Windows.Forms.DataGridView EditedTestSheetSelectorDGV;
        public System.Windows.Forms.DataGridView UserSelectorDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizationLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectsTaught;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditedTestSheetID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPointsAvailable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LockedTestSheet;
    }
}
