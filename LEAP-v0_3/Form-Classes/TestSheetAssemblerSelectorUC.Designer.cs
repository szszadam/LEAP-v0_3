
namespace LEAP_v0_3
{
    partial class TestSheetAssemblerSelectorUC
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateNewTestSheetButton = new System.Windows.Forms.Button();
            this.RefreshTableButton = new System.Windows.Forms.Button();
            this.ModifyTestSheetButton = new System.Windows.Forms.Button();
            this.DeleteTestSheetButton = new System.Windows.Forms.Button();
            this.PreviewTestSheetButton = new System.Windows.Forms.Button();
            this.EditedTestSheetSelectorDGV = new System.Windows.Forms.DataGridView();
            this.EditedTestSheetID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPointsAvailable1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LockedTestSheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditedTestSheetSelectorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditedTestSheetSelectorDGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1206, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 386F));
            this.tableLayoutPanel2.Controls.Add(this.CreateNewTestSheetButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RefreshTableButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifyTestSheetButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DeleteTestSheetButton, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.PreviewTestSheetButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 124);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CreateNewTestSheetButton
            // 
            this.CreateNewTestSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CreateNewTestSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateNewTestSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CreateNewTestSheetButton.FlatAppearance.BorderSize = 2;
            this.CreateNewTestSheetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.CreateNewTestSheetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.CreateNewTestSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewTestSheetButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateNewTestSheetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CreateNewTestSheetButton.Location = new System.Drawing.Point(10, 5);
            this.CreateNewTestSheetButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.CreateNewTestSheetButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.CreateNewTestSheetButton.Name = "CreateNewTestSheetButton";
            this.CreateNewTestSheetButton.Size = new System.Drawing.Size(375, 50);
            this.CreateNewTestSheetButton.TabIndex = 19;
            this.CreateNewTestSheetButton.Text = "Create new edited test sheet";
            this.CreateNewTestSheetButton.UseVisualStyleBackColor = false;
            this.CreateNewTestSheetButton.Click += new System.EventHandler(this.CreateNewTestSheetButton_Click);
            // 
            // RefreshTableButton
            // 
            this.RefreshTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RefreshTableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshTableButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RefreshTableButton.FlatAppearance.BorderSize = 2;
            this.RefreshTableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.RefreshTableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.RefreshTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshTableButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshTableButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RefreshTableButton.Location = new System.Drawing.Point(814, 5);
            this.RefreshTableButton.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.RefreshTableButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.RefreshTableButton.Name = "RefreshTableButton";
            this.RefreshTableButton.Size = new System.Drawing.Size(376, 50);
            this.RefreshTableButton.TabIndex = 20;
            this.RefreshTableButton.Text = "Refresh table";
            this.RefreshTableButton.UseVisualStyleBackColor = false;
            this.RefreshTableButton.Click += new System.EventHandler(this.RefreshTableButton_Click_1);
            // 
            // ModifyTestSheetButton
            // 
            this.ModifyTestSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ModifyTestSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifyTestSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModifyTestSheetButton.FlatAppearance.BorderSize = 2;
            this.ModifyTestSheetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.ModifyTestSheetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.ModifyTestSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyTestSheetButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModifyTestSheetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModifyTestSheetButton.Location = new System.Drawing.Point(10, 65);
            this.ModifyTestSheetButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.ModifyTestSheetButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.ModifyTestSheetButton.Name = "ModifyTestSheetButton";
            this.ModifyTestSheetButton.Size = new System.Drawing.Size(375, 50);
            this.ModifyTestSheetButton.TabIndex = 21;
            this.ModifyTestSheetButton.Text = "Modify selected test sheet";
            this.ModifyTestSheetButton.UseVisualStyleBackColor = false;
            this.ModifyTestSheetButton.Click += new System.EventHandler(this.ModifyTestSheetButton_Click);
            // 
            // DeleteTestSheetButton
            // 
            this.DeleteTestSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteTestSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteTestSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteTestSheetButton.FlatAppearance.BorderSize = 2;
            this.DeleteTestSheetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.DeleteTestSheetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.DeleteTestSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTestSheetButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteTestSheetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteTestSheetButton.Location = new System.Drawing.Point(814, 65);
            this.DeleteTestSheetButton.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.DeleteTestSheetButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.DeleteTestSheetButton.Name = "DeleteTestSheetButton";
            this.DeleteTestSheetButton.Size = new System.Drawing.Size(376, 50);
            this.DeleteTestSheetButton.TabIndex = 22;
            this.DeleteTestSheetButton.Text = "Delete selected test sheet";
            this.DeleteTestSheetButton.UseVisualStyleBackColor = false;
            this.DeleteTestSheetButton.Click += new System.EventHandler(this.DeleteTestSheetButton_Click);
            // 
            // PreviewTestSheetButton
            // 
            this.PreviewTestSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PreviewTestSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewTestSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PreviewTestSheetButton.FlatAppearance.BorderSize = 2;
            this.PreviewTestSheetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.PreviewTestSheetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.PreviewTestSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewTestSheetButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreviewTestSheetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PreviewTestSheetButton.Location = new System.Drawing.Point(417, 5);
            this.PreviewTestSheetButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.PreviewTestSheetButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.PreviewTestSheetButton.Name = "PreviewTestSheetButton";
            this.PreviewTestSheetButton.Size = new System.Drawing.Size(375, 50);
            this.PreviewTestSheetButton.TabIndex = 23;
            this.PreviewTestSheetButton.Text = "Preview selected test sheet";
            this.PreviewTestSheetButton.UseVisualStyleBackColor = false;
            this.PreviewTestSheetButton.Click += new System.EventHandler(this.PreviewTestSheetButton_Click);
            // 
            // EditedTestSheetSelectorDGV
            // 
            this.EditedTestSheetSelectorDGV.AllowUserToAddRows = false;
            this.EditedTestSheetSelectorDGV.AllowUserToDeleteRows = false;
            this.EditedTestSheetSelectorDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EditedTestSheetSelectorDGV.BackgroundColor = System.Drawing.Color.SlateGray;
            this.EditedTestSheetSelectorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EditedTestSheetSelectorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EditedTestSheetSelectorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditedTestSheetSelectorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditedTestSheetID1,
            this.Subject1,
            this.Topic1,
            this.Grade1,
            this.TotalPointsAvailable1,
            this.TimeLimit1,
            this.LockedTestSheet});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditedTestSheetSelectorDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditedTestSheetSelectorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditedTestSheetSelectorDGV.Location = new System.Drawing.Point(3, 133);
            this.EditedTestSheetSelectorDGV.MultiSelect = false;
            this.EditedTestSheetSelectorDGV.Name = "EditedTestSheetSelectorDGV";
            this.EditedTestSheetSelectorDGV.ReadOnly = true;
            this.EditedTestSheetSelectorDGV.RowHeadersVisible = false;
            this.EditedTestSheetSelectorDGV.RowHeadersWidth = 51;
            this.EditedTestSheetSelectorDGV.RowTemplate.Height = 24;
            this.EditedTestSheetSelectorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EditedTestSheetSelectorDGV.Size = new System.Drawing.Size(1200, 464);
            this.EditedTestSheetSelectorDGV.TabIndex = 1;
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
            this.Grade1.Width = 125;
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
            this.TimeLimit1.Width = 125;
            // 
            // LockedTestSheet
            // 
            this.LockedTestSheet.HeaderText = "Is the test sheet locked?";
            this.LockedTestSheet.MinimumWidth = 6;
            this.LockedTestSheet.Name = "LockedTestSheet";
            this.LockedTestSheet.ReadOnly = true;
            this.LockedTestSheet.Width = 125;
            // 
            // TestSheetAssemblerSelectorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestSheetAssemblerSelectorUC";
            this.Size = new System.Drawing.Size(1206, 600);
            this.Load += new System.EventHandler(this.TestSheetAssemblerSelectorUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditedTestSheetSelectorDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CreateNewTestSheetButton;
        private System.Windows.Forms.Button RefreshTableButton;
        private System.Windows.Forms.Button ModifyTestSheetButton;
        private System.Windows.Forms.Button DeleteTestSheetButton;
        public System.Windows.Forms.DataGridView EditedTestSheetSelectorDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditedTestSheetID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPointsAvailable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LockedTestSheet;
        private System.Windows.Forms.Button PreviewTestSheetButton;
    }
}
