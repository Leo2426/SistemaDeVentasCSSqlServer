using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Ventas.Delivery
{
    public class DeliveryRepository
    {
        private string connectionString;

        public DeliveryRepository()
        {
            connectionString = Conexion.stringConexion;
        }

        // Inserta un delivery en la base de datos
        public void InsertDelivery(Delivery delivery)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spInsertDelivery", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@client", delivery.ClientName);
                command.Parameters.AddWithValue("@address", delivery.Address);
                command.Parameters.AddWithValue("@reference", delivery.Reference);
                command.Parameters.AddWithValue("@instructions", delivery.Instructions);
                command.Parameters.AddWithValue("@payment_condition", delivery.PaymentCondition);
                command.Parameters.AddWithValue("@phone", delivery.Phone);
                command.Parameters.AddWithValue("@amount", delivery.Amount);
                command.Parameters.AddWithValue("@amount_due", delivery.Amount_due);
                command.Parameters.AddWithValue("@sales_id", delivery.SaleId);
                command.Parameters.AddWithValue("@date", delivery.Date);


                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //traer todos los delivery
        public List<Delivery> GetAllDeliveries()
        {
            List<Delivery> deliveries = new List<Delivery>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spGetAllDeliveries", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Delivery delivery = new Delivery
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            ClientName = reader["client_name"].ToString(),
                            Date = reader["date"].ToString(),
                            Address = reader["address"].ToString(),
                            Reference = reader["reference"].ToString(),
                            Instructions = reader["instructions"].ToString(),
                            PaymentCondition = reader["payment_condition"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Amount = decimal.Parse(reader["amount"].ToString()),
                            Amount_due = decimal.Parse(reader["amount_due"].ToString()),
                            SaleId = int.Parse(reader["sales_id"].ToString())
                        };
                        deliveries.Add(delivery);
                    }

                }
            }

            return deliveries;
        }

        public void DeleteDeliveryBySalesId(int salesId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spDeleteDeliveryBySalesId", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sales_id", salesId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
