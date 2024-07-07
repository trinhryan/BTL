using System.ComponentModel;

namespace ThreeLayerArchitecture.PresentationLayer
{
    partial class NhanVienForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cobCuaHang = new System.Windows.Forms.ComboBox();
            this.cobChucVu = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSeach = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(482, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(504, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chức vụ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(504, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cửa hàng";
            // 
            // cobCuaHang
            // 
            this.cobCuaHang.FormattingEnabled = true;
            this.cobCuaHang.Location = new System.Drawing.Point(580, 148);
            this.cobCuaHang.Name = "cobCuaHang";
            this.cobCuaHang.Size = new System.Drawing.Size(176, 21);
            this.cobCuaHang.TabIndex = 10;
            // 
            // cobChucVu
            // 
            this.cobChucVu.FormattingEnabled = true;
            this.cobChucVu.Location = new System.Drawing.Point(580, 97);
            this.cobChucVu.Name = "cobChucVu";
            this.cobChucVu.Size = new System.Drawing.Size(176, 21);
            this.cobChucVu.TabIndex = 11;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(127, 50);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(176, 20);
            this.txtTenNhanVien.TabIndex = 12;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(127, 98);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(176, 20);
            this.txtMaNhanVien.TabIndex = 13;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(580, 47);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(176, 20);
            this.txtSoDienThoai.TabIndex = 15;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(11, 240);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(788, 211);
            this.dgvNhanVien.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Khaki;
            this.btnThem.Location = new System.Drawing.Point(32, 198);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 33);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Khaki;
            this.btnXoa.Location = new System.Drawing.Point(145, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 33);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Khaki;
            this.btnSua.Location = new System.Drawing.Point(258, 198);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 33);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Khaki;
            this.btnReload.Location = new System.Drawing.Point(371, 198);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(107, 33);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Khaki;
            this.btnSearch.Location = new System.Drawing.Point(681, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 33);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(512, 205);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(163, 20);
            this.txtSeach.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.trangChủToolStripMenuItem, this.danhMụcNhânToolStripMenuItem, this.giaoDịchToolStripMenuItem, this.đơnHàngToolStripMenuItem, this.quảnLýKhoToolStripMenuItem, this.báoCáoToolStripMenuItem, this.đăngXuấtToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 31;
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
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.cobChucVu);
            this.Controls.Add(this.cobCuaHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhanVienForm";
            this.Text = "NhanVienForm";
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

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSeach;

        private System.Windows.Forms.ComboBox cobCuaHang;
        private System.Windows.Forms.ComboBox cobChucVu;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtSoDienThoai;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        #endregion

        private BikeStoresDataSet bikeStoresDataSet;
        private System.Windows.Forms.BindingSource staffsBindingSource;
        private BikeStoresDataSetTableAdapters.staffsTableAdapter staffsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageridDataGridViewTextBoxColumn;
        private DATABASE_QL_BAN_HANGDataSet4 dATABASE_QL_BAN_HANGDataSet4;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DATABASE_QL_BAN_HANGDataSet4TableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
    }
}