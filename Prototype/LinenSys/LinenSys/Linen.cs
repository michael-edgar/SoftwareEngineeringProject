using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LinenSys
{
    class Linen
    {
        private String linen_code;
        private String linen_name;
        private float hire_price;
        private float cleaning_price;
        private float reject_price;
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
            setLinen_status('N');
        }

        public Linen(String linen_code, String linen_name, float hire_price, float cleaning_price,
                     float reject_price, int pack_size, char linen_status)
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

        public void setHire_price(float hire_price)
        {
            this.hire_price = hire_price;
        }

        public void setCleaning_price(float cleaning_price)
        {
            this.cleaning_price = cleaning_price;
        }

        public void setReject_price(float reject_price)
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

        public float getHire_price()
        {
            return hire_price;
        }

        public float getCleaning_price()
        {
            return cleaning_price;
        }

        public float getReject_price()
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

            String strSQL = "SELECT * FROM Linen ORDER BY linen_name";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static DataSet getLinen(DataSet ds, String SOrder)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Linen ORDER BY " +SOrder;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public void regLinen()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "INSET INTO Linen VALUES(" + this.linen_code.ToString() +
                ",'" + this.linen_name + "'," + this.hire_price.ToString() + "," + this.cleaning_price.ToString() +
                "," + this.reject_price.ToString() + "," + this.pack_size.ToString() + ",'" + this.linen_status + "')";
        }
        public static Boolean alreadyExists(string Code)
        {
            Boolean answer = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Linen WHERE Linen_Code = '" + Code + "'";
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
