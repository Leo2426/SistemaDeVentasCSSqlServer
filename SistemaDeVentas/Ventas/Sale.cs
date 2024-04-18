using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Ventas
{
    public class Sale
    {
        public int Id { get; set; }
        public string SaleType { get; set; }
        public string ClientName { get; set; } // Asumiendo que se relaciona por el nombre del cliente
        public DateTime Date { get; set; }
        public string Phone { get; set; }
        public string Reference { get; set; }
        public string Address { get; set; }
        public string PaymentTypeName { get; set; }
        //observation puede ser null
        public string Observation { get; set; }
        public string Channel { get; set; }
        public string PaymentConditionName { get; set; }
        public decimal Total { get; set; }
        public decimal? CashPayment { get; set; }
        public decimal? CreditPayment { get; set; }
        public int CreditDays { get; set; }
        public string UserName { get; set; }
        public string District { get; set; }

    }
}
