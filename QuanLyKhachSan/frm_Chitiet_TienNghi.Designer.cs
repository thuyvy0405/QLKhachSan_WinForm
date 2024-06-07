namespace QuanLyKhachSan
{
    partial class frm_Chitiet_TienNghi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timNV = new System.Windows.Forms.Button();
            this.txt_timNV = new System.Windows.Forms.TextBox();
            this.cbb_chon = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cbb_tiennghi = new System.Windows.Forms.ComboBox();
            this.tienNghiDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_phong = new System.Windows.Forms.ComboBox();
            this.phongDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_ds_chitietTN = new System.Windows.Forms.DataGridView();
            this.TenTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPHong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thgianSuDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitietTienNghiDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numer_SL = new System.Windows.Forms.NumericUpDown();
            this.NgaySD_Datetime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tienNghiDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongDTOBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_chitietTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietTienNghiDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numer_SL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbb_tiennghi);
            this.panel1.Controls.Add(this.cbb_phong);
            this.panel1.Controls.Add(this.txt_ghiChu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.numer_SL);
            this.panel1.Controls.Add(this.NgaySD_Datetime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 442);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btn_timNV);
            this.groupBox1.Controls.Add(this.txt_timNV);
            this.groupBox1.Controls.Add(this.cbb_chon);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Location = new System.Drawing.Point(4, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 58);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_timNV
            // 
            this.btn_timNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_timNV.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_2023_04_12_040044;
            this.btn_timNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timNV.Location = new System.Drawing.Point(431, 17);
            this.btn_timNV.Name = "btn_timNV";
            this.btn_timNV.Size = new System.Drawing.Size(43, 35);
            this.btn_timNV.TabIndex = 13;
            this.btn_timNV.UseVisualStyleBackColor = true;
            this.btn_timNV.Click += new System.EventHandler(this.btn_timNV_Click);
            // 
            // txt_timNV
            // 
            this.txt_timNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_timNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timNV.Location = new System.Drawing.Point(195, 23);
            this.txt_timNV.Name = "txt_timNV";
            this.txt_timNV.Size = new System.Drawing.Size(230, 26);
            this.txt_timNV.TabIndex = 12;
            this.txt_timNV.Text = "Nhập để tìm";
            this.txt_timNV.Click += new System.EventHandler(this.txt_timNV_Click);
            this.txt_timNV.Leave += new System.EventHandler(this.txt_timNV_Leave);
            // 
            // cbb_chon
            // 
            this.cbb_chon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chon.FormattingEnabled = true;
            this.cbb_chon.Items.AddRange(new object[] {
            "Tìm theo Tên TN",
            "Tìm theo ID TN"});
            this.cbb_chon.Location = new System.Drawing.Point(19, 21);
            this.cbb_chon.Name = "cbb_chon";
            this.cbb_chon.Size = new System.Drawing.Size(170, 28);
            this.cbb_chon.TabIndex = 11;
            this.cbb_chon.Text = "Chọn điều kiện tìm";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Image = global::QuanLyKhachSan.Properties.Resources.time_delete;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(706, 17);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 30);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_capnhat.BackColor = System.Drawing.Color.White;
            this.btn_capnhat.Image = global::QuanLyKhachSan.Properties.Resources.settings;
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(575, 19);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(125, 30);
            this.btn_capnhat.TabIndex = 10;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(479, 18);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 31);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cbb_tiennghi
            // 
            this.cbb_tiennghi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_tiennghi.DataSource = this.tienNghiDTOBindingSource;
            this.cbb_tiennghi.DisplayMember = "TenTN";
            this.cbb_tiennghi.FormattingEnabled = true;
            this.cbb_tiennghi.Location = new System.Drawing.Point(148, 12);
            this.cbb_tiennghi.Name = "cbb_tiennghi";
            this.cbb_tiennghi.Size = new System.Drawing.Size(275, 28);
            this.cbb_tiennghi.TabIndex = 8;
            this.cbb_tiennghi.ValueMember = "IDTN";
            // 
            // tienNghiDTOBindingSource
            // 
            this.tienNghiDTOBindingSource.DataSource = typeof(DTO.TienNghi_DTO);
            // 
            // cbb_phong
            // 
            this.cbb_phong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_phong.DataSource = this.phongDTOBindingSource;
            this.cbb_phong.DisplayMember = "TenPhong";
            this.cbb_phong.FormattingEnabled = true;
            this.cbb_phong.Location = new System.Drawing.Point(503, 12);
            this.cbb_phong.Name = "cbb_phong";
            this.cbb_phong.Size = new System.Drawing.Size(254, 28);
            this.cbb_phong.TabIndex = 8;
            this.cbb_phong.ValueMember = "IDPhong";
            // 
            // phongDTOBindingSource
            // 
            this.phongDTOBindingSource.DataSource = typeof(DTO.Phong_DTO);
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ghiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghiChu.Location = new System.Drawing.Point(107, 79);
            this.txt_ghiChu.Multiline = true;
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ghiChu.Size = new System.Drawing.Size(691, 47);
            this.txt_ghiChu.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_ds_chitietTN);
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 249);
            this.panel2.TabIndex = 6;
            // 
            // dgv_ds_chitietTN
            // 
            this.dgv_ds_chitietTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ds_chitietTN.AutoGenerateColumns = false;
            this.dgv_ds_chitietTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ds_chitietTN.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ds_chitietTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds_chitietTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTN,
            this.TenPHong,
            this.thgianSuDungDataGridViewTextBoxColumn,
            this.soluongSDDataGridViewTextBoxColumn,
            this.ghiChuTNDataGridViewTextBoxColumn});
            this.dgv_ds_chitietTN.DataSource = this.chitietTienNghiDTOBindingSource;
            this.dgv_ds_chitietTN.Location = new System.Drawing.Point(0, 0);
            this.dgv_ds_chitietTN.MultiSelect = false;
            this.dgv_ds_chitietTN.Name = "dgv_ds_chitietTN";
            this.dgv_ds_chitietTN.ReadOnly = true;
            this.dgv_ds_chitietTN.RowHeadersWidth = 62;
            this.dgv_ds_chitietTN.RowTemplate.Height = 28;
            this.dgv_ds_chitietTN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_chitietTN.Size = new System.Drawing.Size(813, 249);
            this.dgv_ds_chitietTN.TabIndex = 0;
            this.dgv_ds_chitietTN.Click += new System.EventHandler(this.dgv_ds_chitietTN_Click);
            // 
            // TenTN
            // 
            this.TenTN.DataPropertyName = "TenTN";
            this.TenTN.HeaderText = "Tiện Nghi";
            this.TenTN.MinimumWidth = 8;
            this.TenTN.Name = "TenTN";
            this.TenTN.ReadOnly = true;
            // 
            // TenPHong
            // 
            this.TenPHong.DataPropertyName = "TenPHong";
            this.TenPHong.HeaderText = "Phòng";
            this.TenPHong.MinimumWidth = 8;
            this.TenPHong.Name = "TenPHong";
            this.TenPHong.ReadOnly = true;
            // 
            // thgianSuDungDataGridViewTextBoxColumn
            // 
            this.thgianSuDungDataGridViewTextBoxColumn.DataPropertyName = "ThgianSuDung";
            this.thgianSuDungDataGridViewTextBoxColumn.HeaderText = "Thời gian BD sử dụng";
            this.thgianSuDungDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thgianSuDungDataGridViewTextBoxColumn.Name = "thgianSuDungDataGridViewTextBoxColumn";
            this.thgianSuDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soluongSDDataGridViewTextBoxColumn
            // 
            this.soluongSDDataGridViewTextBoxColumn.DataPropertyName = "SoluongSD";
            this.soluongSDDataGridViewTextBoxColumn.HeaderText = "Số lượng SD";
            this.soluongSDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soluongSDDataGridViewTextBoxColumn.Name = "soluongSDDataGridViewTextBoxColumn";
            this.soluongSDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghiChuTNDataGridViewTextBoxColumn
            // 
            this.ghiChuTNDataGridViewTextBoxColumn.DataPropertyName = "GhiChu_TN";
            this.ghiChuTNDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuTNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ghiChuTNDataGridViewTextBoxColumn.Name = "ghiChuTNDataGridViewTextBoxColumn";
            this.ghiChuTNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chitietTienNghiDTOBindingSource
            // 
            this.chitietTienNghiDTOBindingSource.DataSource = typeof(DTO.Chitiet_TienNghi_DTO);
            // 
            // numer_SL
            // 
            this.numer_SL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numer_SL.Location = new System.Drawing.Point(571, 46);
            this.numer_SL.Name = "numer_SL";
            this.numer_SL.Size = new System.Drawing.Size(144, 26);
            this.numer_SL.TabIndex = 5;
            // 
            // NgaySD_Datetime
            // 
            this.NgaySD_Datetime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NgaySD_Datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgaySD_Datetime.Location = new System.Drawing.Point(301, 45);
            this.NgaySD_Datetime.Name = "NgaySD_Datetime";
            this.NgaySD_Datetime.Size = new System.Drawing.Size(177, 26);
            this.NgaySD_Datetime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian bắt đầu sử dụng:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phòng:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi Chú:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiện nghi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT TIỆN NGHI ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources._3;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(782, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Chitiet_TienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(836, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Chitiet_TienNghi";
            this.Text = "Chi tiết tiện nghi";
            this.Load += new System.EventHandler(this.frm_Chitiet_TienNghi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tienNghiDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongDTOBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_chitietTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietTienNghiDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numer_SL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbb_tiennghi;
        private System.Windows.Forms.ComboBox cbb_phong;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_ds_chitietTN;
        private System.Windows.Forms.BindingSource chitietTienNghiDTOBindingSource;
        private System.Windows.Forms.NumericUpDown numer_SL;
        private System.Windows.Forms.DateTimePicker NgaySD_Datetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tienNghiDTOBindingSource;
        private System.Windows.Forms.BindingSource phongDTOBindingSource;
        private System.Windows.Forms.Button btn_timNV;
        private System.Windows.Forms.TextBox txt_timNV;
        private System.Windows.Forms.ComboBox cbb_chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPHong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thgianSuDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
    }
}