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
    public partial class frm_inhoadonthanhtoan : Form
    {
        private int id_datphobg;

        public frm_inhoadonthanhtoan(int id_datphong)
        {
            this.id_datphobg = id_datphong;
            InitializeComponent();
        }

        private void frm_inhoadonthanhtoan_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1, id_datphobg);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
