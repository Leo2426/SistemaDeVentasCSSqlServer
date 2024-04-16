using SistemaDeVentas.Ubication;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                SqlCommand command = new SqlCommand("spGetAllClientsWithDetails", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
                    client.Department = reader["DepartmentName"].ToString();
                    client.Province = reader["ProvinceName"].ToString();
                    client.District = reader["DistrictName"].ToString();
                    clients.Add(client);
                }
                
                connection.Close();
                return clients;   

            }catch(Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }

        }


        public void UpdateClient(Client client)
        {
            // Actualizar cliente en base de datos
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                
                //crea el stored procedure 
                SqlCommand command = new SqlCommand("spUpdateClient", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@id", client.Id);
                command.Parameters.AddWithValue("@name", client.Name);
                command.Parameters.AddWithValue("@address", client.Address);
                command.Parameters.AddWithValue("@document", client.Document);
                command.Parameters.AddWithValue("@phone", client.Phone);
                command.Parameters.AddWithValue("@reference", client.Reference);
                command.Parameters.AddWithValue("@departmentName", client.Department);
                command.Parameters.AddWithValue("@provinceName", client.Province);
                command.Parameters.AddWithValue("@districtName", client.District);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }   

        public void deleteClient(int id)
        {
            // Eliminar cliente de la base de datos
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spDeleteClient", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@clientid", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }


        public List<Client> searchClient(string searchTerm){
            // Buscar cliente por nombre o documento
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spSearchClients", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@searchTerm", searchTerm);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                List<Client> clients = new List<Client>();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.Id = Convert.ToInt32(reader["id"]);
                    client.Name = reader["name"].ToString();
                    client.Address = reader["address"].ToString();
                    client.Document = reader["document"].ToString();
                    client.Phone = reader["phone"].ToString();
                    client.Reference = reader["reference"].ToString();
                    client.Department = reader["DepartmentName"].ToString();
                    client.Province = reader["ProvinceName"].ToString();
                    client.District = reader["DistrictName"].ToString();
                    clients.Add(client);
                }
                connection.Close();
                return clients;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente: " + ex.Message);
            }
        }


        public Client getLasClient()
        {

            // Obtener el último cliente insertado
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spGetLastClient", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Client client = new Client();
                while (reader.Read())
                {
                    client.Id = Convert.ToInt32(reader["id"]);
                    client.Name = reader["name"].ToString();
                    client.Address = reader["address"].ToString();
                    client.Document = reader["document"].ToString();
                    client.Phone = reader["phone"].ToString();
                    client.Reference = reader["reference"].ToString();
                }
                connection.Close();
                return client;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener último cliente: " + ex.Message);
            }
        }

    }
}
