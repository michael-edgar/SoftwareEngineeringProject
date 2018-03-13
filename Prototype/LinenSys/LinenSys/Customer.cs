using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    class Customer
    {
        private int customerID;
        private String companyName;
        private String contactNo;
        private String customerName;
        private String email;
        private String street;
        private String town;
        private String county;
        private String eircode;
        private char customerStatus;
        private double rejects;

        public Customer()
        {
            setCustomerID(000000);
            setCompanyName("Not Given");
            setContactNo("Not Given");
            setCustomerName("Not Given");
            setEmail("Not Given");
            setStreet("Not Given");
            setTown("Not Given");
            setCounty("Not Given");
            setEircode("Not Given");
            setCustomerStatus("A");
            setRejects(0.00f);
        }

        public Customer(int customerID, String companyName, String contactNo, String customerName, 
                        String email, String street, String town, String county, 
                        String eircode, char customerStatus, double rejects)
        {
            setCustomerID(customerID);
            setCompanyName(companyName);
            setContactNo(contactNo);
            setCustomerName(customerName);
            setEmail(email);
            setStreet(street);
            setTown(town);
            setCounty(county);
            setEircode(eircode);
            setCustomerStatus(customerStatus);
            setRejects(rejects);
        }

        private void setCustomerID(int customerID)
        {
            this.customerID = customerID;
        }

        private void setCompanyName(string companyName)
        {
            this.companyName = companyName;
        }

        private void setContactNo(string contactNo)
        {
            this.contactNo = contactNo;
        }

        private void setCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        private void setEmail(string email)
        {
            this.email = email;
        }

        private void setStreet(string street)
        {
            this.street = street;
        }

        private void setTown(string town)
        {
            this.town = town;
        }

        private void setCounty(string county)
        {
            this.county = county;
        }

        private void setEircode(string eircode)
        {
            this.eircode = eircode;
        }

        private void setCustomerStatus(char customerStatus)
        {
            this.customerStatus = customerStatus;
        }

        private void setRejects(double rejects)
        {
            this.rejects = rejects;
        }

        public static DataSet getCustomer(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Customer ORDER BY Company_name";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static DataSet getCustomer(DataSet ds, String SOrder)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Customer ORDER BY " + SOrder;
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

            String strSQL = "SELECT * FROM Customer WHERE Customer_ID = '" + Code + "'";
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

            String strSQL = "SELECT * FROM Customer WHERE Customer_ID LIKE '%" + code + "%'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds);

            conn.Close();

            return ds;
        }

        public void regCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "INSERT INTO Customer VALUES(" +this.customerID+ ",'" +this.companyName.ToString()+
                        "','" +this.contactNo.ToString()+ "','" +this.customerName.ToString()+ "','" +this.email.ToString()+
                        "','" +this.street.ToString()+ "','" +this.town.ToString()+ "','" +this.county.ToString()+ 
                        "','" +this.eircode.ToString()+ "','" +this.customerStatus.ToString()+ "'," +this.rejects+ ")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Customer SET Company_Name = '" +this.companyName.ToString()+ "', Contact_Number = '" +
                this.contactNo+ "', Customer_Name = '" +this.customerName.ToString()+ "', Email = '" +this.email.ToString()+
                "', Street = '" +this.street.ToString()+ "',Town = '" +this.town.ToString()+ "', County = '" +this.county.ToString()+
                "',Eircode = '" +this.eircode.ToString()+ "',Customer_Status = '" +this.customerStatus.ToString()+ "',Rejects = " +this.rejects+ 
                "WHERE Customer_ID = '" +this.customerID.ToString()+ "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void removeCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Customer SET Customer_Status = 'I' WHERE Customer_ID = '" +this.customerID.ToString()+ "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
