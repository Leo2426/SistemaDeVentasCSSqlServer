using SistemaDeVentas.Ubication;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Xml.Linq;

namespace SistemaDeVentas.Clientes
{
    public class ClientRepository
    {
        private string connectionString = Conexion.stringConexion;
       public void InsertClient(Client client)
        {
            // Insertar cliente en base de datos usan conexion de Conexion.cs


            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand("spInsertClient", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", client.Name);
                command.Parameters.AddWithValue("@address", client.Address);
                command.Parameters.AddWithValue("@document", client.Document);
                command.Parameters.AddWithValue("@phone", client.Phone);
                command.Parameters.AddWithValue("@reference", client.Reference);
                command.Parameters.AddWithValue("@department", client.Department);
                command.Parameters.AddWithValue("@province", client.Province);
                command.Parameters.AddWithValue("@district", client.District);
                connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();


                connection.Close();
             

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }

        }
 
        public List<Client> GetAllClients()
        {
            // Obtener todos los clientes de la base de datos
            List<Client> clients = new List<Client>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("select * from clients", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.Id = Convert.ToInt32(reader["id"]);
                    client.Name = reader["name"].ToString();
                    client.Address = reader["address"].ToString();
                    client.Document = reader["document"].ToString();
                    client.Phone = reader["phone"].ToString();
                    client.Reference = reader["reference"].ToString();
                    client.Department = reader["departments_id"].ToString();
                    client.Province = reader["provinces_id"].ToString();
                    client.District = reader["districts_id"].ToString();
                    clients.Add(client);
                }
                reader.Close();
                connection.Close();
                return clients;
            }catch(Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }

        }



    }
}
