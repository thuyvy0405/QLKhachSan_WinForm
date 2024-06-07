using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_DSDichVu : Form
    {
        public frm_DSDichVu()
        {
            InitializeComponent();
            loaidsDV();
            loadCbb_loaiDV();
        }
        
        private void loadCbb_loaiDV()
        {
            List<Loai_DichVu_DTO> ldv = Loai_DV_BUS.LayDSLOAIDV();
            cbb_loaiDV.DataSource = ldv;
        }
        private void loaidsDV()
        {
           List<DichVu_DTO> dv = DichVu_BUS.LayDSDichVu();
            dgv_DSDV.DataSource = dv;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear()
        {
            txt_ID.Text = "";
            txt_TenDV.Text = "";
            txt_GhiChu.Text = "";
            txt_dongia.Text = "";
            cbb_loaiDV.Text = "";
            cbb_tim.Text = "";
            txt_tim.Text = "";
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void frm_DSDichVu_Load(object sender, EventArgs e)
        {

        }

        private void txt_TenDV_TextChanged(object sender, EventArgs e)
        {
 
            try
            {
                Control control = (Control)sender;
                if (Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid char");

                }
                else
                    this.errorProvider1.Clear();

            }
            catch (Exception ex)
            {
            }
        }

        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid number");

                }
                else
                    this.errorProvider1.Clear();

            }
            catch (Exception ex)
            {
            }
        }

        private void txt_GhiChu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                if (Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid char");

                }
                else
                    this.errorProvider1.Clear();

            }
            catch (Exception ex)
            {
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu_DTO dv = new DichVu_DTO();
                if (txt_TenDV.Text != "" && txt_dongia.Text != "")
                {
                    dv.TenDV = txt_TenDV.Text;
                    dv.GhiCHu = txt_GhiChu.Text;
                    dv.IDLoaiDV = int.Parse(cbb_loaiDV.SelectedValue.ToString());
                    dv.DongiaDV = SqlMoney.Parse(txt_dongia.Text);
                    DichVu_BUS.add(dv);
                    loaidsDV();
                }
                else
                    MessageBox.Show("Thông tin vẫn còn thiếu !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !"+ ex.Message);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu_DTO dv = new DichVu_DTO();
                if (txt_TenDV.Text != "" && txt_dongia.Text != "")
                {
                    dv.IDDV =int.Parse( txt_ID.Text);
                    dv.TenDV = txt_TenDV.Text;
                    dv.GhiCHu = txt_GhiChu.Text;
                    dv.IDLoaiDV = int.Parse(cbb_loaiDV.SelectedValue.ToString());
                    dv.DongiaDV = SqlMoney.Parse(txt_dongia.Text);
                    DichVu_BUS.Update(dv);
                    loaidsDV();
                }
                else
                    MessageBox.Show("Thông tin vẫn còn thiếu !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !" + ex.Message);
            }
        }

        private void dgv_DSDV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_DSDV.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null)
                {
                    txt_ID.Text = dr.Cells[0].Value.ToString();
                    txt_TenDV.Text = dr.Cells[1].Value.ToString();
                    cbb_loaiDV.Text = dr.Cells[2].Value.ToString();
                    txt_dongia.Text = dr.Cells[3].Value.ToString();
                    txt_GhiChu.Text = dr.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !", ex.Message);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_tim.SelectedIndex == 0)
                {
                    if (txt_tim.Text == "Nhập để tìm")
                    {
                        loaidsDV();
                    }
                    else
                    {
                        dgv_DSDV.DataSource = DichVu_BUS.TimDVtheoIDDV(txt_tim.Text);
                    }
                }
                if (cbb_tim.SelectedIndex == 1)
                {
                    if (txt_tim.Text == "Nhập để tìm")
                    {
                        loaidsDV();
                    }
                    else
                    {
                        dgv_DSDV.DataSource = DichVu_BUS.TimDVtheoTenDV(txt_tim.Text);
                    }
                }
                if (cbb_tim.SelectedIndex == 2)
                {
                    if (txt_tim.Text == "Nhập để tìm")
                    {
                        loaidsDV();
                    }
                    else
                    {
                        dgv_DSDV.DataSource = DichVu_BUS.TimDVtheoLoaiDV(txt_tim.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ThemLoaiDV f1 = new frm_ThemLoaiDV();
            f1.Show();

        }

        private void cbb_loaiDV_DropDown(object sender, EventArgs e)
        {
            loadCbb_loaiDV();
        }
    }
}
