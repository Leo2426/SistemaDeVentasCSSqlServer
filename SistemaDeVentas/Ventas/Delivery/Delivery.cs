using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
        public string Phone { get; set; }
        public decimal Amount { get; set; }
        public decimal? Amount_due { get; set; }
        public List<ProductSaled> products { get; set; }
        public string Date { get; set; }
        public int SaleId { get; set; }


        public Delivery(Sale sale, List<ProductSaled> products)
        {
            this.ClientName = sale.ClientName;
            this.Address = sale.Address;
            this.Reference = sale.Reference;
            this.SaleId = sale.Id;
            this.products = products;
            this.Phone = sale.Phone;
            this.Amount = sale.Total;
            this.Amount_due = sale.CreditPayment;
        }

        public Delivery()
        {
        }

    }
}
