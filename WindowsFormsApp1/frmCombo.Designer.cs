namespace WindowsFormsApp1
{
    partial class frmCombo
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
            this.btnRemove1st = new System.Windows.Forms.Button();
            this.btnSSM1 = new System.Windows.Forms.Button();
            this.btnRemove2nd = new System.Windows.Forms.Button();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.btnSSM2 = new System.Windows.Forms.Button();
            this.btnRemoveIndex = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemove1st
            // 
            this.btnRemove1st.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove1st.Location = new System.Drawing.Point(492, 79);
            this.btnRemove1st.Name = "btnRemove1st";
            this.btnRemove1st.Size = new System.Drawing.Size(130, 105);
            this.btnRemove1st.TabIndex = 6;
            this.btnRemove1st.Text = "Remove Last Item";
            this.btnRemove1st.UseVisualStyleBackColor = false;
            this.btnRemove1st.Click += new System.EventHandler(this.btnRemove1st_Click);
            // 
            // btnSSM1
            // 
            this.btnSSM1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSSM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.btnSSM1.Location = new System.Drawing.Point(54, 28);
            this.btnSSM1.Name = "btnSSM1";
            this.btnSSM1.Size = new System.Drawing.Size(166, 55);
            this.btnSSM1.TabIndex = 10;
            this.btnSSM1.Text = "Show Selected Method 1";
            this.btnSSM1.UseVisualStyleBackColor = false;
            this.btnSSM1.Click += new System.EventHandler(this.btnSSM1_Click);
            // 
            // btnRemove2nd
            // 
            this.btnRemove2nd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove2nd.Location = new System.Drawing.Point(492, 201);
            this.btnRemove2nd.Name = "btnRemove2nd";
            this.btnRemove2nd.Size = new System.Drawing.Size(130, 105);
            this.btnRemove2nd.TabIndex = 12;
            this.btnRemove2nd.Text = "Remove 2nd Item";
            this.btnRemove2nd.UseVisualStyleBackColor = false;
            this.btnRemove2nd.Click += new System.EventHandler(this.btnRemove2nd_Click);
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(151, 175);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(210, 24);
            this.cmbDay.TabIndex = 13;
            this.cmbDay.Text = "Choose a Day of The Week";
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Tai Le", 12.8F);
            this.labelDay.Location = new System.Drawing.Point(68, 172);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(50, 29);
            this.labelDay.TabIndex = 14;
            this.labelDay.Text = "Day";
            // 
            // btnSSM2
            // 
            this.btnSSM2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSSM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSM2.Location = new System.Drawing.Point(245, 28);
            this.btnSSM2.Name = "btnSSM2";
            this.btnSSM2.Size = new System.Drawing.Size(153, 55);
            this.btnSSM2.TabIndex = 15;
            this.btnSSM2.Text = "Show Selected Method 2";
            this.btnSSM2.UseVisualStyleBackColor = false;
            this.btnSSM2.Click += new System.EventHandler(this.btnSSM2_Click);
            // 
            // btnRemoveIndex
            // 
            this.btnRemoveIndex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.btnRemoveIndex.Location = new System.Drawing.Point(54, 314);
            this.btnRemoveIndex.Name = "btnRemoveIndex";
            this.btnRemoveIndex.Size = new System.Drawing.Size(143, 55);
            this.btnRemoveIndex.TabIndex = 17;
            this.btnRemoveIndex.Text = "Remobe by Index";
            this.btnRemoveIndex.UseVisualStyleBackColor = false;
            this.btnRemoveIndex.Click += new System.EventHandler(this.btnRemoveIndex_Click);
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.btnRemoveName.Location = new System.Drawing.Point(226, 314);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(143, 55);
            this.btnRemoveName.TabIndex = 18;
            this.btnRemoveName.Text = "Remove by Name";
            this.btnRemoveName.UseVisualStyleBackColor = false;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(487, 328);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 41);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 401);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveName);
            this.Controls.Add(this.btnRemoveIndex);
            this.Controls.Add(this.btnSSM2);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.btnRemove2nd);
            this.Controls.Add(this.btnSSM1);
            this.Controls.Add(this.btnRemove1st);
            this.Name = "frmCombo";
            this.Text = "frmCombo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove1st;
        private System.Windows.Forms.Button btnSSM1;
        private System.Windows.Forms.Button btnRemove2nd;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button btnSSM2;
        private System.Windows.Forms.Button btnRemoveIndex;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnBack;
    }
}