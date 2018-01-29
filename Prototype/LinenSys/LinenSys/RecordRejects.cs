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
    public partial class frmRecordRejects : Form
    {
        frmMainMenu parent;
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

        private void btnRecordRejects_Click(object sender, EventArgs e)
        {
            //add some dummy customers
            grdOrders.Rows.Add("0254", "BATH MAT", "24", "23.00");
            grdOrders.Rows.Add("0254", "BATH SHEET", "32", "44.00");
            grdOrders.Rows.Add("0254", "HAND TOWEL", "44", "56.10");
            grdOrders.Rows.Add("0254", "KING DUVET", "11", "67.00");

            //display customers
            grdOrders.Visible = true;
        }

        private void btnSaveRejects_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rejects Have Been Saved", "Rejects Saved");
        }

        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            grpDetails.Visible = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            lstItems.Items.Add(cboLinen.Text + "       " + txtQty.Text);
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstItems.Items.RemoveAt(lstItems.SelectedIndex);
        }
    }
}
