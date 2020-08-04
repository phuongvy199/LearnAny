using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ifshop.DAL
{
    public class clsNew
    {
        public clsNew()
        {
            SQLDB.SQLDB.ConnectionString = ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
        }
        public DataTable GetList()
        {
            SqlCommand conn = new SqlCommand("SELECT* FROM SANPHAM");
            conn.CommandType = CommandType.Text;
            return SQLDB.SQLDB.GetData(conn);

        }
        public void Insert (string MASP, string TENSP, string MALSP )
        {
            SqlCommand conn = new SqlCommand("INSERT INTO SANPHAM VALUES (@MASP,@TENSP,@MALSP)");
            conn.CommandType = CommandType.Text;
            conn.Parameters.AddWithValue("@MASP", MASP);
            conn.Parameters.AddWithValue("@TENSP", TENSP);
            conn.Parameters.AddWithValue("@MALSP", MALSP);
            SQLDB.SQLDB.ExcuteNoneQuery(conn);
        }
    }
}
