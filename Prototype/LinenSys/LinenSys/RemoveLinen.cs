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
    public partial class frmRemoveLinen : Form
    {
        frmMainMenu parent;
        public frmRemoveLinen(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnGetLinen_Click(object sender, EventArgs e)
        {
            String linenCode = txtLinenCode.Text;
            linenCode = linenCode.ToLower();
            cboLinenNames.Items.Clear();

            if (linenCode.Equals(""))
            {
                MessageBox.Show("Linen Name must be entered", "Error");
                txtLinenCode.Focus();
                return;
            }

            else if (linenCode.StartsWith("b"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("Bath Mat");
                cboLinenNames.Items.Add("Bath Sheet");
                return;
            }

            else if (linenCode.StartsWith("h"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("Hand Towel");
                return;
            }

            else if (linenCode.StartsWith("s"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("Single Sheet");
                cboLinenNames.Items.Add("Single Duvet");
                return;
            }

            else if (linenCode.StartsWith("k"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("King Sheet");
                cboLinenNames.Items.Add("King Duvet");
                return;
            }

            else if (linenCode.StartsWith("p"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("Pillow Slip");
                return;
            }

            else
            {
                MessageBox.Show("No active linen matching linen code was found, please re-enter");
                txtLinenCode.Focus();
                return;
            }
        }

        private void btnRemoveLinen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected linen has been removed", "Removed");
            cboLinenNames.Items.Clear();
            txtLinenCode.Clear();
            return;
        }
    }
}
