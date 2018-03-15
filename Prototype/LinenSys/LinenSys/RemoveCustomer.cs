using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    public partial class frmRemoveCustomer : Form
    {
        frmMainMenu parent;
        public frmRemoveCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnGetCustomer_Click_1(object sender, EventArgs e)
        {
            String CustomerID = txtCustomerID.Text;
            CustomerID = CustomerID.ToLower();
            cboCompanyNames.Items.Clear();

            if (CustomerID.Equals(""))
            {
                MessageBox.Show("Customer ID must be entered", "Error");
                txtCustomerID.Focus();
                return;
            }

            else
            {
                lblCompanyNames.Visible = true;
                cboCompanyNames.Visible = true;
                cboCompanyNames.Items.Add("Ashe Hotel");
                cboCompanyNames.Items.Add("Grand Hotel");
                return;
            }
        }

        private void btnRemoveCustomer_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Selected customer has been removed", "Removed");
            cboCompanyNames.Items.Clear();
            txtCustomerID.Clear();
            return;
        }
    }
}
