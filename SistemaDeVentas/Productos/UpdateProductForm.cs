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
            cb_sizes.Text = _product.SizesId;

        }

        private void btn_update_product_click(object sender, EventArgs e)
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
            productRepository.UpdateProduct(_product);
            MessageBox.Show("Producto actualizado correctamente");
            this.Close();
        }
    }
}
