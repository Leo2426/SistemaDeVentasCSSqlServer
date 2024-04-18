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
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            //cargar productos
            LoadProducts();
        }


        private void LoadProducts()
        {
            var productRepository = new ProductRepository();
            var products = productRepository.GetAllProducts();
            dt_products.DataSource = products;

            //ocultar columna id
            dt_products.Columns["Id"].Visible = false;

            //renombrar columnas
            dt_products.Columns["Code"].HeaderText = "Código";
            dt_products.Columns["Description"].HeaderText = "Descripción";
            dt_products.Columns["Cost"].HeaderText = "Costo";
            dt_products.Columns["Price"].HeaderText = "Precio";
            dt_products.Columns["MinimumStock"].HeaderText = "Stock mínimo";
            dt_products.Columns["InitialStock"].HeaderText = "Stock";
            dt_products.Columns["SizesId"].HeaderText = "Talla";
           


        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            //abrir formulario para agregar producto
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadProducts();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //enviar producto seleccionado al formulario de actualización
            //validar que haya seleccionado un producto

            if (dt_products.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }
            var product = dt_products.CurrentRow;
            var updateProductForm = new UpdateProductForm((Product)product.DataBoundItem);
            updateProductForm.ShowDialog();
            LoadProducts();  
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //delete product
            var product = (Product)dt_products.CurrentRow.DataBoundItem;
            var productRepository = new ProductRepository();
            //message box de confirmación con la descripcion del producto
            var result = MessageBox.Show($"¿Está seguro de eliminar el producto {product.Description}?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productRepository.DeleteProduct(product.Id);
                LoadProducts();
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //search product
            var productRepository = new ProductRepository();
            var products = productRepository.SearchProduct(txt_search.Text);
                      
            dt_products.DataSource = products;




        }

        public void formating()
        {
         
            //dar formato a las columnas de color si la resta de stock inicial y stock minimo es menor a 2

            foreach (DataGridViewRow row in dt_products.Rows)
            {
                var initialStock = Convert.ToInt32(row.Cells["InitialStock"].Value);
                var minimumStock = Convert.ToInt32(row.Cells["MinimumStock"].Value);
                if (initialStock - minimumStock <= 3)
                {
                   //toda la fila
                   row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    //solo una celda
                }
            }

            
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si presiona enter buscar
            if (e.KeyChar == (char)13)
            {
                btn_search.PerformClick();
            }
        }
    }
}
