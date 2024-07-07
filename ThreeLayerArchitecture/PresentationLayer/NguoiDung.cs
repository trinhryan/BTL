using System;
using System.Windows.Forms;

namespace ThreeLayerArchitecture.PresentationLayer
{
    public partial class NguoiDung : Form
    {
        public NguoiDung()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASE_QL_BAN_HANGDataSet5.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.dATABASE_QL_BAN_HANGDataSet5.NguoiDung);

        }
    }
}