namespace QuanLyKhachSan
{
    partial class frm_DSDichVu
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_tim = new System.Windows.Forms.ComboBox();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_loaiDV = new System.Windows.Forms.ComboBox();
            this.loaiDichVuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_TenDV = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_DSDV = new System.Windows.Forms.DataGridView();
            this.dichVuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.iDDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiCHuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDichVuDTOBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 176);
            this.panel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.BackColor = System.Drawing.Color.Tomato;
            this.btn_thoat.Image = global::QuanLyKhachSan.Properties.Resources.times_hexagon__1_;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(858, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(104, 37);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Exit";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.cbb_tim);
            this.groupBox2.Controls.Add(this.txt_tim);
            this.groupBox2.Controls.Add(this.btn_tim);
            this.groupBox2.Controls.Add(this.btn_huy);
            this.groupBox2.Controls.Add(this.btn_capnhat);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(571, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // cbb_tim
            // 
            this.cbb_tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_tim.FormattingEnabled = true;
            this.cbb_tim.Items.AddRange(new object[] {
            "Tìm theo ID",
            "Tìm theo tên dịch vụ",
            "Tìm theo loại dịch vụ"});
            this.cbb_tim.Location = new System.Drawing.Point(21, 22);
            this.cbb_tim.Name = "cbb_tim";
            this.cbb_tim.Size = new System.Drawing.Size(351, 28);
            this.cbb_tim.TabIndex = 5;
            // 
            // txt_tim
            // 
            this.txt_tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tim.Location = new System.Drawing.Point(23, 54);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(295, 26);
            this.txt_tim.TabIndex = 4;
            // 
            // btn_tim
            // 
            this.btn_tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tim.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_2023_04_12_040044;
            this.btn_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tim.Location = new System.Drawing.Point(320, 49);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(52, 38);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_huy.BackColor = System.Drawing.Color.LightCoral;
            this.btn_huy.Image = global::QuanLyKhachSan.Properties.Resources.trash;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(287, 86);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(89, 37);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_capnhat.Image = global::QuanLyKhachSan.Properties.Resources.settings;
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(137, 87);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(143, 37);
            this.btn_capnhat.TabIndex = 1;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(21, 86);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 38);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbb_loaiDV);
            this.groupBox1.Controls.Add(this.txt_GhiChu);
            this.groupBox1.Controls.Add(this.txt_dongia);
            this.groupBox1.Controls.Add(this.txt_TenDV);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.button1.Location = new System.Drawing.Point(254, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 27);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_loaiDV
            // 
            this.cbb_loaiDV.DataSource = this.loaiDichVuDTOBindingSource;
            this.cbb_loaiDV.DisplayMember = "TenLoaiDV";
            this.cbb_loaiDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaiDV.FormattingEnabled = true;
            this.cbb_loaiDV.Location = new System.Drawing.Point(59, 51);
            this.cbb_loaiDV.Name = "cbb_loaiDV";
            this.cbb_loaiDV.Size = new System.Drawing.Size(195, 28);
            this.cbb_loaiDV.TabIndex = 5;
            this.cbb_loaiDV.ValueMember = "IDLDV";
            this.cbb_loaiDV.DropDown += new System.EventHandler(this.cbb_loaiDV_DropDown);
            // 
            // loaiDichVuDTOBindingSource
            // 
            this.loaiDichVuDTOBindingSource.DataSource = typeof(DTO.Loai_DichVu_DTO);
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(84, 81);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(438, 44);
            this.txt_GhiChu.TabIndex = 4;
            this.txt_GhiChu.TextChanged += new System.EventHandler(this.txt_GhiChu_TextChanged);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(381, 52);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(141, 26);
            this.txt_dongia.TabIndex = 4;
            this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
            // 
            // txt_TenDV
            // 
            this.txt_TenDV.Location = new System.Drawing.Point(250, 23);
            this.txt_TenDV.Name = "txt_TenDV";
            this.txt_TenDV.Size = new System.Drawing.Size(272, 26);
            this.txt_TenDV.TabIndex = 4;
            this.txt_TenDV.TextChanged += new System.EventHandler(this.txt_TenDV_TextChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(43, 23);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(130, 26);
            this.txt_ID.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ghi chú :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên DV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH DỊCH VỤ ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_DSDV);
            this.panel2.Location = new System.Drawing.Point(17, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 394);
            this.panel2.TabIndex = 1;
            // 
            // dgv_DSDV
            // 
            this.dgv_DSDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSDV.AutoGenerateColumns = false;
            this.dgv_DSDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSDV.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDVDataGridViewTextBoxColumn,
            this.tenDVDataGridViewTextBoxColumn,
            this.tenLoaiDVDataGridViewTextBoxColumn,
            this.dongiaDVDataGridViewTextBoxColumn,
            this.ghiCHuDataGridViewTextBoxColumn});
            this.dgv_DSDV.DataSource = this.dichVuDTOBindingSource;
            this.dgv_DSDV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_DSDV.Location = new System.Drawing.Point(0, 0);
            this.dgv_DSDV.MultiSelect = false;
            this.dgv_DSDV.Name = "dgv_DSDV";
            this.dgv_DSDV.ReadOnly = true;
            this.dgv_DSDV.RowHeadersWidth = 62;
            this.dgv_DSDV.RowTemplate.Height = 28;
            this.dgv_DSDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSDV.Size = new System.Drawing.Size(934, 394);
            this.dgv_DSDV.TabIndex = 0;
            this.dgv_DSDV.DoubleClick += new System.EventHandler(this.dgv_DSDV_DoubleClick);
            // 
            // dichVuDTOBindingSource
            // 
            this.dichVuDTOBindingSource.DataSource = typeof(DTO.DichVu_DTO);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(629, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(314, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Double click vào dịch vụ cần cập nhật!";
            // 
            // iDDVDataGridViewTextBoxColumn
            // 
            this.iDDVDataGridViewTextBoxColumn.DataPropertyName = "IDDV";
            this.iDDVDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDVDataGridViewTextBoxColumn.Name = "iDDVDataGridViewTextBoxColumn";
            this.iDDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDVDataGridViewTextBoxColumn
            // 
            this.tenDVDataGridViewTextBoxColumn.DataPropertyName = "TenDV";
            this.tenDVDataGridViewTextBoxColumn.HeaderText = "DỊCH VỤ";
            this.tenDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDVDataGridViewTextBoxColumn.Name = "tenDVDataGridViewTextBoxColumn";
            this.tenDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDVDataGridViewTextBoxColumn
            // 
            this.tenLoaiDVDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiDV";
            this.tenLoaiDVDataGridViewTextBoxColumn.HeaderText = "LOẠI DV";
            this.tenLoaiDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenLoaiDVDataGridViewTextBoxColumn.Name = "tenLoaiDVDataGridViewTextBoxColumn";
            this.tenLoaiDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dongiaDVDataGridViewTextBoxColumn
            // 
            this.dongiaDVDataGridViewTextBoxColumn.DataPropertyName = "DongiaDV";
            dataGridViewCellStyle1.Format = "n2";
            dataGridViewCellStyle1.NullValue = null;
            this.dongiaDVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dongiaDVDataGridViewTextBoxColumn.HeaderText = "ĐƠN GIÁ";
            this.dongiaDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaDVDataGridViewTextBoxColumn.Name = "dongiaDVDataGridViewTextBoxColumn";
            this.dongiaDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghiCHuDataGridViewTextBoxColumn
            // 
            this.ghiCHuDataGridViewTextBoxColumn.DataPropertyName = "GhiCHu";
            this.ghiCHuDataGridViewTextBoxColumn.HeaderText = "GHI CHÚ";
            this.ghiCHuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ghiCHuDataGridViewTextBoxColumn.Name = "ghiCHuDataGridViewTextBoxColumn";
            this.ghiCHuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_DSDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(964, 619);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_DSDichVu";
            this.Text = "DANH SÁCH DỊCH VỤ";
            this.Load += new System.EventHandler(this.frm_DSDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDichVuDTOBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_loaiDV;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_TenDV;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_DSDV;
        private System.Windows.Forms.BindingSource dichVuDTOBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource loaiDichVuDTOBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiCHuDataGridViewTextBoxColumn;
    }
}