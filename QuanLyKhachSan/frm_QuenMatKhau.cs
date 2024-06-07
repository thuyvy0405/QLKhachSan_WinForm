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
    public partial class frm_QuenMatKhau : Form
    {
        private NguoiDung_DTO nguodung;
        public frm_QuenMatKhau(NguoiDung_DTO nguoidung)
        {
            InitializeComponent();
            this.nguodung = nguoidung;
        }

        private void lb_TK_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtPASS.Text != "" && txtXACTHUCPASS.Text != "")
            {
                if (txtPASS.Text == txtXACTHUCPASS.Text)
                {
                    nguodung.Password = txtPASS.Text.Trim();
                    if (NguoiDung_BUS.Update(nguodung))
                    {
                        MessageBox.Show("Đã thay đổi mật khẩu thành công!");
                        txtPASS.Clear();
                        txtXACTHUCPASS.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác thực không khớp. Vui lòng kiểm tra lại!");
                    txtXACTHUCPASS.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu!");
            }    
        }

        private void frm_QuenMatKhau_Load(object sender, EventArgs e)
        {
            txtUSERNAME.Text = nguodung.USERName;
        }
    }
}
