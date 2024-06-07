using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_hethong : Form
    {
        private NguoiDung_DTO nguoiDung;
        public frm_hethong(NguoiDung_DTO nguoiDung)
        {
            this.nguoiDung = nguoiDung;
            InitializeComponent();
        }
        public frm_hethong( )
        {
            InitializeComponent();
        }

        private void btn_saoluu_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
                saoluuFolder.Description = "Chọn thư mục lưu trữ file backup";
                if (saoluuFolder.ShowDialog() == DialogResult.OK)
                {
                    string sDuongDan = saoluuFolder.SelectedPath;
                    if(CSDL_BUS.SaoLuu(sDuongDan))
                        MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                    else
                        MessageBox.Show("Thao tác không thành công! Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_phuchoi_Click(object sender, EventArgs e)
        {
            try
            {
                string fullPath;
                OpenFileDialog phuchoiFile = new OpenFileDialog();
                phuchoiFile.Filter = "*.bak|*.bak";
                phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
                if (phuchoiFile.ShowDialog() == DialogResult.OK &&
                phuchoiFile.CheckFileExists == true)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn phục hồi dữ liệu từ file backup: " + phuchoiFile.FileName + " ?", "XÁC NHẬN PHỤC HỒI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Vui lòng đợi hệ thống phục hồi dữ liệu!");
                        string sDuongDan = phuchoiFile.FileName;
                        fullPath = Path.GetFullPath(sDuongDan);
                        if(CSDL_BUS.PhucHoi(fullPath))
                            MessageBox.Show("Dữ liệu đã phục hồi thành công!");
                        else
                            MessageBox.Show("Phục hồi dữ liệu không thành công!");

                    }
                    else
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                frm_QuenMatKhau qmk = new frm_QuenMatKhau(nguoiDung);
                qmk.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_hethong_Load(object sender, EventArgs e)
        {
            if(nguoiDung == null)
            {
                btn_doimatkhau.Enabled = false;
            }    
        }
    }
}
