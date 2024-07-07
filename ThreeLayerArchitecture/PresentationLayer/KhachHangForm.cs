using System;
using System.Windows.Forms;
using ThreeLayerArchitecture.BusinessLogicLayer;

namespace ThreeLayerArchitecture.PresentationLayer
{
    public partial class KhachHangForm : Form
    {
        private BusinessLogic _businessLogic;
        public KhachHangForm()
        {
            _businessLogic = new BusinessLogic();
            InitializeComponent();
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASE_QL_BAN_HANGDataSet2.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.dATABASE_QL_BAN_HANGDataSet2.KhachHang);
            // TODO: This line of code loads data into the 'bikeStoresDataSet2.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.bikeStoresDataSet2.customers);
            //throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           // throw new System.NotImplementedException();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // throw new System.NotImplementedException();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}