namespace WindowsFormsApp1
{
    partial class frmRandom
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
            this.btnRandomN = new System.Windows.Forms.Button();
            this.btnGenerateRC = new System.Windows.Forms.Button();
            this.labelRGB = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandomN
            // 
            this.btnRandomN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnRandomN.Location = new System.Drawing.Point(30, 220);
            this.btnRandomN.Name = "btnRandomN";
            this.btnRandomN.Size = new System.Drawing.Size(163, 56);
            this.btnRandomN.TabIndex = 1;
            this.btnRandomN.Text = "Random Number";
            this.btnRandomN.UseVisualStyleBackColor = true;
            this.btnRandomN.Click += new System.EventHandler(this.btnRandomN_Click);
            // 
            // btnGenerateRC
            // 
            this.btnGenerateRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnGenerateRC.Location = new System.Drawing.Point(30, 28);
            this.btnGenerateRC.Name = "btnGenerateRC";
            this.btnGenerateRC.Size = new System.Drawing.Size(322, 75);
            this.btnGenerateRC.TabIndex = 2;
            this.btnGenerateRC.Text = "Generate Random Color";
            this.btnGenerateRC.UseVisualStyleBackColor = true;
            this.btnGenerateRC.Click += new System.EventHandler(this.btnGenerateRC_Click);
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Location = new System.Drawing.Point(167, 128);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(39, 17);
            this.labelRGB.TabIndex = 4;
            this.labelRGB.Text = "r-g-b";
            this.labelRGB.Click += new System.EventHandler(this.labelRGB_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(217, 321);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 41);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 421);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelRGB);
            this.Controls.Add(this.btnGenerateRC);
            this.Controls.Add(this.btnRandomN);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.Load += new System.EventHandler(this.frmRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRandomN;
        private System.Windows.Forms.Button btnGenerateRC;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.Button btnBack;
    }
}