using System;
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
            DateTime thisYear = DateTime.UtcNow;
            String year = thisYear.ToString("yy");
            int currentYear = Convert.ToInt32(year);
            txtCost.Text = (Rejects.getRejectCost(currentYear)).ToString();
            lblTotalCost.Visible = true;
            txtCost.Visible = true;
        }
    }
}
