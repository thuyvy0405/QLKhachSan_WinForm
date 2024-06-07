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
    public partial class frm_DS_DatPhong : Form
    {
        private NguoiDung_DTO nguoiDung_DTO;
        public frm_DS_DatPhong(NguoiDung_DTO nguoiDung_DTO)
        {
            InitializeComponent();
            this.nguoiDung_DTO = nguoiDung_DTO;
        }

        private void frm_DS_DatPhong_Load(object sender, EventArgs e)
        {
            LOADDSDP();
        }
        public void LOADDSDP()
        {
            List<DatPhong_DTO> lstDSDP = DatPhong_BUS.LayDSDatPhong();
            dgv_DSdatphong.DataSource = lstDSDP;
        }

        private void dateTime_ngaylap_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_DSdatphong.DataSource = DatPhong_BUS.TimDPtheoNgaylap(dateTime_ngaylap.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Tìm_Leave(object sender, EventArgs e)
        {
            if (txt_Tìm.Text != "")
            {

            }
            else
                txt_Tìm.Text = "Nhập điều kiện để tìm kiếm";
        }

        private void txt_Tìm_Click(object sender, EventArgs e)
        {
            if (txt_Tìm.Text == "Nhập điều kiện để tìm kiếm")
                txt_Tìm.Clear();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbb_Chon.SelectedIndex == 0)
                {
                    if (txt_Tìm.Text == "Nhập điều kiện để tìm kiếm")
                    {
                        LOADDSDP();
                    }
                    else
                    {
                        dgv_DSdatphong.DataSource = DatPhong_BUS.TimDPtheoMaDP(txt_Tìm.Text.Trim());
                    }
                }    
                if(cbb_Chon.SelectedIndex == 1)
                {
                    if (txt_Tìm.Text == "Nhập điều kiện để tìm kiếm")
                    {
                        LOADDSDP();
                    }
                    else
                    {
                        dgv_DSdatphong.DataSource = DatPhong_BUS.TimDPtheoTenKH(txt_Tìm.Text.Trim());
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message+" !", "Thông báo");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Tìm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            frm_DatPhong DP = new frm_DatPhong(this);
            DP.Show();
        }

        private void dgv_DSdatphong_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_DSdatphong.CurrentRow;
                if (row != null)
                {
                    frm_chitietdatphong CTDP = new frm_chitietdatphong(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), nguoiDung_DTO, this);
                    CTDP.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
