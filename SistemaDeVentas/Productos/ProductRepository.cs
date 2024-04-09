﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVentas.Clientes;

namespace SistemaDeVentas.Productos
{
    internal class ProductRepository
    {
        public void AddProduct(Product product)
        {
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spAddProduct", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@code", product.Code));
                cmd.Parameters.Add(new SqlParameter("@description", product.Description));
                cmd.Parameters.Add(new SqlParameter("@cost", product.Cost));
                cmd.Parameters.Add(new SqlParameter("@price", product.Price));
                cmd.Parameters.Add(new SqlParameter("@minimum_stock", product.MinimumStock));
                cmd.Parameters.Add(new SqlParameter("@initial_stock", product.InitialStock));
                cmd.Parameters.Add(new SqlParameter("@size_name", product.SizesId));

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spGetAllProducts", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            Code = reader["code"].ToString(),
                            Description = reader["description"].ToString(),
                            Cost = decimal.Parse(reader["cost"].ToString()),
                            Price = decimal.Parse(reader["price"].ToString()),
                            MinimumStock = int.Parse(reader["minimum_stock"].ToString()),
                            InitialStock = int.Parse(reader["initial_stock"].ToString()),
                            SizesId = (reader["size_name"].ToString())
                        });
                    }
                }
            }
            return products;
        }

        public void DeleteProduct(int id)
        {
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spDeleteProduct", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@id", id));

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spUpdateProduct", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@id", product.Id));
                cmd.Parameters.Add(new SqlParameter("@code", product.Code));
                cmd.Parameters.Add(new SqlParameter("@description", product.Description));
                cmd.Parameters.Add(new SqlParameter("@cost", product.Cost));
                cmd.Parameters.Add(new SqlParameter("@price", product.Price));
                cmd.Parameters.Add(new SqlParameter("@minimum_stock", product.MinimumStock));
                cmd.Parameters.Add(new SqlParameter("@initial_stock", product.InitialStock));
                cmd.Parameters.Add(new SqlParameter("@size_name", product.SizesId));

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //search product por descripcion o codigo o precio o size 
        public List<Product> SearchProduct(string search)
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spSearchProducts", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@SearchTerm", search));

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            Code = reader["code"].ToString(),
                            Description = reader["description"].ToString(),
                            Cost = decimal.Parse(reader["cost"].ToString()),
                            Price = decimal.Parse(reader["price"].ToString()),
                            MinimumStock = int.Parse(reader["minimum_stock"].ToString()),
                            InitialStock = int.Parse(reader["initial_stock"].ToString()),
                            SizesId = (reader["size_name"].ToString())
                        });
                    }
                }
            }
            return products;





            //// Buscar cliente por nombre o documento
            //try
            //{
            //    SqlConnection connection = new SqlConnection(connectionString);
            //    SqlCommand command = new SqlCommand("spSearchClients", connection);
            //    command.CommandType = System.Data.CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue("@searchTerm", searchTerm);
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();

            //    List<Client> clients = new List<Client>();
            //    while (reader.Read())
            //    {
            //        Client client = new Client();
            //        client.Id = Convert.ToInt32(reader["id"]);
            //        client.Name = reader["name"].ToString();
            //        client.Address = reader["address"].ToString();
            //        client.Document = reader["document"].ToString();
            //        client.Phone = reader["phone"].ToString();
            //        client.Reference = reader["reference"].ToString();
            //        client.Department = reader["DepartmentName"].ToString();
            //        client.Province = reader["ProvinceName"].ToString();
            //        client.District = reader["DistrictName"].ToString();
            //        clients.Add(client);
            //    }
            //    connection.Close();
            //    return clients;

            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Error al buscar cliente: " + ex.Message);
            //}
        
        }


    }
}