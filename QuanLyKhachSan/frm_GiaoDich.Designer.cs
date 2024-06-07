namespace QuanLyKhachSan
{
    partial class frm_GiaoDich
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_hd = new System.Windows.Forms.DataGridView();
            this.hoaDonDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Ngay = new System.Windows.Forms.DateTimePicker();
            this.cbb_chon = new System.Windows.Forms.ComboBox();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_timkiemngay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iDHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayGDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDatphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgv_hd);
            this.panel1.Location = new System.Drawing.Point(26, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 548);
            this.panel1.TabIndex = 0;
            // 
            // dgv_hd
            // 
            this.dgv_hd.AllowUserToAddRows = false;
            this.dgv_hd.AllowUserToDeleteRows = false;
            this.dgv_hd.AutoGenerateColumns = false;
            this.dgv_hd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hd.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDHDDataGridViewTextBoxColumn,
            this.ngayGDDataGridViewTextBoxColumn,
            this.tenkhDataGridViewTextBoxColumn,
            this.iDDatphongDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.tongHDDataGridViewTextBoxColumn});
            this.dgv_hd.DataSource = this.hoaDonDTOBindingSource;
            this.dgv_hd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_hd.Location = new System.Drawing.Point(0, 0);
            this.dgv_hd.MultiSelect = false;
            this.dgv_hd.Name = "dgv_hd";
            this.dgv_hd.ReadOnly = true;
            this.dgv_hd.RowHeadersWidth = 62;
            this.dgv_hd.RowTemplate.Height = 28;
            this.dgv_hd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hd.Size = new System.Drawing.Size(897, 548);
            this.dgv_hd.TabIndex = 0;
            this.dgv_hd.DoubleClick += new System.EventHandler(this.dgv_hd_DoubleClick);
            // 
            // hoaDonDTOBindingSource
            // 
            this.hoaDonDTOBindingSource.DataSource = typeof(DTO.HoaDon_DTO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn thời gian :";
            // 
            // Ngay
            // 
            this.Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Ngay.Location = new System.Drawing.Point(138, 6);
            this.Ngay.Name = "Ngay";
            this.Ngay.Size = new System.Drawing.Size(135, 26);
            this.Ngay.TabIndex = 2;
            // 
            // cbb_chon
            // 
            this.cbb_chon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_chon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chon.FormattingEnabled = true;
            this.cbb_chon.Items.AddRange(new object[] {
            "Số hóa đơn",
            "Số phiếu đặt phòng",
            "Tên khách hàng",
            "Tên nhân viên"});
            this.cbb_chon.Location = new System.Drawing.Point(492, 37);
            this.cbb_chon.Name = "cbb_chon";
            this.cbb_chon.Size = new System.Drawing.Size(164, 28);
            this.cbb_chon.TabIndex = 3;
            // 
            // txt_tim
            // 
            this.txt_tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(661, 32);
            this.txt_tim.Multiline = true;
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(218, 34);
            this.txt_tim.TabIndex = 4;
            this.txt_tim.Text = "Nhập để tìm";
            this.txt_tim.Click += new System.EventHandler(this.txt_tim_Click);
            this.txt_tim.Leave += new System.EventHandler(this.txt_tim_Leave);
            // 
            // btn_tim
            // 
            this.btn_tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tim.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_2023_04_12_040044;
            this.btn_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tim.Location = new System.Drawing.Point(880, 28);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(50, 40);
            this.btn_tim.TabIndex = 5;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duoble click vào 1 dòng trong bảng để xem chi tiết";
            // 
            // btn_timkiemngay
            // 
            this.btn_timkiemngay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timkiemngay.Location = new System.Drawing.Point(279, 2);
            this.btn_timkiemngay.Name = "btn_timkiemngay";
            this.btn_timkiemngay.Size = new System.Drawing.Size(96, 50);
            this.btn_timkiemngay.TabIndex = 5;
            this.btn_timkiemngay.Text = "Xem";
            this.btn_timkiemngay.UseVisualStyleBackColor = true;
            this.btn_timkiemngay.Click += new System.EventHandler(this.btn_timkiemngay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Image = global::QuanLyKhachSan.Properties.Resources.task__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(380, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Báo Cáo Doanh Thu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(584, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iDHDDataGridViewTextBoxColumn
            // 
            this.iDHDDataGridViewTextBoxColumn.DataPropertyName = "IDHD";
            this.iDHDDataGridViewTextBoxColumn.HeaderText = "ID HĐ";
            this.iDHDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDHDDataGridViewTextBoxColumn.Name = "iDHDDataGridViewTextBoxColumn";
            this.iDHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayGDDataGridViewTextBoxColumn
            // 
            this.ngayGDDataGridViewTextBoxColumn.DataPropertyName = "NgayGD";
            this.ngayGDDataGridViewTextBoxColumn.HeaderText = "Ngày Giao Dịch";
            this.ngayGDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayGDDataGridViewTextBoxColumn.Name = "ngayGDDataGridViewTextBoxColumn";
            this.ngayGDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenkhDataGridViewTextBoxColumn
            // 
            this.tenkhDataGridViewTextBoxColumn.DataPropertyName = "Tenkh";
            this.tenkhDataGridViewTextBoxColumn.HeaderText = "Khách Hàng";
            this.tenkhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenkhDataGridViewTextBoxColumn.Name = "tenkhDataGridViewTextBoxColumn";
            this.tenkhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDatphongDataGridViewTextBoxColumn
            // 
            this.iDDatphongDataGridViewTextBoxColumn.DataPropertyName = "IDDatphong";
            this.iDDatphongDataGridViewTextBoxColumn.HeaderText = "ID Đặt Phòng";
            this.iDDatphongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDatphongDataGridViewTextBoxColumn.Name = "iDDatphongDataGridViewTextBoxColumn";
            this.iDDatphongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Nhân Viên";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongHDDataGridViewTextBoxColumn
            // 
            this.tongHDDataGridViewTextBoxColumn.DataPropertyName = "TongHD";
            dataGridViewCellStyle1.Format = "N2";
            this.tongHDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tongHDDataGridViewTextBoxColumn.HeaderText = "Tổng HĐ";
            this.tongHDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tongHDDataGridViewTextBoxColumn.Name = "tongHDDataGridViewTextBoxColumn";
            this.tongHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_timkiemngay);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.cbb_chon);
            this.Controls.Add(this.Ngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_GiaoDich";
            this.Text = "GIAO DỊCH";
            this.Load += new System.EventHandler(this.frm_GiaoDich_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Ngay;
        private System.Windows.Forms.ComboBox cbb_chon;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.DataGridView dgv_hd;
        private System.Windows.Forms.BindingSource hoaDonDTOBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_timkiemngay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDatphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongHDDataGridViewTextBoxColumn;
    }
}