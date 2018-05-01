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
    public partial class frmCalculateCustomerEarnings : Form
    {
        frmMainMenu parent;
        public frmCalculateCustomerEarnings(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboCustomerID.Items.Clear();
            lblCustomerIDs.Visible = false;
            cboCustomerID.Visible = false;
            btnCalculateEarnings.Visible = false;
            lblCustomerEarnings.Visible = false;
            txtEarnings.Visible = false;
            DataTable dt = new DataTable();
            dt = Customer.getMatchingNames(dt, txtCustomerID.Text);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int item = Convert.ToInt32(dt.Rows[i]["CUSTOMER_ID"].ToString());
                cboCustomerID.Items.Add(item.ToString("000000"));
            }

            lblCustomerIDs.Visible = true;
            cboCustomerID.Visible = true;
            
        }

        private void btnCalculateEarnings_Click(object sender, EventArgs e)
        {
            if((Orders.getOrdersFromACustomer(Convert.ToInt32(cboCustomerID.Text))).ToString().Equals("-1"))
            {
                MessageBox.Show("No Earnings from this customer, please enter new customer");
                return;
            }
            else
            {
                txtEarnings.Text = (Orders.getOrdersFromACustomer(Convert.ToInt32(cboCustomerID.Text))).ToString();
                txtEarnings.Visible = true;
                lblCustomerEarnings.Visible = true;
            }
        }

        private void cboCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCalculateEarnings.Visible = true;
        }
    }
}
