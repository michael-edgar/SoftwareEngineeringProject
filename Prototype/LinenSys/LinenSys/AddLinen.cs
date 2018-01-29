using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmAddLinen : Form
    {
        frmMainMenu parent;

        public frmAddLinen(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddLinen_Load(object sender, EventArgs e)
        {

        }

        private void btnAddLinen_Click(object sender, EventArgs e)
        {
            //validate data
            float check;
            int checkInt;

            if (txtLinenName.Text.Equals(""))
            {
                MessageBox.Show("Linen Name must be entered", "Error");
                txtLinenName.Focus();
                return;
            }

            if (txtLinenCode.Text.Equals(""))
            {
                MessageBox.Show("Linen Name must be entered", "Error");
                txtLinenName.Focus();
                return;
            }

            if (!float.TryParse(txtHirePrice.Text, out check))
            {
                MessageBox.Show("Hire Price must be numeric", "Error");
                txtHirePrice.Focus();
                return;
            }

            if (!float.TryParse(txtCleaningPrice.Text, out check))
            {
                MessageBox.Show("Cleaning Price must be numeric", "Error");
                txtCleaningPrice.Focus();
                return;
            }

            if (!float.TryParse(txtRejectPrice.Text, out check))
            {
                MessageBox.Show("Reject Price must be numeric", "Error");
                txtRejectPrice.Focus();
                return;
            }

            if (!int.TryParse(txtPackSize.Text, out checkInt))
            {
                MessageBox.Show("Pack Size must be numeric", "Error");
                txtPackSize.Focus();
                return;
            }

            else
            {
                String addedLinen;
                addedLinen = "\nLinen Name: " + txtLinenName.Text + "\nLinen Code: " + txtLinenCode.Text + 
                             "\nHire Price: " + txtHirePrice.Text + "\nCleaning Price: " + 
                             txtCleaningPrice.Text + "\nReject Price: " + txtRejectPrice.Text+ "\nPack Size: " +txtPackSize.Text;

                MessageBox.Show("The new Linen has been added to the system." +addedLinen , "Added Linen");
                txtLinenName.Clear();
                txtLinenCode.Clear();
                txtHirePrice.Clear();
                txtCleaningPrice.Clear();
                txtRejectPrice.Clear();
                txtPackSize.Clear();
                return;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
