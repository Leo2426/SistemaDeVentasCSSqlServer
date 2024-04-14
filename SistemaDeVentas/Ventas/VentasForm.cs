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
            dt_sales.Columns.Add("Id", "ID");
            dt_sales.Columns.Add("SaleType", "Tipo de Venta");
            dt_sales.Columns.Add("ClientName", "Cliente");
            dt_sales.Columns.Add("Date", "Fecha");
            dt_sales.Columns.Add("Phone", "Teléfono");
            dt_sales.Columns.Add("Reference", "Referencia");
            dt_sales.Columns.Add("Address", "Dirección");
            dt_sales.Columns.Add("PaymentTypeName", "Tipo de Pago");
            dt_sales.Columns.Add("Observation", "Observación");
            dt_sales.Columns.Add("Channel", "Canal");
            dt_sales.Columns.Add("PaymentConditionName", "Condición de Pago");
            dt_sales.Columns.Add("Total", "Total");
            dt_sales.Columns.Add("CashPayment", "Pago en Efectivo");
            dt_sales.Columns.Add("CreditPayment", "Pago a Crédito");
            dt_sales.Columns.Add("CreditDays", "Días de Crédito");
            dt_sales.Columns.Add("UserName", "Vendedor");
            loadSales();
        }


        private void loadSales()
        {
            //limpiar las ventas
            dt_sales.Rows.Clear();

            //cargar las ventas
            var saleRepository = new SaleRepository();
            var sales = saleRepository.GetAllSales();

            foreach (var sale in sales)
            {
                dt_sales.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address, sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total, sale.CashPayment, sale.CreditPayment,sale.CreditDays, sale.UserName);
            }

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
                var sale = new Sale();
                sale.Id = (int)dt_sales.CurrentRow.Cells[0].Value;  

                var saleRepository = new SaleRepository();
                saleRepository.DeleteSale(sale.Id);
                loadSales();
            }


        }

    }
}