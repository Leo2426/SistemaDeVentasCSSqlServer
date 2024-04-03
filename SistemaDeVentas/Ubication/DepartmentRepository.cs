using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Ubication
{
    public class DepartmentRepository
    {
        private string conexion = Conexion.stringConexion;
        public List<Department> GetAllDepartments()
        {
            SqlConnection connection = new SqlConnection(conexion);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM departments", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Department> departments = new List<Department>();
            while (reader.Read())
            {
                Department department = new Department();
                department.Id = reader.GetString(0);
                department.Name = reader.GetString(1);
                departments.Add(department);
            }
            connection.Close();
            return departments;
        }
    }
}
