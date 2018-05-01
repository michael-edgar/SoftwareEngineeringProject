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
    public partial class frmDispatchDelivery : Form
    {
        DataTable dt = new DataTable();
        frmMainMenu parent;
        String selectedCell;
        public frmDispatchDelivery(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dt.Clear();

            if (txtOrderId.Text == "")
            {
                MessageBox.Show("Must enter search key");
                return;
            }
            else
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
            //display customers
            grdOrders.Visible = true;
            lblOrders.Visible = true;
        }

        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDispatchDelivery.Visible = true;
            int selectedRowIndex = grdOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdOrders.Rows[selectedRowIndex];
            selectedCell = Convert.ToString(selectedRow.Cells["OrderID"].Value);
        }

        private void btnDispatchDelivery_Click(object sender, EventArgs e)
        {
            Orders dispatchOrder = Orders.getMatchingOrder(selectedCell);
            OrderItem dispatchItems = new OrderItem();
            dispatchItems.setOrderID(dispatchOrder.getOrderID());
            dispatchOrder.setDeliveryDate(DateTime.UtcNow.Date.ToString("dd/MMM/yyyy"));
            dispatchItems.deliverOrderItems();
            dispatchOrder.deliverOrder();
            MessageBox.Show("Order has been Delivered");
        }
    }
}

        
