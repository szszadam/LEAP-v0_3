
namespace LEAP_v0_3
{
    partial class MultipleChoiceAnswerOptionCheckerUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.answerOptionRTB = new System.Windows.Forms.RichTextBox();
            this.AnswerOptionButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.Controls.Add(this.answerOptionRTB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AnswerOptionButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // answerOptionRTB
            // 
            this.answerOptionRTB.BackColor = System.Drawing.Color.Silver;
            this.answerOptionRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerOptionRTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.answerOptionRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerOptionRTB.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.answerOptionRTB.Location = new System.Drawing.Point(186, 6);
            this.answerOptionRTB.Margin = new System.Windows.Forms.Padding(6);
            this.answerOptionRTB.Name = "answerOptionRTB";
            this.answerOptionRTB.ReadOnly = true;
            this.answerOptionRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.answerOptionRTB.Size = new System.Drawing.Size(808, 73);
            this.answerOptionRTB.TabIndex = 2;
            this.answerOptionRTB.Text = "";
            // 
            // AnswerOptionButton
            // 
            this.AnswerOptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AnswerOptionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswerOptionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AnswerOptionButton.FlatAppearance.BorderSize = 2;
            this.AnswerOptionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.AnswerOptionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.AnswerOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerOptionButton.Font = new System.Drawing.Font("Gill Sans MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnswerOptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AnswerOptionButton.Location = new System.Drawing.Point(3, 3);
            this.AnswerOptionButton.Name = "AnswerOptionButton";
            this.AnswerOptionButton.Size = new System.Drawing.Size(94, 79);
            this.AnswerOptionButton.TabIndex = 0;
            this.AnswerOptionButton.Text = "?";
            this.AnswerOptionButton.UseVisualStyleBackColor = false;
            // 
            // MultipleChoiceAnswerOptionCheckerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MultipleChoiceAnswerOptionCheckerUC";
            this.Size = new System.Drawing.Size(1000, 85);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AnswerOptionButton;
        private System.Windows.Forms.RichTextBox answerOptionRTB;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
