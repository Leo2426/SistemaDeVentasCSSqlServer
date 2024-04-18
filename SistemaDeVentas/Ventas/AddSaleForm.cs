using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Engines;
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
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace SistemaDeVentas.Ventas
{
    public partial class AddSaleForm : Form
    {
        private Sale sale = new Sale();
        private List<ProductSaled> saledProducts = new List<ProductSaled>();
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
            cb_payment_condition.Text = "CONTADO";

            //cargar vendedores
            var userRepository = new SaleRepository();
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

            //si no hay clientes mostrar un mensaje
            if (clients.Count == 0)
            {
                MessageBox.Show("No hay clientes registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //si hay clientes selecccionar last cliente
            if (clients.Count > 0)
            {
                cb_client_name.Text =  clientRepository.getLasClient().Name;
            }

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
            //validar que el cliente no este vacio
            if (string.IsNullOrWhiteSpace(cb_client_name.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validar que el cliente este en la coleccion de clientes
            var client = (Client)cb_client_name.SelectedItem;
            if (client == null)
            {
                MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DialogResult dialogResult = MessageBox.Show("¿Imprimir ticket de Venta?", "Ticket de venta", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            //validar que hayan productos
            if (dt_products.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar productos a la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validar que txt_cash no este vacio si es que esta visible
            if (txt_cash.Visible && string.IsNullOrWhiteSpace(txt_cash.Text))
            {
                MessageBox.Show("Debe ingresar el monto en efectivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            sale.SaleType = cb_type.Text;
            sale.ClientName = cb_client_name.Text;
            sale.Date = dtp_date.Value;
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
            sale.CreditDays = string.IsNullOrWhiteSpace(txt_days_credit.Text) ? 0 : int.Parse(txt_days_credit.Text);
            sale.UserName = cb_sales_man.Text;

            var saleRepository = new SaleRepository();
            saleRepository.InsertSale(sale);

            //agregar el id de la venta a la clase sale
            sale.Id = saleRepository.GetLastSaleId();

            foreach (DataGridViewRow row in dt_products.Rows)
            {
                var productSaled = new ProductSaled();
                //se obtiene el id de la venta que se acaba de insertar
                productSaled.ProductId = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                //se obtiene el id de la venta que se acaba de insertar
                productSaled.Description = row.Cells["Description"].Value.ToString();
                productSaled.SaleId = sale.Id;
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


           //generar ticket de venta si el usuario lo desea por confimacion de messagebox
            
            if (dialogResult == DialogResult.Yes)
            {
                Ticket80mm ticket80Mm = new Ticket80mm(sale, saledProducts);
                ticket80Mm.CreateTicket80mm();
            }

            //lanzar form de delivery
            var deliveryForm = new DeliveryForm(sale, saledProducts);
            deliveryForm.ShowDialog();

        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            //cargar el formulario de busqueda de productos
            var searchProductForm = new SearchProductForm();
            searchProductForm.ShowDialog();

            //cargar los campos con el producto seleccionado
            loadTextBoxesWithProductSelected();
            if (GlobalClass.SelectedProduct != null)
                txt_quantity.Focus();

            if (GlobalClass.isProductSelectProperly)
            {
                txt_product_code.ReadOnly = true;
                GlobalClass.isProductSelectProperly = false;
            }


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
                txt_product_stock.Text = product.InitialStock.ToString();
                //setear al txt_quantity que su mayor valor sea el stock del producto
                txt_quantity.Maximum = int.Parse(product.InitialStock.ToString());
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

            //si la cantidad es 0 no permitir agregar el producto
            if (txt_quantity.Text == "0")
            {
                MessageBox.Show("La cantidad no puede ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
            dt_products.Rows.Add(GlobalClass.SelectedProduct.Id, txt_product_code.Text, txt_product_name.Text, txt_product_price.Text, txt_size.Text, txt_quantity.Text);

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
            txt_product_stock.Text = "";
            txt_size.Text = "";
            txt_product_code.Text = "";
            txt_product_name.Text = "";
            txt_product_price.Text = "";
            txt_quantity.Text = "";

            //desabilitar maximo de cantidad
            txt_quantity.Maximum = 10000;

            txt_product_code.ReadOnly = false;
            GlobalClass.isProductSelectProperly = false;

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
                    txt_product_stock.Text = product.InitialStock.ToString();
                    txt_quantity.Text = "1";


                    //establecer maximo stock
                    txt_quantity.Maximum = int.Parse(product.InitialStock.ToString());

                    //agregar al global class
                    GlobalClass.SelectedProduct = product;
                    GlobalClass.isProductSelectProperly = true;
                    txt_product_code.ReadOnly = true;

                }
                //sino lanzar un mensaje
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }


        }

        private void cb_payment_condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si selecciona contado deshabilitar el campo de credito
            if (cb_payment_condition.Text == "CONTADO")
            {
                //desabilitar campo credito , dias de credito y habilitar campo efectivo
                txt_credit.Visible = false;
                lbl_credit.Visible = false;
                txt_days_credit.Visible = false;
                lbl_days_credit.Visible = false;
                txt_cash.Visible = false;
                lbl_cash.Visible = false;
                txt_credit.Text = "";
                txt_days_credit.Text = "";

            }
            else if (cb_payment_condition.Text == "CONTADO / CREDITO")
            {
                txt_credit.Visible = false;
                lbl_credit.Visible = false;
                txt_days_credit.Visible = true;
                lbl_days_credit.Visible = true;
                lbl_cash.Visible = true;
                lbl_credit.Visible = true;
                txt_credit.Visible = true;
                txt_cash.Visible = true;
                txt_credit.Text = "";

            }
            else if (cb_payment_condition.Text == "CREDITO")
            {
                txt_credit.Visible = false;
                lbl_credit.Visible = false;
                lbl_cash.Visible = false;
                txt_cash.Visible = false;
                lbl_days_credit.Visible = true;
                txt_days_credit.Visible = true;
                txt_credit.Text = "";
                txt_cash.Text = "";
            }
        }

        private void txt_cash_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.validateOnlyNumbersAndDecimalKeyPress( e, txt_cash);

        }

        private void txt_cash_TextChanged(object sender, EventArgs e)
        {


            bool cashIsLessThanTotal = false;
            if (txt_total.Text != "" && txt_cash.Text != "")
                cashIsLessThanTotal = (decimal.Parse(txt_cash.Text) < decimal.Parse(txt_total.Text));

            if (cashIsLessThanTotal)
                txt_credit.Text = (decimal.Parse(txt_total.Text) - decimal.Parse(txt_cash.Text)).ToString();
            else
            {
                txt_credit.Text = "";
                txt_cash.Text = "";
            }


        }

        private void txt_days_credit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }

            //permitir el backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }


            //que no acepte la , al principio
            if (ch == 44)
            {
                e.Handled = true;
            }



        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            //lanzar el formulario de agregar producto
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();

            //cargar el ultimo producto agregado
            var productRepository = new ProductRepository();
            var product = productRepository.getLastProductAdded();
            if (product != null)
            {
                txt_product_name.Text = product.Description;
                txt_product_code.Text = product.Code;
                txt_product_code.ReadOnly = true;
                txt_product_price.Text = product.Price.ToString();
                txt_size.Text = product.SizesId;
                txt_product_stock.Text = product.InitialStock.ToString();
                txt_quantity.Text = "1";

                //establecer maximo stock
                txt_quantity.Maximum = int.Parse(product.InitialStock.ToString());

                //agregar al global class
                GlobalClass.SelectedProduct = product;

            }

           


        }
    }
}

