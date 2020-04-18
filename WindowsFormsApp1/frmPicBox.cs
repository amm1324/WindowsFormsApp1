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
    public partial class frmPicBox : Form
    {
        public frmPicBox()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            TryImage.Image = Image.FromFile("D:\\IE.jpg");

        }

        private void TryImage_Click(object sender, EventArgs e)
        {

        }
    }
}
