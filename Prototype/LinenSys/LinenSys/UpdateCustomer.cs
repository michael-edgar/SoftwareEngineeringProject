using System;
using System.Data;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmUpdateCustomer : Form
    {
        frmMainMenu parent;
        DataTable dt = new DataTable();

        public frmUpdateCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            grpCustomer.Visible = false;
            cboCompanyNames.Visible = false;

            if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Customer ID must be entered", "Error");
                txtCustomerID.Focus();
                return;
            }

            cboCompanyNames.Items.Clear();
            dt.Clear();

            dt = Customer.getMatchingNames(dt, txtCustomerID.Text.ToUpper());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["CUSTOMER_STATUS"].ToString().Equals("A"))
                {
                    cboCompanyNames.Items.Add(dt.Rows[i]["COMPANY_NAME"].ToString().Trim());
                }
            }

            if (cboCompanyNames.Items.Count == 0)
            {
                MessageBox.Show("No active customers matching customer ID was found, please re-enter");
                txtCustomerID.Focus();
                return;
            }

            lblCompanyNames.Visible = true;
            cboCompanyNames.Visible = true;
        }

        private void cboCompanyNames_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            grpCustomer.Visible = true;

            txtCustomerIDDisplay.Text = String.Format("{0:000000}", dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["CUSTOMER_ID"]);
            txtCompanyName.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["COMPANY_NAME"].ToString().Trim();
            txtCustomerName.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["CUSTOMER_NAME"].ToString().Trim();
            txtEmail.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["EMAIL"].ToString().Trim();
            txtContactNumber.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["CONTACT_NUMBER"].ToString().Trim();
            txtStreet.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["STREET"].ToString().Trim();
            txtTown.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["TOWN"].ToString().Trim();
            txtCounty.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["COUNTY"].ToString().Trim();
            txtEircode.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["EIRCODE"].ToString().Trim();
            txtRejects.Text = dt.Rows[Convert.ToInt32(cboCompanyNames.SelectedIndex)]["REJECTS"].ToString().Trim();
        }

        private void btnUpdateCustomer_Click_1(object sender, EventArgs e)
        {
            //validate data
            if (txtCompanyName.Text.Equals(""))
            {
                MessageBox.Show("Company Name must be entered", "Error");
                txtCompanyName.Focus();
                return;
            }

            foreach (char item in txtCompanyName.Text)
            {
                if (!char.IsLetter(item) && item != ' ')
                {
                    MessageBox.Show("Company Name must only contain letters", "Error");
                    txtCompanyName.Focus();
                    return;
                }
            }

            if (txtCustomerName.Text.Equals(""))
            {
                MessageBox.Show("Customer Name must be entered", "Error");
                txtCustomerName.Focus();
                return;
            }

            foreach (char item in txtCustomerName.Text)
            {
                if (!char.IsLetter(item) && item != ' ')
                {
                    MessageBox.Show("Customer Name must only contain letters", "Error");
                    txtCustomerName.Focus();
                    return;
                }
            }

            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error");
                txtEmail.Focus();
                return;
            }

            foreach (char item in txtEmail.Text)
            {
                if (!char.IsLetter(item) && item != ' ' && item != '.' && item != '@')
                {
                    MessageBox.Show("Email must only contain letters", "Error");
                    txtEmail.Focus();
                    return;
                }
            }

            if (txtContactNumber.Text.Equals(""))
            {
                MessageBox.Show("Contact Number must be entered", "Error");
                txtContactNumber.Focus();
                return;
            }

            foreach (char item in txtContactNumber.Text)
            {
                if (!char.IsDigit(item) && item != ' ')
                {
                    MessageBox.Show("Contact Number must only contain letters", "Error");
                    txtContactNumber.Focus();
                    return;
                }
            }

            if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("Street must be entered", "Error");
                txtStreet.Focus();
                return;
            }

            foreach (char item in txtStreet.Text)
            {
                if (!char.IsLetter(item) && item != ' ')
                {
                    MessageBox.Show("Street must only contain letters", "Error");
                    txtEmail.Focus();
                    return;
                }
            }

            if (txtTown.Text.Equals(""))
            {
                MessageBox.Show("Town must be entered", "Error");
                txtTown.Focus();
                return;
            }

            foreach (char item in txtTown.Text)
            {
                if (!char.IsLetter(item) && item != ' ')
                {
                    MessageBox.Show("Town must only contain letters", "Error");
                    txtTown.Focus();
                    return;
                }
            }

            if (txtCounty.Text.Equals(""))
            {
                MessageBox.Show("County must be entered", "Error");
                txtCounty.Focus();
                return;
            }

            foreach (char item in txtCounty.Text)
            {
                if (!char.IsLetter(item) && item != ' ')
                {
                    MessageBox.Show("County must only contain letters", "Error");
                    txtCounty.Focus();
                    return;
                }
            }

            if (txtEircode.Text.Equals(""))
            {
                MessageBox.Show("Eircode must be entered", "Error");
                txtEircode.Focus();
                return;
            }

            int count = 0;

            foreach (char item in txtEircode.Text)
            {
                if (count == 3 && item != ' ')
                {
                    MessageBox.Show("Invalid Eircode, Eircode must be in the form XXX XXXX where X is a letter or number other than O(the letter)" + count, "Error");
                    txtEircode.Focus();
                    count = 0;
                    return;
                }

                else if (count != 3 && ((!char.IsLetter(item) && !char.IsDigit(item)) || (item == 'O' || item == 'o')))
                {
                    MessageBox.Show("Invalid Eircode, Eircode must be in the form XXX XXXX where X is a letter or number other than O(the letter)" + count, "Error");
                    txtEircode.Focus();
                    count = 0;
                    return;
                }

                count++;
            }

            if (!float.TryParse(txtRejects.Text, out float check))
            {
                MessageBox.Show("Rejects must be numeric", "Error");
                txtRejects.Focus();
                return;
            }

            else
            {
                Customer newCustomer = new Customer();
                int customerID = Convert.ToInt32(txtCustomerIDDisplay.Text);

                newCustomer.setCustomerID(customerID);
                newCustomer.setCompanyName(txtCompanyName.Text);
                newCustomer.setCustomerName(txtCustomerName.Text);
                newCustomer.setEmail(txtEmail.Text);
                newCustomer.setContactNo(txtContactNumber.Text);
                newCustomer.setStreet(txtStreet.Text);
                newCustomer.setTown(txtTown.Text);
                newCustomer.setCounty(txtCounty.Text);
                newCustomer.setEircode(txtEircode.Text.ToUpper());
                newCustomer.setRejects(Convert.ToDouble(txtRejects.Text));

                newCustomer.updateCustomer();

                String updatedCustomer;
                updatedCustomer = "Customer ID: " + newCustomer.getCustomerID() + "\nCompany Name: " + newCustomer.getCompanyName() +
                                "\nCustomer Name: " + newCustomer.getCustomerName() + "\nEmail: " + newCustomer.getEmail() + "\nContact Number: " +
                                newCustomer.getContactNumber() + "Street: " + newCustomer.getStreet() + "Town: " + newCustomer.getTown() + "County: " +
                                newCustomer.getCounty() + "Eircode: " + newCustomer.getEircode() + "Status: " + newCustomer.getCustomerStatus() +
                                "Rejects: " + newCustomer.getRejects();

                MessageBox.Show("Customer updated in the system", "Added Customer");
                txtCompanyName.Clear();
                txtContactNumber.Clear();
                txtCounty.Clear();
                txtCustomerName.Clear();
                txtEircode.Clear();
                txtEmail.Clear();
                txtStreet.Clear();
                txtTown.Clear();
                txtRejects.Clear();
                grpCustomer.Visible = false;
                lblCompanyNames.Visible = false;
                cboCompanyNames.Visible = false;
                return;
            }
        }
    }
}
