using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS2
{
    class kn
    {
        // chuỗi kết nối csdl
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4IK6CM8;Initial Catalog=QLKS;Integrated Security=True");
        
        // lấy dữ liệu từ các table
        public static DataTable LayBang(String sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable kq = new DataTable();
            da.Fill(kq);

            con.Close();
            return kq;
        }

        // Thay đổi dữ liệu các table
        public static void ThayDoiDL(String sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        // kiểm tra khóa
        public static bool Check_Key(String sql, String key)
        {
            bool ok = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read() && (data.GetString(0).ToUpper() == key.ToUpper()))
                    ok = true;
                con.Close();
            }
            catch (Exception) { MessageBox.Show("error key!!!"); }
            return ok;
        }
    }
}
