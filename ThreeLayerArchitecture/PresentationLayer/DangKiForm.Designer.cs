using System.ComponentModel;

namespace ThreeLayerArchitecture.PresentationLayer
{
    partial class DangKiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(142, 115);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(311, 20);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(142, 71);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(311, 20);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(95, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(556, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "ĐĂNG KÝ VÀO HỆ THỐNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(410, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDangKi.Location = new System.Drawing.Point(282, 398);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(122, 40);
            this.btnDangKi.TabIndex = 9;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDangNhap.Location = new System.Drawing.Point(120, 393);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(122, 40);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoVaTen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 300);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng kí";
            // 
            // rdbNu
            // 
            this.rdbNu.Location = new System.Drawing.Point(282, 157);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(104, 24);
            this.rdbNu.TabIndex = 16;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.Location = new System.Drawing.Point(142, 157);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(104, 24);
            this.rdbNam.TabIndex = 15;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giới tính";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(142, 34);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(311, 20);
            this.txtHoVaTen.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Họ và tên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(142, 245);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(310, 20);
            this.txtDiaChi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(28, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 46);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bạn đã có tài khoản";
            // 
            // DangKiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.groupBox1);
            this.Name = "DangKiForm";
            this.Text = "DangKiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoVaTen;

        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;

        #endregion
    }
}