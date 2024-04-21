using SistemaDeVentas.Productos;
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
    public partial class ProductsWithSalesForm : Form
    {
        private Sale sale = new Sale();
        public ProductsWithSalesForm(Sale sale)
        {
            InitializeComponent();
            this.sale = sale;
        }

        private void ProductsWithSalesForm_Load(object sender, EventArgs e)
        {
            //cargar los productos de la venta
            var saleRepository = new SaleRepository();
            var products = saleRepository.getAllProductsWithSaleId(sale.Id);
            dt_products.DataSource = products;

            lbl_title.Text = "Productos de la venta N " + sale.Id;

            //renombrar columnas
            dt_products.Columns["Description"].HeaderText = "Descripción";
            dt_products.Columns["Quantity"].HeaderText = "Cantidad";
            dt_products.Columns["SalePrice"].HeaderText = "Precio de venta";
            dt_products.Columns["Code"].HeaderText = "Código";
            dt_products.Columns["Size"].HeaderText = "Talla";

            //reordenar que el codigo vaya primero
            dt_products.Columns["Code"].DisplayIndex = 0;


            //ocultar SaleId
            dt_products.Columns["SaleId"].Visible = false;
            dt_products.Columns["ProductId"].Visible = false;


            
        }
    }
}
