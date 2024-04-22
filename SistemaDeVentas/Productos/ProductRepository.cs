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
        public async Task AddProductAsync(Product product)
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

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = new List<Product>();
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spGetAllProducts", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                await connection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
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
                            SizesId = reader["size_name"].ToString()
                        });
                    }
                }
            }
            return products;
        }

        public async Task DeleteProductAsync(int id)
        {
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spDeleteProduct", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@id", id));

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdateProductAsync(Product product)
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

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<List<Product>> SearchProductAsync(string search)
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spSearchProducts", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@SearchTerm", search));

                await connection.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
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
                            SizesId = reader["size_name"].ToString()
                        });
                    }
                }
            }
            return products;
        }

        public async Task<Product> GetProductByCodeAsync(string code)
        {
            Product product = null;
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spGetProductByCode", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@code", code));

                await connection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
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
                            SizesId = reader["SizeName"].ToString()
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

        public async Task<Product> GetLastProductAddedAsync()
        {
            Product product = null;
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand("spGetLastProductAdded", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                await connection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
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
                            SizesId = reader["size_name"].ToString()
                        };
                    }
                }
            }
            return product;
        }

        public async Task<bool> ProductHasSalesAsync(int id)
        {
            try
            {
                using (var connection = new SqlConnection(Conexion.stringConexion))
                {
                    await connection.OpenAsync();
                    var cmd = new SqlCommand("SELECT COUNT(*) FROM products_sales WHERE products_id = @ProductId", connection);
                    cmd.Parameters.AddWithValue("@ProductId", id);

                    int count = (int)await cmd.ExecuteScalarAsync();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar si el producto tiene ventas: " + ex.Message);
            }
        }


        public async Task<int> getLastIdAsync()
        {
            using (var connection = new SqlConnection(Conexion.stringConexion))
            {
                var cmd = new SqlCommand(@"  
          
                    SELECT id from products where id = (SELECT MAX(id) FROM products)
                    ", connection)
                {
                };

                await connection.OpenAsync();
                var id = await cmd.ExecuteScalarAsync();
                return (int)id;
            }
        }

    }
}
