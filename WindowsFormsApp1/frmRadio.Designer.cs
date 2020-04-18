namespace WindowsFormsApp1
{
    partial class frm1
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
            this.groupRadio = new System.Windows.Forms.GroupBox();
            this.rdoYellow1 = new System.Windows.Forms.RadioButton();
            this.rdoBlue1 = new System.Windows.Forms.RadioButton();
            this.rdoGreen1 = new System.Windows.Forms.RadioButton();
            this.rdoRed1 = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRadio
            // 
            this.groupRadio.Controls.Add(this.rdoYellow1);
            this.groupRadio.Controls.Add(this.rdoBlue1);
            this.groupRadio.Controls.Add(this.rdoGreen1);
            this.groupRadio.Controls.Add(this.rdoRed1);
            this.groupRadio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRadio.Location = new System.Drawing.Point(249, 69);
            this.groupRadio.Name = "groupRadio";
            this.groupRadio.Size = new System.Drawing.Size(216, 223);
            this.groupRadio.TabIndex = 4;
            this.groupRadio.TabStop = false;
            this.groupRadio.Text = "Grouped Radio Buttons";
            // 
            // rdoYellow1
            // 
            this.rdoYellow1.AutoSize = true;
            this.rdoYellow1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoYellow1.Location = new System.Drawing.Point(49, 166);
            this.rdoYellow1.Name = "rdoYellow1";
            this.rdoYellow1.Size = new System.Drawing.Size(79, 26);
            this.rdoYellow1.TabIndex = 9;
            this.rdoYellow1.TabStop = true;
            this.rdoYellow1.Text = "Yellow";
            this.rdoYellow1.UseVisualStyleBackColor = true;
            // 
            // rdoBlue1
            // 
            this.rdoBlue1.AutoSize = true;
            this.rdoBlue1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBlue1.Location = new System.Drawing.Point(49, 120);
            this.rdoBlue1.Name = "rdoBlue1";
            this.rdoBlue1.Size = new System.Drawing.Size(64, 26);
            this.rdoBlue1.TabIndex = 10;
            this.rdoBlue1.TabStop = true;
            this.rdoBlue1.Text = "Blue";
            this.rdoBlue1.UseVisualStyleBackColor = true;
            this.rdoBlue1.CheckedChanged += new System.EventHandler(this.rdoBlue1_CheckedChanged);
            // 
            // rdoGreen1
            // 
            this.rdoGreen1.AutoSize = true;
            this.rdoGreen1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGreen1.Location = new System.Drawing.Point(49, 78);
            this.rdoGreen1.Name = "rdoGreen1";
            this.rdoGreen1.Size = new System.Drawing.Size(77, 26);
            this.rdoGreen1.TabIndex = 11;
            this.rdoGreen1.TabStop = true;
            this.rdoGreen1.Text = "Green";
            this.rdoGreen1.UseVisualStyleBackColor = true;
            this.rdoGreen1.CheckedChanged += new System.EventHandler(this.rdoGreen1_CheckedChanged);
            // 
            // rdoRed1
            // 
            this.rdoRed1.AutoSize = true;
            this.rdoRed1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRed1.Location = new System.Drawing.Point(49, 36);
            this.rdoRed1.Name = "rdoRed1";
            this.rdoRed1.Size = new System.Drawing.Size(60, 26);
            this.rdoRed1.TabIndex = 12;
            this.rdoRed1.TabStop = true;
            this.rdoRed1.Text = "Red";
            this.rdoRed1.UseVisualStyleBackColor = true;
            this.rdoRed1.CheckedChanged += new System.EventHandler(this.rdoRed1_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoYellow.Location = new System.Drawing.Point(37, 235);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(79, 26);
            this.rdoYellow.TabIndex = 5;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "Yellow";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBlue.Location = new System.Drawing.Point(37, 189);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(64, 26);
            this.rdoBlue.TabIndex = 6;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGreen.Location = new System.Drawing.Point(37, 147);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(77, 26);
            this.rdoGreen.TabIndex = 7;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRed.Location = new System.Drawing.Point(37, 105);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(60, 26);
            this.rdoRed.TabIndex = 8;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnReset.Location = new System.Drawing.Point(37, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 41);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(330, 319);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 41);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 428);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rdoYellow);
            this.Controls.Add(this.groupRadio);
            this.Controls.Add(this.rdoBlue);
            this.Controls.Add(this.rdoGreen);
            this.Controls.Add(this.rdoRed);
            this.Name = "frm1";
            this.Text = "frmRadio";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.groupRadio.ResumeLayout(false);
            this.groupRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupRadio;
        private System.Windows.Forms.RadioButton rdoYellow1;
        private System.Windows.Forms.RadioButton rdoBlue1;
        private System.Windows.Forms.RadioButton rdoGreen1;
        private System.Windows.Forms.RadioButton rdoRed1;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
    }
}