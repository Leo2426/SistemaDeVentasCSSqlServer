using SistemaDeVentas.Productos;
using SistemaDeVentas.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Ventas
{
    public partial class SearchProductForm : Form
    {
        private string conectionString = Conexion.stringConexion;
        public SearchProductForm()
        {
            InitializeComponent();
        }

        private void SearchProductForm_Load(object sender, EventArgs e)
        {
            //cargar los productos
            loadProducts();
        }


        private void loadProducts()
        {

            var productRepository = new ProductRepository();
            var products = productRepository.GetAllProducts();

            //si la no hay productos mostrar mensaje
            if (products.Count == 0)
            {
                MessageBox.Show("No hay productos registrados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }


            dt_products.DataSource = products;

            //ocultar columna id
            dt_products.Columns["Id"].Visible = false;

            //renombrar columnas
            dt_products.Columns["Code"].HeaderText = "Código";
            dt_products.Columns["Description"].HeaderText = "Descripción";
            dt_products.Columns["Cost"].HeaderText = "Costo";
            dt_products.Columns["Price"].HeaderText = "Precio";
            dt_products.Columns["MinimumStock"].HeaderText = "Stock mínimo";
            dt_products.Columns["InitialStock"].HeaderText = "Stock inicial";
            dt_products.Columns["SizesId"].HeaderText = "Talla";


        }

        private void dt_products_DoubleClick(object sender, EventArgs e)
        {
            //Retornar el producto seleccionado
            var product = new Product();
            product.Id = int.Parse(dt_products.CurrentRow.Cells["Id"].Value.ToString());
            product.Code = dt_products.CurrentRow.Cells["Code"].Value.ToString();
            product.Description = dt_products.CurrentRow.Cells["Description"].Value.ToString();
            product.Cost = decimal.Parse(dt_products.CurrentRow.Cells["Cost"].Value.ToString());
            product.Price = decimal.Parse(dt_products.CurrentRow.Cells["Price"].Value.ToString());
            product.MinimumStock = int.Parse(dt_products.CurrentRow.Cells["MinimumStock"].Value.ToString());
            product.InitialStock = int.Parse(dt_products.CurrentRow.Cells["InitialStock"].Value.ToString());
            product.SizesId = dt_products.CurrentRow.Cells["SizesId"].Value.ToString();

            GlobalClass.SelectedProduct = product;
            GlobalClass.isProductSelectProperly = true;
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //buscar productos por código o descripción
            var productRepository = new ProductRepository();
            var products = productRepository.SearchProduct(txt_search.Text);
            
            //cargar los productos 
            dt_products.DataSource = products;

        }
    }
}
