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
    public partial class frm_Chitiet_TienNghi : Form
    {
        public frm_Chitiet_TienNghi()
        {
            InitializeComponent();
            
        }
        private frm_Phong frmphong;
        private frm_TienNghi frmtiennghi;
        public frm_Chitiet_TienNghi(frm_TienNghi frmtiennghi, frm_Phong frmphong)
        {
            InitializeComponent();
            this.frmphong = frmphong;
            this.frmtiennghi = frmtiennghi;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loadDSChitietTN()
        {
                List<Chitiet_TienNghi_DTO> ct = ChiTiet_TienNghi_BUS.LayCTTienNghi();
                dgv_ds_chitietTN.DataSource = ct;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loadcbb_phong()
        {
            try
            {
                List<Phong_DTO> phong = Phong_BUS.LayPHONG();
                cbb_phong.DataSource = phong;
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_tiennghi.Text != "" && cbb_phong.Text != "" && numer_SL.Value != 0)
                {
                    Chitiet_TienNghi_DTO ct = new Chitiet_TienNghi_DTO();
                    ct.IDTN = int.Parse(cbb_tiennghi.SelectedValue.ToString());
                    ct.IDPhong =int.Parse( cbb_phong.SelectedValue.ToString());
                    ct.SoluongSD = int.Parse(numer_SL.Value.ToString());
                    ct.ThgianSuDung =DateTime.Parse( NgaySD_Datetime.Text);
                    ct.GhiChu_TN = txt_ghiChu.Text;
                    ChiTiet_TienNghi_BUS.add(ct);
                    loadDSChitietTN();
                    cleartext();
                }
                else
                    MessageBox.Show("Thêm thất bại!Bạn cần kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_tiennghi.Text != "" && cbb_phong.Text != "" && numer_SL.Value != 0)
                {
                    Chitiet_TienNghi_DTO ct = new Chitiet_TienNghi_DTO();
                    ct.IDTN = int.Parse(cbb_tiennghi.SelectedValue.ToString());
                    ct.IDPhong = int.Parse(cbb_phong.SelectedValue.ToString());
                    ct.SoluongSD = int.Parse(numer_SL.Value.ToString());
                    ct.ThgianSuDung = DateTime.Parse(NgaySD_Datetime.Text);
                    ct.GhiChu_TN = txt_ghiChu.Text;
                    ChiTiet_TienNghi_BUS.Update(ct);
                    loadDSChitietTN();
                    cleartext();
                }
                else
                    MessageBox.Show("Cập nhật thất bại! Bãn hãy kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cleartext()
        {
            cbb_tiennghi.Text = "";
            cbb_phong.Text = "";
            txt_ghiChu.Text = "";
            NgaySD_Datetime.Value = DateTime.Now;
            numer_SL.Value = 0;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btn_timNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chon.SelectedIndex == 0)
                {
                    if (txt_timNV.Text == "Nhập để tìm")
                    {
                        loadDSChitietTN();
                    }
                    else
                    {
                        dgv_ds_chitietTN.DataSource = ChiTiet_TienNghi_BUS.TimCTTNtheoTenTN(txt_timNV.Text);
                    }
                }
                if (cbb_chon.SelectedIndex == 1)
                {
                    if (txt_timNV.Text == "Nhập để tìm")
                    {
                        loadDSChitietTN();
                    }
                    else
                    {
                        dgv_ds_chitietTN.DataSource = ChiTiet_TienNghi_BUS.TimTNtheoTenphong(txt_timNV.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !", "Thông báo");
            }
        }

        private void dgv_ds_chitietTN_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgv_ds_chitietTN.SelectedRows[0];
            if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null )
            {
                cbb_tiennghi.Text = dr.Cells[0].Value.ToString();
                cbb_phong.Text = dr.Cells[1].Value.ToString();
                NgaySD_Datetime.Text = dr.Cells[2].Value.ToString();
                numer_SL.Text = dr.Cells[3].Value.ToString();
                txt_ghiChu.Text = dr.Cells[4].Value.ToString();
            }
        }
        private void loadccb_TN()
        {
            List<TienNghi_DTO> tn = TienNghi_BUS.LayDSTienNghi();
            cbb_tiennghi.DataSource = tn;
        }
        private void frm_Chitiet_TienNghi_Load(object sender, EventArgs e)
        {
            loadDSChitietTN();
            Loadcbb_phong();
            loadccb_TN();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_timNV_Leave(object sender, EventArgs e)
        {
            if (txt_timNV.Text != "")
            {

            }
            else
                txt_timNV.Text = "Nhập để tìm";
        }

        private void txt_timNV_Click(object sender, EventArgs e)
        {
            if (txt_timNV.Text == "Nhập để tìm")
                txt_timNV.Clear();
                txt_timNV.Clear();
        }
    }
}
