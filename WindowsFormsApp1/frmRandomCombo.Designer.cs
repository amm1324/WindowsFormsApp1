namespace WindowsFormsApp1
{
    partial class frmRandomCombo
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
            this.groupQuiz03_AAF19 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbRandom = new System.Windows.Forms.ComboBox();
            this.rdoGreater = new System.Windows.Forms.RadioButton();
            this.rdoLess = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupQuiz03_EAF19 = new System.Windows.Forms.GroupBox();
            this.Reset2 = new System.Windows.Forms.Button();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.rdoGreater2 = new System.Windows.Forms.RadioButton();
            this.rdoLess2 = new System.Windows.Forms.RadioButton();
            this.btnGenerate2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupQuiz03_AAF19.SuspendLayout();
            this.groupQuiz03_EAF19.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupQuiz03_AAF19
            // 
            this.groupQuiz03_AAF19.Controls.Add(this.btnReset);
            this.groupQuiz03_AAF19.Controls.Add(this.cmbRandom);
            this.groupQuiz03_AAF19.Controls.Add(this.rdoGreater);
            this.groupQuiz03_AAF19.Controls.Add(this.rdoLess);
            this.groupQuiz03_AAF19.Controls.Add(this.btnGenerate);
            this.groupQuiz03_AAF19.Location = new System.Drawing.Point(26, 34);
            this.groupQuiz03_AAF19.Name = "groupQuiz03_AAF19";
            this.groupQuiz03_AAF19.Size = new System.Drawing.Size(284, 290);
            this.groupQuiz03_AAF19.TabIndex = 0;
            this.groupQuiz03_AAF19.TabStop = false;
            this.groupQuiz03_AAF19.Text = "Quiz03_AAF19";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(140, 222);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 36);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbRandom
            // 
            this.cmbRandom.FormattingEnabled = true;
            this.cmbRandom.Location = new System.Drawing.Point(6, 39);
            this.cmbRandom.Name = "cmbRandom";
            this.cmbRandom.Size = new System.Drawing.Size(127, 24);
            this.cmbRandom.TabIndex = 4;
            this.cmbRandom.SelectedIndexChanged += new System.EventHandler(this.cmbRandom_SelectedIndexChanged);
            // 
            // rdoGreater
            // 
            this.rdoGreater.AutoSize = true;
            this.rdoGreater.Location = new System.Drawing.Point(140, 149);
            this.rdoGreater.Name = "rdoGreater";
            this.rdoGreater.Size = new System.Drawing.Size(138, 21);
            this.rdoGreater.TabIndex = 3;
            this.rdoGreater.TabStop = true;
            this.rdoGreater.Text = "Greater than 500";
            this.rdoGreater.UseVisualStyleBackColor = true;
            this.rdoGreater.CheckedChanged += new System.EventHandler(this.rdoGreater_CheckedChanged);
            // 
            // rdoLess
            // 
            this.rdoLess.AutoSize = true;
            this.rdoLess.Location = new System.Drawing.Point(140, 102);
            this.rdoLess.Name = "rdoLess";
            this.rdoLess.Size = new System.Drawing.Size(119, 21);
            this.rdoLess.TabIndex = 2;
            this.rdoLess.TabStop = true;
            this.rdoLess.Text = "Less than 500";
            this.rdoLess.UseVisualStyleBackColor = true;
            this.rdoLess.CheckedChanged += new System.EventHandler(this.rdoLess_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(150, 30);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 45);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate__Click);
            // 
            // groupQuiz03_EAF19
            // 
            this.groupQuiz03_EAF19.Controls.Add(this.Reset2);
            this.groupQuiz03_EAF19.Controls.Add(this.cmbRandom2);
            this.groupQuiz03_EAF19.Controls.Add(this.rdoGreater2);
            this.groupQuiz03_EAF19.Controls.Add(this.rdoLess2);
            this.groupQuiz03_EAF19.Controls.Add(this.btnGenerate2);
            this.groupQuiz03_EAF19.Location = new System.Drawing.Point(325, 34);
            this.groupQuiz03_EAF19.Name = "groupQuiz03_EAF19";
            this.groupQuiz03_EAF19.Size = new System.Drawing.Size(284, 290);
            this.groupQuiz03_EAF19.TabIndex = 6;
            this.groupQuiz03_EAF19.TabStop = false;
            this.groupQuiz03_EAF19.Text = "Quiz03_EAF19";
            // 
            // Reset2
            // 
            this.Reset2.Location = new System.Drawing.Point(140, 222);
            this.Reset2.Name = "Reset2";
            this.Reset2.Size = new System.Drawing.Size(138, 36);
            this.Reset2.TabIndex = 5;
            this.Reset2.Text = "Reset";
            this.Reset2.UseVisualStyleBackColor = true;
            this.Reset2.Click += new System.EventHandler(this.Reset2_Click);
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(6, 39);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(127, 24);
            this.cmbRandom2.TabIndex = 4;
            this.cmbRandom2.SelectedIndexChanged += new System.EventHandler(this.cmbRandom2_SelectedIndexChanged);
            // 
            // rdoGreater2
            // 
            this.rdoGreater2.AutoSize = true;
            this.rdoGreater2.Location = new System.Drawing.Point(140, 149);
            this.rdoGreater2.Name = "rdoGreater2";
            this.rdoGreater2.Size = new System.Drawing.Size(130, 21);
            this.rdoGreater2.TabIndex = 3;
            this.rdoGreater2.TabStop = true;
            this.rdoGreater2.Text = "Greater than 50";
            this.rdoGreater2.UseVisualStyleBackColor = true;
            this.rdoGreater2.CheckedChanged += new System.EventHandler(this.rdoGreater2_CheckedChanged);
            // 
            // rdoLess2
            // 
            this.rdoLess2.AutoSize = true;
            this.rdoLess2.Location = new System.Drawing.Point(140, 102);
            this.rdoLess2.Name = "rdoLess2";
            this.rdoLess2.Size = new System.Drawing.Size(111, 21);
            this.rdoLess2.TabIndex = 2;
            this.rdoLess2.TabStop = true;
            this.rdoLess2.Text = "Less than 50";
            this.rdoLess2.UseVisualStyleBackColor = true;
            this.rdoLess2.CheckedChanged += new System.EventHandler(this.rdoLess2_CheckedChanged);
            // 
            // btnGenerate2
            // 
            this.btnGenerate2.Location = new System.Drawing.Point(150, 30);
            this.btnGenerate2.Name = "btnGenerate2";
            this.btnGenerate2.Size = new System.Drawing.Size(127, 45);
            this.btnGenerate2.TabIndex = 0;
            this.btnGenerate2.Text = "Generate";
            this.btnGenerate2.UseVisualStyleBackColor = true;
            this.btnGenerate2.Click += new System.EventHandler(this.btnGenerate2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(465, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 402);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupQuiz03_EAF19);
            this.Controls.Add(this.groupQuiz03_AAF19);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.Load += new System.EventHandler(this.frmRandomCombo_Load);
            this.groupQuiz03_AAF19.ResumeLayout(false);
            this.groupQuiz03_AAF19.PerformLayout();
            this.groupQuiz03_EAF19.ResumeLayout(false);
            this.groupQuiz03_EAF19.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupQuiz03_AAF19;
        private System.Windows.Forms.RadioButton rdoGreater;
        private System.Windows.Forms.RadioButton rdoLess;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbRandom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupQuiz03_EAF19;
        private System.Windows.Forms.Button Reset2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.RadioButton rdoGreater2;
        private System.Windows.Forms.RadioButton rdoLess2;
        private System.Windows.Forms.Button btnGenerate2;
        private System.Windows.Forms.Button btnBack;
    }
}