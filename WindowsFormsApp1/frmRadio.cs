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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void frmRadio_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYellow.Checked = false;

            rdoRed1.Checked = false;
            rdoGreen1.Checked = false;
            rdoBlue1.Checked = false;
            rdoYellow1.Checked = false;

            rdoRed.ForeColor = Color.FromArgb(0);
            rdoGreen.ForeColor = Color.FromArgb(0);
            rdoBlue.ForeColor = Color.FromArgb(0);
            rdoYellow.ForeColor = Color.FromArgb(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked == true)

                rdoRed.ForeColor = Color.FromArgb(255, 0, 0);
            else
                rdoRed.ForeColor = Color.FromArgb(0);
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
                rdoGreen.ForeColor = Color.FromName("green");
            else
                rdoGreen.ForeColor = Color.FromArgb(0);
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked == true)
                rdoBlue.ForeColor = Color.FromName("blue");
            else
                rdoBlue.ForeColor = Color.FromArgb(0);
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked == true)//this if statment is like saying that when the radio button is not on then turn it to black
                rdoYellow.ForeColor = Color.FromName("yellow");
            else
                rdoYellow.ForeColor = Color.FromArgb(0);
        }

        private void rdoBlue1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoGreen1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoRed1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
