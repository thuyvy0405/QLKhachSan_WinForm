namespace QuanLyKhachSan
{
    partial class frm_CapNhat_LoaiPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_idloai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numer_sogiuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dongiaNgay = new System.Windows.Forms.TextBox();
            this.nume_songuoi = new System.Windows.Forms.NumericUpDown();
            this.txt_dongiaGio = new System.Windows.Forms.TextBox();
            this.txt_tenLoai = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numer_sogiuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nume_songuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CẬP NHẬT LOẠI PHÒNG";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txt_idloai);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numer_sogiuong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_dongiaNgay);
            this.panel1.Controls.Add(this.nume_songuoi);
            this.panel1.Controls.Add(this.txt_dongiaGio);
            this.panel1.Controls.Add(this.txt_tenLoai);
            this.panel1.Location = new System.Drawing.Point(24, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 162);
            this.panel1.TabIndex = 2;
            // 
            // txt_idloai
            // 
            this.txt_idloai.Enabled = false;
            this.txt_idloai.Location = new System.Drawing.Point(100, 6);
            this.txt_idloai.Name = "txt_idloai";
            this.txt_idloai.Size = new System.Drawing.Size(404, 26);
            this.txt_idloai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn ngày:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID loại :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên loại :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá giờ :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số giường :";
            // 
            // numer_sogiuong
            // 
            this.numer_sogiuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numer_sogiuong.Location = new System.Drawing.Point(341, 63);
            this.numer_sogiuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numer_sogiuong.Name = "numer_sogiuong";
            this.numer_sogiuong.Size = new System.Drawing.Size(101, 26);
            this.numer_sogiuong.TabIndex = 1;
            this.numer_sogiuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số người :";
            // 
            // txt_dongiaNgay
            // 
            this.txt_dongiaNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dongiaNgay.Location = new System.Drawing.Point(100, 123);
            this.txt_dongiaNgay.Name = "txt_dongiaNgay";
            this.txt_dongiaNgay.Size = new System.Drawing.Size(404, 26);
            this.txt_dongiaNgay.TabIndex = 0;
            // 
            // nume_songuoi
            // 
            this.nume_songuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nume_songuoi.Location = new System.Drawing.Point(100, 62);
            this.nume_songuoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nume_songuoi.Name = "nume_songuoi";
            this.nume_songuoi.Size = new System.Drawing.Size(111, 26);
            this.nume_songuoi.TabIndex = 1;
            this.nume_songuoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_dongiaGio
            // 
            this.txt_dongiaGio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dongiaGio.Location = new System.Drawing.Point(100, 94);
            this.txt_dongiaGio.Name = "txt_dongiaGio";
            this.txt_dongiaGio.Size = new System.Drawing.Size(404, 26);
            this.txt_dongiaGio.TabIndex = 0;
            // 
            // txt_tenLoai
            // 
            this.txt_tenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenLoai.Location = new System.Drawing.Point(100, 32);
            this.txt_tenLoai.Name = "txt_tenLoai";
            this.txt_tenLoai.Size = new System.Drawing.Size(404, 26);
            this.txt_tenLoai.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Image = global::QuanLyKhachSan.Properties.Resources.times_hexagon__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(316, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hủy";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_capnhat.BackColor = System.Drawing.Color.Linen;
            this.btn_capnhat.Image = global::QuanLyKhachSan.Properties.Resources.settings;
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(155, 233);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(108, 42);
            this.btn_capnhat.TabIndex = 3;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // frm_CapNhat_LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_CapNhat_LoaiPhong";
            this.Text = "CẬP NHẬT LOẠI PHÒNG";
            this.Load += new System.EventHandler(this.frm_CapNhat_LoaiPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numer_sogiuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nume_songuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numer_sogiuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nume_songuoi;
        private System.Windows.Forms.TextBox txt_tenLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dongiaNgay;
        private System.Windows.Forms.TextBox txt_dongiaGio;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_idloai;
        private System.Windows.Forms.Label label7;
    }
}