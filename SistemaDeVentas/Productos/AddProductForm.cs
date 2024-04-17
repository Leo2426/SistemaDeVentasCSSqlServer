using SistemaDeVentas.Clientes;
using SistemaDeVentas.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Productos
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            //cargar tallas
            LoadSizes();
        }

        private void LoadSizes()
        {
            var sizeRepository = new SizeRepository();
            var sizes = sizeRepository.GetAllSizes();
            cb_sizes.DataSource = sizes;
            cb_sizes.DisplayMember = "SizeName";
            cb_sizes.ValueMember = "Id";

            //valor para mostrar en el combobox es (en blanco)
            cb_sizes.Text = "(en blanco)";

        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {

            //validar que el cliente este en la coleccion de clientes
            var size = (Size)cb_sizes.SelectedItem;
            if (size == null)
            {
                MessageBox.Show("La talla no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            //add product
            var product = new Product
            {
                Code = txt_code.Text,
                Description = txt_description.Text,
                Cost = decimal.Parse(txt_unit_cost.Text),
                Price = decimal.Parse(txt_unit_price.Text),
                MinimumStock = int.Parse(txt_minimum_stock.Text),
                InitialStock = int.Parse(txt_initial_stock.Text),
                SizesId = cb_sizes.Text
            };
            
            var productRepository = new ProductRepository();
            productRepository.AddProduct(product);
            this.Close();

        }

        private void txt_unit_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.validateOnlyNumbersAndDecimalKeyPress(e, txt_unit_cost);
        }

        private void txt_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.validateOnlyNumbersAndDecimalKeyPress(e, txt_unit_price);
        }

        private void txt_initial_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo ingresar numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            //permitir el backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txt_minimum_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo ingresar numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            //permitir el backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
    }
}
