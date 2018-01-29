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
    public partial class frmUpdateCustomer : Form
    {
        frmMainMenu parent;
        public frmUpdateCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
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
                cboCompanyNames.Items.Add("Rose Hotel");
                return;
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The updated customer has been saved to the system.");
            txtCustomerName.Clear();
            txtCompanyName.Clear();
            txtContactNumber.Clear();
            txtCounty.Clear();
            txtCustomerID.Clear();
            txtEircode.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            return;
        }

        private void cboCompanyNames_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            grpCustomer.Visible = true;
            txtCompanyName.Text = "Ashe Hotel";
            txtContactNumber.Text = "0831234567";
            txtCounty.Text = "Kerry";
            txtCustomerID.Text = "0114";
            txtCustomerName.Text = "John Doe";
            txtEircode.Text = "V92 YX1T";
            txtEmail.Text = "John@ashehotel.ie";
            txtStreet.Text = "Ashe Street";
            txtTown.Text = "Tralee";
        }
    }
}
