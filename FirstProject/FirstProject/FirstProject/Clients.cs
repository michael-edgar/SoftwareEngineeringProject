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

            String strSQL = "SELECT * FROM Clients ORDER BY client_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }
        
        public static DataSet getClients(DataSet ds, String SOrder)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Clients ORDER BY " +SOrder;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static int getNextClientID()
        {
            int nextClientID;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(Client_ID) FROM Clients";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if(dr.IsDBNull(0))
            {
                nextClientID = 1;
            }
            else
            {
                nextClientID = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            conn.Close();

            return nextClientID;
        }
    }
}
