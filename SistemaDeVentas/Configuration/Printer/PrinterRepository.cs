using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaDeVentas.Configuration.Printer
{
    public class PrinterRepository
    {
        string connectionString = Conexion.stringConexion;

        
        public List<Printer> getAllPrintersSaved()
        {
            List<Printer> printers = new List<Printer>();
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Printers";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Printer printer = new Printer();
                        printer.Id = reader.GetInt32(0);
                        printer.Name = reader.GetString(1);
                        printers.Add(printer);
                    }
                    connection.Close();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener las impresoras: " + ex.Message);
            }


            return printers;
        }


        

    }
}
