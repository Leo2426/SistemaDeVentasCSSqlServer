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
    public partial class DeliveryForm : Form
    {
        private Delivery delivery;
        public DeliveryForm(Sale sale, List<ProductSaled> products)
        {
            InitializeComponent();
            this.delivery = new Delivery(sale, products);
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            //cargar los txt
            txt_name.Text = delivery.ClientName;
            txt_address.Text = delivery.Address + " - " + delivery.District;
            txt_reference.Text = delivery.Reference;
            txt_instructions.Text = delivery.Instructions;
            txt_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_phone.Text = delivery.Phone;
            txt_amount.Text = delivery.Amount.ToString();
            txt_saldo_a_cobrar.Text = delivery.Amount_due.ToString();
            cb_payment_condition.SelectedIndex = 0;


            //cargar cabeceras al dtw
            dt_products.Columns.Add("Description","Descripción");
            dt_products.Columns.Add("Quantity", "Cantidad");
            dt_products.Columns.Add("Price", "Precio");


            //cargar todos los productos
            foreach (var product in delivery.products)
            {
                dt_products.Rows.Add(product.Description, product.Quantity,product.SalePrice);
            }


            //cargar el titulo con el numero de venta
            lbl_title.Text = "Delivery de venta N " + delivery.SaleId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cargar delivery
            delivery.ClientName = txt_name.Text;
            delivery.Address = txt_address.Text;
            delivery.Reference = txt_reference.Text;
            delivery.Instructions = txt_instructions.Text;
            delivery.Phone = txt_phone.Text;
            delivery.Amount = string.IsNullOrWhiteSpace(txt_amount.Text) ? 0 : decimal.Parse(txt_amount.Text);
            delivery.Amount_due = string.IsNullOrWhiteSpace(txt_saldo_a_cobrar.Text) ? 0 : decimal.Parse(txt_saldo_a_cobrar.Text);
            delivery.PaymentCondition = cb_payment_condition.SelectedItem.ToString();
            delivery.Date = txt_date.Text;

            //insertar el delivery
            var deliveryRepository = new DeliveryRepository();
            deliveryRepository.InsertDelivery(delivery);
            this.Close();
            
            //preguntar si desea imprimir el ticket
            var ticketDelivery = new TicketDelivery(delivery);
            ticketDelivery.createTicketDelivery();
        }

        private void txt_saldo_a_cobrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

            //que solo acepte el punto 1 vez y que solo haya 2 decimales
            if (ch == 46 && txt_saldo_a_cobrar.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            //que solo acepte 2 decimales
            if (txt_saldo_a_cobrar.Text.IndexOf('.') != -1 && txt_saldo_a_cobrar.Text.Substring(txt_saldo_a_cobrar.Text.IndexOf('.')).Length > 2)
            {
                e.Handled = true;
            }

            //permitir el backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            //que no acepte primero el punto
            if (txt_saldo_a_cobrar.Text.Length == 0 && ch == 46)
            {
                e.Handled = true;
            }


        }

        private void txt_saldo_a_cobrar_TextChanged(object sender, EventArgs e)
        {
            //validar que el saldo no sea mayor al monto
            if (txt_saldo_a_cobrar.Text !=""  && decimal.Parse(txt_saldo_a_cobrar.Text) > decimal.Parse(txt_amount.Text))
            {
                txt_saldo_a_cobrar.Text = txt_amount.Text;
            }

        }
    }
}
