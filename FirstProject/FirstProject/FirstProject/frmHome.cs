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

namespace FirstProject
{
    public partial class frmHome : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Clients.getClients(ds).Tables["ss"];

            txtNextClientID.Text = Clients.getNextClientID().ToString("00000"); //00000 is a mask
        }

        private void rdoForename_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String source;

            if(rdoForename.Checked)
            {
                source = "Forename";
            }
            else
            {
                source = "Client_ID";
            }

           grdData.DataSource = Clients.getClients(ds, source).Tables["ss"];
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            //Clients newClient = new Clients(txtNextClientID, txtSurname, txtSurname, txtForename, txtStreet, txtTown, txtCounty);

        }
    }
}
