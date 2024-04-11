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
            txt_address.Text = delivery.Address;
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


            //cargar todos los productos
            foreach (var product in delivery.products)
            {
                dt_products.Rows.Add(product.Description, product.Quantity);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cargar delivery
            delivery.ClientName = txt_name.Text;
            delivery.Address = txt_address.Text;
            delivery.Reference = txt_reference.Text;
            delivery.Instructions = txt_instructions.Text;
            delivery.Phone = txt_phone.Text;
            delivery.Amount = decimal.Parse(txt_amount.Text);
            delivery.Amount_due = decimal.Parse(txt_saldo_a_cobrar.Text);
            delivery.PaymentCondition = cb_payment_condition.SelectedItem.ToString();
            delivery.Date = txt_date.Text;

            //insertar el delivery
            var deliveryRepository = new DeliveryRepository();
            deliveryRepository.InsertDelivery(delivery);
            MessageBox.Show("Delivery insertado correctamente");
            this.Close();
        }
    }
}
