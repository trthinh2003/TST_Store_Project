using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketnoi
{
    public class Ham
    {
        public void KetNoi(ref SqlConnection conn)
        {
            string strConn = "Server=DESKTOP-1SJVE2K; Database=QL_CuaHangVatTuNongNghiep; Integrated Security=true";
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void HienThiDg(SqlConnection conn, string query, DataGridView dg)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "name");
            dg.DataSource = ds;
            dg.DataMember = "name";
        }
    }
}
