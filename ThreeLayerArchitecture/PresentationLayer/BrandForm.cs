using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeLayerArchitecture.BusinessLogicLayer;
using ThreeLayerArchitecture.DataAccessLayer.Entities;

namespace ThreeLayerArchitecture.PresentationLayer
{
    public partial class BrandForm : Form
    {
        private BusinessLogic _businessLogic;

        public BrandForm()
        {
            InitializeComponent();
            _businessLogic = new BusinessLogic();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            var data = _businessLogic.GetAllData();
            dataGridView.DataSource = data;
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            var data = new Brand()
            {
                brand_name = txtName.Text,
                // ... other fields
            };
            _businessLogic.InsertData(data);
            RefreshDataGrid();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            var data = new Brand
            {
                brand_id = int.Parse(txtId.Text),
                brand_name = txtName.Text,
                // ... other fields
            };
            _businessLogic.UpdateData(data);
            RefreshDataGrid();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _businessLogic.DeleteData(id);
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            var data = _businessLogic.GetAllData();
            dataGridView.DataSource = data;
        }
    }
}