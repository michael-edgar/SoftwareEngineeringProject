using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    class Rejects
    {
        private int rejectID;
        private String rejectDate;
        private int rejectQty;
        private String linenCode;
        private int orderID;
        private double totalPrice;

        public Rejects()
        {
            setRejectID(000000);
            setRejectDate("00/00/0000");
            setRejectQty(0);
            setLinenCode("NA");
            setOrderID(000000);
            setTotalPrice(00.00);
        }

        public Rejects(int rejectID, String rejectDate, int rejectQty, String linenCode, int OrderID, double totalPrice)
        {
            setRejectID(rejectID);
            setRejectDate(rejectDate);
            setRejectQty(rejectQty);
            setLinenCode(linenCode);
            setOrderID(orderID);
            setTotalPrice(totalPrice);
        }

        public void setRejectID(int rejectID)
        {
            this.rejectID = rejectID;
        }

        public void setRejectDate(string rejectDate)
        {
            this.rejectDate = rejectDate;
        }

        public void setRejectQty(int rejectQty)
        {
            this.rejectQty = rejectQty;
        }

        public void setLinenCode(string linenCode)
        {
            this.linenCode = linenCode;
        }

        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }

        public void setTotalPrice(double totalPrice)
        {
            this.totalPrice = totalPrice;
        }

        public static DataSet getRejects(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Rejects ORDER BY Reject_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static DataSet getRejects(DataSet ds, String SOrder)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Rejects ORDER BY " + SOrder;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static Boolean alreadyExists(string Code)
        {
            Boolean answer = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Rejects WHERE Reject_ID = '" + Code + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                answer = true;
            }

            conn.Close();
            return answer;
        }

        public static DataTable getMatchingNames(DataTable ds, String code)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Rejects WHERE Reject_ID LIKE '%" + code + "%'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds);

            conn.Close();

            return ds;
        }

        public static int getNextRejectID()
        {
            int nextRejectID;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(Reject_ID) FROM Rejects";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextRejectID = 1;
            }
            else
            {
                nextRejectID = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            conn.Close();

            return nextRejectID;
        }

        public static double getRejectCost(int year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT SUM(Total_Price) FROM Rejects WHERE Reject_Date LIKE '%" + year + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader da = cmd.ExecuteReader();

            da.Read();
            double total = Convert.ToDouble(da.GetValue(0));
            conn.Close();

            return total;
        }

        public void regReject()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "INSERT INTO Rejects VALUES(" + this.rejectID +
                ",'" + this.rejectDate.ToString() + "'," + this.rejectQty + ",'" + this.linenCode +
                "'," + this.orderID+ ", "+this.totalPrice+")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
