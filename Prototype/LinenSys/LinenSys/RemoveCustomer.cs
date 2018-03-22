using System;
using System.Data;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmRemoveCustomer : Form
    {
        frmMainMenu parent;
        DataTable dt = new DataTable();

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
            lblCompanyNames.Visible = false;
            cboCompanyNames.Visible = false;
            btnRemoveCustomer.Visible = false;

            if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Customer ID must be entered", "Error");
                txtCustomerID.Focus();
                return;
            }

            cboCompanyNames.Items.Clear();
            dt.Clear();

            dt = Customer.getMatchingNames(dt, txtCustomerID.Text.ToUpper());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["CUSTOMER_STATUS"].ToString().Equals("A"))
                {
                    cboCompanyNames.Items.Add(dt.Rows[i]["COMPANY_NAME"]);
                }
            }

            if (cboCompanyNames.Items.Count == 0)
            {
                MessageBox.Show("No active linen matching linen code was found, please re-enter");
                txtCustomerID.Focus();
                return;
            }

            cboCompanyNames.Visible = true;
            lblCompanyNames.Visible = true;
        }

        private void btnRemoveCustomer_Click_1(object sender, EventArgs e)
        {
            Customer customerToRemove = new Customer();
            String cusID = (dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["CUSTOMER_ID"].ToString());
            customerToRemove.setCustomerID(Convert.ToInt32(cusID));
            customerToRemove.removeCustomer();

            MessageBox.Show("Selected Customer has been removed", "Removed");
            cboCompanyNames.Items.Clear();
            txtCustomerID.Clear();
            return;
        }

        private void cboCompanyNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveCustomer.Visible = true;
        }
    }
}
