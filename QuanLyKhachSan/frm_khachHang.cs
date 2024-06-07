using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_khachHang : Form
    {
        public frm_khachHang()
        {
            InitializeComponent();
            loadDSKH();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void loadDSKH()
        {
            List<KhachHang_DTO> kh = KhachHang_BUS.LayDSKhachHang();
            dgv_dskhachhang.DataSource = kh;
        }
        private string GioiTinh()
        {
            string gioitinh = "";
            if (rad_Nam.Checked == true)
            {
                return gioitinh = "Nam";
            }
            else
                return gioitinh = "Nữ";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                if (txt_hoten.Text != "" && txt_cccd.Text != "" && txt_sdt.Text != "" && txt_Dchi.Text != "")
                {
                    kh.TenKH = txt_hoten.Text;

                    if (txt_cccd.Text.Length == 12)
                    {
                        if (KhachHang_BUS.CheckCCCD(txt_cccd.Text))
                        {
                            kh.CCCD_KH = txt_cccd.Text;
                        }
                        else
                            MessageBox.Show("CCCD đã tồn tại trong hệ thống!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("CCCD phải là 12 số !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (txt_sdt.Text.Length == 10)
                    {
                        if (KhachHang_BUS.CheckSDT(txt_sdt.Text))
                        {
                            kh.SDT_Kh = txt_sdt.Text;
                        }
                        else
                            MessageBox.Show("SĐT đã tồn tại trong hệ thống!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("SĐT phải là 10 số !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    kh.Dchi_KH = txt_Dchi.Text;
                    kh.Email_KH = txtEmail.Text;
                    if (rad_Nam.Checked == true)
                    {
                        kh.Phai = "Nam";
                    }
                    else
                        kh.Phai = "Nữ";
                    KhachHang_BUS.add(kh);
                    loadDSKH();
                    cleartext();
                }
                else
                    MessageBox.Show("Thông tin vẫn còn thiếu !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !" + ex.Message);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_dskhachhang.CurrentRow;
                
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.IDKH = int.Parse(row.Cells[0].Value.ToString());
                if (txt_hoten.Text != "" && txt_sdt.Text != "" && txt_Dchi.Text != "")
                {
                    kh.TenKH = txt_hoten.Text;
                    if (txt_cccd.Text.Length == 12)
                    {
                        kh.CCCD_KH = txt_cccd.Text;
                    }
                    else
                    {
                        MessageBox.Show("CCCD phải là 12 số !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (txt_sdt.Text.Length == 10)
                    {
                        kh.SDT_Kh = txt_sdt.Text;
                    }
                    else
                    {
                        MessageBox.Show("SĐT phải là 10 số !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    kh.Dchi_KH = txt_Dchi.Text;
                    kh.Email_KH = txtEmail.Text;
                    if (rad_Nam.Checked == true)
                    {
                        kh.Phai = "Nam";
                    }
                    else
                        kh.Phai = "Nữ";
                    KhachHang_BUS.Update(kh);
                    loadDSKH();
                    cleartext();
                }
                else
                    MessageBox.Show("Thông tin cập nhật sai !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !", ex.Message);
            }
        }
        private void cleartext()
        {
            txtEmail.Text = "";
            txt_cccd.Text = "";
            txt_Dchi.Text = "";
            txt_hoten.Text = "";
            txt_sdt.Text = "";
            rad_Nam.Checked = false;
            rad_nu.Checked = false;
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            cleartext();
            cbb_chon.Text = "Chọn điều kiện tìm";
            txt_tim.Text = "Nhập để tìm";
        }

        private void txt_tim_Leave(object sender, EventArgs e)
        {
            if (txt_tim.Text != "")
            {

            }
            else
                txt_tim.Text = "Nhập để tìm";
        }

        private void txt_tim_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == "Nhập để tìm")
                txt_tim.Clear();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chon.SelectedIndex == 0)
                {
                    if (txt_tim.Text == "Nhập để tìm")
                    {
                        loadDSKH();
                    }
                    else
                    {
                        dgv_dskhachhang.DataSource = KhachHang_BUS.TimKHtheoTenkh(txt_tim.Text);
                    }
                }
                if (cbb_chon.SelectedIndex == 1)
                {
                    if (txt_tim.Text == "Nhập để tìm")
                    {
                        loadDSKH();
                    }
                    else
                    {
                        dgv_dskhachhang.DataSource = KhachHang_BUS.TimKHtheoSDT(txt_tim.Text);
                    }
                }
                if (cbb_chon.SelectedIndex == 2)
                {
                    if (txt_tim.Text == "Nhập để tìm")
                    {
                        loadDSKH();
                    }
                    else
                    {
                        dgv_dskhachhang.DataSource = KhachHang_BUS.TimKHtheoCCCD(txt_tim.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !", ex.Message);
            }
        }

        private void dgv_dskhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_dskhachhang.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null && dr.Cells[6].Value != null)
                {
                    txt_hoten.Text = dr.Cells[1].Value.ToString();
                    txt_cccd.Text = dr.Cells[2].Value.ToString();
                    txt_sdt.Text = dr.Cells[3].Value.ToString();
                    if (dr.Cells[4].Value.ToString() == "Nam")
                    {
                        rad_Nam.Checked = true;
                    }
                    else
                        rad_nu.Checked = true;
                    txtEmail.Text = dr.Cells[5].Value.ToString();
                    txt_Dchi.Text = dr.Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !", ex.Message);
            }
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
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

        private void txt_cccd_TextChanged(object sender, EventArgs e)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string email = control.Text;

            if (!email.Contains("@"))
            {
                errorProvider1.SetError(control, "This is not a valid Gmail address");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (!CheckdEmail(email))
            {
                errorProvider2.SetError(control, "Invalid characters in the email address");
            }
            else
            {
                errorProvider2.Clear();
            }

        }
        static bool CheckdEmail(string email)
        {
            // Biểu thức chính quy kiểm tra địa chỉ email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Kiểm tra định dạng email
            Match match = Regex.Match(email, pattern);

            // Kiểm tra các ký tự không hợp lệ trong địa chỉ email
            if (match.Success)
            {
                string invalidChars = "!#$%^&*()+=[]\\';,/{}|\":<>?";
                foreach (char c in invalidChars)
                {
                    if (email.Contains(c))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void txt_Dchi_TextChanged(object sender, EventArgs e)
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

        private void txt_sdt_TextChanged(object sender, EventArgs e)
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

        private void dgv_dskhachhang_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgv_dskhachhang.SelectedRows[0];
            if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null && dr.Cells[5].Value != null)
            {
                txt_hoten.Text = dr.Cells[1].Value.ToString();
                txtEmail.Text = dr.Cells[5].Value.ToString();
                txt_cccd.Text = dr.Cells[2].Value.ToString();
                txt_sdt.Text = dr.Cells[3].Value.ToString();
                txt_Dchi.Text = dr.Cells[6].Value.ToString();
                string gioitinh = dr.Cells[4].Value.ToString();
                if (gioitinh == "Nam") rad_Nam.Checked = true; else rad_nu.Checked= true;     
            }
            btn_capnhat.Enabled = true;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
