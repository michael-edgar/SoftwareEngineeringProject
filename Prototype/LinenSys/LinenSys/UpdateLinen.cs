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
    public partial class frmUpdateLinen : Form
    {
        frmMainMenu parent;
        public frmUpdateLinen(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
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

        private void btnUpdateLinen_Click(object sender, EventArgs e)
        {
            //validate data
            float check;
            int checkInt;

            if (txtLinenName.Text.Equals("") && txtHirePrice.Text.Equals("") && txtCleaningPrice.Text.Equals("") && txtRejectPrice.Text.Equals("") && txtPackSize.Text.Equals(""))
            {
                MessageBox.Show("At least one field must be entered", "Error");
                txtLinenName.Focus();
                return;
            }

            if (!float.TryParse(txtHirePrice.Text, out check))
            {
                MessageBox.Show("Hire Price must be numeric", "Error");
                txtHirePrice.Focus();
                return;
            }

            if (!float.TryParse(txtCleaningPrice.Text, out check))
            {
                MessageBox.Show("Cleaning Price must be numeric", "Error");
                txtCleaningPrice.Focus();
                return;
            }

            if (!float.TryParse(txtRejectPrice.Text, out check))
            {
                MessageBox.Show("Reject Price must be numeric", "Error");
                txtRejectPrice.Focus();
                return;
            }

            if (!int.TryParse(txtPackSize.Text, out checkInt))
            {
                MessageBox.Show("Pack Size must be numeric", "Error");
                return;
            }

            else
            {
                String updateLinen;
                updateLinen = "\nLinen Name: " + txtLinenName.Text + "\nLinen Code: " + txtLinenCode.Text +
                             "\nHire Price: " + txtHirePrice.Text + "\nCleaning Price: " +
                             txtCleaningPrice.Text + "\nReject Price: " + txtRejectPrice.Text+ "\nPack Size: " +txtPackSize.Text;

                MessageBox.Show("The updated lined has been saved to the system." + updateLinen, "Update Linen");
                txtLinenName.Clear();
                txtLinenCode.Clear();
                txtHirePrice.Clear();
                txtCleaningPrice.Clear();
                txtRejectPrice.Clear();
                txtPackSize.Clear();
                return;
            }
        }

        private void cboLinenNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpLinen.Visible = true;

            if(cboLinenNames.SelectedItem.ToString().Equals("Hand Towel"))
            {
                txtLinenName.Text = "Hand Towel";
                txtHirePrice.Text = "2.00";
                txtCleaningPrice.Text = "1.50";
                txtRejectPrice.Text = "1.75";
                txtPackSize.Text = "10";
            }
            else if(cboLinenNames.SelectedItem.ToString().Equals("Bath Sheet"))
            {
                txtLinenName.Text = "Bath Sheet";
                txtHirePrice.Text = "2.50";
                txtCleaningPrice.Text = "2.00";
                txtRejectPrice.Text = "2.25";
                txtPackSize.Text = "10";
            }
            else if(cboLinenNames.SelectedItem.ToString().Equals("Bath Mat"))
            {
                txtLinenName.Text = "Bath Mat";
                txtHirePrice.Text = "2.25";
                txtCleaningPrice.Text = "1.75";
                txtRejectPrice.Text = "2.00";
                txtPackSize.Text = "10";
            }
            else if(cboLinenNames.SelectedItem.ToString().Equals("Single Sheet"))
            {
                txtLinenName.Text = "Single Sheet";
                txtHirePrice.Text = "1.75";
                txtCleaningPrice.Text = "1.25";
                txtRejectPrice.Text = "1.50";
                txtPackSize.Text = "10";
            }
            else if(cboLinenNames.SelectedItem.ToString().Equals("Single Duvet"))
            {
                txtLinenName.Text = "Single Duvet";
                txtHirePrice.Text = "2.00";
                txtCleaningPrice.Text = "1.50";
                txtRejectPrice.Text = "1.75";
                txtPackSize.Text = "10";
            }
            else if(cboLinenNames.SelectedItem.ToString().Equals("King Sheet"))
            {
                txtLinenName.Text = "King Sheet";
                txtHirePrice.Text = "3.00";
                txtCleaningPrice.Text = "2.50";
                txtRejectPrice.Text = "2.75";
                txtPackSize.Text = "5";
            }
            else if(cboLinenNames.SelectedItem.ToString().Equals("King Duvet"))
            {
                txtLinenName.Text = "King Duvet";
                txtHirePrice.Text = "3.50";
                txtCleaningPrice.Text = "3.00";
                txtRejectPrice.Text = "3.25";
                txtPackSize.Text = "5";
            }
            else if(cboLinenNames.SelectedItem.ToString().Equals("Pillow Slip"))
            {
                txtLinenName.Text = "Pillow Slip";
                txtHirePrice.Text = "1.50";
                txtCleaningPrice.Text = "1.00";
                txtRejectPrice.Text = "1.25";
                txtPackSize.Text = "50";
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
