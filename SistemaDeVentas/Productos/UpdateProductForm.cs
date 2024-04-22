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
    public partial class UpdateProductForm : Form
    {
        private Product _product;

        // Delegate declaration
        public delegate void ProductEventHandler(Product product);

        // Event declaration
        public event ProductEventHandler ProductUpdated;

        public UpdateProductForm(Product product)
        {
            InitializeComponent();
            _product = product;
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            //cargar todos los datos del producto
            txt_code.Text = _product.Code;
            txt_description.Text = _product.Description;
            txt_unit_cost.Text = _product.Cost.ToString();
            txt_unit_price.Text = _product.Price.ToString();
            txt_minimum_stock.Text = _product.MinimumStock.ToString();
            txt_initial_stock.Text = _product.InitialStock.ToString();


            //cargar tallas
            LoadSizes();

        }

        private void LoadSizes()
        {
            //cargar tallas
            var sizeRepository = new SizeRepository();
            var sizes = sizeRepository.GetAllSizes();
            cb_sizes.DataSource = sizes;
            cb_sizes.DisplayMember = "SizeName";
            cb_sizes.ValueMember = "Id";
            cb_sizes.Text = _product.SizesId;

        }

        private async void btn_update_product_click(object sender, EventArgs e)
        {
            //update product
            _product.Code = txt_code.Text;
            _product.Description = txt_description.Text;
            _product.Cost = decimal.Parse(txt_unit_cost.Text);
            _product.Price = decimal.Parse(txt_unit_price.Text);
            _product.MinimumStock = int.Parse(txt_minimum_stock.Text);
            _product.InitialStock = int.Parse(txt_initial_stock.Text);
            _product.SizesId = cb_sizes.Text;

            var productRepository = new ProductRepository();

            //invocar el evento
            ProductUpdated?.Invoke(_product);

            await productRepository.UpdateProductAsync(_product);
            MessageBox.Show("Producto actualizado correctamente");
            this.Close();
        }

        private void txt_initial_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo admite numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            //solo admite numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            //permitir el backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txt_unit_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.validateOnlyNumbersAndDecimalKeyPress(e, txt_unit_cost);
        }

        private void txt_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.validateOnlyNumbersAndDecimalKeyPress(e, txt_unit_price);
        }

    }
}
