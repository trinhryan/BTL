using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ThreeLayerArchitecture.DataAccessLayer.Entities;

namespace ThreeLayerArchitecture.DataAccessLayer
{
    public class DataAccess
    {
        // table names in the database (tên bảng trong cơ sở dữ liệu)
        private string brandTbl = "production.brands";
        private string categoryTbl = "categories";
        private string ChiTietDonHangTBL = "ChiTietDonHangForm";
        private string CuaHangTbl = "CuaHangForm";
        private string KhachHangTbl = "KhachHangForm";
        private string _connectionString =  @"Data Source=LAPTOP-LJOB371P\SQLEXPRESS01;Initial Catalog=DATABASE_QL_Ban_Hang;Integrated Security=True;TrustServerCertificate=True";

        // Method to get all data
        public List<Brand> GetAllData()
        {
            var data = new List<Brand>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM {brandTbl}";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new Brand
                    {
                        brand_id = reader.GetInt32(0),
                        brand_name = reader.GetString(1),
                    });
                }
            }

            return data;
        }

        // Method to get data by Id
        public Brand GetDataById(int id)
        {
            Brand data = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM {brandTbl} WHERE brand_id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    data = new Brand
                    {
                        brand_id = reader.GetInt32(0),
                        brand_name = reader.GetString(1),
                    };
                }
            }

            return data;
        }

        // Method to insert new data
        public void InsertData(Brand data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = $"INSERT INTO {brandTbl} (brand_name) VALUES (@Name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", data.brand_name);
                // ... other fields

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Method to update existing data
        public void UpdateData(Brand data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = $"UPDATE {brandTbl} SET brand_name = @Name WHERE brand_id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", data.brand_name);
                // ... other fields
                command.Parameters.AddWithValue("@Id", data.brand_id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Method to delete data by Id
        public void DeleteData(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = $"DELETE FROM {brandTbl} WHERE brand_id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}