using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Ventas.Payments
{
    public class PaymentTypeRepository
    {
        private readonly string _connectionString = Conexion.stringConexion;

        public List<PaymentType> GetAllPaymentTypes()
        {
            List<PaymentType> paymentTypes = new List<PaymentType>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("spGetAllPaymentTypes", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PaymentType paymentType = new PaymentType
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };

                    paymentTypes.Add(paymentType);
                }
            }

            return paymentTypes;
        }

    }
}
