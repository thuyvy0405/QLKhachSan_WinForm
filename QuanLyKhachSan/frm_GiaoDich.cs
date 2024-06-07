using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyKhachSan
{
    public partial class frm_GiaoDich : Form
    {
        private NguoiDung_DTO nguoidug;
        public frm_GiaoDich()
        {
            InitializeComponent();
        }
        public frm_GiaoDich(NguoiDung_DTO nguoidug)
        {
            InitializeComponent();
            this.nguoidug = nguoidug;
        }
        private void loadHD()
        {
            cbb_chon.SelectedIndex = 0;
            List<HoaDon_DTO> hd = HoaDon_BUS.LayDSHD();
            dgv_hd.DataSource = hd;
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tim.Text != "Nhập để tìm" && txt_tim.Text != "")
                {
                    if (cbb_chon.SelectedIndex == 0)// số hóa đơn
                    {
                        List<HoaDon_DTO> hd = HoaDon_BUS.TimHDtheoIDHD(int.Parse(txt_tim.Text.Trim()));
                        dgv_hd.DataSource = hd;
                    }
                    else if (cbb_chon.SelectedIndex == 1)// số phiếu đặt
                    {
                        List<HoaDon_DTO> hd = HoaDon_BUS.TimHDtheoIDDATPHONG(int.Parse(txt_tim.Text.Trim()));
                        dgv_hd.DataSource = hd;
                    }
                    else if (cbb_chon.SelectedIndex == 2)// mã khách hàng
                    {
                        List<HoaDon_DTO> hd = HoaDon_BUS.TimHDtheoTenKH(txt_tim.Text.Trim());
                        dgv_hd.DataSource = hd;
                    }
                    else// mã nhân vien
                    {
                        List<HoaDon_DTO> hd = HoaDon_BUS.TimHDtheoTenNV(txt_tim.Text.Trim());
                        dgv_hd.DataSource = hd;
                    }
                }
                else
                {
                    List<HoaDon_DTO> hd = HoaDon_BUS.LayDSHD();
                    dgv_hd.DataSource = hd;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_hd_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_hd.CurrentRow;
                frm_inhoadonthanhtoan f1 = new frm_inhoadonthanhtoan(int.Parse(dr.Cells[3].Value.ToString()));
                f1.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_GiaoDich_Load(object sender, EventArgs e)
        {
            loadHD();
        }

        private void txt_tim_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == "Nhập để tìm")
                txt_tim.Clear();
        }

        private void txt_tim_Leave(object sender, EventArgs e)
        {
            if (txt_tim.Text == "")
                txt_tim.Text = "Nhập để tìm";
        }

        private void btn_timkiemngay_Click(object sender, EventArgs e)
        {
            try
            {
                List<HoaDon_DTO> hd = HoaDon_BUS.TimHDtheoNgayGD(Ngay.Text.Trim());
                dgv_hd.DataSource = hd;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frm_THONGKEDOANHTHU f1 = new frm_THONGKEDOANHTHU(nguoidug.TenNV);
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
