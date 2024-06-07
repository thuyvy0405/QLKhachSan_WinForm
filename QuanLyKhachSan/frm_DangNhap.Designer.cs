namespace QuanLyKhachSan
{
    partial class frm_DangNhap
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
            this.checkBox_Hienpass = new System.Windows.Forms.CheckBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.linkLb_quenmk = new System.Windows.Forms.LinkLabel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_tb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶNG NHẬP";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkBox_Hienpass);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 132);
            this.panel1.TabIndex = 2;
            // 
            // checkBox_Hienpass
            // 
            this.checkBox_Hienpass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Hienpass.AutoSize = true;
            this.checkBox_Hienpass.Location = new System.Drawing.Point(107, 102);
            this.checkBox_Hienpass.Name = "checkBox_Hienpass";
            this.checkBox_Hienpass.Size = new System.Drawing.Size(153, 24);
            this.checkBox_Hienpass.TabIndex = 2;
            this.checkBox_Hienpass.Text = "Hiện password";
            this.checkBox_Hienpass.UseVisualStyleBackColor = true;
            this.checkBox_Hienpass.CheckedChanged += new System.EventHandler(this.checkBox_Hienpass_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(82, 62);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(244, 34);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Text = "Password";
            this.txt_pass.Click += new System.EventHandler(this.txt_pass_Click);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // txt_user
            // 
            this.txt_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(82, 13);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(244, 34);
            this.txt_user.TabIndex = 0;
            this.txt_user.Text = "Tên tài khoản";
            this.txt_user.Click += new System.EventHandler(this.txt_user_Click);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.password;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(29, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 44);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.profile;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(29, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dangnhap.Image = global::QuanLyKhachSan.Properties.Resources.shield_check;
            this.btn_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangnhap.Location = new System.Drawing.Point(102, 202);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_dangnhap.Size = new System.Drawing.Size(171, 45);
            this.btn_dangnhap.TabIndex = 3;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // linkLb_quenmk
            // 
            this.linkLb_quenmk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.linkLb_quenmk.AutoSize = true;
            this.linkLb_quenmk.Location = new System.Drawing.Point(117, 249);
            this.linkLb_quenmk.Name = "linkLb_quenmk";
            this.linkLb_quenmk.Size = new System.Drawing.Size(146, 20);
            this.linkLb_quenmk.TabIndex = 4;
            this.linkLb_quenmk.TabStop = true;
            this.linkLb_quenmk.Text = "Quên mật khẩu ?";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_20221115_052711;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.Location = new System.Drawing.Point(328, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(38, 31);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_tb
            // 
            this.lb_tb.AutoSize = true;
            this.lb_tb.ForeColor = System.Drawing.Color.Brown;
            this.lb_tb.Location = new System.Drawing.Point(33, 181);
            this.lb_tb.Name = "lb_tb";
            this.lb_tb.Size = new System.Drawing.Size(326, 20);
            this.lb_tb.TabIndex = 6;
            this.lb_tb.Text = "Tài khoản hoặc PassWord không đúng !";
            this.lb_tb.Visible = false;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 277);
            this.Controls.Add(this.lb_tb);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.linkLb_quenmk);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox_Hienpass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.LinkLabel linkLb_quenmk;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_tb;
    }
}