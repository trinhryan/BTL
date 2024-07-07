using System;
using System.Windows.Forms;

namespace ThreeLayerArchitecture.PresentationLayer
{
    public partial class NhaCungCapForm : Form
    {
        public NhaCungCapForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASE_QL_BAN_HANGDataSet1.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.dATABASE_QL_BAN_HANGDataSet1.NhaCungCap);
            // TODO: This line of code loads data into the 'bikeStoresDataSet3.brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.bikeStoresDataSet3.brands);

        }
    }
}