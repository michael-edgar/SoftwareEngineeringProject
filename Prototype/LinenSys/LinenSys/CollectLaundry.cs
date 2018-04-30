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

            if(grdCustomers.Rows.Count == 0)
            {
                MessageBox.Show("No active customers matching customer ID was found, please re-enter");
                txtCustomerID.Focus();
                return;
            }

            //display customers
            grdCustomers.Visible = true;
        }
    }
}
