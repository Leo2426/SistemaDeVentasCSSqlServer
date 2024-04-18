using SistemaDeVentas.Print;
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

            dt_deliverys.Columns.Add("SaleId", "Correlativo");
            dt_deliverys.Columns.Add("ClientName", "Cliente");
            dt_deliverys.Columns.Add("Date", "Fecha");
            dt_deliverys.Columns.Add("Address", "Dirección");
            dt_deliverys.Columns.Add("Reference", "Referencia");
            dt_deliverys.Columns.Add("Instructions", "Instrucciones");
            dt_deliverys.Columns.Add("PaymentCondition", "C.de Pago");
            dt_deliverys.Columns.Add("Phone", "Teléfono");
            dt_deliverys.Columns.Add("Amount", "Monto");
            dt_deliverys.Columns.Add("Amount_due", "Saldo a cobrar");

            
            foreach (var delivery in deliveries)
            {
                dt_deliverys.Rows.Add(delivery.SaleId, delivery.ClientName, delivery.Date, delivery.Address, delivery.Reference, delivery.Instructions, delivery.PaymentCondition, delivery.Phone, delivery.Amount, delivery.Amount_due);
            }


        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //validar que se haya seleccionado un delivery
            if (dt_deliverys.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un delivery");
                return;
            }



            try
            {
                //preguntar si esta seguro de imprimir el delivey
                var result = MessageBox.Show("¿Está seguro de imprimir el delivery?", "Imprimir delivery", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //obtener el delivery seleccionado
                    var selectedRow = dt_deliverys.CurrentRow;
                    var delivery = new Delivery();
                    delivery.ClientName = selectedRow.Cells["ClientName"].Value.ToString();
                    delivery.Date = selectedRow.Cells["Date"].Value.ToString();
                    delivery.Address = selectedRow.Cells["Address"].Value.ToString();
                    delivery.Reference = selectedRow.Cells["Reference"].Value.ToString();
                    delivery.Instructions = selectedRow.Cells["Instructions"].Value.ToString();
                    delivery.PaymentCondition = selectedRow.Cells["PaymentCondition"].Value.ToString();
                    delivery.Phone = selectedRow.Cells["Phone"].Value.ToString();
                    delivery.Amount = decimal.Parse(selectedRow.Cells["Amount"].Value.ToString());
                    delivery.Amount_due = decimal.Parse(selectedRow.Cells["Amount_due"].Value.ToString());
                    delivery.SaleId = int.Parse(selectedRow.Cells["SaleId"].Value.ToString());

                    //obtener los productos del delivery
                    var productSaledRepository = new SaleRepository();
                    var products = productSaledRepository.getAllProductsWithSaleId(delivery.SaleId);
                    delivery.products = products;

                    //imprimir el delivery
                    var ticketDelivery = new TicketDelivery(delivery);
                    ticketDelivery.createTicketDelivery();

                    //mensaje de impresion exitosa
                    MessageBox.Show("Delivery impreso correctamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir el delivery: " + ex.Message);
            }
        
            
        }
    }
}