using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhThuDTO
    {
        private int thang;
        private double tongtien;
        private int sohoadon;
        private int nam;
        public int Thang { get => thang; set => thang = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
        public int Sohoadon { get => sohoadon; set => sohoadon = value; }
        public int Nam { get => nam; set => nam = value; }
    }
}
