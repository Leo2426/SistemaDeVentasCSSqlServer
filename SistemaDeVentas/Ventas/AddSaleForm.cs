using Microsoft.IdentityModel.Tokens;
using SistemaDeVentas.Clientes;
using SistemaDeVentas.Shared;
using SistemaDeVentas.Ventas.Payments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Ventas
{
    public partial class AddSaleForm : Form
    {
        private Sale sale = new Sale();
        public AddSaleForm()
        {
            InitializeComponent();

        }

        private void loadComboBoxes()
        {
            //cargar clientes
            loadClients();

            //cargar payment types
            var paymentTypeRepository = new PaymentTypeRepository();
            var paymentTypes = paymentTypeRepository.GetAllPaymentTypes();
            cb_payment_type.DataSource = paymentTypes;
            cb_payment_type.DisplayMember = "Name";
            cb_payment_type.ValueMember = "Name";

            //cargar payment conditions
            var paymentConditionRepository = new PaymentConditionRepository();
            var paymentConditions = paymentConditionRepository.GetAllPaymentConditions();
            cb_payment_condition.DataSource = paymentConditions;
            cb_payment_condition.DisplayMember = "Name";
            cb_payment_condition.ValueMember = "Name";

            //cargar vendedores
            var userRepository = new SaleRepository ();
            var users = userRepository.getAllSalesMan();
            cb_sales_man.DataSource = users;
            cb_sales_man.DisplayMember = "Name";
            cb_sales_man.ValueMember = "Name";

            //cargar canal por defecto y tipo de comprobante por defecto
            cb_chanel.Text = "WHATSAPP";
            cb_type.Text = "BOLETA";

        }

        private void loadClients()
        {
            var clientRepository = new ClientRepository();
            var clients = clientRepository.GetAllClients();
            cb_client_name.DataSource = clients;
            cb_client_name.DisplayMember = "Name";
            cb_client_name.ValueMember = "Name";
        }


        private void AddSaleForm_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            sale.SaleType = cb_type.Text;
            sale.ClientName = cb_client_name.Text;
            sale.Date = DateTime.Now;
            sale.Phone = txt_phone.Text;
            sale.Reference = txt_reference.Text;
            sale.Address = txt_address.Text;
            sale.PaymentTypeName = cb_payment_type.Text;
            sale.Observation = txt_observation.Text;
            sale.Channel = cb_chanel.Text;
            sale.PaymentConditionName = cb_payment_condition.Text;
            sale.Total = decimal.Parse(txt_total.Text);
            //parsear a decimal sino se puede que sea 0

            sale.CashPayment = string.IsNullOrWhiteSpace(txt_cash.Text) ? 0 : decimal.Parse(txt_cash.Text);
            sale.CreditPayment = string.IsNullOrWhiteSpace(txt_credit.Text) ? 0 : decimal.Parse(txt_credit.Text);
            sale.UserName = cb_sales_man.Text;

            var saleRepository = new SaleRepository();
            saleRepository.InsertSale(sale);

            this.Close();


        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            //cargar el formulario de busqueda de productos
            var searchProductForm = new SearchProductForm();
            searchProductForm.ShowDialog();

            //obtener el producto seleccionado
            var product = GlobalClass.SelectedProduct;
            if (product != null)
            {
                   //agregar el producto a la lista de productos
                txt_product_name.Text = product.Description;
                txt_product_code.Text = product.Code;
                txt_product_price.Text = product.Price.ToString();
                txt_quantity.Text = "1";
            }

            GlobalClass.SelectedProduct = null;
        }

        private void btn_add_product_to_dt_Click(object sender, EventArgs e)
        {
            //validar que haya seleccionado un producto
            if (txt_product_code.Text == "")
            {
                //mostrar mensaje de error con icono de 
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            //agregar cabeceras a la tabla  
            if (dt_products.Columns.Count == 0)
            {
                dt_products.Columns.Add("Code", "Código");
                dt_products.Columns.Add("Description", "Descripción");
                dt_products.Columns.Add("Price", "Precio");
                dt_products.Columns.Add("Quantity", "Cantidad");
            }


            //agregar producto a la lista de productos
            dt_products.Rows.Add(txt_product_code.Text, txt_product_name.Text, txt_product_price.Text, txt_quantity.Text);

            //calcular el total
            decimal total = 0;

            foreach (DataGridViewRow row in dt_products.Rows)
            {
                if (row.Cells["Price"].Value != null && row.Cells["Quantity"].Value != null)
                {
                    decimal precio = Convert.ToDecimal(row.Cells["Price"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Quantity"].Value);
                    total += precio * cantidad;
                }
            }

            // Aquí puedes usar el valor de 'total' como necesites.
            txt_total.Text = total.ToString();


            //limpiar los campos
            txt_product_code.Text = "";
            txt_product_name.Text = "";
            txt_product_price.Text = "";
            txt_quantity.Text = "";
            
        }

        private void cb_client_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtener el cliente seleccionado
            var client = (Client)cb_client_name.SelectedItem;
            txt_phone.Text = client.Phone;
            txt_address.Text = client.Address;
            txt_reference.Text = client.Reference;
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            //cargar el formulario de agregar cliente
            var addClientForm = new AddClientForm();
            addClientForm.ShowDialog();

            //recargar los clientes
            loadClients();
        }
    }
}
