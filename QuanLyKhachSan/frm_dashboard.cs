using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Globalization;
using System.Windows.Media.Animation;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }
        private List<string> thang = new List<string>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_ngaygiohientai.Text = DateTime.Now.ToLongTimeString();
        }
        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Enabled = true;
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                Labels = thang
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh thu/Số hóa đơn",
                LabelFormatter = value => value.ToString("N2", new CultureInfo("vi-VN"))
            });
            dtpk_nam_ValueChanged(sender, e);
        }

        private void dtpk_nam_ValueChanged(object sender, EventArgs e)
        {
            int year = int.Parse(dtpk_nam.Text);
            List<DoanhThuDTO> doanhThuThangDTOs = HoaDon_BUS.LayDoanhThuHoaDon(year);
            double tongdoanhthuthang = 0;
            int tonghoadonthang = 0;
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<KhachHang_DTO> khachHang_DTOs = KhachHang_BUS.LayDSKhachHang();
            List<NhanVien_DTO> nhanVien_DTOs = NhanVien_BUS.LayDSNhanvien();
            LineSeries lineSeries = new LineSeries
            {
                Title = "Doanh thu",
                Values = new ChartValues<double>()
            };
            LineSeries lineSeries_hoadon = new LineSeries
            {
                Title = "Hóa đơn",
                Values = new ChartValues<int>()
            };
            if (doanhThuThangDTOs != null)
            {
                foreach (DoanhThuDTO doanhThuThangDTO in doanhThuThangDTOs)
                {
                    tongdoanhthuthang += doanhThuThangDTO.Tongtien;
                    tonghoadonthang += doanhThuThangDTO.Sohoadon;
                    lineSeries.Values.Add(doanhThuThangDTO.Tongtien);
                    lineSeries_hoadon.Values.Add(doanhThuThangDTO.Sohoadon);
                    thang.Add(doanhThuThangDTO.Thang.ToString());
                }
               
                cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
                lb_tongdoanhthu.Text = tongdoanhthuthang.ToString("c", new CultureInfo("vi-vn"));
                lb_tonghoadon.Text = tonghoadonthang.ToString("N1", new CultureInfo("vi-vn"));
                lb_tongkhachhang.Text = khachHang_DTOs.Count.ToString();
                lb_tongnhanvien.Text = nhanVien_DTOs.Count.ToString();
                series.Add(lineSeries);
                series.Add(lineSeries_hoadon);
                cartesianChart1.Series = series;
            }
            else
            {
                cartesianChart1.Series.Clear();
                lb_tongdoanhthu.Text = tongdoanhthuthang.ToString("c", new CultureInfo("vi-vn"));
                lb_tonghoadon.Text = tonghoadonthang.ToString("N1", new CultureInfo("vi-vn"));
                lb_tongkhachhang.Text = khachHang_DTOs.Count.ToString();
                lb_tongnhanvien.Text = nhanVien_DTOs.Count.ToString();
                MessageBox.Show("Không có doanh thu trong năm " + dtpk_nam.Text + " !");
            }    
        }
    }
}
