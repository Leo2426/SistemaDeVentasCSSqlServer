using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class Conexion
    {
        public static string stringConexion =  ConfigurationManager.ConnectionStrings["sistemadeventasdbConnectionString"].ToString();
    }
}
