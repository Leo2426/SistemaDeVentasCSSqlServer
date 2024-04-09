﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVentas.Productos;

namespace SistemaDeVentas.Ventas
{
    public class SaleRepository
    {
        private readonly string _connectionString;

        public SaleRepository()
        {
            _connectionString = Conexion.stringConexion;
        }

        public void InsertSale(Sale sale)
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
                command.Parameters.AddWithValue("@UserName", sale.UserName);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }






        public List<Sale> GetAllSales()
        {
            List<Sale> sales = new List<Sale>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetAllSales", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sale sale = new Sale()
                        {
                            // Asumiendo que tienes una clase Sale con estas propiedades
                            Id = int.Parse(reader["id"].ToString()),
                            SaleType = reader["sale_type"].ToString(),
                            ClientName = reader["ClientName"].ToString(),
                            Date = DateTime.Parse(reader["date"].ToString()),
                            Phone = reader["phone"].ToString(),
                            Reference = reader["reference"].ToString(),
                            Address = reader["address"].ToString(),
                            PaymentTypeName = reader["PaymentType"].ToString(),
                            Observation = reader["observation"].ToString(),
                            Channel = reader["channel"].ToString(),
                            PaymentConditionName = reader["PaymentCondition"].ToString(),
                            Total = decimal.Parse(reader["total"].ToString()),
                            CashPayment = reader["cash_payment"] == DBNull.Value ? null : (decimal?)decimal.Parse(reader["cash_payment"].ToString()),
                            CreditPayment = reader["credit_payment"] == DBNull.Value ? null : (decimal?)decimal.Parse(reader["credit_payment"].ToString()),
                            UserName = reader["UserName"].ToString()

                        };
                        sales.Add(sale);
                    }
                }
            }
            return sales;
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

        public void InsertProductSaled(ProductSaled productSaled)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spInsertProductSale", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sales_id", productSaled.SaleId);
                command.Parameters.AddWithValue("@products_id", productSaled.ProductId);
                command.Parameters.AddWithValue("@quantity", productSaled.Quantity);
                command.Parameters.AddWithValue("@sale_price", productSaled.SalePrice);

                connection.Open();
                command.ExecuteNonQuery();
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
                        saleId = int.Parse(reader["id"].ToString());
                    }
                }
            }
            return saleId;
        }
        
    }
}