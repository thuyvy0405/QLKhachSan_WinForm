using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace QuanLyKhachSan
{
    public partial class frmConnectDataBase : Form
    {
        public frmConnectDataBase()
        {
            InitializeComponent();
        }

        private void frmConnectDataBase_Load(object sender, EventArgs e)
        {
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow row in dt.Rows)
            {
                string serverName = row["ServerName"].ToString();
                string instanceName = row["InstanceName"].ToString();
                if (!string.IsNullOrEmpty(instanceName))
                {
                    serverName += "\\" + instanceName;
                }

                cbb_servername.Items.Add(serverName);
            }
        }

        private void checkxacthuc_CheckedChanged(object sender, EventArgs e)
        {
            if(checkxacthuc.Checked == true)
            {
                txt_matkhau.Enabled = true;
                txt_tentaikhoan.Enabled = true;
            }
            else
            {
                txt_matkhau.Enabled = false;
                txt_tentaikhoan.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConnect = "";
            if (!checkxacthuc.Checked)
                strConnect = "Server=" + cbb_servername.Text + ";Database=QLKS;Trusted_Connection=True;";
            else
                strConnect = "Server=" + cbb_servername.Text + ";Database=QLKS;User Id=" + txt_tentaikhoan.Text + ";Password = " + txt_matkhau.Text + "; ";
            SqlConnection sqlcon = new SqlConnection(strConnect);
            try
            {
                sqlcon.Open();
                QuanLyKhachSan.Properties.Settings.Default.strConnect = strConnect;
                QuanLyKhachSan.Properties.Settings.Default.Save();
                MessageBox.Show("Kết nối thành công, vui lòng khởi động lại chương trình sau tiếp beep!");
                Console.Beep();
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối không thành công, xin kiểm tra lại!");
                sqlcon.Close();
            }
        }
    }
}
