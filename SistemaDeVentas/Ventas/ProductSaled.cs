using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace SistemaDeVentas.Ventas
{
    public class ProductSaled
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public string Code { get; set; }
        public int Stock { get; set; }
        public string Size { get; set; }
    }
}
