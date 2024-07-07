using System.ComponentModel;

namespace ThreeLayerArchitecture.PresentationLayer
{
    partial class CuaHangForm
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
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcKháchHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngĐãĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngĐãGiaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuĐặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHàngTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTàiChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(501, 204);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(163, 20);
            this.txtSeach.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Khaki;
            this.btnSearch.Location = new System.Drawing.Point(670, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 33);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Khaki;
            this.btnReload.Location = new System.Drawing.Point(360, 197);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(107, 33);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Khaki;
            this.btnSua.Location = new System.Drawing.Point(247, 197);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 33);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Khaki;
            this.btnXoa.Location = new System.Drawing.Point(134, 197);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 33);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Khaki;
            this.btnThem.Location = new System.Drawing.Point(21, 197);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 33);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 239);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(788, 211);
            this.dgvNhanVien.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(440, 126);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(222, 20);
            this.textBox6.TabIndex = 53;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(440, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(222, 20);
            this.textBox5.TabIndex = 52;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(440, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 20);
            this.textBox4.TabIndex = 51;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 20);
            this.textBox3.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 49;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(381, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 47;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(381, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(381, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(58, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.trangChủToolStripMenuItem, this.danhMụcNhânToolStripMenuItem, this.giaoDịchToolStripMenuItem, this.đơnHàngToolStripMenuItem, this.quảnLýKhoToolStripMenuItem, this.báoCáoToolStripMenuItem, this.đăngXuấtToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.quảnLýNgườiDùngToolStripMenuItem });
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            // 
            // danhMụcNhânToolStripMenuItem
            // 
            this.danhMụcNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.nhânViênBánToolStripMenuItem, this.nhânViênKhoToolStripMenuItem, this.danhMụcKháchHàngToolStripMenuItem1, this.danhMụcNhàCungCấpToolStripMenuItem });
            this.danhMụcNhânToolStripMenuItem.Name = "danhMụcNhânToolStripMenuItem";
            this.danhMụcNhânToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcNhânToolStripMenuItem.Text = "Danh mục";
            // 
            // nhânViênBánToolStripMenuItem
            // 
            this.nhânViênBánToolStripMenuItem.Name = "nhânViênBánToolStripMenuItem";
            this.nhânViênBánToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.nhânViênBánToolStripMenuItem.Text = "Danh mục sản phẩm";
            // 
            // nhânViênKhoToolStripMenuItem
            // 
            this.nhânViênKhoToolStripMenuItem.Name = "nhânViênKhoToolStripMenuItem";
            this.nhânViênKhoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.nhânViênKhoToolStripMenuItem.Text = "Danh mục nhân viên";
            // 
            // danhMụcKháchHàngToolStripMenuItem1
            // 
            this.danhMụcKháchHàngToolStripMenuItem1.Name = "danhMụcKháchHàngToolStripMenuItem1";
            this.danhMụcKháchHàngToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.danhMụcKháchHàngToolStripMenuItem1.Text = "Danh mục khách hàng";
            // 
            // danhMụcNhàCungCấpToolStripMenuItem
            // 
            this.danhMụcNhàCungCấpToolStripMenuItem.Name = "danhMụcNhàCungCấpToolStripMenuItem";
            this.danhMụcNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.danhMụcNhàCungCấpToolStripMenuItem.Text = "Danh mục nhà cung cấp";
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.hóaĐơnToolStripMenuItem });
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.giaoDịchToolStripMenuItem.Text = "Giao Dịch";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.đơnHàngĐãĐặtToolStripMenuItem, this.đơnHàngĐãGiaoToolStripMenuItem, this.tạoPhiếuĐặtHàngToolStripMenuItem });
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
            // 
            // đơnHàngĐãĐặtToolStripMenuItem
            // 
            this.đơnHàngĐãĐặtToolStripMenuItem.Name = "đơnHàngĐãĐặtToolStripMenuItem";
            this.đơnHàngĐãĐặtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đơnHàngĐãĐặtToolStripMenuItem.Text = "Đơn hàng khách đặt";
            // 
            // đơnHàngĐãGiaoToolStripMenuItem
            // 
            this.đơnHàngĐãGiaoToolStripMenuItem.Name = "đơnHàngĐãGiaoToolStripMenuItem";
            this.đơnHàngĐãGiaoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đơnHàngĐãGiaoToolStripMenuItem.Text = "Đơn hàng đã giao";
            // 
            // tạoPhiếuĐặtHàngToolStripMenuItem
            // 
            this.tạoPhiếuĐặtHàngToolStripMenuItem.Name = "tạoPhiếuĐặtHàngToolStripMenuItem";
            this.tạoPhiếuĐặtHàngToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tạoPhiếuĐặtHàngToolStripMenuItem.Text = "Tạo phiếu đặt hàng";
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            this.quảnLýKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.phiếuNhậpHàngToolStripMenuItem, this.phiếuXuấtHàngToolStripMenuItem, this.thốngKêHàngTồnToolStripMenuItem });
            this.quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            this.quảnLýKhoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            // 
            // phiếuNhậpHàngToolStripMenuItem
            // 
            this.phiếuNhậpHàngToolStripMenuItem.Name = "phiếuNhậpHàngToolStripMenuItem";
            this.phiếuNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.phiếuNhậpHàngToolStripMenuItem.Text = "Phiếu nhập hàng";
            // 
            // phiếuXuấtHàngToolStripMenuItem
            // 
            this.phiếuXuấtHàngToolStripMenuItem.Name = "phiếuXuấtHàngToolStripMenuItem";
            this.phiếuXuấtHàngToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.phiếuXuấtHàngToolStripMenuItem.Text = "Phiếu xuất hàng";
            // 
            // thốngKêHàngTồnToolStripMenuItem
            // 
            this.thốngKêHàngTồnToolStripMenuItem.Name = "thốngKêHàngTồnToolStripMenuItem";
            this.thốngKêHàngTồnToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.thốngKêHàngTồnToolStripMenuItem.Text = "Thống kê hàng tồn";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.báoCáoTàiChínhToolStripMenuItem, this.báoCáoDoanhToolStripMenuItem });
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // báoCáoTàiChínhToolStripMenuItem
            // 
            this.báoCáoTàiChínhToolStripMenuItem.Name = "báoCáoTàiChínhToolStripMenuItem";
            this.báoCáoTàiChínhToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.báoCáoTàiChínhToolStripMenuItem.Text = "Báo cáo tài chính";
            // 
            // báoCáoDoanhToolStripMenuItem
            // 
            this.báoCáoDoanhToolStripMenuItem.Name = "báoCáoDoanhToolStripMenuItem";
            this.báoCáoDoanhToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.báoCáoDoanhToolStripMenuItem.Text = "Báo cáo doanh thu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // CuaHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNhanVien);
            this.Name = "CuaHangForm";
            this.Text = "CuaHangForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcKháchHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuĐặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHàngTồnToolStripMenuItem;

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanVien;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngĐãĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngĐãGiaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTàiChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;

        #endregion
    }
}