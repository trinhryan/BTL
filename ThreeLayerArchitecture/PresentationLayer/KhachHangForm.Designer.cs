using System.ComponentModel;

namespace ThreeLayerArchitecture.PresentationLayer
{
    partial class KhachHangForm
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
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dATABASE_QL_BAN_HANGDataSet7 = new ThreeLayerArchitecture.DATABASE_QL_BAN_HANGDataSet7();
            this.txtSoDTKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khachHangTableAdapter1 = new ThreeLayerArchitecture.DATABASE_QL_BAN_HANGDataSet7TableAdapters.KhachHangTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASE_QL_BAN_HANGDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(513, 204);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(163, 20);
            this.txtSeach.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Khaki;
            this.btnSearch.Location = new System.Drawing.Point(682, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 33);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Khaki;
            this.btnReload.Location = new System.Drawing.Point(372, 197);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(107, 33);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Khaki;
            this.btnSua.Location = new System.Drawing.Point(259, 197);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 33);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Khaki;
            this.btnXoa.Location = new System.Drawing.Point(146, 197);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 33);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Khaki;
            this.btnThem.Location = new System.Drawing.Point(33, 197);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 33);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvKhachHang.DataSource = this.bindingSource1;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 239);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(788, 211);
            this.dgvKhachHang.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenKH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn3.HeaderText = "SDT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn4.HeaderText = "DiaChi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "KhachHang";
            this.bindingSource1.DataSource = this.dATABASE_QL_BAN_HANGDataSet7;
            // 
            // dATABASE_QL_BAN_HANGDataSet7
            // 
            this.dATABASE_QL_BAN_HANGDataSet7.DataSetName = "DATABASE_QL_BAN_HANGDataSet7";
            this.dATABASE_QL_BAN_HANGDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSoDTKH
            // 
            this.txtSoDTKH.Location = new System.Drawing.Point(482, 53);
            this.txtSoDTKH.Name = "txtSoDTKH";
            this.txtSoDTKH.Size = new System.Drawing.Size(222, 20);
            this.txtSoDTKH.TabIndex = 51;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(116, 144);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(222, 20);
            this.txtDiaChiKH.TabIndex = 50;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(116, 97);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(222, 20);
            this.txtMaKH.TabIndex = 49;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(116, 56);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(222, 20);
            this.txtTenKH.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(380, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Địa chỉ ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên khách hàng";
            // 
            // khachHangTableAdapter1
            // 
            this.khachHangTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // KhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoDTKH);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtTenKH);
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
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "KhachHangForm";
            this.Text = "KhachHangForm";
            this.Load += new System.EventHandler(this.KhachHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASE_QL_BAN_HANGDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtSoDTKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
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
        private System.Windows.Forms.DataGridView dgvKhachHang;

        #endregion

        private BikeStoresDataSet2 bikeStoresDataSet2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private BikeStoresDataSet2TableAdapters.customersTableAdapter customersTableAdapter;
        private DATABASE_QL_BAN_HANGDataSet2 dATABASE_QL_BAN_HANGDataSet2;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private DATABASE_QL_BAN_HANGDataSet2TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DATABASE_QL_BAN_HANGDataSet7 dATABASE_QL_BAN_HANGDataSet7;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DATABASE_QL_BAN_HANGDataSet7TableAdapters.KhachHangTableAdapter khachHangTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label5;
    }
}