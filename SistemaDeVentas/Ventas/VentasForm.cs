using PagedList;
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

        int pageNumber = 1;
        IPagedList<Sale> list;
        



        public VentasForm()
        {
            InitializeComponent();
        }


        private async void VentasForm2_Load(object sender, EventArgs e)
        {

            setUpPaginator();



            //cb_columns.DataSource = salesTable.Columns.Cast<DataColumn>()
            //                        .Where(c => c.ColumnName != "Id") // Excluir la columna de ID
            //                        .Select(c => c.ColumnName).ToList();
            //cb_columns.SelectedIndex = 2;
        }

        private async Task<IPagedList<Sale>> GetPagedListAsync(int pageNumber = 1, int pageSize = 35, string filterColumn = null, string filterValue = null)
        {
            var saleRepository = new SaleRepository();
            return await saleRepository.GetSalesPagedAsync(pageNumber, pageSize, filterColumn, filterValue);
        }

        private async Task setUpPaginator(string filterColumn = null, string filterValue = null)
        {
            list = await GetPagedListAsync(pageNumber, 35, filterColumn, filterValue);
            btn_previous_page.Enabled = list.HasPreviousPage;
            btn_next_page.Enabled = list.HasNextPage;

            dt_sales.DataSource = list.ToList();
            lbl_page.Text = $"Página {pageNumber} de {list.PageCount}";
        }


        private async Task LoadSalesAsync()
        {
            //var saleRepository = new SaleRepository();
            //sales = await saleRepository.GetAllSalesAsync();

            //salesTable.Rows.Clear();
            //foreach (var sale in sales)
            //{
            //    salesTable.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address,
            //        sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total,
            //        sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);
            //}

            //dt_sales.DataSource = salesTable;

            ////renombrar id por correlativo
            //dt_sales.Columns["Id"].HeaderText = "Correlativo";
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
            //salesTable.Rows.Clear();
            //foreach (var sale in filteredSales)
            //{
            //    salesTable.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address,
            //        sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total,
            //        sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);
            //}
        }



        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_search_Click(sender, e);
                e.Handled = true;
            }
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            var addSaleForm = new AddSaleForm();
            //suscribirse al evento
            addSaleForm.SaleAdded += handlerSaleAdded;

            addSaleForm.ShowDialog();


        }

        private void handlerSaleAdded(Sale sale)
        {
            ////agregar la venta a la tabla
            //salesTable.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address,
            //                   sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total,
            //                                  sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);

            ////agregar la venta a la lista
            //sales.Add(sale);

            ////agregar la venta a la tabla temporal
            //tabletemp.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address,
            //                                  sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total,
            //                                                                               sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);

            ////actualizar la tabla
            //dt_sales.Refresh();
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
            //dt_sales.DataSource = salesTable;
        }

        private void  btn_export_Click(object sender, EventArgs e)
        {

            DataGridView dataGrid = dt_sales;


            if (dataGrid.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        MExcel.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_previous_page_Click(object sender, EventArgs e)
        {
            if(list.HasPreviousPage)
            {
                list = await GetPagedListAsync(--pageNumber);
                btn_previous_page.Enabled = list.HasPreviousPage;
                btn_next_page.Enabled = list.HasNextPage;
                dt_sales.DataSource = list.ToList();
                lbl_page.Text = $"Página {pageNumber} de {list.PageCount}";
            }


        }

        private async void btn_next_page_Click(object sender, EventArgs e)
        {
            if(list.HasNextPage)
            {
                list = await GetPagedListAsync(++pageNumber);
                btn_previous_page.Enabled = list.HasPreviousPage;
                btn_next_page.Enabled = list.HasNextPage;
                dt_sales.DataSource = list.ToList();
                lbl_page.Text = $"Página {pageNumber} de {list.PageCount}";
            }
        }

    }
}