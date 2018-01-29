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
    public partial class frmAddCustomer : Form
    {
        frmMainMenu parent;
        public frmAddCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnAddLinen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer added to the system", "Added Customer");
            txtCompanyName.Clear();
            txtContactNumber.Clear();
            txtCounty.Clear();
            txtCustomerName.Clear();
            txtEircode.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            return;
        }
    }
}
