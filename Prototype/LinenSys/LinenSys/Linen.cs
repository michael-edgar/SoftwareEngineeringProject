using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    class Linen
    {
        private String linen_code;
        private String linen_name;
        private double hire_price;
        private double cleaning_price;
        private double reject_price;
        private int pack_size;
        private char linen_status;

        public Linen()
        {
            setLinen_code("NA");
            setLinen_name("No Linen Name Available");
            setHire_price(0);
            setCleaning_price(0);
            setReject_price(0);
            setPack_size(0);
            setLinen_status('A');
        }

        public Linen(String linen_code, String linen_name, double hire_price, double cleaning_price,
                     double reject_price, int pack_size, char linen_status)
        {
            setLinen_code(linen_code);
            setLinen_name(linen_name);
            setHire_price(hire_price);
            setCleaning_price(cleaning_price);
            setReject_price(reject_price);
            setPack_size(pack_size);
            setLinen_status(linen_status);
        }
        
        public void setLinen_code(String linen_code)
        {
            this.linen_code = linen_code;
        }

        public void setLinen_name(String linen_name)
        {
            this.linen_name = linen_name;
        }

        public void setHire_price(double hire_price)
        {
            this.hire_price = hire_price;
        }

        public void setCleaning_price(double cleaning_price)
        {
            this.cleaning_price = cleaning_price;
        }

        public void setReject_price(double reject_price)
        {
            this.reject_price = reject_price;
        }

        public void setPack_size(int pack_size)
        {
            this.pack_size = pack_size;
        }

        public void setLinen_status(char linen_status)
        {
            this.linen_status = linen_status;
        }

        public String getLinen_code()
        {
            return linen_code;
        }

        public String getLinen_name()
        {
            return linen_name;
        }

        public double getHire_price()
        {
            return hire_price;
        }

        public double getCleaning_price()
        {
            return cleaning_price;
        }

        public double getReject_price()
        {
            return reject_price;
        }

        public int getPack_size()
        {
            return pack_size;
        }

        public char getLinen_status()
        {
            return linen_status;
        }

        public static DataSet getLinen(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Linen WHERE Linen_Status = 'A' ORDER BY linen_name";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static double getPrice(String priceType, String linenName)
        {
            double price;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT "+priceType+" FROM Linen WHERE Linen_Name = '" +linenName+ "' AND Linen_Status = 'A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                price = -1;
            }
            else
            {
                price = Convert.ToDouble(dr.GetValue(0));
                price = Math.Round(price, 2);
            }

            conn.Close();

            return price;
        }

        public static DataTable getMatchingNames(DataTable ds, String code)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Linen WHERE Linen_Code LIKE '%" + code + "%' AND Linen_Status = 'A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds);

            conn.Close();

            return ds;
        }

        public void regLinen()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "INSERT INTO Linen VALUES('" + this.linen_code.ToString() +
                "','" + this.linen_name.ToString() + "'," + this.hire_price + "," + this.cleaning_price +
                "," + this.reject_price + "," + this.pack_size + ",'" + this.linen_status.ToString() + "')";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateLinen()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Linen SET Linen_Name = '" + this.linen_name.ToString() + "', Hire_Price = " +
                this.hire_price + ", Cleaning_Price = " + this.cleaning_price + ", Reject_Price = " +
                this.reject_price + ", Pack_Size = " + this.pack_size + " WHERE Linen_Code = '" + this.linen_code.ToString() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void removeLinen()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Linen SET Linen_Status = 'I' WHERE Linen_Code = '" + this.linen_code.ToString() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static Boolean alreadyExists(string Code)
        {
            Boolean answer = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Linen WHERE Linen_Code = '" + Code + "' AND Linen_Status = 'A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                answer = true;
            }

            conn.Close();
            return answer;
        }
    }
}
