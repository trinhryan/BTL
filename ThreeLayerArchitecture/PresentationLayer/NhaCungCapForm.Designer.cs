using System.ComponentModel;

namespace ThreeLayerArchitecture.PresentationLayer
{
    partial class NhaCungCapForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.txtSeach.Location = new System.Drawing.Point(501, 202);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(163, 20);
            this.txtSeach.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Khaki;
            this.btnSearch.Location = new System.Drawing.Point(670, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 33);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Khaki;
            this.btnReload.Location = new System.Drawing.Point(360, 195);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(107, 33);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Khaki;
            this.btnSua.Location = new System.Drawing.Point(247, 195);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 33);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Khaki;
            this.btnXoa.Location = new System.Drawing.Point(134, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 33);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Khaki;
            this.btnThem.Location = new System.Drawing.Point(21, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 33);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 237);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(788, 211);
            this.dgvNhanVien.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên NCC";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(415, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sản phẩm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(415, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(415, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ngày nhập";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(112, 51);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(222, 20);
            this.txtTenNCC.TabIndex = 36;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(112, 92);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(222, 20);
            this.txtSDT.TabIndex = 37;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(112, 139);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(222, 20);
            this.txtDiaChi.TabIndex = 38;
            // 
            // txtSanPham
            // 
            this.txtSanPham.Location = new System.Drawing.Point(517, 51);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(222, 20);
            this.txtSanPham.TabIndex = 39;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(517, 92);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(222, 20);
            this.txtSoLuong.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(522, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.trangChủToolStripMenuItem, this.danhMụcNhânToolStripMenuItem, this.giaoDịchToolStripMenuItem, this.đơnHàngToolStripMenuItem, this.quảnLýKhoToolStripMenuItem, this.báoCáoToolStripMenuItem, this.đăngXuấtToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 42;
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
            // NhaCungCapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtSanPham);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenNCC);
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
            this.Name = "NhaCungCapForm";
            this.Text = "NhaCungCapForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcKháchHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuĐặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHàngTồnToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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

        private BikeStoresDataSet3 bikeStoresDataSet3;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private BikeStoresDataSet3TableAdapters.brandsTableAdapter brandsTableAdapter;
        private DATABASE_QL_BAN_HANGDataSet1 dATABASE_QL_BAN_HANGDataSet1;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private DATABASE_QL_BAN_HANGDataSet1TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}