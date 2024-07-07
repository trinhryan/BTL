using System.Windows.Forms;

namespace ThreeLayerArchitecture.PresentationLayer
{
    public partial class SanPhamForm : Form
    {
        public SanPhamForm()
        {
            InitializeComponent();
        }

        private void SanPhamForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASE_QL_BAN_HANGDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.dATABASE_QL_BAN_HANGDataSet.SanPham);
            // TODO: This line of code loads data into the 'bikeStoresDataSet4.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.bikeStoresDataSet4.products);

        }

        private void SanPhamForm_Load_1(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASE_QL_BAN_HANGDataSet8.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter1.Fill(this.dATABASE_QL_BAN_HANGDataSet8.SanPham);

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }
    }
}