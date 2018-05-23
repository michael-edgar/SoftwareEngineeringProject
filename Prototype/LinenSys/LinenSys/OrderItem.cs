using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    class OrderItem
    {
        private int orderID;
        private String linenCode;
        private double linenAmount;
        private double price;
        private char itemStatus;

        public OrderItem()
        {
            setLinenAmount(0.00f);
            setLinenCode("NA");
            setOrderID(000000);
            setPrice(00.00);
            setItemStatus('A');
        }

        public void setLinenAmount(double linenAmount)
        {
            this.linenAmount = linenAmount;
        }

        public void setLinenCode(string linenCode)
        {
            this.linenCode = linenCode;
        }

        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setItemStatus(char itemStatus)
        {
            this.itemStatus = itemStatus;
        }

        public static DataTable getItemsAndAmount(DataTable ds, String code)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT Linen_Code, Linen_Amount FROM OrderItem WHERE Order_ID = '" + code + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds);

            conn.Close();

            return ds;
        }

        public void regOrderItem()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "INSERT INTO OrderItem VALUES("+this.orderID+",'"+this.linenCode+"'," +this.linenAmount+", "+this.price+", 'A')";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void cancelOrderItem()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE OrderItem SET ItemStatus = 'C' WHERE Order_ID = '" + this.orderID.ToString() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void deliverOrderItems()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE OrderItem SET ItemStatus = 'D' WHERE Order_ID = '" + this.orderID.ToString() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
