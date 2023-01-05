
namespace LEAP_v0_3
{
    partial class EssayTaskUC
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
            this.panel1_decoration = new System.Windows.Forms.Panel();
            this.KeywordsListbox = new System.Windows.Forms.ListBox();
            this.AnswerFieldRTB = new System.Windows.Forms.RichTextBox();
            this.EssayQuestionTextRTB = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1_decoration, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.KeywordsListbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.AnswerFieldRTB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.EssayQuestionTextRTB, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 992);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1_decoration
            // 
            this.panel1_decoration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1_decoration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_decoration.Location = new System.Drawing.Point(3, 23);
            this.panel1_decoration.Name = "panel1_decoration";
            this.panel1_decoration.Size = new System.Drawing.Size(1000, 9);
            this.panel1_decoration.TabIndex = 3;
            // 
            // KeywordsListbox
            // 
            this.KeywordsListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.KeywordsListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeywordsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeywordsListbox.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.KeywordsListbox.FormattingEnabled = true;
            this.KeywordsListbox.ItemHeight = 29;
            this.KeywordsListbox.Location = new System.Drawing.Point(3, 134);
            this.KeywordsListbox.Name = "KeywordsListbox";
            this.KeywordsListbox.Size = new System.Drawing.Size(1000, 30);
            this.KeywordsListbox.TabIndex = 4;
            this.KeywordsListbox.Tag = "";
            // 
            // AnswerFieldRTB
            // 
            this.AnswerFieldRTB.BackColor = System.Drawing.Color.Wheat;
            this.AnswerFieldRTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnswerFieldRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswerFieldRTB.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.AnswerFieldRTB.Location = new System.Drawing.Point(3, 170);
            this.AnswerFieldRTB.Name = "AnswerFieldRTB";
            this.AnswerFieldRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AnswerFieldRTB.Size = new System.Drawing.Size(1000, 819);
            this.AnswerFieldRTB.TabIndex = 6;
            this.AnswerFieldRTB.Text = "";
            // 
            // EssayQuestionTextRTB
            // 
            this.EssayQuestionTextRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EssayQuestionTextRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EssayQuestionTextRTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EssayQuestionTextRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EssayQuestionTextRTB.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.EssayQuestionTextRTB.Location = new System.Drawing.Point(3, 58);
            this.EssayQuestionTextRTB.Name = "EssayQuestionTextRTB";
            this.EssayQuestionTextRTB.ReadOnly = true;
            this.EssayQuestionTextRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.EssayQuestionTextRTB.Size = new System.Drawing.Size(1000, 70);
            this.EssayQuestionTextRTB.TabIndex = 0;
            this.EssayQuestionTextRTB.Text = "";
            this.EssayQuestionTextRTB.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.EssayQuestionTextRTB_ContentsResized);
            // 
            // EssayTaskUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EssayTaskUC";
            this.Size = new System.Drawing.Size(1006, 992);
            this.Load += new System.EventHandler(this.EssayTaskUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox EssayQuestionTextRTB;
        private System.Windows.Forms.Panel panel1_decoration;
        private System.Windows.Forms.ListBox KeywordsListbox;
        public System.Windows.Forms.RichTextBox AnswerFieldRTB;
    }
}
