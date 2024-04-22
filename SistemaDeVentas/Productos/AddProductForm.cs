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
        // Delegate declaration
        public delegate void ProductEventHandler(Product product);

        // Event declaration
        public event ProductEventHandler ProductAdded;

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // Cargar tallas de forma asíncrona
             LoadSizesAsync();
        }

        private  void LoadSizesAsync()
        {
            var sizeRepository = new SizeRepository();
            var sizes =  sizeRepository.GetAllSizes();
            cb_sizes.DataSource = sizes;
            cb_sizes.DisplayMember = "SizeName";
            cb_sizes.ValueMember = "Id";

            // Establecer valor por defecto en el combobox
            cb_sizes.SelectedIndex = -1;
            cb_sizes.Text = "(en blanco)";
        }

        private async void btn_add_client_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txt_code.Text) || string.IsNullOrEmpty(txt_description.Text) || string.IsNullOrEmpty(txt_unit_cost.Text) || string.IsNullOrEmpty(txt_unit_price.Text) || string.IsNullOrEmpty(txt_minimum_stock.Text) || string.IsNullOrEmpty(txt_initial_stock.Text) || cb_sizes.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que el código no se repita de forma asíncrona
            var productRepository = new ProductRepository();
            var productExists = await productRepository.GetProductByCodeAsync(txt_code.Text);
            if (productExists !=null)
            {
                MessageBox.Show("El código ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var size = (Size)cb_sizes.SelectedItem;
            if (size == null)
            {
                MessageBox.Show("La talla no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var lastId = await productRepository.getLastIdAsync();

            // Crear producto
            var product = new Product
            {
                Id = lastId + 1,
                Code = txt_code.Text,
                Description = txt_description.Text,
                Cost = decimal.Parse(txt_unit_cost.Text),
                Price = decimal.Parse(txt_unit_price.Text),
                MinimumStock = int.Parse(txt_minimum_stock.Text),
                InitialStock = int.Parse(txt_initial_stock.Text),
                SizesId = cb_sizes.Text


            };


            // Trigger the event
            ProductAdded?.Invoke(product);

            // Añadir producto de forma asíncrona
            await productRepository.AddProductAsync(product);


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

