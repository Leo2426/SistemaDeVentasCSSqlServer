using SistemaDeVentas.Clientes;
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
        List<Sale> sales;

        DataTable salesTable = new DataTable();
        DataTable tabletemp = new DataTable();

        public VentasForm()
        {
            InitializeComponent();
        }

        private async void VentasForm2_Load(object sender, EventArgs e)
        {
            SetupDataTable();
            SetupDataTableTemp();
            await LoadSalesAsync();

            cb_columns.DataSource = salesTable.Columns.Cast<DataColumn>()
                                    .Where(c => c.ColumnName != "Id") // Excluir la columna de ID
                                    .Select(c => c.ColumnName).ToList();
            cb_columns.SelectedIndex = 2;
        }

        private void SetupDataTableTemp()
        {
            tabletemp.Columns.Add("Id", typeof(int));
            tabletemp.Columns.Add("Tipo de Venta", typeof(string));
            tabletemp.Columns.Add("Cliente", typeof(string));
            tabletemp.Columns.Add("Fecha", typeof(DateTime));
            tabletemp.Columns.Add("Teléfono", typeof(string));
            tabletemp.Columns.Add("Referencia", typeof(string));
            tabletemp.Columns.Add("Dirección", typeof(string));
            tabletemp.Columns.Add("Tipo de Pago", typeof(string));
            tabletemp.Columns.Add("Observación", typeof(string));
            tabletemp.Columns.Add("Canal", typeof(string));
            tabletemp.Columns.Add("Condición de Pago", typeof(string));
            tabletemp.Columns.Add("Total", typeof(decimal));
            tabletemp.Columns.Add("Pago Efectivo", typeof(decimal));
            tabletemp.Columns.Add("Pago Crédito", typeof(decimal));
            tabletemp.Columns.Add("Días Crédito", typeof(int));
            tabletemp.Columns.Add("Usuario", typeof(string));
            tabletemp.Columns.Add("Distrito", typeof(string));
            tabletemp.Columns.Add("Ganancia", typeof(decimal));

        }

        private void SetupDataTable()
        {
            salesTable.Columns.Add("Id", typeof(int));
            salesTable.Columns.Add("Tipo de Venta", typeof(string));
            salesTable.Columns.Add("Cliente", typeof(string));
            salesTable.Columns.Add("Fecha", typeof(DateTime));
            salesTable.Columns.Add("Teléfono", typeof(string));
            salesTable.Columns.Add("Referencia", typeof(string));
            salesTable.Columns.Add("Dirección", typeof(string));
            salesTable.Columns.Add("Tipo de Pago", typeof(string));
            salesTable.Columns.Add("Observación", typeof(string));
            salesTable.Columns.Add("Canal", typeof(string));
            salesTable.Columns.Add("Condición de Pago", typeof(string));
            salesTable.Columns.Add("Total", typeof(decimal));
            salesTable.Columns.Add("Pago Efectivo", typeof(decimal));
            salesTable.Columns.Add("Pago Crédito", typeof(decimal));
            salesTable.Columns.Add("Días Crédito", typeof(int));
            salesTable.Columns.Add("Usuario", typeof(string));
            salesTable.Columns.Add("Distrito", typeof(string));
            salesTable.Columns.Add("Ganancia", typeof(decimal));
        }

        private async Task LoadSalesAsync()
        {
            var saleRepository = new SaleRepository();
            sales = await saleRepository.GetAllSalesAsync();

            salesTable.Rows.Clear();
            foreach (var sale in sales)
            {
                salesTable.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address,
                    sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total,
                    sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);
            }

            dt_sales.DataSource = salesTable;

            //renombrar id por correlativo
            dt_sales.Columns["Id"].HeaderText = "Correlativo";
        }


        private void FilterSales(string filterColumn, string filterValue)
        {
            var filteredList = sales.Where(sale =>
                sale.GetType().GetProperty(filterColumn)?.GetValue(sale, null)?.ToString().IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            UpdateDataGridView(filteredList);
        }

        private void UpdateDataGridView(List<Sale> filteredSales)
        {
            salesTable.Rows.Clear();
            foreach (var sale in filteredSales)
            {
                salesTable.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address,
                    sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total,
                    sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);
            }
        }



        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string selectedColumn = cb_columns.Text;
                FilterSales(selectedColumn, txt_search.Text);
                e.Handled = true;
            }
        }



        private async void btn_add_Click(object sender, EventArgs e)
        {
            var addSaleForm = new AddSaleForm();
            //suscribirse al evento
            addSaleForm.SaleAdded += handlerSaleAdded;

            addSaleForm.ShowDialog();


        }

        private void handlerSaleAdded(Sale sale)
        {
            //agregar la venta a la tabla
            salesTable.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address,
                               sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total,
                                              sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);

            //agregar la venta a la lista
            sales.Add(sale);

            //agregar la venta a la tabla temporal
            tabletemp.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address,
                                              sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total,
                                                                                           sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);

            //actualizar la tabla
            dt_sales.Refresh();
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
            var sale = new Sale();
            sale.Id = Convert.ToInt32(dt_sales.CurrentRow.Cells["Id"].Value);

            var productsWithSalesForm = new ProductsWithSalesForm(sale);
            productsWithSalesForm.ShowDialog();

        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (dt_sales.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta para eliminar");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de eliminar la venta?", "Eliminar Venta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int saleId = Convert.ToInt32(dt_sales.CurrentRow.Cells["Id"].Value);
                var saleRepository = new SaleRepository();
                await saleRepository.DeleteSaleAsync(saleId);
                await LoadSalesAsync();  // Reload data after deleting
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (dt_sales.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta para imprimir");
                return;
            }

            var sale = new Sale();
            sale.Id = Convert.ToInt32(dt_sales.CurrentRow.Cells["Id"].Value);
            sale.Date = Convert.ToDateTime(dt_sales.CurrentRow.Cells["Fecha"].Value);
            sale.ClientName = dt_sales.CurrentRow.Cells["Cliente"].Value.ToString();
            sale.Address = dt_sales.CurrentRow.Cells["Dirección"].Value.ToString();
            sale.Phone = dt_sales.CurrentRow.Cells["Teléfono"].Value.ToString();
            sale.Reference = dt_sales.CurrentRow.Cells["Referencia"].Value.ToString();
            sale.PaymentTypeName = dt_sales.CurrentRow.Cells["Tipo de Pago"].Value.ToString();
            sale.Observation = dt_sales.CurrentRow.Cells["Observación"].Value.ToString();
            sale.Channel = dt_sales.CurrentRow.Cells["Canal"].Value.ToString();
            sale.PaymentConditionName = dt_sales.CurrentRow.Cells["Condición de Pago"].Value.ToString();
            sale.Total = Convert.ToDecimal(dt_sales.CurrentRow.Cells["Total"].Value);
            sale.CashPayment = Convert.ToDecimal(dt_sales.CurrentRow.Cells["Pago Efectivo"].Value);
            sale.CreditPayment = Convert.ToDecimal(dt_sales.CurrentRow.Cells["Pago Crédito"].Value);
            sale.CreditDays = Convert.ToInt32(dt_sales.CurrentRow.Cells["Días Crédito"].Value);
            sale.UserName = dt_sales.CurrentRow.Cells["Usuario"].Value.ToString();
            sale.District = dt_sales.CurrentRow.Cells["Distrito"].Value.ToString();
            sale.Profit = Convert.ToDecimal(dt_sales.CurrentRow.Cells["Ganancia"].Value);

            var saleRepository = new SaleRepository();
            var saleDetails = saleRepository.getAllProductsWithSaleId(sale.Id);

            var saleTicket = new Ticket80mm(sale, saleDetails);
            saleTicket.CreateTicket80mm();

            MessageBox.Show("Venta impresa correctamente.");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dt_sales.DataSource = salesTable;
        }

    }
}