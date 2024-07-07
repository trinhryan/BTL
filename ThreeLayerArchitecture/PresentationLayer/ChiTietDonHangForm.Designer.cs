using System.ComponentModel;

namespace ThreeLayerArchitecture.PresentationLayer
{
    partial class ChiTietDonHangForm
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
            this.components = new System.ComponentModel.Container();
            this.gbThongTInDonHang = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnTaoKH = new System.Windows.Forms.Button();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.cobCuaHang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinSapPham = new System.Windows.Forms.GroupBox();
            this.NumberSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.maDHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGiaTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietDonHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATABASE_QL_BAN_HANGDataSet3 = new ThreeLayerArchitecture.DATABASE_QL_BAN_HANGDataSet3();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
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
            this.orderitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bikeStoresDataSet1 = new ThreeLayerArchitecture.BikeStoresDataSet1();
            this.order_itemsTableAdapter = new ThreeLayerArchitecture.BikeStoresDataSet1TableAdapters.order_itemsTableAdapter();
            this.chiTietDonHangTableAdapter = new ThreeLayerArchitecture.DATABASE_QL_BAN_HANGDataSet3TableAdapters.ChiTietDonHangTableAdapter();
            this.gbThongTInDonHang.SuspendLayout();
            this.gbThongTinSapPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASE_QL_BAN_HANGDataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoresDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTInDonHang
            // 
            this.gbThongTInDonHang.Controls.Add(this.dateTimePicker1);
            this.gbThongTInDonHang.Controls.Add(this.txtSoDienThoai);
            this.gbThongTInDonHang.Controls.Add(this.btnTaoKH);
            this.gbThongTInDonHang.Controls.Add(this.txtTenKhachHang);
            this.gbThongTInDonHang.Controls.Add(this.txtMaKH);
            this.gbThongTInDonHang.Controls.Add(this.txtMaDonHang);
            this.gbThongTInDonHang.Controls.Add(this.cobCuaHang);
            this.gbThongTInDonHang.Controls.Add(this.label7);
            this.gbThongTInDonHang.Controls.Add(this.label6);
            this.gbThongTInDonHang.Controls.Add(this.label5);
            this.gbThongTInDonHang.Controls.Add(this.label3);
            this.gbThongTInDonHang.Controls.Add(this.label2);
            this.gbThongTInDonHang.Controls.Add(this.label1);
            this.gbThongTInDonHang.Location = new System.Drawing.Point(12, 41);
            this.gbThongTInDonHang.Name = "gbThongTInDonHang";
            this.gbThongTInDonHang.Size = new System.Drawing.Size(776, 181);
            this.gbThongTInDonHang.TabIndex = 3;
            this.gbThongTInDonHang.TabStop = false;
            this.gbThongTInDonHang.Text = "Thông tin đơn hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(366, 122);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(178, 20);
            this.txtSoDienThoai.TabIndex = 17;
            // 
            // btnTaoKH
            // 
            this.btnTaoKH.Location = new System.Drawing.Point(568, 73);
            this.btnTaoKH.Name = "btnTaoKH";
            this.btnTaoKH.Size = new System.Drawing.Size(104, 33);
            this.btnTaoKH.TabIndex = 16;
            this.btnTaoKH.Text = "Tạo Khách hàng";
            this.btnTaoKH.UseVisualStyleBackColor = true;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(366, 27);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(178, 20);
            this.txtTenKhachHang.TabIndex = 12;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(364, 80);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(178, 20);
            this.txtMaKH.TabIndex = 11;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(77, 80);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(178, 20);
            this.txtMaDonHang.TabIndex = 8;
            // 
            // cobCuaHang
            // 
            this.cobCuaHang.FormattingEnabled = true;
            this.cobCuaHang.Location = new System.Drawing.Point(77, 127);
            this.cobCuaHang.Name = "cobCuaHang";
            this.cobCuaHang.Size = new System.Drawing.Size(175, 21);
            this.cobCuaHang.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(299, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(299, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(299, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cửa hàng";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đơn hàng";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Nhập";
            // 
            // gbThongTinSapPham
            // 
            this.gbThongTinSapPham.Controls.Add(this.NumberSoLuong);
            this.gbThongTinSapPham.Controls.Add(this.txtGiaTien);
            this.gbThongTinSapPham.Controls.Add(this.textBox9);
            this.gbThongTinSapPham.Controls.Add(this.txtMaSanPham);
            this.gbThongTinSapPham.Controls.Add(this.btnThoat);
            this.gbThongTinSapPham.Controls.Add(this.btnThem);
            this.gbThongTinSapPham.Controls.Add(this.btnXoa);
            this.gbThongTinSapPham.Controls.Add(this.btnHuy);
            this.gbThongTinSapPham.Controls.Add(this.label12);
            this.gbThongTinSapPham.Controls.Add(this.label11);
            this.gbThongTinSapPham.Controls.Add(this.label10);
            this.gbThongTinSapPham.Controls.Add(this.label9);
            this.gbThongTinSapPham.Location = new System.Drawing.Point(12, 235);
            this.gbThongTinSapPham.Name = "gbThongTinSapPham";
            this.gbThongTinSapPham.Size = new System.Drawing.Size(776, 183);
            this.gbThongTinSapPham.TabIndex = 4;
            this.gbThongTinSapPham.TabStop = false;
            this.gbThongTinSapPham.Text = "Thông tin sản phầm";
            // 
            // NumberSoLuong
            // 
            this.NumberSoLuong.Location = new System.Drawing.Point(366, 23);
            this.NumberSoLuong.Name = "NumberSoLuong";
            this.NumberSoLuong.Size = new System.Drawing.Size(176, 20);
            this.NumberSoLuong.TabIndex = 23;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(365, 69);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(178, 20);
            this.txtGiaTien.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(77, 25);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(178, 20);
            this.textBox9.TabIndex = 20;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(77, 69);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(178, 20);
            this.txtMaSanPham.TabIndex = 19;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(628, 127);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 33);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(299, 127);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 33);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(409, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 33);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(519, 127);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 33);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Sửa ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(299, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Giá tiền";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(299, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã sản phẩm";
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.AutoGenerateColumns = false;
            this.dgvChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDHDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.cuaHangDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongSPDataGridViewTextBoxColumn,
            this.tongGiaTienDataGridViewTextBoxColumn});
            this.dgvChiTietDonHang.DataSource = this.chiTietDonHangBindingSource;
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(6, 424);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(782, 179);
            this.dgvChiTietDonHang.TabIndex = 5;
            // 
            // maDHDataGridViewTextBoxColumn
            // 
            this.maDHDataGridViewTextBoxColumn.DataPropertyName = "MaDH";
            this.maDHDataGridViewTextBoxColumn.HeaderText = "MaDH";
            this.maDHDataGridViewTextBoxColumn.Name = "maDHDataGridViewTextBoxColumn";
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            // 
            // cuaHangDataGridViewTextBoxColumn
            // 
            this.cuaHangDataGridViewTextBoxColumn.DataPropertyName = "CuaHang";
            this.cuaHangDataGridViewTextBoxColumn.HeaderText = "CuaHang";
            this.cuaHangDataGridViewTextBoxColumn.Name = "cuaHangDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // soLuongSPDataGridViewTextBoxColumn
            // 
            this.soLuongSPDataGridViewTextBoxColumn.DataPropertyName = "SoLuongSP";
            this.soLuongSPDataGridViewTextBoxColumn.HeaderText = "SoLuongSP";
            this.soLuongSPDataGridViewTextBoxColumn.Name = "soLuongSPDataGridViewTextBoxColumn";
            // 
            // tongGiaTienDataGridViewTextBoxColumn
            // 
            this.tongGiaTienDataGridViewTextBoxColumn.DataPropertyName = "TongGiaTien";
            this.tongGiaTienDataGridViewTextBoxColumn.HeaderText = "TongGiaTien";
            this.tongGiaTienDataGridViewTextBoxColumn.Name = "tongGiaTienDataGridViewTextBoxColumn";
            // 
            // chiTietDonHangBindingSource
            // 
            this.chiTietDonHangBindingSource.DataMember = "ChiTietDonHang";
            this.chiTietDonHangBindingSource.DataSource = this.dATABASE_QL_BAN_HANGDataSet3;
            // 
            // dATABASE_QL_BAN_HANGDataSet3
            // 
            this.dATABASE_QL_BAN_HANGDataSet3.DataSetName = "DATABASE_QL_BAN_HANGDataSet3";
            this.dATABASE_QL_BAN_HANGDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(560, 589);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(631, 592);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(112, 20);
            this.txtTongTien.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.danhMụcNhânToolStripMenuItem,
            this.giaoDịchToolStripMenuItem,
            this.đơnHàngToolStripMenuItem,
            this.quảnLýKhoToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgườiDùngToolStripMenuItem});
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
            this.danhMụcNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênBánToolStripMenuItem,
            this.nhânViênKhoToolStripMenuItem,
            this.danhMụcKháchHàngToolStripMenuItem1,
            this.danhMụcNhàCungCấpToolStripMenuItem});
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
            this.giaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem});
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
            this.đơnHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đơnHàngĐãĐặtToolStripMenuItem,
            this.đơnHàngĐãGiaoToolStripMenuItem,
            this.tạoPhiếuĐặtHàngToolStripMenuItem});
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
            this.quảnLýKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuNhậpHàngToolStripMenuItem,
            this.phiếuXuấtHàngToolStripMenuItem,
            this.thốngKêHàngTồnToolStripMenuItem});
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
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoTàiChínhToolStripMenuItem,
            this.báoCáoDoanhToolStripMenuItem});
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
            // orderitemsBindingSource
            // 
            this.orderitemsBindingSource.DataMember = "order_items";
            this.orderitemsBindingSource.DataSource = this.bikeStoresDataSet1;
            // 
            // bikeStoresDataSet1
            // 
            this.bikeStoresDataSet1.DataSetName = "BikeStoresDataSet1";
            this.bikeStoresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_itemsTableAdapter
            // 
            this.order_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietDonHangTableAdapter
            // 
            this.chiTietDonHangTableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietDonHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvChiTietDonHang);
            this.Controls.Add(this.gbThongTinSapPham);
            this.Controls.Add(this.gbThongTInDonHang);
            this.Name = "ChiTietDonHangForm";
            this.Text = "ChiTietDonHangForm";
            this.gbThongTInDonHang.ResumeLayout(false);
            this.gbThongTInDonHang.PerformLayout();
            this.gbThongTinSapPham.ResumeLayout(false);
            this.gbThongTinSapPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASE_QL_BAN_HANGDataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoresDataSet1)).EndInit();
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

        private System.Windows.Forms.NumericUpDown NumberSoLuong;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTongTien;

        private System.Windows.Forms.DataGridView dgvChiTietDonHang;

        private System.Windows.Forms.Button btnTaoKH;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtGiaTien;

        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKhachHang;

        private System.Windows.Forms.ComboBox cobCuaHang;

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngĐãĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngĐãGiaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbThongTInDonHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTàiChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbThongTinSapPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        #endregion

        private BikeStoresDataSet1 bikeStoresDataSet1;
        private System.Windows.Forms.BindingSource orderitemsBindingSource;
        private BikeStoresDataSet1TableAdapters.order_itemsTableAdapter order_itemsTableAdapter;
        private DATABASE_QL_BAN_HANGDataSet3 dATABASE_QL_BAN_HANGDataSet3;
        private System.Windows.Forms.BindingSource chiTietDonHangBindingSource;
        private DATABASE_QL_BAN_HANGDataSet3TableAdapters.ChiTietDonHangTableAdapter chiTietDonHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGiaTienDataGridViewTextBoxColumn;
    }
}