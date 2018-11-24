using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace DAO_QLRV
{
    public class DAO_ThanhVien : DBconnect
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(connectstring);
        }

        public DataTable getTable(string sql)
        {
            SqlConnection con = getConnect();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);

            return dt;
        }
        public bool ExcuteNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);

           if (cmd.ExecuteNonQuery()>0)
            {
                return true;
            }
            cmd.Dispose();
            con.Close();
            return false;
        }
    }
}
