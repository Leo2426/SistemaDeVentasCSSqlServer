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
        }
    }
}
