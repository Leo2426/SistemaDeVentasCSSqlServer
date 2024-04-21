using System;
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
        }

        //obtener un producto por codigo
        public Product GetProductByCode(string code)
        {
            Product product = new Product();
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spGetProductByCode", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@code", code));

                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product = new Product
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            Code = reader["code"].ToString(),
                            Description = reader["description"].ToString(),
                            Cost = decimal.Parse(reader["cost"].ToString()),
                            Price = decimal.Parse(reader["price"].ToString()),
                            MinimumStock = int.Parse(reader["minimum_stock"].ToString()),
                            InitialStock = int.Parse(reader["initial_stock"].ToString()),
                            SizesId = (reader["SizeName"].ToString())
                        };
                    }
                }
            }
            return product;
        }



        public Product getLastProductAdded()
        {
            Product product = new Product();
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spGetLastProductAdded", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product = new Product
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            Code = reader["code"].ToString(),
                            Description = reader["description"].ToString(),
                            Cost = decimal.Parse(reader["cost"].ToString()),
                            Price = decimal.Parse(reader["price"].ToString()),
                            MinimumStock = int.Parse(reader["minimum_stock"].ToString()),
                            InitialStock = int.Parse(reader["initial_stock"].ToString()),
                            SizesId = (reader["size"].ToString())
                        };
                    }
                }
            }
            return product;
        }


        public List<Product> getAllProductsWithSock()
        {
            //traer todos los productos con stock
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spGetAllProductsWithStock", connection)
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

        internal bool ProductHasSales(int id)
        {
            try
            {
                //verificar si el producto se encuentra en products_sales usando un query
                using (var connection = new SqlConnection(Conexion.stringConexion))
                {
                    connection.Open();
                    using (var command = new SqlCommand(@"
                    SELECT * FROM products_sales WHERE products_id = @ProductId", connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", id);
                        using (var reader = command.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }

                }
            }catch(Exception ex)
            {
                throw new Exception("Error al verificar si el producto tiene ventas: " + ex.Message);
            }
        }
    }


}

