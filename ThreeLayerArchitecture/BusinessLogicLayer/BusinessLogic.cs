using System.Collections.Generic;
using ThreeLayerArchitecture.DataAccessLayer;
using ThreeLayerArchitecture.DataAccessLayer.Entities;

namespace ThreeLayerArchitecture.BusinessLogicLayer
{

    public class BusinessLogic
    {
        private DataAccess _dataAccess;

        
        public BusinessLogic()
        {
            _dataAccess = new DataAccess();
        }

        // Get all data
        public List<Brand> GetAllData()
        {
            return _dataAccess.GetAllData();
        }

        // Get data by Id
        public Brand GetDataById(int id)
        {
            return _dataAccess.GetDataById(id);
        }

        // Insert new data
        public void InsertData(Brand data)
        {
            _dataAccess.InsertData(data);
        }

        // Update existing data
        public void UpdateData(Brand data)
        {
            _dataAccess.UpdateData(data);
        }

        // Delete data by Id
        public void DeleteData(int id)
        {
            _dataAccess.DeleteData(id);
        }
    }
}