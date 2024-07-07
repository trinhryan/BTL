using System.Windows.Forms;

namespace ThreeLayerArchitecture.PresentationLayer
{
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVienForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'bikeStoresDataSet.staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.bikeStoresDataSet.staffs);

        }

        private void NhanVienForm_Load_1(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASE_QL_BAN_HANGDataSet4.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.dATABASE_QL_BAN_HANGDataSet4.Sale);

        }
    }
}