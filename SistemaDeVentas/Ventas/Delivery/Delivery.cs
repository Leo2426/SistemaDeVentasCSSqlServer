using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Ventas.Delivery
{
    public class Delivery
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string Reference { get; set; }
        public string Instructions { get; set; }
        public string PaymentCondition { get; set; }

        public int SaleId { get; set; }

    }
}
