namespace QuanLyKhachSan
{
    partial class frm_themphong
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
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_themmoiphong = new System.Windows.Forms.Button();
            this.btn_themloaiphong = new System.Windows.Forms.Button();
            this.btn_themtang = new System.Windows.Forms.Button();
            this.cbb_loaiphong = new System.Windows.Forms.ComboBox();
            this.cbb_tang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dong
            // 
            this.btn_dong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dong.Image = global::QuanLyKhachSan.Properties.Resources.Screenshot_20221102_080018;
            this.btn_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dong.Location = new System.Drawing.Point(276, 230);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(130, 55);
            this.btn_dong.TabIndex = 16;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_themmoiphong
            // 
            this.btn_themmoiphong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_themmoiphong.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btn_themmoiphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themmoiphong.Location = new System.Drawing.Point(129, 230);
            this.btn_themmoiphong.Name = "btn_themmoiphong";
            this.btn_themmoiphong.Size = new System.Drawing.Size(120, 55);
            this.btn_themmoiphong.TabIndex = 17;
            this.btn_themmoiphong.Text = "Thêm";
            this.btn_themmoiphong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themmoiphong.UseVisualStyleBackColor = true;
            this.btn_themmoiphong.Click += new System.EventHandler(this.btn_themmoiphong_Click);
            // 
            // btn_themloaiphong
            // 
            this.btn_themloaiphong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_themloaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themloaiphong.Location = new System.Drawing.Point(469, 171);
            this.btn_themloaiphong.Name = "btn_themloaiphong";
            this.btn_themloaiphong.Size = new System.Drawing.Size(47, 27);
            this.btn_themloaiphong.TabIndex = 14;
            this.btn_themloaiphong.Text = "- - -";
            this.btn_themloaiphong.UseVisualStyleBackColor = true;
            this.btn_themloaiphong.Click += new System.EventHandler(this.btn_themloaiphong_Click);
            // 
            // btn_themtang
            // 
            this.btn_themtang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_themtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themtang.Location = new System.Drawing.Point(469, 137);
            this.btn_themtang.Name = "btn_themtang";
            this.btn_themtang.Size = new System.Drawing.Size(47, 27);
            this.btn_themtang.TabIndex = 15;
            this.btn_themtang.Text = "- - -";
            this.btn_themtang.UseVisualStyleBackColor = true;
            this.btn_themtang.Click += new System.EventHandler(this.btn_themtang_Click);
            // 
            // cbb_loaiphong
            // 
            this.cbb_loaiphong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_loaiphong.DisplayMember = "TenLoaiP";
            this.cbb_loaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaiphong.FormattingEnabled = true;
            this.cbb_loaiphong.Location = new System.Drawing.Point(157, 171);
            this.cbb_loaiphong.Name = "cbb_loaiphong";
            this.cbb_loaiphong.Size = new System.Drawing.Size(297, 28);
            this.cbb_loaiphong.TabIndex = 11;
            this.cbb_loaiphong.ValueMember = "IDLoaiP";
            this.cbb_loaiphong.DropDown += new System.EventHandler(this.cbb_loaiphong_DropDown);
            // 
            // cbb_tang
            // 
            this.cbb_tang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_tang.DisplayMember = "TenTang";
            this.cbb_tang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tang.FormattingEnabled = true;
            this.cbb_tang.Location = new System.Drawing.Point(157, 137);
            this.cbb_tang.Name = "cbb_tang";
            this.cbb_tang.Size = new System.Drawing.Size(297, 28);
            this.cbb_tang.TabIndex = 12;
            this.cbb_tang.ValueMember = "IDtang";
            this.cbb_tang.DropDown += new System.EventHandler(this.cbb_tang_DropDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại phòng:";
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_trangthai.DisplayMember = "TenTTPhong";
            this.cbb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Location = new System.Drawing.Point(157, 104);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(297, 28);
            this.cbb_trangthai.TabIndex = 13;
            this.cbb_trangthai.ValueMember = "IDTTPhong";
            this.cbb_trangthai.DropDown += new System.EventHandler(this.cbb_trangthai_DropDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tầng:";
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tenphong.Location = new System.Drawing.Point(157, 73);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(298, 26);
            this.txt_tenphong.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(44, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "NHẬP THÔNG TIN PHÒNG";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên phòng:";
            // 
            // frm_themphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 306);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_themmoiphong);
            this.Controls.Add(this.btn_themloaiphong);
            this.Controls.Add(this.btn_themtang);
            this.Controls.Add(this.cbb_loaiphong);
            this.Controls.Add(this.cbb_tang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_trangthai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_themphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM PHÒNG";
            this.Load += new System.EventHandler(this.frm_themphong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_themmoiphong;
        private System.Windows.Forms.Button btn_themloaiphong;
        private System.Windows.Forms.Button btn_themtang;
        private System.Windows.Forms.ComboBox cbb_loaiphong;
        private System.Windows.Forms.ComboBox cbb_tang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_trangthai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}