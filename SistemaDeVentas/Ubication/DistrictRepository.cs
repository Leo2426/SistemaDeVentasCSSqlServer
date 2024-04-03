using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Ubication
{
    public class DistrictRepository
    {
        string connectionString = Conexion.stringConexion;
        public List<District> getAllDistricts()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM districts", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<District> districts = new List<District>();
            while (reader.Read())
            {
                District district = new District();
                district.Id = reader.GetString(0);
                district.Name = reader.GetString(1);
                district.Province = reader.GetString(2);
                district.Department = reader.GetString(3);
                districts.Add(district);
            }
            
            sqlConnection.Close();
            return districts;

        }

        public List<District> GetDistrictsByProvince(string province)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            //usar el stored procedure
            SqlCommand sqlCommand = new SqlCommand("spGetDistrictsByProvinceName", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ProvinceName", province);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<District> districts = new List<District>();
            while (reader.Read())
            {
                District district = new District();
                district.Id = reader.GetString(0);
                district.Name = reader.GetString(1);
                district.Province = reader.GetString(2);
                district.Department = reader.GetString(3);
                districts.Add(district);
            }
            sqlConnection.Close();
            return districts;
        }
    }
}
