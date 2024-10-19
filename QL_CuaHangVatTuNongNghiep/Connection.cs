using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangVatTuNongNghiep
{
    public class Connection
    {
        public static string strConn = "Server = DESKTOP-1SJVE2K; Database = QL_CuaHangVatTuNongNghiep; " +
            "Integrated Security = true";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConn);
        }
    }
}
