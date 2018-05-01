using System;
using System.Data;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmCalculateEarnings : Form
    {
        frmMainMenu parent;
        public frmCalculateEarnings(frmMainMenu Parent)
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
            DateTime thisYear = DateTime.UtcNow;
            String year = thisYear.ToString("yy");
            int currentYear = Convert.ToInt32(year);
            txtEarnings.Text = (Orders.getOrdersInAYear(currentYear)).ToString();
            label1.Visible = true;
            txtEarnings.Visible = true;
        }
    }
}
