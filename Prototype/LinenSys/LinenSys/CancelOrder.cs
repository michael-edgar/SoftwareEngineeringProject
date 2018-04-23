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
    public partial class frmCancelOrder : Form
    {
        DataTable dt;
        frmMainMenu parent;
        public frmCancelOrder(frmMainMenu Parent)
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
            dt.Clear();

            if (txtOrderDate.Text == "" && txtOrderId.Text == "")
            {
                MessageBox.Show("Must enter search key");
                return;
            }
            else if(txtOrderDate.Text == "" && txtOrderId.Text != "")
            {
                dt = Orders.getMatchingNames(dt, txtOrderId.Text);

                foreach (DataColumn dc in dt.Columns)
                {

                    grdOrders.Columns.Add(new DataGridViewTextBoxColumn());

                }

                foreach (DataRow dr in dt.Rows)
                {

                    grdOrders.Rows.Add(dr.ItemArray);

                }

                if (grdOrders.Rows.Count == 0)
                {
                    MessageBox.Show("No active orders matching order ID was found, please re-enter");
                    txtOrderId.Focus();
                    return;
                }

                //display customers
                grdOrders.Visible = true;
            }
            else if(txtOrderId.Text == "" && txtOrderDate.Text != "")
            {
                dt = Orders.getOrders(dt, "Order_Date", txtOrderDate.Text);

                foreach (DataColumn dc in dt.Columns)
                {

                    grdOrders.Columns.Add(new DataGridViewTextBoxColumn());

                }

                foreach (DataRow dr in dt.Rows)
                {

                    grdOrders.Rows.Add(dr.ItemArray);

                }

                if (grdOrders.Rows.Count == 0)
                {
                    MessageBox.Show("No active orders matching order Date was found, please re-enter");
                    txtOrderDate.Focus();
                    return;
                }

                //display customers
                grdOrders.Visible = true;
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been Cancelled");
        }

        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelOrder.Visible = true;
        }
    }
}
