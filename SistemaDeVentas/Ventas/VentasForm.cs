using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace SistemaDeVentas.Ventas
{
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            loadSales();
        }


        private void loadSales()
        {
            //cargar las ventas
            var saleRepository = new SaleRepository();
            var sales = saleRepository.GetAllSales();
            dt_sales.DataSource = sales;

            //cambiar el nombre de las columnas
            dt_sales.Columns["Id"].HeaderText = "ID";
            //ID SaleType    ClientName Date    Phone Reference   Address PaymentTypeName Observation Channel PaymentConditionName Total   CashPayment CreditPayment   UserName
            dt_sales.Columns["SaleType"].HeaderText = "Tipo de Venta";
            dt_sales.Columns["ClientName"].HeaderText = "Cliente";
            dt_sales.Columns["Date"].HeaderText = "Fecha";
            dt_sales.Columns["Phone"].HeaderText = "Teléfono";
            dt_sales.Columns["Reference"].HeaderText = "Referencia";
            dt_sales.Columns["Address"].HeaderText = "Dirección";
            dt_sales.Columns["PaymentTypeName"].HeaderText = "Tipo de Pago";
            dt_sales.Columns["Observation"].HeaderText = "Observación";
            dt_sales.Columns["Channel"].HeaderText = "Canal";
            dt_sales.Columns["PaymentConditionName"].HeaderText = "Condición de Pago";
            dt_sales.Columns["Total"].HeaderText = "Total";
            dt_sales.Columns["CashPayment"].HeaderText = "Pago en Efectivo";
            dt_sales.Columns["CreditPayment"].HeaderText = "Pago con Tarjeta";
            dt_sales.Columns["UserName"].HeaderText = "Vendedor";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var addSaleForm = new AddSaleForm();
            addSaleForm.ShowDialog();
            loadSales();
        }

        private void dt_sales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtener la venta seleccionada y mostrar los productos
            var sale = (Sale)dt_sales.CurrentRow.DataBoundItem;
            var productsWithSalesForm = new ProductsWithSalesForm(sale);
            productsWithSalesForm.ShowDialog();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //eliminar la venta seleccionada

            if (dt_sales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para eliminar");
                return;
            }

            //preguntar si esta seguro de eliminar la venta 
            var result = MessageBox.Show("¿Está seguro de eliminar la venta?", "Eliminar Venta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var sale = (Sale)dt_sales.CurrentRow.DataBoundItem;
                var saleRepository = new SaleRepository();
                saleRepository.DeleteSale(sale.Id);
                loadSales();
            }


        }
    }
}
