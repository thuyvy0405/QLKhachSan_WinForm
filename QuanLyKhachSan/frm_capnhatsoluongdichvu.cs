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
    public partial class frm_capnhatsoluongdichvu : Form
    {
        private DatPhong_DichVu_DTO dpdv;
        private DataGridView dgvdichvu;
        private int soluongdaco;
        private int vitridongcapnhat;
        private frm_chitietdatphong frm_Chitietdatphong;
        public frm_capnhatsoluongdichvu(frm_chitietdatphong frm_,DatPhong_DichVu_DTO dpdv, DataGridView dgv , int SOLUONGDACO, int vitridongcapnhat)
        {
            InitializeComponent();
            this.dgvdichvu = dgv;
            this.dpdv = dpdv;
            this.soluongdaco = SOLUONGDACO;
            this.vitridongcapnhat = vitridongcapnhat;
            this.frm_Chitietdatphong = frm_;    
        }

        private void frm_capnhatsoluongdichvu_Load(object sender, EventArgs e)
        {
            if(dpdv != null)
            {
                txt_tendichvu.Text = dpdv.TenDV;
                txtdongia.Text = dpdv.DongiaDV.ToString();
                numericUpDownsoluong.Value = soluongdaco;
                double thanhtien = dpdv.DongiaDV *  double.Parse(numericUpDownsoluong.Value.ToString());
                txt_thanhtien.Text = thanhtien.ToString();
            }    
        }




        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_capnhat_Click_1(object sender, EventArgs e)
        {
            if (txt_thanhtien.Text != "")
            {
                DataGridViewRow rowcapnhat = dgvdichvu.Rows[vitridongcapnhat];
                dgvdichvu.Update();
                dpdv.SoluongDV = int.Parse(numericUpDownsoluong.Value.ToString());
                dpdv.NgaySD_DV = DateTime.Now;
                dpdv.ThanhtienDV = double.Parse(txt_thanhtien.Text);
                if (DatPhong_DichVu_BUS.Update(dpdv))
                {
                    frm_Chitietdatphong.LoadDanhSachDichVu_Dat();
                    frm_Chitietdatphong.ShowTienThanhToan();
                    MessageBox.Show("Cập nhật lại số lượng thành công.");
                    this.Close();
                }
                else
                    MessageBox.Show("LỖI: không thể cập nhật dịch vụ. Vui lòng thử lại.", "LỖI");
            }
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDownsoluong_ValueChanged_1(object sender, EventArgs e)
        {
            double thanhtien = dpdv.DongiaDV * double.Parse(numericUpDownsoluong.Value.ToString());
            txt_thanhtien.Text = thanhtien.ToString();
        }
    }
}
