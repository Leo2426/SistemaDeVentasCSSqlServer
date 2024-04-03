using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Xml.Linq;

namespace SistemaDeVentas.Ubication
{
    public class ProvinceRepository
    {
        string connectionString = Conexion.stringConexion;
        public List<Province> GetAllProvinces ()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM provinces", sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Province> provinces = new List<Province>();
            while (reader.Read())
            {
                Province province = new Province();
                province.Id = reader.GetString(0);
                province.Name = reader.GetString(1);
                province.Department = reader.GetString(2);
                provinces.Add(province);
            }
            sqlConnection.Close();
            return provinces;
        }

        public List<Province> GetProvincesByDepartment(string department)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //usar el procedimineto almacenado  spGetProvincesByDepartmentName
        SqlCommand sqlCommand = new SqlCommand("spGetProvincesByDepartmentName", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@DepartmentName", department);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Province> provinces = new List<Province>();
            while (reader.Read())
            {
                Province province = new Province();
                province.Id = reader.GetString(0);
                province.Name = reader.GetString(1);
                province.Department = reader.GetString(2);
                provinces.Add(province);
            }
            sqlConnection.Close();
            return provinces;
        }
    }
}
