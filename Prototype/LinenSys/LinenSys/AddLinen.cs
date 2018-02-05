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
    public partial class frmAddLinen : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        frmMainMenu parent;

        public frmAddLinen(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddLinen_Load(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
        }

        private void btnAddLinen_Click(object sender, EventArgs e)
        {
            //validate data
            float check;
            int checkInt;

            if (txtLinenName.Text.Equals(""))
            {
                MessageBox.Show("Linen Name must be entered", "Error");
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

            if (txtLinenCode.Text.Equals(""))
            {
                MessageBox.Show("Linen Code must be entered", "Error");
                txtLinenName.Focus();
                return;
            }

            foreach (char item in txtLinenCode.Text)
            {
                if (char.IsDigit(item))
                {
                    MessageBox.Show("Linen Code must only contain letters", "Error");
                    txtLinenName.Focus();
                    return;
                }
            }
      
            if (Linen.alreadyExists(txtLinenCode.Text))
            {
                MessageBox.Show("alrady exists");
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
                txtPackSize.Focus();
                return;
            }

            else
            {
                Linen newLinen = new Linen();

                newLinen.setLinen_code(txtLinenCode.Text);
                newLinen.setLinen_name(txtLinenName.Text);
                newLinen.setHire_price(Convert.ToDouble(txtHirePrice.Text));
                newLinen.setCleaning_price(Convert.ToDouble(txtCleaningPrice.Text));
                newLinen.setReject_price(Convert.ToDouble(txtRejectPrice.Text));
                newLinen.setPack_size(Convert.ToInt32(txtPackSize.Text));

                newLinen.regLinen();

                String addedLinen;
                addedLinen = "\nLinen Name: " + txtLinenName.Text + "\nLinen Code: " + txtLinenCode.Text + 
                             "\nHire Price: " + txtHirePrice.Text + "\nCleaning Price: " + 
                             txtCleaningPrice.Text + "\nReject Price: " + txtRejectPrice.Text+ "\nPack Size: " +txtPackSize.Text;

                MessageBox.Show("The new Linen has been added to the system." +addedLinen , "Added Linen");

                txtLinenName.Clear();
                txtLinenCode.Clear();
                txtHirePrice.Clear();
                txtCleaningPrice.Clear();
                txtRejectPrice.Clear();
                txtPackSize.Clear();
                return;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
