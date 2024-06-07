using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 
namespace DAO
{
    public class KetNoi
    {
        public static SqlConnection MoKetNoi()
        {
            string s = @"Data Source=vei-pc\vydang;Initial Catalog=QLKS;Integrated Security=True";
            SqlConnection KetNoi = new SqlConnection(s);
            KetNoi.Open();
            return KetNoi;
        }
        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection
        KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection
        KetNoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
        public static SqlConnection Dongketnoi()
        {
            string s = @"Data Source=vei-pc\vydang;Initial Catalog=QLKS;Integrated Security=True";
            SqlConnection Dongketnoi = new SqlConnection(s);
            Dongketnoi.Close();
            return Dongketnoi;
        }
        public static string GetValue(string query, SqlConnection KetNoi)
        {
            string temp = null;
            SqlCommand cm = new SqlCommand(query,KetNoi);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                temp = dr[0].ToString();
            }
            return temp;
        }
    }
}
