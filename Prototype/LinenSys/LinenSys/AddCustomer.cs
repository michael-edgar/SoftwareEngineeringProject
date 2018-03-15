using System;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmAddCustomer : Form
    {
        frmMainMenu parent;

        public frmAddCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
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

            //Fix down here

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

            foreach (char item in txtEircode.Text)
            {
                if (!char.IsLetter(item) && item != ' ')
                {
                    MessageBox.Show("Eircode must only contain letters", "Error");
                    txtEircode.Focus();
                    return;
                }
            }

            if (txtEircode.Text == "Bob")
            {
                MessageBox.Show("Invalid Eircode", "Error");
                txtEircode.Focus();
                return;
            }

            else
            {
                Customer newCustomer = new Customer();
                int customerID = Convert.ToInt32(txtCustomerID.Text);

                newCustomer.setCustomerID(customerID);
                newCustomer.setCompanyName(txtCompanyName.Text);
                newCustomer.setCustomerName(txtCustomerName.Text);
                newCustomer.setEmail(txtEmail.Text);
                newCustomer.setContactNo(txtContactNumber.Text);
                newCustomer.setStreet(txtStreet.Text);
                newCustomer.setTown(txtTown.Text);
                newCustomer.setCounty(txtCounty.Text);
                newCustomer.setEircode(txtEircode.Text);

                newCustomer.regCustomer();

                String addedCustomer;
                addedCustomer = "Customer ID: " + newCustomer.getCustomerID() + "\nCompany Name: " + newCustomer.getCompanyName() +
                                "\nCustomer Name: " + newCustomer.getCustomerName() + "\nEmail: " + newCustomer.getEmail() + "\nContact Number: " +
                                newCustomer.getContactNumber() + "Street: " + newCustomer.getStreet() + "Town: " + newCustomer.getTown() + "County: " +
                                newCustomer.getCounty() + "Eircode: " + newCustomer.getEircode() + "Status: " + newCustomer.getCustomerStatus() +
                                "Rejects: " + newCustomer.getRejects();

                MessageBox.Show("Customer added to the system", "Added Customer");
                txtCompanyName.Clear();
                txtContactNumber.Clear();
                txtCounty.Clear();
                txtCustomerName.Clear();
                txtEircode.Clear();
                txtEmail.Clear();
                txtStreet.Clear();
                txtTown.Clear();

                return;
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = Customer.getNextCustomerID().ToString("000000");
        }
    }
}
