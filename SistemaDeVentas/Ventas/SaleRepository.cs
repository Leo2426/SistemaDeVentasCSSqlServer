using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVentas.Productos;
using SistemaDeVentas.Ventas.Delivery;
using Dapper;
using PagedList;

namespace SistemaDeVentas.Ventas
{
    public class SaleRepository
    {
        private readonly string _connectionString;

        public SaleRepository()
        {
            _connectionString = Conexion.stringConexion;
        }


        public async Task<IPagedList<Sale>> GetSalesPagedAsync(int pageNumber, int pageSize, string filterColumn = null, string filterValue = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = new StringBuilder(@"
                SELECT s.id, s.sale_type AS SaleType, c.name AS ClientName, s.date, s.phone, s.reference, s.address, 
                       pt.name AS PaymentTypeName, s.observation, s.channel, pc.name AS PaymentConditionName, 
                       s.total, s.cash_payment AS CashPayment, s.credit_payment AS CreditPayment, 
                       s.credit_days AS CreditDays, u.user_name AS UserName, s.profit
                FROM sales s
                JOIN clients c ON s.clients_id = c.id
                JOIN payment_type pt ON s.payment_type_id = pt.id
                JOIN payment_condition pc ON s.payment_condition_id = pc.id
                JOIN users u ON s.users_id = u.id");

                if (!string.IsNullOrEmpty(filterColumn) && !string.IsNullOrEmpty(filterValue))
                {
                    query.Append($" WHERE {filterColumn} LIKE @FilterValue");
                }

                query.Append(" ORDER BY s.date DESC OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;");

                var offset = (pageNumber - 1) * pageSize;
                var sales = await connection.QueryAsync<Sale>(query.ToString(), new { Offset = offset, PageSize = pageSize, FilterValue = $"%{filterValue}%" });

                var countQuery = "SELECT COUNT(*) FROM sales";
                if (!string.IsNullOrEmpty(filterColumn) && !string.IsNullOrEmpty(filterValue))
                {
                    countQuery += $" WHERE {filterColumn} LIKE @FilterValue";
                }
                var totalItemCount = await connection.ExecuteScalarAsync<int>(countQuery, new { FilterValue = $"%{filterValue}%" });

                return new StaticPagedList<Sale>(sales, pageNumber, pageSize, totalItemCount);
            }
        }


