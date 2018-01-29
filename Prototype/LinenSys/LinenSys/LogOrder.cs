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
        public frmLogOrder(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //add some dummy customers
            grdCustomers.Rows.Add("0254","WALSH","ADAM","0871234567");
            grdCustomers.Rows.Add("0114", "WALSH", "JOHN", "0871232227");
            grdCustomers.Rows.Add("0202", "WILSON", "ANN", "0871244467");
            grdCustomers.Rows.Add("0017", "WOODS", "KEN", "0872222267");

            //display customers
            grdCustomers.Visible = true;
        }

        private void grdCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //display selected customer
            grpCustomer.Visible = true;
            txtCustomerID.Text = "114";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstItems.Items.Add(cboLinen.Text+ "       " +txtQty.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lstItems.Items.RemoveAt(lstItems.SelectedIndex);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been made", "Completed Order");
        }
    }
}
