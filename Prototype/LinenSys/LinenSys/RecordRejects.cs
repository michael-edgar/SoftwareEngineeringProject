using System;
using System.Data;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmRecordRejects : Form
    {
        frmMainMenu parent;
        DataTable dt = new DataTable();
        DataTable dl = new DataTable();
        int currentIndex = -1;
        double totalPrice;
        public frmRecordRejects(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmRecordRejects_Load(object sender, EventArgs e)
        {
            txtRejectID.Text = Rejects.getNextRejectID().ToString("000000");
        }

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            grdOrders.Visible = false;
            lblOrderDetails.Visible = false;
            grpAddReject.Visible = false;
            grpRejects.Visible = false;

            if (txtOrderID.Text.Equals(""))
            {
                MessageBox.Show("Order ID must be entered", "Error");
                txtOrderID.Focus();
                return;
            }

            grdOrders.DataSource = null;
            dt.Clear();

            dt = Orders.getOrdersForReject(dt, txtOrderID.Text);

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
                MessageBox.Show("No active customers matching customer ID was found, please re-enter");
                txtOrderID.Focus();
                return;
            }

            //display orders
            grdOrders.Visible = true;
        }

        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lstItems.Items.Clear();
            lstAmount.Items.Clear();
            String selectedCell;
            int selectedRowIndex = grdOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdOrders.Rows[selectedRowIndex];
            selectedCell = Convert.ToString(selectedRow.Cells["OrderID"].Value);
            txtOrderIDDisplay.Text = (Convert.ToInt32(selectedCell.ToString())).ToString("000000");

            dl = OrderItem.getItemsAndAmount(dl, txtOrderIDDisplay.Text);
            foreach(DataRow dr in dl.Rows)
            {
                lstItems.Items.Add(dr[0]);
                lstAmount.Items.Add(dr[1]);
            }
            grpAddReject.Visible = true;
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboQty.Items.Clear();
            if (lstItems.SelectedIndex != -1)
            {
                lstAmount.SelectedIndex = -1;
                currentIndex = Convert.ToInt32(lstItems.SelectedIndex);
                int amount = Convert.ToInt32(lstAmount.Items[currentIndex]);
                for (int i = 0; i < amount; i++)
                {
                    cboQty.Items.Add((i + 1));
                }
            }
        }

        private void lstAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboQty.Items.Clear();
            if (lstAmount.SelectedIndex != -1)
            {
                lstItems.SelectedIndex = -1;
                currentIndex = Convert.ToInt32(lstAmount.SelectedIndex);
                int amount = Convert.ToInt32(lstAmount.Items[currentIndex]);
                for (int i = 0; i < amount; i++)
                {
                    cboQty.Items.Add((i + 1));
                }
            }
        }

        private void btnAddReject_Click(object sender, EventArgs e)
        {
            if (currentIndex != -1)
            {
                if (cboQty.SelectedIndex != -1)
                {
                    lstRejectAmount.Items.Add(cboQty.Items[cboQty.SelectedIndex]);
                    lstRejectItems.Items.Add(lstItems.Items[currentIndex]);
                }
            }
            grpRejects.Visible = true;
        }

        private void lstRejectItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstRejectItems.SelectedIndex != -1)
            {
                lstRejectAmount.SelectedIndex = -1;
            }
        }

        private void lstRejectAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstRejectAmount.SelectedIndex != -1)
            {
                lstRejectItems.SelectedIndex = -1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstRejectItems.SelectedIndex != -1)
            {
                lstRejectItems.Items.RemoveAt(lstRejectItems.SelectedIndex);
                lstRejectAmount.Items.RemoveAt(lstRejectItems.SelectedIndex);
            }
            else if(lstRejectAmount.SelectedIndex != -1)
            {
                lstRejectItems.Items.RemoveAt(lstRejectAmount.SelectedIndex);
                lstRejectAmount.Items.RemoveAt(lstRejectAmount.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Must selected item to remove");
            }
            
        }

        private void btnSaveRejects_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstRejectAmount.Items[0].ToString());

            foreach(object item in lstRejectItems.Items)
            {
                int count = 0;
                Rejects newReject = new Rejects();
                newReject.setRejectID(Rejects.getNextRejectID());
                newReject.setRejectDate(DateTime.UtcNow.Date.ToString("dd/MMM/yyyy"));
                newReject.setRejectQty(Convert.ToInt32(lstRejectAmount.Items[count]));
                newReject.setLinenCode(lstRejectItems.Items[count].ToString());
                newReject.setOrderID(Convert.ToInt32(txtOrderIDDisplay.Text));
                newReject.setTotalPrice(Math.Round((Linen.getPrice("Reject_Price", lstRejectItems.Items[count].ToString()) * (Convert.ToDouble(lstRejectAmount.Items[count]))), 2));
                Customer.updateRejects(Orders.getCustomerIDFromOrder(Convert.ToInt32(txtOrderIDDisplay.Text)), 
                                        (Math.Round((Linen.getPrice("Reject_Price", lstRejectItems.Items[count].ToString()) * (Convert.ToDouble(lstRejectAmount.Items[count]))), 2)));
                newReject.regReject();
                count++;
            }
            
            MessageBox.Show("Rejects Have Been Saved", "Rejects Saved");
        }
    }
}
