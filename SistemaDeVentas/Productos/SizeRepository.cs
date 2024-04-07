using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Productos
{
    public class SizeRepository
    {
        public List<Size> GetAllSizes()
        {
            var sizes = new List<Size>();
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spGetAllSizes", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sizes.Add(new Size
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            SizeName = reader["size_name"].ToString(),
                        });
                    }
                }
            }
            return sizes;
        }

        public void AddSize(Size size)
        {
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spAddSize", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@size_name", size.SizeName);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSize(Size size)
        {
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spUpdateSize", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@id", size.Id);
                cmd.Parameters.AddWithValue("@size_name", size.SizeName);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSize(int id)
        {
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spDeleteSize", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

