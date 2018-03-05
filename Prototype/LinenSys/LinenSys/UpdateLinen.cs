using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    public partial class frmUpdateLinen : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        frmMainMenu parent;
        DataTable dt = new DataTable();
        int numberOfItems = 0;


        public frmUpdateLinen(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnGetLinen_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            cboLinenNames.Items.Clear();

            //MessageBox.Show(cboLinenNames.SelectedIndex.ToString());

            txtLinenName.Clear();
            txtHirePrice.Clear();
            txtCleaningPrice.Clear();
            txtRejectPrice.Clear();
            txtPackSize.Clear();

            for(int i = 0; i < numberOfItems; i++)
            {
                cboLinenNames.Items.Remove(i);
                MessageBox.Show("hi");
            }

            if (txtLinenCode.Text.Equals(""))
            {
                MessageBox.Show("Linen Name must be entered", "Error");
                txtLinenCode.Focus();
                return;

            }
            
            dt = Linen.getMatchingNames(dt, txtLinenCode.Text.ToUpper());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i]["LINEN_STATUS"].ToString().Equals("A"))
                {
                    cboLinenNames.Items.Add(dt.Rows[i]["LINEN_NAME"]);
                }
            }

            if (cboLinenNames.Items.Count == 0)
            {
                MessageBox.Show("No active linen matching linen code was found, please re-enter");
                txtLinenCode.Focus();
                return;
            }

            cboLinenNames.Visible = true;
            numberOfItems = cboLinenNames.Items.Count;
            MessageBox.Show(numberOfItems + "");

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

            foreach (char item in txtLinenName.Text)
            {
                if (char.IsDigit(item))
                {
                    MessageBox.Show("Linen Name must only contain letters", "Error");
                    txtLinenName.Focus();
                    return;
                }
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
                Linen updatedLinen = new Linen();

                if(!txtLinenName.Text.Equals(""))
                {
                    updatedLinen.setLinen_name(txtLinenName.Text);
                }
                if (!txtHirePrice.Text.Equals(""))
                {
                    updatedLinen.setHire_price(Convert.ToDouble(txtHirePrice.Text));
                }
                if (!txtCleaningPrice.Text.Equals(""))
                {
                    updatedLinen.setCleaning_price(Convert.ToDouble(txtCleaningPrice.Text));
                }
                if (!txtRejectPrice.Text.Equals(""))
                {
                    updatedLinen.setReject_price(Convert.ToDouble(txtRejectPrice.Text));
                }
                if (!txtPackSize.Text.Equals(""))
                {
                    updatedLinen.setPack_size(Convert.ToInt32(txtPackSize.Text));
                }

                updatedLinen.updateLinen();

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
            //MessageBox.Show(cboLinenNames.Items.Count + "");
            
            txtLinenName.Text = dt.Rows[Convert.ToInt32(cboLinenNames.SelectedIndex)]["LINEN_NAME"].ToString();
            txtHirePrice.Text = dt.Rows[Convert.ToInt32(cboLinenNames.SelectedIndex)]["HIRE_PRICE"].ToString();
            txtCleaningPrice.Text = dt.Rows[Convert.ToInt32(cboLinenNames.SelectedIndex)]["CLEANING_PRICE"].ToString();
            txtRejectPrice.Text = dt.Rows[Convert.ToInt32(cboLinenNames.SelectedIndex)]["REJECT_PRICE"].ToString();
            txtPackSize.Text = dt.Rows[Convert.ToInt32(cboLinenNames.SelectedIndex)]["PACK_SIZE"].ToString();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmUpdateLinen_Load(object sender, EventArgs e){
        }
    }
}
