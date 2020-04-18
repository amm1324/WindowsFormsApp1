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
    public partial class frmRandom : Form
    {
        Random y = new Random();
        public frmRandom()
        {
            InitializeComponent();
        }

        private void labelRGB_Click(object sender, EventArgs e)
        {

        }

        private void frmRandom_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnRandomN_Click(object sender, EventArgs e)
        {
            btnRandomN.Text = Convert.ToString(y.Next(1, 10));
        }

        private void btnGenerateRC_Click(object sender, EventArgs e)
        {

        }
    }
}
