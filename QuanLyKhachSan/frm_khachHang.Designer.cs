namespace QuanLyKhachSan
{
    partial class frm_khachHang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.cbb_chon = new System.Windows.Forms.ComboBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.khachHangDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Dchi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_dskhachhang = new System.Windows.Forms.DataGridView();
            this.iDKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTKhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dchiKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txt_tim);
            this.groupBox3.Controls.Add(this.cbb_chon);
            this.groupBox3.Controls.Add(this.btn_tim);
            this.groupBox3.Controls.Add(this.btn_dong);
            this.groupBox3.Controls.Add(this.btn_huy);
            this.groupBox3.Controls.Add(this.btn_capnhat);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(512, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 153);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // txt_tim
            // 
            this.txt_tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(17, 66);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(349, 26);
            this.txt_tim.TabIndex = 7;
            this.txt_tim.Text = "Nhập để tìm";
            this.txt_tim.Click += new System.EventHandler(this.txt_tim_Click);
            this.txt_tim.Leave += new System.EventHandler(this.txt_tim_Leave);
            // 
            // cbb_chon
            // 
            this.cbb_chon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chon.FormattingEnabled = true;
            this.cbb_chon.Items.AddRange(new object[] {
            "Tìm theo Tên",
            "Tìm theo SĐT",
            "Tìm theo CCCD"});
            this.cbb_chon.Location = new System.Drawing.Point(17, 32);
            this.cbb_chon.Name = "cbb_chon";
            this.cbb_chon.Size = new System.Drawing.Size(349, 28);
            this.cbb_chon.TabIndex = 1;
            this.cbb_chon.Text = "Chọn điều kiện tìm";
            // 
            // btn_tim
            // 
            this.btn_tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tim.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_2023_04_12_040044;
            this.btn_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tim.Location = new System.Drawing.Point(372, 38);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(57, 54);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dong.BackColor = System.Drawing.Color.IndianRed;
            this.btn_dong.Image = global::QuanLyKhachSan.Properties.Resources.exit__1_;
            this.btn_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dong.Location = new System.Drawing.Point(346, 98);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(84, 40);
            this.btn_dong.TabIndex = 11;
            this.btn_dong.Text = "Exit";
            this.btn_dong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_huy.BackColor = System.Drawing.Color.IndianRed;
            this.btn_huy.Image = global::QuanLyKhachSan.Properties.Resources.time_delete;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(245, 99);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(84, 40);
            this.btn_huy.TabIndex = 11;
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
            this.btn_capnhat.Location = new System.Drawing.Point(111, 98);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(119, 40);
            this.btn_capnhat.TabIndex = 10;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_them.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(15, 98);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 40);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // khachHangDTOBindingSource
            // 
            this.khachHangDTOBindingSource.DataSource = typeof(DTO.KhachHang_DTO);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_Dchi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_cccd);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_Dchi
            // 
            this.txt_Dchi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Dchi.Location = new System.Drawing.Point(67, 117);
            this.txt_Dchi.Name = "txt_Dchi";
            this.txt_Dchi.Size = new System.Drawing.Size(413, 26);
            this.txt_Dchi.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(68, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sdt.Location = new System.Drawing.Point(310, 86);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(170, 26);
            this.txt_sdt.TabIndex = 3;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cccd.Location = new System.Drawing.Point(68, 86);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(170, 26);
            this.txt_cccd.TabIndex = 2;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_hoten.Location = new System.Drawing.Point(68, 22);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(278, 26);
            this.txt_hoten.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.rad_nu);
            this.groupBox2.Controls.Add(this.rad_Nam);
            this.groupBox2.Location = new System.Drawing.Point(358, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 53);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rad_nu
            // 
            this.rad_nu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(72, 17);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(54, 24);
            this.rad_nu.TabIndex = 5;
            this.rad_nu.TabStop = true;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Location = new System.Drawing.Point(6, 18);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(67, 24);
            this.rad_Nam.TabIndex = 5;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SĐT:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "CCCD:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgv_dskhachhang);
            this.groupBox4.Location = new System.Drawing.Point(0, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(978, 451);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // dgv_dskhachhang
            // 
            this.dgv_dskhachhang.AutoGenerateColumns = false;
            this.dgv_dskhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dskhachhang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dskhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dskhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.cCCDKHDataGridViewTextBoxColumn,
            this.sDTKhDataGridViewTextBoxColumn,
            this.phaiDataGridViewTextBoxColumn,
            this.emailKHDataGridViewTextBoxColumn,
            this.dchiKHDataGridViewTextBoxColumn});
            this.dgv_dskhachhang.DataSource = this.khachHangDTOBindingSource;
            this.dgv_dskhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dskhachhang.Location = new System.Drawing.Point(3, 22);
            this.dgv_dskhachhang.MultiSelect = false;
            this.dgv_dskhachhang.Name = "dgv_dskhachhang";
            this.dgv_dskhachhang.ReadOnly = true;
            this.dgv_dskhachhang.RowHeadersWidth = 62;
            this.dgv_dskhachhang.RowTemplate.Height = 28;
            this.dgv_dskhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dskhachhang.Size = new System.Drawing.Size(972, 426);
            this.dgv_dskhachhang.TabIndex = 0;
            this.dgv_dskhachhang.Click += new System.EventHandler(this.dgv_dskhachhang_Click_1);
            // 
            // iDKHDataGridViewTextBoxColumn
            // 
            this.iDKHDataGridViewTextBoxColumn.DataPropertyName = "IDKH";
            this.iDKHDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDKHDataGridViewTextBoxColumn.Name = "iDKHDataGridViewTextBoxColumn";
            this.iDKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "Tên ";
            this.tenKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            this.tenKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCCDKHDataGridViewTextBoxColumn
            // 
            this.cCCDKHDataGridViewTextBoxColumn.DataPropertyName = "CCCD_KH";
            this.cCCDKHDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cCCDKHDataGridViewTextBoxColumn.Name = "cCCDKHDataGridViewTextBoxColumn";
            this.cCCDKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTKhDataGridViewTextBoxColumn
            // 
            this.sDTKhDataGridViewTextBoxColumn.DataPropertyName = "SDT_Kh";
            this.sDTKhDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTKhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sDTKhDataGridViewTextBoxColumn.Name = "sDTKhDataGridViewTextBoxColumn";
            this.sDTKhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phaiDataGridViewTextBoxColumn
            // 
            this.phaiDataGridViewTextBoxColumn.DataPropertyName = "Phai";
            this.phaiDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.phaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phaiDataGridViewTextBoxColumn.Name = "phaiDataGridViewTextBoxColumn";
            this.phaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailKHDataGridViewTextBoxColumn
            // 
            this.emailKHDataGridViewTextBoxColumn.DataPropertyName = "Email_KH";
            this.emailKHDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailKHDataGridViewTextBoxColumn.Name = "emailKHDataGridViewTextBoxColumn";
            this.emailKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dchiKHDataGridViewTextBoxColumn
            // 
            this.dchiKHDataGridViewTextBoxColumn.DataPropertyName = "Dchi_KH";
            this.dchiKHDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.dchiKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dchiKHDataGridViewTextBoxColumn.Name = "dchiKHDataGridViewTextBoxColumn";
            this.dchiKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_khachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(978, 612);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_khachHang";
            this.Text = "DANH SÁCH KHÁCH HÀNG";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.ComboBox cbb_chon;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.BindingSource khachHangDTOBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Dchi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_dskhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTKhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dchiKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_dong;
    }
}