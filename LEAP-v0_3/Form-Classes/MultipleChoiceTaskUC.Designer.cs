
namespace LEAP_v0_3
{
    partial class MultipleChoiceTaskUC
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
            this.AnswerOptions_FlowLP_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1_decoration = new System.Windows.Forms.Panel();
            this.MultipleChoiceQuestionTextRTB = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AnswerOptions_FlowLP_1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1_decoration, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MultipleChoiceQuestionTextRTB, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AnswerOptions_FlowLP_1
            // 
            this.AnswerOptions_FlowLP_1.AutoSize = true;
            this.AnswerOptions_FlowLP_1.BackColor = System.Drawing.Color.SlateGray;
            this.AnswerOptions_FlowLP_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswerOptions_FlowLP_1.Location = new System.Drawing.Point(3, 364);
            this.AnswerOptions_FlowLP_1.Name = "AnswerOptions_FlowLP_1";
            this.AnswerOptions_FlowLP_1.Size = new System.Drawing.Size(1010, 35);
            this.AnswerOptions_FlowLP_1.TabIndex = 2;
            // 
            // panel1_decoration
            // 
            this.panel1_decoration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1_decoration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_decoration.Location = new System.Drawing.Point(3, 23);
            this.panel1_decoration.Name = "panel1_decoration";
            this.panel1_decoration.Size = new System.Drawing.Size(1010, 9);
            this.panel1_decoration.TabIndex = 3;
            // 
            // MultipleChoiceQuestionTextRTB
            // 
            this.MultipleChoiceQuestionTextRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MultipleChoiceQuestionTextRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultipleChoiceQuestionTextRTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MultipleChoiceQuestionTextRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultipleChoiceQuestionTextRTB.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.MultipleChoiceQuestionTextRTB.Location = new System.Drawing.Point(6, 58);
            this.MultipleChoiceQuestionTextRTB.Margin = new System.Windows.Forms.Padding(6, 3, 10, 3);
            this.MultipleChoiceQuestionTextRTB.Name = "MultipleChoiceQuestionTextRTB";
            this.MultipleChoiceQuestionTextRTB.ReadOnly = true;
            this.MultipleChoiceQuestionTextRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultipleChoiceQuestionTextRTB.Size = new System.Drawing.Size(1000, 300);
            this.MultipleChoiceQuestionTextRTB.TabIndex = 0;
            this.MultipleChoiceQuestionTextRTB.Text = "";
            this.MultipleChoiceQuestionTextRTB.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.MultipleChoiceQuestionTextRTB_ContentsResized);
            // 
            // MultipleChoiceTaskUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MultipleChoiceTaskUC";
            this.Size = new System.Drawing.Size(1016, 402);
            this.Load += new System.EventHandler(this.MultipleChoiceTaskUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox MultipleChoiceQuestionTextRTB;
        private System.Windows.Forms.Panel panel1_decoration;
        public System.Windows.Forms.FlowLayoutPanel AnswerOptions_FlowLP_1;
    }
}
