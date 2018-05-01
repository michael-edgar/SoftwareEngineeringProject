using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    class Orders
    {
        private int orderID;
        private String orderDate;
        private String deliveryDate;
        private char orderStatus;
        private char orderType;
        private int customerID;
        private double totalPrice;

        public Orders()
        {
            setOrderID(000000);
            setOrderDate("00/00/0000");
            setDeliveryDate("00/00/0000");
            setOrderStatus('N');
            setOrderType('N');
            setCustomerID(000000);
            setTotalPrice(00.00);
        }

        public Orders(int orderID, String orderDate, String deliveryDate, char orderStatus, char orderType, int customerID, double totalePrice)
        {
            setOrderID(orderID);
            setOrderDate(orderDate);
            setDeliveryDate(deliveryDate);
            setOrderStatus(orderStatus);
            setOrderType(orderType);
            setCustomerID(customerID);
            setTotalPrice(totalePrice);
        }

        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }

        public void setOrderDate(string orderDate)
        {
            this.orderDate = orderDate;
        }

        public void setDeliveryDate(string deliveryDate)
        {
            this.deliveryDate = deliveryDate;
        }

        public void setOrderStatus(char orderStatus)
        {
            this.orderStatus = orderStatus;
        }

        public void setOrderType(char orderType)
        {
            this.orderType = orderType;
        }

        public void setCustomerID(int customerID)
        {
            this.customerID = customerID;
        }

        public void setTotalPrice(double totalPrice)
        {
            this.totalPrice = totalPrice;
        }

        public int getOrderID()
        {
            return this.orderID;
        }

        public static double getOrdersInAYear(int year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT SUM(total_Price) FROM Orders WHERE Order_Date LIKE '%"+year+"'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader da = cmd.ExecuteReader();

            da.Read();
            double total = Convert.ToDouble(da.GetValue(0));
            conn.Close();

            return total;
        }

        public static double getOrdersFromACustomer(int customerID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT SUM(total_Price) FROM Orders WHERE Customer_ID LIKE '%" + customerID + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader da = cmd.ExecuteReader();
            double total;

            da.Read();

            if (da.IsDBNull(0))
            {
                total = -1;
            }
            else
            {
                total = Convert.ToDouble(da.GetValue(0));
            }
            
            conn.Close();

            return total;
        }

        public static DataTable getOrders(DataTable ds, String SOrder, String code)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Orders WHERE " + SOrder+ "LIKE '%" +code+ "%' AND Order_Status = 'P'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds);

            conn.Close();

            return ds;
        }

        public static Orders getMatchingOrder(String code)
        {
            Orders newOrder = new Orders();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Orders WHERE Order_ID LIKE '%" + code + "%' ABD Order_Status = 'P'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            newOrder.setOrderID(Convert.ToInt32(dr.GetValue(0)));
            newOrder.setOrderDate(Convert.ToString(Convert.ToDateTime(dr.GetValue(1)).Date));
            newOrder.setDeliveryDate(Convert.ToString(dr.GetValue(2)));
            newOrder.setOrderStatus(Convert.ToChar(dr.GetValue(3)));
            newOrder.setOrderType(Convert.ToChar(dr.GetValue(4)));
            newOrder.setCustomerID(Convert.ToChar(dr.GetValue(5)));
            newOrder.setTotalPrice(Math.Round(Convert.ToDouble(dr.GetValue(6)), 2));

            conn.Close();

            return newOrder;
        }

        public static DataTable getMatchingNames(DataTable ds, String code)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Orders WHERE Order_ID LIKE '%" + code + "%' AND Order_Status = 'P'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds);

            conn.Close();

            return ds;
        }

        public static int getNextOrderID()
        {
            int nextOrderID;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(Order_ID) FROM Orders";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextOrderID = 1;
            }
            else
            {
                nextOrderID = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            conn.Close();

            return nextOrderID;
        }

        public void regOrders()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "INSERT INTO Orders VALUES(" +this.orderID+ ", '" + this.orderDate + "', '" +
                                                            this.deliveryDate + "', '" + this.orderStatus + "', '" +
                                                            this.orderType+ "', "+this.customerID+", " +this.totalPrice+")";
            
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void cancelOrder()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Orders SET Order_Status = 'C' WHERE Order_ID = '" + this.orderID.ToString() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void deliverOrder()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Orders SET Order_Status = 'D', Delivery_Date = '"+this.deliveryDate.ToString()+"' WHERE Order_ID = '" + this.orderID.ToString() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
