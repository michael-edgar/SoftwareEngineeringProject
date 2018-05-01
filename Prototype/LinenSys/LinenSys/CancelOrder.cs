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
        DataTable dt = new DataTable();
        frmMainMenu parent;
        String selectedCell;
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
            }
            //display customers
            grdOrders.Visible = true;
            lblOrders.Visible = true;
        }
        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelOrder.Visible = true;
            int selectedRowIndex = grdOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdOrders.Rows[selectedRowIndex];
            selectedCell = Convert.ToString(selectedRow.Cells["OrderID"].Value);
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            Orders cancelOrder = Orders.getMatchingOrder(selectedCell);
            OrderItem cancelItems = new OrderItem();
            cancelItems.setOrderID(cancelOrder.getOrderID());
            cancelItems.cancelOrderItem();
            cancelOrder.cancelOrder();
            MessageBox.Show("Order has been Cancelled");
        }
    }
}
