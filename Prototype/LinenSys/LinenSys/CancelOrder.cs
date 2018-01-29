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
            grdOrders.Rows.Add("0254", "BATH MAT", "10", "21.50");
            grdOrders.Rows.Add("0114", "BATH SHEET", "14", "22.00");
            grdOrders.Rows.Add("0202", "HAND TOWEL", "20", "20.00");
            grdOrders.Rows.Add("0017", "PILLOW SLIP", "5", "25.50");
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
