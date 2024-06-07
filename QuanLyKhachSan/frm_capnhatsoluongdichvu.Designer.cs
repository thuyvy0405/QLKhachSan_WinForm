namespace QuanLyKhachSan
{
    partial class frm_capnhatsoluongdichvu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.numericUpDownsoluong = new System.Windows.Forms.NumericUpDown();
            this.txt_thanhtien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tendichvu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_huy);
            this.panel1.Controls.Add(this.btn_capnhat);
            this.panel1.Controls.Add(this.numericUpDownsoluong);
            this.panel1.Controls.Add(this.txt_thanhtien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtdongia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_tendichvu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 187);
            this.panel1.TabIndex = 4;
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_huy.Image = global::QuanLyKhachSan.Properties.Resources.trash;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(202, 131);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(81, 39);
            this.btn_huy.TabIndex = 13;
            this.btn_huy.Text = "HỦY";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click_1);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_capnhat.Image = global::QuanLyKhachSan.Properties.Resources.settings;
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(52, 131);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(126, 39);
            this.btn_capnhat.TabIndex = 12;
            this.btn_capnhat.Text = "CẬP NHẬT";
            this.btn_capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click_1);
            // 
            // numericUpDownsoluong
            // 
            this.numericUpDownsoluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownsoluong.Location = new System.Drawing.Point(189, 68);
            this.numericUpDownsoluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownsoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownsoluong.Name = "numericUpDownsoluong";
            this.numericUpDownsoluong.Size = new System.Drawing.Size(111, 26);
            this.numericUpDownsoluong.TabIndex = 11;
            this.numericUpDownsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownsoluong.ValueChanged += new System.EventHandler(this.numericUpDownsoluong_ValueChanged_1);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thanhtien.AutoSize = true;
            this.txt_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhtien.ForeColor = System.Drawing.Color.Red;
            this.txt_thanhtien.Location = new System.Drawing.Point(185, 104);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(108, 20);
            this.txt_thanhtien.TabIndex = 4;
            this.txt_thanhtien.Text = "THÀNH TIỀN:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "THÀNH TIỀN:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SỐ LƯỢNG:";
            // 
            // txtdongia
            // 
            this.txtdongia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdongia.AutoSize = true;
            this.txtdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdongia.Location = new System.Drawing.Point(185, 43);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(81, 20);
            this.txtdongia.TabIndex = 7;
            this.txtdongia.Text = "ĐƠN GIÁ:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ĐƠN GIÁ:";
            // 
            // txt_tendichvu
            // 
            this.txt_tendichvu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tendichvu.AutoSize = true;
            this.txt_tendichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendichvu.Location = new System.Drawing.Point(185, 16);
            this.txt_tendichvu.Name = "txt_tendichvu";
            this.txt_tendichvu.Size = new System.Drawing.Size(115, 20);
            this.txt_tendichvu.TabIndex = 9;
            this.txt_tendichvu.Text = "TÊN DỊCH VỤ:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "TÊN DỊCH VỤ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "CẬP NHẬT SỐ LƯỢNG DỊCH VỤ";
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthoat.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_20221115_052711;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthoat.Location = new System.Drawing.Point(339, 1);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(31, 25);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frm_capnhatsoluongdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(373, 231);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_capnhatsoluongdichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT SỐ LƯỢNG DỊCH VỤ";
            this.Load += new System.EventHandler(this.frm_capnhatsoluongdichvu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.NumericUpDown numericUpDownsoluong;
        private System.Windows.Forms.Label txt_thanhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtdongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_tendichvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthoat;
    }
}