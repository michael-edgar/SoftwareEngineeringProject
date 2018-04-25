﻿using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    class OrderItem
    {
        private int orderItem;
        private double linenAmount;
        private String linenCode;
        private int orderID;
        private double price;

        public OrderItem()
        {
            setOrderItem(000000);
            setLinenAmount(0.00f);
            setLinenCode("NA");
            setOrderID(000000);
            setPrice(00.00);
        }

        public OrderItem(int orderItem, double linenAmount, String linenCode, int OrderID, double price)
        {
            setOrderItem(orderItem);
            setLinenAmount(linenAmount);
            setLinenCode(linenCode);
            setOrderID(orderID);
            setPrice(price);
        }

        public void setOrderItem(int orderItem)
        {
            this.orderItem = orderItem;
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

        public static DataSet getOrderItem(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM OrderItem ORDER BY Order_Item";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static DataSet getOrderItem(DataSet ds, String SOrder)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM OrderItem ORDER BY " + SOrder;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static int getNextOrderItem()
        {
            int nextOrderItem;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(Order_Item) FROM OrderItem";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextOrderItem = 1;
            }
            else
            {
                nextOrderItem = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            conn.Close();

            return nextOrderItem;
        }

        public static Boolean alreadyExists(string Code)
        {
            Boolean answer = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM OrderItem WHERE Order_Item = '" + Code + "'";
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

            String strSQL = "SELECT * FROM OrderItem WHERE Order_Item LIKE '%" + code + "%'";
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

            String strSQL = "INSERT INTO OrderItem VALUES(" +this.orderItem+", "+this.linenAmount+",'"+this.linenCode+"'," +this.orderID+", "+this.price+")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        /*public void updateLinen()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Linen SET Linen_Name = '" + this.companyName.ToString() + "', Hire_Price = " +
                this.contactNo + ", Cleaning_Price = " + this.customerName + ", Reject_Price = " +
                this.email + ", Pack_Size = " + this.street + " WHERE Linen_Code = '" + this.customerID.ToString() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void removeLinen()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Linen SET Linen_Status = 'I' WHERE Linen_Code = '" + this.customerID.ToString() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }*/
    }
}
