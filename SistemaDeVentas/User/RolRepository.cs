using SistemaDeVentas.Clientes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.User
{
    public class RolRepository
    {
        private string connectionString = Conexion.stringConexion;
        public List<Rol> getRols()
        {
            List<Rol> rols = new List<Rol>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spGetAllRols", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rol rol = new Rol();
                    rol.Id = Convert.ToInt32(reader["id"]);
                    rol.Name = reader["name"].ToString();
                    rols.Add(rol);
                }

                connection.Close();
                return rols;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }   

    }
}