        public async Task InsertSaleAsync(Sale sale)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spInsertSale", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@SaleType", sale.SaleType);
                command.Parameters.AddWithValue("@ClientName", sale.ClientName);
                command.Parameters.AddWithValue("@Date", sale.Date);
                command.Parameters.AddWithValue("@Phone", sale.Phone);
                command.Parameters.AddWithValue("@Reference", sale.Reference);
                command.Parameters.AddWithValue("@Address", sale.Address);
                command.Parameters.AddWithValue("@PaymentTypeName", sale.PaymentTypeName);
                command.Parameters.AddWithValue("@Observation", sale.Observation);
                command.Parameters.AddWithValue("@Channel", sale.Channel);
                command.Parameters.AddWithValue("@PaymentConditionName", sale.PaymentConditionName);
                command.Parameters.AddWithValue("@Total", sale.Total);
                command.Parameters.AddWithValue("@CashPayment", sale.CashPayment ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CreditPayment", sale.CreditPayment ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CreditDays", sale.CreditDays);
                command.Parameters.AddWithValue("@UserName", sale.UserName);
                command.Parameters.AddWithValue("@Profit", sale.Profit);


                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }






        public async Task<List<Sale>> GetAllSalesAsync()
        {
            //retornar las sales usando dapper
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT s.id, s.sale_type AS SaleType, c.name AS ClientName, s.date, s.phone, s.reference, s.address, 
                       pt.name AS PaymentType, s.observation, s.channel, pc.name AS PaymentCondition, 
                       s.total, s.cash_payment AS CashPayment, s.credit_payment AS CreditPayment, 
                       s.credit_days AS CreditDays, u.user_name AS UserName, s.profit
                FROM sales s
                JOIN clients c ON s.clients_id = c.id
                JOIN payment_type pt ON s.payment_type_id = pt.id
                JOIN payment_condition pc ON s.payment_condition_id = pc.id
                JOIN users u ON s.users_id = u.id
                ORDER BY s.date DESC
            ";

                return connection.Query<Sale>(query).ToList();
            }

        }


        public List<SalesMan> getAllSalesMan()
        {
            List<SalesMan> salesMans = new List<SalesMan>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetAllNameSalesMan", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SalesMan salesMan = new SalesMan()
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            Name = reader["user_name"].ToString()
                        };
                        salesMans.Add(salesMan);
                    }
                }
            }
            return salesMans;

        }

        public List<ProductSaled> getAllProductsWithSaleId(int saleID)
        {
            //traer todos los productos de una venta
            List<ProductSaled> products = new List<ProductSaled>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetSaleDetails", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SaleId", saleID);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductSaled product = new ProductSaled()
                        {
                            ProductId = int.Parse(reader["Id"].ToString()),
                            Description = reader["Descripción"].ToString(),
                            Code = reader["Código"].ToString(),
                            Quantity = int.Parse(reader["Cantidad"].ToString()),
                            SalePrice = decimal.Parse(reader["Precio de Venta"].ToString()),
                            Stock = int.Parse(reader["Stock"].ToString()),
                            Size = reader["Talla"].ToString()
                        };
                        products.Add(product);
                    }
                }

            }
            return products;
        }

        public async Task<int> InsertProductSaledAsync(ProductSaled productSaled)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spInsertProductSale", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Parámetros...
                command.Parameters.AddWithValue("@sales_id", productSaled.SaleId);
                command.Parameters.AddWithValue("@products_id", productSaled.ProductId);
                command.Parameters.AddWithValue("@quantity", productSaled.Quantity);
                command.Parameters.AddWithValue("@sale_price", productSaled.SalePrice);

                await connection.OpenAsync();
                return await command.ExecuteNonQueryAsync();
            }
        }

        public int GetLastSaleId()
        {
            int saleId = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetLastSaleId", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //si el sale id es null o no existe que sea 1
                        if (reader["id"] == DBNull.Value)
                        {
                            saleId = 1;
                        }
                        else
                        { saleId = int.Parse(reader["id"].ToString()); }

                    }
                }
            }
            return saleId;
        }

        public async Task DeleteSaleAsync(int saleId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Borrar los delivery de la venta
                var deliveryRepository = new DeliveryRepository();
                deliveryRepository.DeleteDeliveryBySalesId(saleId);
                //Borrar los productos de la venta
                DeleteProductsSalesBySalesId(saleId);

                SqlCommand command = new SqlCommand("spDeleteSale", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", saleId);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }

        public void UpdateSale(Sale sale)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spUpdateSale", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@SaleId", sale.Id);
                command.Parameters.AddWithValue("@SaleType", sale.SaleType);
                command.Parameters.AddWithValue("@ClientName", sale.ClientName);
                command.Parameters.AddWithValue("@Date", sale.Date);
                command.Parameters.AddWithValue("@Phone", sale.Phone);
                command.Parameters.AddWithValue("@Reference", sale.Reference);
                command.Parameters.AddWithValue("@Address", sale.Address);
                command.Parameters.AddWithValue("@PaymentTypeName", sale.PaymentTypeName);
                command.Parameters.AddWithValue("@Observation", sale.Observation);
                command.Parameters.AddWithValue("@Channel", sale.Channel);
                command.Parameters.AddWithValue("@PaymentConditionName", sale.PaymentConditionName);
                command.Parameters.AddWithValue("@Total", sale.Total);
                command.Parameters.AddWithValue("@CashPayment", sale.CashPayment ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CreditPayment", sale.CreditPayment ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@UserName", sale.UserName);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteProductsSalesBySalesId(int salesId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spDeleteProductsSalesBySalesId", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sales_id", salesId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public List<Sale> getSalesbyDate(string day, string month, string year)
        {
            List<Sale> sales = new List<Sale>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetSalesByDate", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Day", day);
                command.Parameters.AddWithValue("@Month", month);
                command.Parameters.AddWithValue("@Year", year);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sale sale = new Sale()
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            SaleType = reader["sale_type"].ToString(),
                            Date = DateTime.Parse(reader["date"].ToString()),
                            Phone = reader["phone"].ToString(),
                            Reference = reader["reference"].ToString(),
                            Address = reader["address"].ToString(),
                            Observation = reader["observation"].ToString(),
                            Channel = reader["channel"].ToString(),
                            Total = decimal.Parse(reader["total"].ToString()),
                            CashPayment = reader["cash_payment"] == DBNull.Value ? 0 : (decimal?)decimal.Parse(reader["cash_payment"].ToString()),
                            CreditPayment = reader["credit_payment"] == DBNull.Value ? 0 : (decimal?)decimal.Parse(reader["credit_payment"].ToString()),
                            CreditDays = reader["credit_days"] == DBNull.Value ? 0 : int.Parse(reader["credit_days"].ToString()),

                        };
                        sales.Add(sale);
                    }
                }
            }
            return sales;
        }

        public List<Sale> GetSalesBetweenDates(DateTime startDate, DateTime endDate)
        {
            List<Sale> sales = new List<Sale>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetSalesBetweenDates", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sale sale = new Sale()
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            Date = DateTime.Parse(reader["date"].ToString()),
                            PaymentTypeName = reader["payment_type"].ToString(),
                            PaymentConditionName = reader["payment_condition"].ToString(),
                            ClientName = reader["name"].ToString(),
                            Profit = decimal.Parse(reader["profit"].ToString()),
                            Total = decimal.Parse(reader["total"].ToString()),
                        };
                        sales.Add(sale);
                    }
                }
            }
            return sales;
        }

    }
}
