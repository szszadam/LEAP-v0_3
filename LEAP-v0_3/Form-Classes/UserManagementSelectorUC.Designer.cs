
namespace LEAP_v0_3
{
    partial class UserManagementSelectorUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserSelectorDGV = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIdentificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizationLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectsTaught = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateNewUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.UserDataModificationButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSelectorDGV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.UserSelectorDGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1206, 600);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.UserID,
            this.FamilyName,
            this.FirstName,
            this.UserIdentificationNumber,
            this.AuthorizationLevel,
            this.SubjectsTaught,
            this.Grade,
            this.Class,
            this.RegistrationDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserSelectorDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserSelectorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSelectorDGV.Location = new System.Drawing.Point(3, 63);
            this.UserSelectorDGV.MultiSelect = false;
            this.UserSelectorDGV.Name = "UserSelectorDGV";
            this.UserSelectorDGV.ReadOnly = true;
            this.UserSelectorDGV.RowHeadersVisible = false;
            this.UserSelectorDGV.RowHeadersWidth = 51;
            this.UserSelectorDGV.RowTemplate.Height = 24;
            this.UserSelectorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserSelectorDGV.Size = new System.Drawing.Size(1200, 534);
            this.UserSelectorDGV.TabIndex = 2;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 120;
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
            // UserIdentificationNumber
            // 
            this.UserIdentificationNumber.HeaderText = "User identification number";
            this.UserIdentificationNumber.MinimumWidth = 6;
            this.UserIdentificationNumber.Name = "UserIdentificationNumber";
            this.UserIdentificationNumber.ReadOnly = true;
            this.UserIdentificationNumber.Width = 109;
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
            // RegistrationDate
            // 
            this.RegistrationDate.HeaderText = "Registration date";
            this.RegistrationDate.MinimumWidth = 6;
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            this.RegistrationDate.Width = 108;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.Controls.Add(this.CreateNewUserButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteUserButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.UserDataModificationButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CreateNewUserButton
            // 
            this.CreateNewUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CreateNewUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateNewUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CreateNewUserButton.FlatAppearance.BorderSize = 2;
            this.CreateNewUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.CreateNewUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.CreateNewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewUserButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateNewUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CreateNewUserButton.Location = new System.Drawing.Point(10, 0);
            this.CreateNewUserButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.CreateNewUserButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.CreateNewUserButton.Name = "CreateNewUserButton";
            this.CreateNewUserButton.Size = new System.Drawing.Size(365, 54);
            this.CreateNewUserButton.TabIndex = 19;
            this.CreateNewUserButton.Text = "Create new user account";
            this.CreateNewUserButton.UseVisualStyleBackColor = false;
            this.CreateNewUserButton.Click += new System.EventHandler(this.CreateNewUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteUserButton.FlatAppearance.BorderSize = 2;
            this.DeleteUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.DeleteUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteUserButton.Location = new System.Drawing.Point(824, 0);
            this.DeleteUserButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DeleteUserButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(366, 54);
            this.DeleteUserButton.TabIndex = 20;
            this.DeleteUserButton.Text = "Delete user account";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // UserDataModificationButton
            // 
            this.UserDataModificationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UserDataModificationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDataModificationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UserDataModificationButton.FlatAppearance.BorderSize = 2;
            this.UserDataModificationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.UserDataModificationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.UserDataModificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDataModificationButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserDataModificationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UserDataModificationButton.Location = new System.Drawing.Point(417, 0);
            this.UserDataModificationButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.UserDataModificationButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.UserDataModificationButton.Name = "UserDataModificationButton";
            this.UserDataModificationButton.Size = new System.Drawing.Size(365, 54);
            this.UserDataModificationButton.TabIndex = 21;
            this.UserDataModificationButton.Text = "Modify user's data";
            this.UserDataModificationButton.UseVisualStyleBackColor = false;
            this.UserDataModificationButton.Click += new System.EventHandler(this.UserDataModificationButton_Click);
            // 
            // UserManagementSelectorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserManagementSelectorUC";
            this.Size = new System.Drawing.Size(1206, 600);
            this.Load += new System.EventHandler(this.UserManagementSelectorUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserSelectorDGV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CreateNewUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        public System.Windows.Forms.DataGridView UserSelectorDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdentificationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizationLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectsTaught;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.Button UserDataModificationButton;
    }
}
