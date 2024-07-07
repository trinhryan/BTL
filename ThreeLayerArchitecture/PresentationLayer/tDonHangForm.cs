using System;
using System.Windows.Forms;

namespace ThreeLayerArchitecture.PresentationLayer
{
    public partial class tDonHangForm : Form
    {
        public tDonHangForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tDonHangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASE_QL_BAN_HANGDataSet6.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter.Fill(this.dATABASE_QL_BAN_HANGDataSet6.DonHang);

        }
    }
}