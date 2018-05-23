using System;
using System.Data;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmCollectLaundry : Form
    {
        frmMainMenu parent;
        DataTable dt = new DataTable();
        DateTime today;
        DateTime deliveryDate;
        DataTable dl = new DataTable();
        double totalPrice;
        double price;

        public frmCollectLaundry(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmCollectLaundry_Load(object sender, EventArgs e)
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

            if(txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Customer ID must be entered", "Error");
                txtCustomerID.Focus();
                return;
            }

            dt.Clear();
            grdCustomers.Rows.Clear();

            dt = Customer.getCustomerForOrder(dt, txtCustomerID.Text.ToUpper());

            foreach (DataColumn dc in dt.Columns)
            {
                if (grdCustomers.Columns.Count < dt.Columns.Count)
                {
                    grdCustomers.Columns.Add(new DataGridViewTextBoxColumn());
                }
            }

            foreach (DataRow dr in dt.Rows)
            {
                grdCustomers.Rows.Add(dr.ItemArray);
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
                price = Math.Round((Linen.getPrice("Cleaning_Price", cboLinen.Text) * (Convert.ToDouble(txtQty.Text))), 2);
                lstPrice.Items.Add((price));
                totalPrice += price;
                txtTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void lstPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPrice.SelectedIndex != -1)
            {
                lstItems.SelectedIndex = -1;
                lstAmount.SelectedIndex = -1;
            }
        }

        private void lstAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAmount.SelectedIndex != -1)
            {
                lstItems.SelectedIndex = -1;
                lstPrice.SelectedIndex = -1;
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex != -1)
            {
                lstAmount.SelectedIndex = -1;
                lstPrice.SelectedIndex = -1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex == -1 && lstAmount.SelectedIndex == -1 && lstPrice.SelectedIndex == -1)
            {
                MessageBox.Show("Must Select Item To Remove");
                return;
            }
            else if (lstItems.SelectedIndex == -1 && lstAmount.SelectedIndex == -1)
            {
                totalPrice -= Convert.ToDouble(lstPrice.Items[lstPrice.SelectedIndex]);
                txtTotalPrice.Text = totalPrice.ToString();
                lstItems.Items.RemoveAt(lstPrice.SelectedIndex);
                lstAmount.Items.RemoveAt(lstPrice.SelectedIndex);
                lstPrice.Items.RemoveAt(lstPrice.SelectedIndex);
            }
            else if (lstItems.SelectedIndex == -1 && lstPrice.SelectedIndex == -1)
            {
                totalPrice -= Convert.ToDouble(lstPrice.Items[lstAmount.SelectedIndex]);
                txtTotalPrice.Text = totalPrice.ToString();
                lstItems.Items.RemoveAt(lstAmount.SelectedIndex);
                lstPrice.Items.RemoveAt(lstAmount.SelectedIndex);
                lstAmount.Items.RemoveAt(lstAmount.SelectedIndex);
            }
            else
            {
                totalPrice -= Convert.ToDouble(lstPrice.Items[lstItems.SelectedIndex]);
                txtTotalPrice.Text = totalPrice.ToString();
                lstAmount.Items.RemoveAt(lstItems.SelectedIndex);
                lstPrice.Items.RemoveAt(lstItems.SelectedIndex);
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
            txtTotalPrice.Text = totalPrice.ToString();
        }

        private void dtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            btnCompleteOrder.Visible = true;
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
            newOrder.setOrderStatus('A');
            newOrder.setOrderType('L');
            newOrder.setTotalPrice(Convert.ToDouble(txtTotalPrice.Text));
            newOrder.regOrders();

            OrderItem orderItems = new OrderItem();
            for (int item = 0; item < lstItems.Items.Count; item++)
            {
                orderItems.setOrderID(Convert.ToInt32(txtOrderId.Text));
                orderItems.setLinenAmount(Convert.ToInt32(lstAmount.Items[item]));
                orderItems.setPrice(Convert.ToDouble(lstPrice.Items[item]));
                for (int i = 0; i < dl.Rows.Count; i++)
                {
                    if (dl.Rows[i]["LINEN_NAME"].ToString().Trim().Equals(lstItems.Items[item].ToString()))
                    {
                        orderItems.setLinenCode(dl.Rows[i]["LINEN_CODE"].ToString().Trim());
                    }
                }
                orderItems.regOrderItem();
            }
            MessageBox.Show("Order has been made", "Completed Order");
        }
    }
}
