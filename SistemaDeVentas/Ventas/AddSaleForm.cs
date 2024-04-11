﻿using Microsoft.IdentityModel.Tokens;
using SistemaDeVentas.Clientes;
using SistemaDeVentas.Print;
using SistemaDeVentas.Productos;
using SistemaDeVentas.Shared;
using SistemaDeVentas.Ventas.Delivery;
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
            addbtndeleteAndHeaders();
        }

        private void addbtndeleteAndHeaders()
        {


            //agregar cabeceras a la tabla  

            dt_products.Columns.Add("Id", "Id");
            dt_products.Columns.Add("Code", "Código");
            dt_products.Columns.Add("Description", "Descripción");
            dt_products.Columns.Add("Price", "Precio");
            dt_products.Columns.Add("Size", "Talla");
            dt_products.Columns.Add("Quantity", "Cantidad");

            //agregar un boton para eliminar del data grid view
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dt_products.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Eliminar";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            btn = new DataGridViewButtonColumn();

            //si da click al boton se elimina toda la fila
            dt_products.CellClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0 && ev.ColumnIndex == dt_products.Columns["btn"].Index)
                {
                    dt_products.Rows.RemoveAt(ev.RowIndex);
                }
            };

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //validar que hayan productos
            if (dt_products.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar productos a la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaleRepository salerepo = new SaleRepository();
            sale.Id = salerepo.GetLastSaleId() + 1;
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


            //insertar los productos de la venta
            var saledProducts = new List<ProductSaled>();
            foreach (DataGridViewRow row in dt_products.Rows)
            {
                var productSaled = new ProductSaled();
                //se obtiene el id de la venta que se acaba de insertar
                productSaled.ProductId = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                //se obtiene el id de la venta que se acaba de insertar
                productSaled.Description = row.Cells["Description"].Value.ToString();
                productSaled.SaleId = saleRepository.GetLastSaleId();
                productSaled.Code = row.Cells["Code"].Value.ToString();
                productSaled.Quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                productSaled.SalePrice = decimal.Parse(row.Cells["Price"].Value.ToString());
                saleRepository.InsertProductSaled(productSaled);
                saledProducts.Add(productSaled);


                //disminuir la cantidad de initial stock de cada producto
                var productRepository = new ProductRepository();
                var product = productRepository.GetProductByCode(productSaled.Code);
                product.InitialStock -= productSaled.Quantity;
                productRepository.UpdateProduct(product);
            }



            this.Close();

            //Preguntar si quiere generar pdf
            DialogResult dialogResult = MessageBox.Show("¿Desea generar un ticket de venta?", "Ticket de venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                generatePdf(saledProducts);
            }

            //lanzar form de delivery
            var deliveryForm = new DeliveryForm(sale, saledProducts);
            deliveryForm.ShowDialog();

        }

        private void generatePdf(List<ProductSaled> productSaleds)
        {
            //generar ticket de venta
            var saleTicket = new SaleTicket(sale,productSaleds);
            saleTicket.CreateSaleTicketPdf();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //cargar el formulario de busqueda de productos
            var searchProductForm = new SearchProductForm();
            searchProductForm.ShowDialog();

            //cargar los campos con el producto seleccionado
            loadTextBoxesWithProductSelected();

        }

        public void loadTextBoxesWithProductSelected()
        {
            //obtener el producto seleccionado
            var product = GlobalClass.SelectedProduct;
            if (product != null)
            {
                //agregar el producto a la lista de productos
                txt_product_name.Text = product.Description;
                txt_product_code.Text = product.Code;
                txt_product_price.Text = product.Price.ToString();
                txt_size.Text = product.SizesId;
                txt_quantity.Text = "1";
            }
        }


        private void btn_add_product_to_dt_Click(object sender, EventArgs e)
        {
            //si el producto seleccionado ya esta en la lista no permitir agregarlo
            foreach (DataGridViewRow row in dt_products.Rows)
            {
                if (row.Cells["Code"].Value.ToString() == txt_product_code.Text)
                {
                    MessageBox.Show("El producto ya se encuentra en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            var productRepository = new ProductRepository();

            var product = productRepository.GetProductByCode(txt_product_code.Text);


            //si no existen productos que salga un messagebox de error
            if (GlobalClass.SelectedProduct == null)
            {
                MessageBox.Show("Selecciona un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validar que el producto cuente con intial_stock luego de restarle la cantidad
            if (product.InitialStock < int.Parse(txt_quantity.Text))
            {
                MessageBox.Show("No hay suficiente stock para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }





            //validar que haya seleccionado un producto
            if (txt_product_code.Text == "")
            {
                //mostrar mensaje de error con icono de 
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //agregar producto a la lista de productos
            dt_products.Rows.Add(GlobalClass.SelectedProduct.Id,txt_product_code.Text, txt_product_name.Text, txt_product_price.Text, txt_size.Text, txt_quantity.Text);

            GlobalClass.SelectedProduct = null;

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

        private void txt_product_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar el producto por el codigo
                var productRepository = new ProductRepository();
                var product = productRepository.GetProductByCode(txt_product_code.Text);
                if (product.Code != null)
                {
                    txt_product_name.Text = product.Description;
                    txt_product_price.Text = product.Price.ToString();
                    txt_size.Text = product.SizesId;
                    txt_quantity.Text = "1";


                    //agregar al global class
                    GlobalClass.SelectedProduct = product;

                }
                //sino lanzar un mensaje
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }


        }
    }
}
