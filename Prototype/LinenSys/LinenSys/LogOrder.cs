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
    public partial class frmLogOrder : Form
    {
        frmMainMenu parent;
        DataTable dt = new DataTable();

        public frmLogOrder(frmMainMenu Parent)
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
            if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Customer ID must be entered", "Error");
                txtCustomerID.Focus();
                return;
            }

            grdCustomers.DataSource = null;
            dt.Clear();

            dt = Customer.getMatchingNames(dt, txtCustomerID.Text.ToUpper());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["CUSTOMER_STATUS"].ToString().Equals("A"))
                {
                    grdCustomers.Equals(dt);
                }
            }

            if(grdCustomers.Rows.Count == 0)
            {
                MessageBox.Show("No active customers matching customer ID was found, please re-enter");
                txtCustomerID.Focus();
                return;
            }

            //display customers
            grdCustomers.Visible = true;
        }

        private void grdCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //display selected customer
            grpCustomer.Visible = true;
            txtCustomerIDDisplay.Text = "114";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstItems.Items.Add(cboLinen.Text+ "       " +txtQty.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lstItems.Items.RemoveAt(lstItems.SelectedIndex);
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been made", "Completed Order");
        }
    }
}
