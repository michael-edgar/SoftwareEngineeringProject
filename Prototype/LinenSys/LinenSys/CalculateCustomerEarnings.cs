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
    public partial class frmCalculateCustomerEarnings : Form
    {
        frmMainMenu parent;
        public frmCalculateCustomerEarnings(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnCalculateEarnings_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtEarnings.Visible = true;
            txtEarnings.Text = "200";
        }
    }
}
