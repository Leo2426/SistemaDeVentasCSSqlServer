using SistemaDeVentas.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Shared
{
    public static class GlobalClass
    {
        public static string Username { get; set; }
        public static Product SelectedProduct { get; set; }
    }
}
