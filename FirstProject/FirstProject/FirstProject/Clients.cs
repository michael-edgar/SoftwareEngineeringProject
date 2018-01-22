using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace FirstProject
{
    class Clients
    {
        private int clientID;
        private String surname;
        private String forename;

        public Clients()
        {
            clientID = 0;
            surname = "unknown";
            forename = "unknown";
        }

        public static DataSet getClients(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Client ORDER BY clientID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }
    }
}
