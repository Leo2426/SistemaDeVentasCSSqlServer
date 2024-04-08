using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Ventas.Payments
{
    public class PaymentConditionRepository
    {
        private readonly string _connectionString = Conexion.stringConexion;

        public List<PaymentCondition> GetAllPaymentConditions()
        {
            List<PaymentCondition> paymentConditions = new List<PaymentCondition>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetAllPaymentConditions", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PaymentCondition paymentCondition = new PaymentCondition
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };

                    paymentConditions.Add(paymentCondition);
                }
            }

            return paymentConditions;
        }
    }
}
