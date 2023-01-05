
namespace LEAP_v0_3
{
    partial class SingInWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingInWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserIdentificationNumber_textBox1 = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.SingInButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UserIdentificationNumber_comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(588, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Lambda Exam Application!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(581, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "User identification number:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(765, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // UserIdentificationNumber_textBox1
            // 
            this.UserIdentificationNumber_textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.UserIdentificationNumber_textBox1.Enabled = false;
            this.UserIdentificationNumber_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserIdentificationNumber_textBox1.Location = new System.Drawing.Point(882, 81);
            this.UserIdentificationNumber_textBox1.Name = "UserIdentificationNumber_textBox1";
            this.UserIdentificationNumber_textBox1.Size = new System.Drawing.Size(167, 28);
            this.UserIdentificationNumber_textBox1.TabIndex = 3;
            this.UserIdentificationNumber_textBox1.Text = "ASA-0001";
            // 
            // Password_textBox
            // 
            this.Password_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password_textBox.Location = new System.Drawing.Point(882, 147);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(167, 28);
            this.Password_textBox.TabIndex = 4;
            this.Password_textBox.UseSystemPasswordChar = true;
            // 
            // SingInButton
            // 
            this.SingInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SingInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SingInButton.FlatAppearance.BorderSize = 2;
            this.SingInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.SingInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.SingInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingInButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SingInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SingInButton.Location = new System.Drawing.Point(882, 214);
            this.SingInButton.Name = "SingInButton";
            this.SingInButton.Size = new System.Drawing.Size(150, 50);
            this.SingInButton.TabIndex = 5;
            this.SingInButton.Text = "Sing In";
            this.SingInButton.UseVisualStyleBackColor = false;
            this.SingInButton.Click += new System.EventHandler(this.SingInButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CloseButton.FlatAppearance.BorderSize = 2;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CloseButton.Location = new System.Drawing.Point(670, 214);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(150, 50);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UserIdentificationNumber_comboBox1
            // 
            this.UserIdentificationNumber_comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UserIdentificationNumber_comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.UserIdentificationNumber_comboBox1.FormattingEnabled = true;
            this.UserIdentificationNumber_comboBox1.Items.AddRange(new object[] {
            "ASA-0001",
            "ANF-0002",
            "TSA-0004",
            "SDD-0005",
            "SMM-0006",
            "TCL-0007",
            "SAR-0008",
            "TKP-0022",
            "STK-0023",
            "SHE-0024",
            "SKK-0025",
            "TOO-0035",
            "TVV-0036",
            "SSS-0037",
            "SKK-0038",
            "STT-0039",
            "SSS-0040",
            "SAA-0041",
            "SKK-0042",
            "TPP-0043",
            "TSS-0044",
            "SAA-0045",
            "SAA-0046",
            "SMF-0047",
            "SRO-0048"});
            this.UserIdentificationNumber_comboBox1.Location = new System.Drawing.Point(882, 81);
            this.UserIdentificationNumber_comboBox1.Name = "UserIdentificationNumber_comboBox1";
            this.UserIdentificationNumber_comboBox1.Size = new System.Drawing.Size(167, 30);
            this.UserIdentificationNumber_comboBox1.TabIndex = 9;
            this.UserIdentificationNumber_comboBox1.SelectedIndexChanged += new System.EventHandler(this.UserIdentificationNumber_comboBox1_SelectedIndexChanged);
            // 
            // SingInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1065, 279);
            this.Controls.Add(this.UserIdentificationNumber_comboBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SingInButton);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserIdentificationNumber_textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingInWindow";
            this.Text = "LEAP: Sign in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserIdentificationNumber_textBox1;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button SingInButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox UserIdentificationNumber_comboBox1;
    }
}

