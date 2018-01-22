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

            //grdData.DataSource = Clients.getClient(ds).Tables["ss"];
        }
    }
}
