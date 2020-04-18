using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        string username = "Ammar";
        string Password = "1234";

        int attempt = 1;
        int MaxAttempts = 3;
        bool loggedIn = false;
       

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnComvo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();

        }

        private void btnRobotic_Clicked(object sender, EventArgs e)
        {
           
        }

        private void btnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                while (attempt <= MaxAttempts)
                {
                     if (txtUser.Text != username)
                    {

                        MessageBox.Show("invalid username , " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        loggedIn = false;
                        return;
                    }//endif

                    else
                    {
                        if (txtPassword.Text != Password)
                        {
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            attempt++;
                            loggedIn = false;
                            return;
                        }//endif
                        else
                        {
                            attempt = 0;
                            loggedIn = true;

                            MessageBox.Show("welcome, " + username + "... you are logged in successfuly");
                            btnLogin.Text = "Logout";//to change the text on the login button 
                            break; //to break out of the loop 
                        }//endelse
                    }//endelse
                }//endwhile
            }//endif
        }
        private static void button9_Click(object sender, EventArgs e)
        {
            frm1 frm = new frm1();
            frm.ShowDialog();
            
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frm1 x = new frm1();
            x.ShowDialog();

        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheckBox frm = new frmCheckBox();
            frm.ShowDialog();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnArduino_Click(object sender, EventArgs e)
        {
            ;

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupGraphical_Enter(object sender, EventArgs e)
        {

        }

        private void btnPictureBox_Click(object sender, EventArgs e)
        {
            frmPicBox frm = new frmPicBox();
            frm.ShowDialog();
        }

        private void btnSelfieApp_Click(object sender, EventArgs e)
        {

        }

        private void btnPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnGroupApp_Click(object sender, EventArgs e)
        {

        }

        private void btnProgress_Click(object sender, EventArgs e)
        {

        }

        private void btnTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

        }

        private void btnTalk_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnManufacturing_Click(object sender, EventArgs e)
        {

        }

        private void btnJohari_Click(object sender, EventArgs e)
        {

        }

        private void btnABC_Click(object sender, EventArgs e)
        {

        }
    }
}