using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Ventas.Delivery
{
    public partial class ShowDeliveryForm : Form
    {
        public ShowDeliveryForm()
        {
            InitializeComponent();
        }

        private void ShowDeliveryForm_Load(object sender, EventArgs e)
        {
            //cargar todos los deliverys

            var deliveryRepository = new DeliveryRepository();
            var deliveries = deliveryRepository.GetAllDeliveries();

            //cargar cabeceras al dtw
            dt_deliverys.Columns.Add("Id", "Id");
            dt_deliverys.Columns.Add("ClientName", "Nombre del cliente");
            dt_deliverys.Columns.Add("Date", "Fecha");
            dt_deliverys.Columns.Add("Address", "Dirección");
            dt_deliverys.Columns.Add("Reference", "Referencia");
            dt_deliverys.Columns.Add("Instructions", "Instrucciones");
            dt_deliverys.Columns.Add("PaymentCondition", "Condición de pago");
            dt_deliverys.Columns.Add("Phone", "Teléfono");
            dt_deliverys.Columns.Add("Amount", "Monto");
            dt_deliverys.Columns.Add("Amount_due", "Saldo a cobrar");
            dt_deliverys.Columns.Add("SaleId", "Id de la venta");
            
            foreach (var delivery in deliveries)
            {
                dt_deliverys.Rows.Add(delivery.Id, delivery.ClientName, delivery.Date, delivery.Address, delivery.Reference, delivery.Instructions, delivery.PaymentCondition, delivery.Phone, delivery.Amount, delivery.Amount_due, delivery.SaleId);
            }


        }
    }
}
