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
    public partial class frmTrackRejectCost : Form
    {
        frmMainMenu parent;
        public frmTrackRejectCost(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnCalculateRejectCost_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtCost.Visible = true;
            txtCost.Text = "2000";
        }
    }
}
