using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection con;
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = @"\QLKS(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = @"USE [master];
            BACKUP DATABASE QLKS TO DISK = N'" + sDuongDan +
            sTen + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sql, con);
            return kq;

        }
        public static bool PhucHoiDuLieu(string sDuongDan)
        {
            //string sql = @"USE [master];
            // RESTORE DATABASE QLNV FROM DISK = N'"+ sDuongDan+"' WITH REPLACE";
            string sql = @"USE master ALTER DATABASE QLKS SET SINGLE_USER WITH ROLLBACK IMMEDIATE  RESTORE DATABASE QLKS FROM disk = N'" + sDuongDan + "' WITH REPLACE ";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}
