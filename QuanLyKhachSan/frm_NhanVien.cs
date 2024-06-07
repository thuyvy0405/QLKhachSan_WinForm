using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
            loadDSNV();
            loadDSTK();
            LoadID_NV();
            Load_quyen();
        }
        private void loadDSNV()
        {
            List<NhanVien_DTO> nv = NhanVien_BUS.LayDSNhanvien();
            dgv_DSNV.DataSource = nv;
        }
        private void loadDSTK()
        {
            List<NguoiDung_DTO> nd = NguoiDung_BUS.LayDSNguoiDung();
            dgv_TaiKhoan.DataSource = nd;
        }

        private void clearText()
        {
            txt_email.Text = "";
            txt_Dchi.Text = "";
            txt_CCCD.Text = "";
            txt_SDT.Text = "";
            txt_HotenNV.Text = "";
            txt_IDNV.Text = "";
            txt_pass.Text = "";
            cbb_Quyen.Text = "";
            cbb_IDNV.Text = "";
            txt_username.Text = "";
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_HotenNV.Text != "" && txt_CCCD.Text != "" && txt_SDT.Text != "" && txt_email.Text != "" && txt_Dchi.Text != "")
                {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.TenNV = txt_HotenNV.Text;
                    if (NhanVien_BUS.Checksdt(txt_SDT.Text))
                    {
                        if (txt_SDT.TextLength == 10)
                        {
                            nv.SDTNV = txt_SDT.Text;
                        }
                        else
                        {
                            MessageBox.Show("Số SĐT phải là 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                        MessageBox.Show("Số CCCD đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (NhanVien_BUS.CheckCCCD(txt_CCCD.Text))
                    {
                        if (txt_CCCD.TextLength == 12)
                        {
                            nv.CCCD_NV = txt_CCCD.Text;
                        }
                        else
                        {
                            MessageBox.Show("Số CCCD phải là 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                        MessageBox.Show("Số CCCD đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    nv.EmailNV = txt_email.Text;
                    nv.DchiNV = txt_Dchi.Text;
                    if (NhanVien_BUS.add(nv))
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                        loadDSNV();
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công. Vui lòng thử lại!");
                    }
                }
               else
                {
                    MessageBox.Show("Thông tin còn thiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_capnhat_NV_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            if (txt_HotenNV.Text != "" && txt_SDT.Text != "" && txt_email.Text != "" && txt_Dchi.Text != "")
            {
                nv.IDNV =int.Parse (txt_IDNV.Text);
                nv.TenNV = txt_HotenNV.Text;

                    if (txt_SDT.TextLength == 10)
                    {
                        nv.SDTNV = txt_SDT.Text;
                    }
                    else
                    {
                        MessageBox.Show("Số SĐT phải là 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                
                nv.EmailNV = txt_email.Text;
                nv.DchiNV = txt_Dchi.Text;
                NhanVien_BUS.Update(nv);
                loadDSNV();
                clearText();
            }
        } 

        private void dgv_DSNV_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgv_DSNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgv_DSNV.SelectedRows[0];
            if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null && dr.Cells[5].Value != null)
            {
                txt_IDNV.Text = dr.Cells[0].Value.ToString();
                txt_HotenNV.Text = dr.Cells[1].Value.ToString();
                txt_CCCD.Text = dr.Cells[2].Value.ToString();
                txt_SDT.Text = dr.Cells[3].Value.ToString();
                txt_email.Text = dr.Cells[4].Value.ToString();
                txt_Dchi.Text = dr.Cells[5].Value.ToString();
            }
            btn_capnhat_NV.Enabled = true;
        }

        private void btn_huyNV_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btn_exitNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_timNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chonTimNV.SelectedIndex == 0)
                {
                    if (txt_timNV.Text == "Nhập để tìm")
                    {
                        loadDSNV();
                    }
                    else
                    {
                        dgv_DSNV.DataSource = NhanVien_BUS.LayNhanvienTheoten(txt_timNV.Text);
                    }
                }
                 if (cbb_chonTimNV.SelectedIndex == 1)
                {
                    if (txt_timNV.Text == "Nhập để tìm")
                    {
                        loadDSNV();
                    }
                    else
                    {
                        dgv_DSNV.DataSource = NhanVien_BUS.LayNhanvienTheoCCCD(txt_timNV.Text);
                    }
                }
                 if (cbb_chonTimNV.SelectedIndex == 2)
                {
                    if (txt_timNV.Text == "Nhập để tìm")
                    {
                        loadDSNV();
                    }
                    else
                    {
                        dgv_DSNV.DataSource = NhanVien_BUS.LayNhanvienTheoSDT(txt_timNV.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống 2!", "Thông báo");
            }
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
        }

        private void txt_Tim_TK_Leave(object sender, EventArgs e)
        {
            if (txt_Tim_TK.Text != "")
            {

            }
            else
                txt_Tim_TK.Text = "Nhập để tìm";
        }

        private void txt_Tim_TK_Click(object sender, EventArgs e)
        {
            if (txt_Tim_TK.Text == "Nhập để tìm")
                txt_Tim_TK.Clear();
        }
        private void LoadID_NV()
        {
            List<NhanVien_DTO> nv = NhanVien_BUS.LayDSNhanvien();
            cbb_IDNV.DataSource = nv;
        }
        private void Load_quyen()
        {
            List<PhanQuyen_DTO> q = PhanQuyen_BUS.Layquyen();
            cbb_Quyen.DataSource = q;
        }
        private NhanVien_DTO LoadNHanvientheoID(string ID)
        {
            return NhanVien_BUS.LayNhanvienTheoIDNV1(ID);
        }    
        private void btn_them_TK_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_IDNV.Text != "" && txt_pass.Text != "" && txt_username.Text != "" && cbb_Quyen.Text != "")
                {
                    NguoiDung_DTO nd = new NguoiDung_DTO();

                    nd.IDNV = int.Parse(cbb_IDNV.SelectedValue.ToString());
                    MessageBox.Show(nd.IDNV.ToString());
                    if (NguoiDung_BUS.CheckUSer(txt_username.Text))
                    {
                        nd.USERName = txt_username.Text;
                        MessageBox.Show(nd.USERName.ToString());
                    }
                    else
                        MessageBox.Show("Usernaem này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nd.Password = txt_pass.Text;
                    nd.IDQuyen = int.Parse(cbb_Quyen.SelectedValue.ToString());
                    MessageBox.Show(nd.IDQuyen.ToString());
                    MessageBox.Show(nd.Password.ToString());
                    if (NguoiDung_BUS.add(nd))
                    {
                        MessageBox.Show("Thêm mới tài khoản thành công!");
                        loadDSTK();
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công. Vui lòng thử lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin còn thiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_capnhat_TK_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_IDNV.Text != "" && txt_pass.Text != "" && txt_username.Text != "" && cbb_Quyen.Text != "")
                {
                    NguoiDung_DTO nd = new NguoiDung_DTO();
                    nd.IDNV = int.Parse(cbb_IDNV.SelectedValue.ToString());
                    nd.USERName = txt_username.Text;
                    nd.Password = txt_pass.Text;
                    nd.IDQuyen = int.Parse(cbb_Quyen.SelectedValue.ToString());
                    if (NguoiDung_BUS.Update(nd))
                    {
                        MessageBox.Show("Đã cập nhật lại thông tin tài khoản!");
                        loadDSTK();
                        clearText();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại!");
                }
                else
                {
                    MessageBox.Show("Thông tin cần chỉnh sửa chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_huy_TK_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btn_EXIT_TK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_IDNV.Text != "" && txt_pass.Text != "" && txt_username.Text != "" && cbb_Quyen.Text != "")
                {
                    NguoiDung_DTO nd = new NguoiDung_DTO();
                    nd.IDNV = int.Parse(cbb_IDNV.SelectedValue.ToString());
                    nd.USERName = txt_username.Text;
                    nd.Password = txt_pass.Text;
                    nd.IDQuyen = int.Parse(cbb_Quyen.SelectedValue.ToString());
                    NguoiDung_BUS.Delete(nd);
                    loadDSTK();
                    clearText();
                }
                else
                {
                    MessageBox.Show("Thông tin cần xóa chưa chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Tim_TK_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chonTimNV.SelectedIndex == 0)
                {
                    if (txt_Tim_TK.Text == "Nhập để tìm")
                    {
                        loadDSTK();
                    }
                    else
                    {
                       List<NguoiDung_DTO>  list = NguoiDung_BUS.TimNguoidungtheTenNV(txt_Tim_TK.Text);
                        dgv_TaiKhoan.DataSource = list;
                    }
                }
               if (cbb_chonTimNV.SelectedIndex == 1)
                {
                    if (txt_Tim_TK.Text == "Nhập để tìm")
                    {
                        loadDSTK();
                    }
                    else
                    {
                        dgv_TaiKhoan.DataSource = NguoiDung_BUS.TimNguoidungtheTenQuyen(txt_Tim_TK.Text);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !"+ex.Message, "Thông báo");
            }
        }

        private void dgv_TaiKhoan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr =dgv_TaiKhoan.SelectedRows[0];
            if ( dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null)
            {
                cbb_IDNV.Text = dr.Cells[1].Value.ToString();
                cbb_Quyen.Text = dr.Cells[2].Value.ToString();
                txt_username.Text = dr.Cells[3].Value.ToString();
                txt_pass.Text = dr.Cells[4].Value.ToString();
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
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

        private void txt_CCCD_TextChanged(object sender, EventArgs e)
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

        private void txt_SDT_TextChanged(object sender, EventArgs e)
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

        private void txt_HotenNV_TextChanged(object sender, EventArgs e)
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

    }
}
