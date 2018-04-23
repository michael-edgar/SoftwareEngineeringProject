using System;
using System.Data;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmLogOrder : Form
    {
        frmMainMenu parent;
        DataTable dt = new DataTable();
        DateTime today;
        DateTime deliveryDate;
        DataTable dl = new DataTable();

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

        private void frmLogOrder_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = Orders.getNextOrderID().ToString("000000");
            today = DateTime.UtcNow.Date;
            txtOrderDate.Text = today.ToString("dd/MMM/yyyy");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdCustomers.Visible = false;
            grpCustomer.Visible = false;
            grpLinen.Visible = false;
            grpOrder.Visible = false;

            if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Customer ID must be entered", "Error");
                txtCustomerID.Focus();
                return;
            }

            grdCustomers.DataSource = null;
            dt.Clear();

            dt = Customer.getCustomerForOrder(dt, txtCustomerID.Text.ToUpper());

            foreach (DataColumn dc in dt.Columns)
            {

                grdCustomers.Columns.Add(new DataGridViewTextBoxColumn());

            }

            foreach (DataRow dr in dt.Rows)
            {

                grdCustomers.Rows.Add(dr.ItemArray);

            }

            if (grdCustomers.Rows.Count == 0)
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
            String selectedCell;
            int selectedRowIndex = grdCustomers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdCustomers.Rows[selectedRowIndex];
            selectedCell = Convert.ToString(selectedRow.Cells["CustID"].Value);
            txtCustomerIDDisplay.Text = (Convert.ToInt32(selectedCell.ToString())).ToString("000000");
            grpLinen.Visible = true;
        }

        private void cboLinen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQty.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboLinen.Text == "")
            {
                MessageBox.Show("You must select a linen");
                cboLinen.Focus();
                return;
            }
            else if (txtQty.Text == "")
            {
                MessageBox.Show("You must enter a quantity of linen");
                txtQty.Focus();
                return;
            }
            else
            {
                lstItems.Items.Add(cboLinen.Text);
                lstAmount.Items.Add(txtQty.Text);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(lstItems.SelectedIndex == -1)
            {
                MessageBox.Show("Must Select Item To Remove");
                return;
            }
            else
            {
                lstItems.Items.RemoveAt(lstItems.SelectedIndex);
            }
            
        }

        private void grpLinen_VisibleChanged(object sender, EventArgs e)
        {
            dl = Linen.getMatchingNames(dl, "");
            cboLinen.Items.Clear();
            for (int i = 0; i < dl.Rows.Count; i++)
            {
                if (dl.Rows[i]["LINEN_STATUS"].ToString().Equals("A"))
                {
                    cboLinen.Items.Add(dl.Rows[i]["LINEN_NAME"].ToString().Trim());
                }
            }
            grpOrder.Visible = true;
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            DateTime validStartDate = today.AddDays(2).Date;
            deliveryDate = dtpDeliveryDate.Value.Date;

            if (DateTime.Compare(deliveryDate, validStartDate) <= 0)
            {
                MessageBox.Show("Invalid Order Date; must be at least 3 days after the date of order");
            }

            Orders newOrder = new Orders();
            newOrder.setOrderID(Convert.ToInt32(txtOrderId.Text));
            newOrder.setCustomerID(Convert.ToInt32(txtCustomerIDDisplay.Text));
            newOrder.setOrderDate(txtOrderDate.Text);
            newOrder.setDeliveryDate(deliveryDate.ToString("dd/MMM/yyyy"));
            newOrder.setOrderStatus('P');
            newOrder.setOrderType('D');
            newOrder.regOrders();

            OrderItem orderItems = new OrderItem();
            for(int item = 0; item < lstItems.Items.Count; item++)
            {
                orderItems.setOrderItem(OrderItem.getNextOrderItem());
                orderItems.setOrderID(Convert.ToInt32(txtOrderId.Text));
                orderItems.setLinenAmount(Convert.ToInt32(lstAmount.Items[item]));
                for(int i = 0; i < dl.Rows.Count; i++)
                {
                    if(dl.Rows[i]["LINEN_NAME"].ToString().Trim().Equals(lstItems.Items[item].ToString()))
                    {
                        orderItems.setLinenCode(dl.Rows[i]["LINEN_CODE"].ToString().Trim());
                    }
                }
                orderItems.regOrderItem();
            }
            MessageBox.Show("Order has been made " + newOrder.ToString() + "" +orderItems.ToString(), "Completed Order");
        }
    }
}
