using SistemaDeVentas.Print;
using SistemaDeVentas.Ventas.Delivery;
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
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
        }

        private void VentasForm2_Load(object sender, EventArgs e)
        {
            loadSales();
            //renombrar columnas
            dt_sales.Columns["Id"].HeaderText = "Correlativo";
            dt_sales.Columns["SaleType"].HeaderText = "Tipo de venta";
            dt_sales.Columns["ClientName"].HeaderText = "Cliente";
            dt_sales.Columns["Date"].HeaderText = "Fecha";
            dt_sales.Columns["Phone"].HeaderText = "Teléfono";
            dt_sales.Columns["Reference"].HeaderText = "Referencia";
            dt_sales.Columns["Address"].HeaderText = "Dirección";
            dt_sales.Columns["PaymentTypeName"].HeaderText = "Tipo de pago";
            dt_sales.Columns["Observation"].HeaderText = "Observación";
            dt_sales.Columns["Channel"].HeaderText = "Canal";
            dt_sales.Columns["PaymentConditionName"].HeaderText = "Condición de pago";
            dt_sales.Columns["Total"].HeaderText = "Total";
            dt_sales.Columns["CashPayment"].HeaderText = "Pago en efectivo";
            dt_sales.Columns["CreditPayment"].HeaderText = "Pago a crédito";
            dt_sales.Columns["CreditDays"].HeaderText = "Días de crédito";
            dt_sales.Columns["UserName"].HeaderText = "Usuario";
        }


        private void loadSales()
        {
            //cargar las ventas
            var saleRepository = new SaleRepository();
            var sales = saleRepository.GetAllSales();

           dt_sales.DataSource = sales;

            dt_sales.Columns["District"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var addSaleForm = new AddSaleForm();
            addSaleForm.ShowDialog();
            loadSales();
        }

        private void dt_sales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //validar que se haya seleccionado una venta
            if (dt_sales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para ver los productos");
                return;
            }

            //obtener la venta seleccionada y mostrar los productos
            var sale = (Sale)dt_sales.CurrentRow.DataBoundItem;
            var productsWithSalesForm = new ProductsWithSalesForm(sale);
            productsWithSalesForm.ShowDialog();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //verificar si se selecciono una venta


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
                //seleccionar la venta del grid
                var sale = (Sale)dt_sales.CurrentRow.DataBoundItem;
                var saleRepository = new SaleRepository();
                saleRepository.DeleteSale(sale.Id);
                loadSales();
            }


        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //Imprimir la venta seleccionada
            if (dt_sales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para imprimir");
                return;
            }


            //preguntar si esta seguro de imprimir la venta
            var result = MessageBox.Show("¿Está seguro de imprimir la venta?", "Imprimir Venta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //seleccionar la venta del grid
                var sale = (Sale)dt_sales.CurrentRow.DataBoundItem;
                var productSaledRepository = new SaleRepository();
                var productsSaled = productSaledRepository.getAllProductsWithSaleId(sale.Id);

                var saleTicket = new Ticket80mm(sale, productsSaled);
                saleTicket.CreateTicket80mm();
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_search.Text))
            {
                loadSales();
                return;
            }


            //cargar las ventas del resultado de la busqueda
            var saleRepository = new SaleRepository();
            var sales = saleRepository.searchSalesByTerm(txt_search.Text);
            dt_sales.DataSource = sales;

            

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