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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();

            cmbDay.Items.Add("SUNDAY");
            cmbDay.Items.Add("MONDAY");
            cmbDay.Items.Add("TUESDAY");
            cmbDay.Items.Add("WEDNESDAY");
            cmbDay.Items.Add("THURSDAY");
            cmbDay.Items.Add("FRIDAY");
            cmbDay.Items.Add("SATURDAY");
        }

        private void frmCombo_Load(object sender, EventArgs e)
        {

        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSSM1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDay.Text);
        }

        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            cmbDay.Items.Remove(cmbDay.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnRemove2nd_Click(object sender, EventArgs e)
        {
            if (cmbDay.Items.Count >= 2)
            {
                cmbDay.Items.RemoveAt(cmbDay.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }
        }

        private void btnRemove1st_Click(object sender, EventArgs e)
        {
            if (cmbDay.Items.Count >= 1)
            {
                cmbDay.Items.RemoveAt(cmbDay.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }
        }

        private void btnRemoveIndex_Click(object sender, EventArgs e)
        {
            cmbDay.Items.RemoveAt(1);
        }

        private void btnSSM2_Click(object sender, EventArgs e)
        {
            string itemText = cmbDay.GetItemText(cmbDay.SelectedItem);

            MessageBox.Show(itemText);
        }
    }
}
