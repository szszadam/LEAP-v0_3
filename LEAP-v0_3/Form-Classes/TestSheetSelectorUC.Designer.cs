
namespace LEAP_v0_3
{
    partial class TestSheetSelectorUC
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
            this.SelectTestSheetButton = new System.Windows.Forms.Button();
            this.RefreshTableButton = new System.Windows.Forms.Button();
            this.TestSheetSelectorDGV = new System.Windows.Forms.DataGridView();
            this.IndividualTestSheetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsEarned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmittedTestSheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedTestSheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestSheetSelectorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TestSheetSelectorDGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1206, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.Controls.Add(this.SelectTestSheetButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RefreshTableButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SelectTestSheetButton
            // 
            this.SelectTestSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SelectTestSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectTestSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SelectTestSheetButton.FlatAppearance.BorderSize = 2;
            this.SelectTestSheetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.SelectTestSheetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.SelectTestSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectTestSheetButton.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectTestSheetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SelectTestSheetButton.Location = new System.Drawing.Point(10, 0);
            this.SelectTestSheetButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SelectTestSheetButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.SelectTestSheetButton.Name = "SelectTestSheetButton";
            this.SelectTestSheetButton.Size = new System.Drawing.Size(365, 54);
            this.SelectTestSheetButton.TabIndex = 19;
            this.SelectTestSheetButton.Text = "Solve selected test sheet";
            this.SelectTestSheetButton.UseVisualStyleBackColor = false;
            this.SelectTestSheetButton.Click += new System.EventHandler(this.SelectTestSheetButton_Click);
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
            this.RefreshTableButton.Location = new System.Drawing.Point(825, 0);
            this.RefreshTableButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.RefreshTableButton.MinimumSize = new System.Drawing.Size(155, 50);
            this.RefreshTableButton.Name = "RefreshTableButton";
            this.RefreshTableButton.Size = new System.Drawing.Size(365, 54);
            this.RefreshTableButton.TabIndex = 21;
            this.RefreshTableButton.Text = "Refresh table";
            this.RefreshTableButton.UseVisualStyleBackColor = false;
            this.RefreshTableButton.Click += new System.EventHandler(this.RefreshTableButton_Click);
            // 
            // TestSheetSelectorDGV
            // 
            this.TestSheetSelectorDGV.AllowUserToAddRows = false;
            this.TestSheetSelectorDGV.AllowUserToDeleteRows = false;
            this.TestSheetSelectorDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TestSheetSelectorDGV.BackgroundColor = System.Drawing.Color.SlateGray;
            this.TestSheetSelectorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestSheetSelectorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TestSheetSelectorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestSheetSelectorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndividualTestSheetID,
            this.FamilyName,
            this.FirstName,
            this.Subject,
            this.Topic,
            this.Grade,
            this.PointsAvailable,
            this.PointsEarned,
            this.SubmittedTestSheet,
            this.CheckedTestSheet,
            this.TimeLimit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestSheetSelectorDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TestSheetSelectorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestSheetSelectorDGV.Location = new System.Drawing.Point(3, 63);
            this.TestSheetSelectorDGV.MultiSelect = false;
            this.TestSheetSelectorDGV.Name = "TestSheetSelectorDGV";
            this.TestSheetSelectorDGV.ReadOnly = true;
            this.TestSheetSelectorDGV.RowHeadersVisible = false;
            this.TestSheetSelectorDGV.RowHeadersWidth = 51;
            this.TestSheetSelectorDGV.RowTemplate.Height = 24;
            this.TestSheetSelectorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestSheetSelectorDGV.Size = new System.Drawing.Size(1200, 534);
            this.TestSheetSelectorDGV.TabIndex = 1;
            // 
            // IndividualTestSheetID
            // 
            this.IndividualTestSheetID.HeaderText = "Individual test sheet ID";
            this.IndividualTestSheetID.MinimumWidth = 6;
            this.IndividualTestSheetID.Name = "IndividualTestSheetID";
            this.IndividualTestSheetID.ReadOnly = true;
            this.IndividualTestSheetID.Width = 120;
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
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 109;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Topic";
            this.Topic.MinimumWidth = 6;
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            this.Topic.Width = 109;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 109;
            // 
            // PointsAvailable
            // 
            this.PointsAvailable.HeaderText = "Available points";
            this.PointsAvailable.MinimumWidth = 6;
            this.PointsAvailable.Name = "PointsAvailable";
            this.PointsAvailable.ReadOnly = true;
            this.PointsAvailable.Width = 109;
            // 
            // PointsEarned
            // 
            this.PointsEarned.HeaderText = "Earned points";
            this.PointsEarned.MinimumWidth = 6;
            this.PointsEarned.Name = "PointsEarned";
            this.PointsEarned.ReadOnly = true;
            this.PointsEarned.Width = 109;
            // 
            // SubmittedTestSheet
            // 
            this.SubmittedTestSheet.HeaderText = "Submitted test";
            this.SubmittedTestSheet.MinimumWidth = 6;
            this.SubmittedTestSheet.Name = "SubmittedTestSheet";
            this.SubmittedTestSheet.ReadOnly = true;
            this.SubmittedTestSheet.Width = 108;
            // 
            // CheckedTestSheet
            // 
            this.CheckedTestSheet.HeaderText = "Checked test";
            this.CheckedTestSheet.MinimumWidth = 6;
            this.CheckedTestSheet.Name = "CheckedTestSheet";
            this.CheckedTestSheet.ReadOnly = true;
            this.CheckedTestSheet.Width = 109;
            // 
            // TimeLimit
            // 
            this.TimeLimit.HeaderText = "Time limit [minute]";
            this.TimeLimit.MinimumWidth = 6;
            this.TimeLimit.Name = "TimeLimit";
            this.TimeLimit.ReadOnly = true;
            this.TimeLimit.Width = 109;
            // 
            // TestSheetSelectorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestSheetSelectorUC";
            this.Size = new System.Drawing.Size(1206, 600);
            this.Load += new System.EventHandler(this.TestSheetSelectorUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestSheetSelectorDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.DataGridView TestSheetSelectorDGV;
        private System.Windows.Forms.Button SelectTestSheetButton;
        private System.Windows.Forms.Button RefreshTableButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndividualTestSheetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsEarned;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmittedTestSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedTestSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit;
    }
}
