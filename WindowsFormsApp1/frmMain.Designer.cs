namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.groupBasic = new System.Windows.Forms.GroupBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.groupGraphical = new System.Windows.Forms.GroupBox();
            this.btnGroupApp = new System.Windows.Forms.Button();
            this.btnSelfieApp = new System.Windows.Forms.Button();
            this.btnPictureBox2 = new System.Windows.Forms.Button();
            this.btnPictureBox = new System.Windows.Forms.Button();
            this.groupMoreControls = new System.Windows.Forms.GroupBox();
            this.btnRandomCom = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.groupDrawAndTalk = new System.Windows.Forms.GroupBox();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.groupExamApps = new System.Windows.Forms.GroupBox();
            this.btnJohari = new System.Windows.Forms.Button();
            this.btnABC = new System.Windows.Forms.Button();
            this.btnRobotic = new System.Windows.Forms.Button();
            this.btnManufacturing = new System.Windows.Forms.Button();
            this.groupMicro = new System.Windows.Forms.GroupBox();
            this.btnArduino = new System.Windows.Forms.Button();
            this.groupLogin.SuspendLayout();
            this.groupBasic.SuspendLayout();
            this.groupGraphical.SuspendLayout();
            this.groupMoreControls.SuspendLayout();
            this.groupDrawAndTalk.SuspendLayout();
            this.groupExamApps.SuspendLayout();
            this.groupMicro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLogin
            // 
            this.groupLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.groupLogin.Controls.Add(this.btnAbout);
            this.groupLogin.Controls.Add(this.btnLogin);
            this.groupLogin.Controls.Add(this.labelPassword);
            this.groupLogin.Controls.Add(this.labelUsername);
            this.groupLogin.Controls.Add(this.txtPassword);
            this.groupLogin.Controls.Add(this.txtUser);
            this.groupLogin.Location = new System.Drawing.Point(12, 12);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Size = new System.Drawing.Size(259, 510);
            this.groupLogin.TabIndex = 0;
            this.groupLogin.TabStop = false;
            this.groupLogin.Text = "Login";
            this.groupLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(9, 456);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(244, 48);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(9, 131);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(244, 55);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(3, 87);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(91, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(0, 42);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(94, 20);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(141, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(112, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(141, 22);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(593, 432);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(269, 90);
            this.btnEXIT.TabIndex = 1;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // groupBasic
            // 
            this.groupBasic.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBasic.Controls.Add(this.btnCombo);
            this.groupBasic.Controls.Add(this.btnCheckBox);
            this.groupBasic.Controls.Add(this.btnRadio);
            this.groupBasic.Location = new System.Drawing.Point(277, 12);
            this.groupBasic.Name = "groupBasic";
            this.groupBasic.Size = new System.Drawing.Size(310, 135);
            this.groupBasic.TabIndex = 3;
            this.groupBasic.TabStop = false;
            this.groupBasic.Text = "Basic Controls";
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.Location = new System.Drawing.Point(75, 89);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(168, 40);
            this.btnCombo.TabIndex = 6;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = false;
            this.btnCombo.Click += new System.EventHandler(this.btnComvo_Click);
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBox.Location = new System.Drawing.Point(169, 31);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(137, 41);
            this.btnCheckBox.TabIndex = 5;
            this.btnCheckBox.Text = "CheckBox";
            this.btnCheckBox.UseVisualStyleBackColor = false;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadio.Location = new System.Drawing.Point(6, 31);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(135, 41);
            this.btnRadio.TabIndex = 4;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = false;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // groupGraphical
            // 
            this.groupGraphical.BackColor = System.Drawing.Color.Gainsboro;
            this.groupGraphical.Controls.Add(this.btnGroupApp);
            this.groupGraphical.Controls.Add(this.btnSelfieApp);
            this.groupGraphical.Controls.Add(this.btnPictureBox2);
            this.groupGraphical.Controls.Add(this.btnPictureBox);
            this.groupGraphical.Location = new System.Drawing.Point(277, 153);
            this.groupGraphical.Name = "groupGraphical";
            this.groupGraphical.Size = new System.Drawing.Size(310, 135);
            this.groupGraphical.TabIndex = 4;
            this.groupGraphical.TabStop = false;
            this.groupGraphical.Text = "Graphical";
            this.groupGraphical.Enter += new System.EventHandler(this.groupGraphical_Enter);
            // 
            // btnGroupApp
            // 
            this.btnGroupApp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroupApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupApp.Location = new System.Drawing.Point(169, 75);
            this.btnGroupApp.Name = "btnGroupApp";
            this.btnGroupApp.Size = new System.Drawing.Size(135, 48);
            this.btnGroupApp.TabIndex = 7;
            this.btnGroupApp.Text = "Group App";
            this.btnGroupApp.UseVisualStyleBackColor = false;
            this.btnGroupApp.Click += new System.EventHandler(this.btnGroupApp_Click);
            // 
            // btnSelfieApp
            // 
            this.btnSelfieApp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelfieApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelfieApp.Location = new System.Drawing.Point(169, 21);
            this.btnSelfieApp.Name = "btnSelfieApp";
            this.btnSelfieApp.Size = new System.Drawing.Size(135, 48);
            this.btnSelfieApp.TabIndex = 8;
            this.btnSelfieApp.Text = "SelfieApp";
            this.btnSelfieApp.UseVisualStyleBackColor = false;
            this.btnSelfieApp.Click += new System.EventHandler(this.btnSelfieApp_Click);
            // 
            // btnPictureBox2
            // 
            this.btnPictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPictureBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureBox2.Location = new System.Drawing.Point(6, 75);
            this.btnPictureBox2.Name = "btnPictureBox2";
            this.btnPictureBox2.Size = new System.Drawing.Size(135, 48);
            this.btnPictureBox2.TabIndex = 9;
            this.btnPictureBox2.Text = "PictureBox2";
            this.btnPictureBox2.UseVisualStyleBackColor = false;
            this.btnPictureBox2.Click += new System.EventHandler(this.btnPictureBox2_Click);
            // 
            // btnPictureBox
            // 
            this.btnPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPictureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureBox.Location = new System.Drawing.Point(6, 21);
            this.btnPictureBox.Name = "btnPictureBox";
            this.btnPictureBox.Size = new System.Drawing.Size(135, 48);
            this.btnPictureBox.TabIndex = 10;
            this.btnPictureBox.Text = "PictureBox";
            this.btnPictureBox.UseVisualStyleBackColor = false;
            this.btnPictureBox.Click += new System.EventHandler(this.btnPictureBox_Click);
            // 
            // groupMoreControls
            // 
            this.groupMoreControls.BackColor = System.Drawing.Color.Gainsboro;
            this.groupMoreControls.Controls.Add(this.btnRandomCom);
            this.groupMoreControls.Controls.Add(this.btnRandom);
            this.groupMoreControls.Controls.Add(this.btnTimer);
            this.groupMoreControls.Controls.Add(this.btnProgress);
            this.groupMoreControls.Location = new System.Drawing.Point(277, 294);
            this.groupMoreControls.Name = "groupMoreControls";
            this.groupMoreControls.Size = new System.Drawing.Size(310, 132);
            this.groupMoreControls.TabIndex = 4;
            this.groupMoreControls.TabStop = false;
            this.groupMoreControls.Text = "More Controls";
            // 
            // btnRandomCom
            // 
            this.btnRandomCom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRandomCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomCom.Location = new System.Drawing.Point(169, 75);
            this.btnRandomCom.Name = "btnRandomCom";
            this.btnRandomCom.Size = new System.Drawing.Size(135, 48);
            this.btnRandomCom.TabIndex = 11;
            this.btnRandomCom.Text = "RandomCombo";
            this.btnRandomCom.UseVisualStyleBackColor = false;
            this.btnRandomCom.Click += new System.EventHandler(this.btnRandomCombo_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(6, 75);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(135, 48);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.Location = new System.Drawing.Point(169, 21);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(135, 48);
            this.btnTimer.TabIndex = 13;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgress.Location = new System.Drawing.Point(6, 21);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(135, 48);
            this.btnProgress.TabIndex = 14;
            this.btnProgress.Text = "Progress";
            this.btnProgress.UseVisualStyleBackColor = false;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // groupDrawAndTalk
            // 
            this.groupDrawAndTalk.BackColor = System.Drawing.Color.Gainsboro;
            this.groupDrawAndTalk.Controls.Add(this.btnTalk);
            this.groupDrawAndTalk.Controls.Add(this.btnDraw);
            this.groupDrawAndTalk.Location = new System.Drawing.Point(277, 432);
            this.groupDrawAndTalk.Name = "groupDrawAndTalk";
            this.groupDrawAndTalk.Size = new System.Drawing.Size(310, 90);
            this.groupDrawAndTalk.TabIndex = 5;
            this.groupDrawAndTalk.TabStop = false;
            this.groupDrawAndTalk.Text = "Draw and Talk";
            // 
            // btnTalk
            // 
            this.btnTalk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalk.Location = new System.Drawing.Point(171, 26);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(135, 48);
            this.btnTalk.TabIndex = 11;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(6, 26);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(135, 48);
            this.btnDraw.TabIndex = 12;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // groupExamApps
            // 
            this.groupExamApps.BackColor = System.Drawing.Color.Gainsboro;
            this.groupExamApps.Controls.Add(this.btnJohari);
            this.groupExamApps.Controls.Add(this.btnABC);
            this.groupExamApps.Controls.Add(this.btnRobotic);
            this.groupExamApps.Controls.Add(this.btnManufacturing);
            this.groupExamApps.Location = new System.Drawing.Point(593, 12);
            this.groupExamApps.Name = "groupExamApps";
            this.groupExamApps.Size = new System.Drawing.Size(269, 310);
            this.groupExamApps.TabIndex = 6;
            this.groupExamApps.TabStop = false;
            this.groupExamApps.Text = "Exam Apps";
            // 
            // btnJohari
            // 
            this.btnJohari.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnJohari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJohari.Location = new System.Drawing.Point(6, 234);
            this.btnJohari.Name = "btnJohari";
            this.btnJohari.Size = new System.Drawing.Size(257, 56);
            this.btnJohari.TabIndex = 14;
            this.btnJohari.Text = "Johari";
            this.btnJohari.UseVisualStyleBackColor = false;
            this.btnJohari.Click += new System.EventHandler(this.btnJohari_Click);
            // 
            // btnABC
            // 
            this.btnABC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABC.Location = new System.Drawing.Point(6, 162);
            this.btnABC.Name = "btnABC";
            this.btnABC.Size = new System.Drawing.Size(257, 56);
            this.btnABC.TabIndex = 13;
            this.btnABC.Text = "ABC Analysis";
            this.btnABC.UseVisualStyleBackColor = false;
            this.btnABC.Click += new System.EventHandler(this.btnABC_Click);
            // 
            // btnRobotic
            // 
            this.btnRobotic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRobotic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotic.Location = new System.Drawing.Point(6, 89);
            this.btnRobotic.Name = "btnRobotic";
            this.btnRobotic.Size = new System.Drawing.Size(257, 56);
            this.btnRobotic.TabIndex = 12;
            this.btnRobotic.Text = "Robotic Cell";
            this.btnRobotic.UseVisualStyleBackColor = false;
            this.btnRobotic.Click += new System.EventHandler(this.btnRobotic_Clicked);
            // 
            // btnManufacturing
            // 
            this.btnManufacturing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnManufacturing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManufacturing.Location = new System.Drawing.Point(6, 21);
            this.btnManufacturing.Name = "btnManufacturing";
            this.btnManufacturing.Size = new System.Drawing.Size(257, 56);
            this.btnManufacturing.TabIndex = 11;
            this.btnManufacturing.Text = "Manufacturing Cell";
            this.btnManufacturing.UseVisualStyleBackColor = false;
            this.btnManufacturing.Click += new System.EventHandler(this.btnManufacturing_Click);
            // 
            // groupMicro
            // 
            this.groupMicro.BackColor = System.Drawing.Color.Gainsboro;
            this.groupMicro.Controls.Add(this.btnArduino);
            this.groupMicro.Location = new System.Drawing.Point(593, 328);
            this.groupMicro.Name = "groupMicro";
            this.groupMicro.Size = new System.Drawing.Size(269, 98);
            this.groupMicro.TabIndex = 7;
            this.groupMicro.TabStop = false;
            this.groupMicro.Text = "Micro Controller";
            // 
            // btnArduino
            // 
            this.btnArduino.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArduino.Location = new System.Drawing.Point(6, 27);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Size = new System.Drawing.Size(257, 56);
            this.btnArduino.TabIndex = 15;
            this.btnArduino.Text = "Arduino";
            this.btnArduino.UseVisualStyleBackColor = false;
            this.btnArduino.Click += new System.EventHandler(this.btnArduino_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(875, 530);
            this.Controls.Add(this.groupMicro);
            this.Controls.Add(this.groupExamApps);
            this.Controls.Add(this.groupDrawAndTalk);
            this.Controls.Add(this.groupGraphical);
            this.Controls.Add(this.groupMoreControls);
            this.Controls.Add(this.groupBasic);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.groupLogin);
            this.Name = "frmMain";
            this.Text = "IE322_S20_KAU";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            this.groupBasic.ResumeLayout(false);
            this.groupGraphical.ResumeLayout(false);
            this.groupMoreControls.ResumeLayout(false);
            this.groupDrawAndTalk.ResumeLayout(false);
            this.groupExamApps.ResumeLayout(false);
            this.groupMicro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLogin;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox groupBasic;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.GroupBox groupGraphical;
        private System.Windows.Forms.Button btnGroupApp;
        private System.Windows.Forms.Button btnSelfieApp;
        private System.Windows.Forms.Button btnPictureBox2;
        private System.Windows.Forms.Button btnPictureBox;
        private System.Windows.Forms.GroupBox groupMoreControls;
        private System.Windows.Forms.Button btnRandomCom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.GroupBox groupDrawAndTalk;
        private System.Windows.Forms.GroupBox groupExamApps;
        private System.Windows.Forms.Button btnJohari;
        private System.Windows.Forms.Button btnABC;
        private System.Windows.Forms.Button btnRobotic;
        private System.Windows.Forms.Button btnManufacturing;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupMicro;
        private System.Windows.Forms.Button btnArduino;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnAbout;
    }
}

