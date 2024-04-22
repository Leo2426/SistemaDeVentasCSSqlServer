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

        public VentasForm()
        {
            InitializeComponent();
        }

        private async void VentasForm2_Load(object sender, EventArgs e)
        {
            //anadir columnas si no hay
            if (dt_sales.Columns.Count == 0)
            {

                //renombrar columnas
                dt_sales.Columns.Add("Id", "Id");
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
                dt_sales.Columns.Add("CashPayment", "Pago Efectivo");
                dt_sales.Columns.Add("CreditPayment", "Pago Crédito");
                dt_sales.Columns.Add("CreditDays", "Días Crédito");
                dt_sales.Columns.Add("UserName", "Usuario");
                dt_sales.Columns.Add("District", "Distrito");
                dt_sales.Columns.Add("Profit", "Ganancia");


                //cargar el cb_columns con los nombres de las columnas del datagrid
                foreach (DataGridViewColumn column in dt_sales.Columns)
                {
                    cb_columns.Items.Add(column.HeaderText);
                }
                //ocultar id del cb_columns
                cb_columns.Items.RemoveAt(0);

                //seleccionar por defecto nombre
                cb_columns.SelectedIndex = 1;

                await loadSales();
            }
        }


        private async Task loadSales()
        {
            //limpiar datagrid
            dt_sales.Rows.Clear();
            var saleRepository = new SaleRepository();
            sales = await saleRepository.GetAllSalesAsync(); // Asegúrate de que este método sea asíncrono

            //anadir las ventas al datagrid
            foreach (var sale in sales)
            {
                 //anadir todos los campos de sale
                 dt_sales.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address, sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total, sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);
      
            }

            dt_sales.Columns["District"].Visible = false;
        }

        public void FilterSales(string filterColumn, string filterValue)
        {
            var filteredList = sales.Where(sale =>
                sale.GetType().GetProperty(filterColumn)?.GetValue(sale, null)?.ToString().IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            UpdateDataGridView(filteredList);

        }

        private void UpdateDataGridView(List<Sale> filteredClients)
        {
            dt_sales.Rows.Clear();
            foreach (var sale in filteredClients)
            {
                dt_sales.Rows.Add(sale.Id, sale.SaleType, sale.ClientName, sale.Date, sale.Phone, sale.Reference, sale.Address, sale.PaymentTypeName, sale.Observation, sale.Channel, sale.PaymentConditionName, sale.Total, sale.CashPayment, sale.CreditPayment, sale.CreditDays, sale.UserName, sale.District, sale.Profit);
            }
        }
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                string selectedColumn= "";

                if (cb_columns.SelectedItem.ToString() == "Tipo de Venta")
                        selectedColumn = "SaleType";
                else if (cb_columns.SelectedItem.ToString() == "Cliente")
                    selectedColumn = "ClientName";
                else if (cb_columns.SelectedItem.ToString() == "Fecha")
                    selectedColumn = "Date";
                else if (cb_columns.SelectedItem.ToString() == "Teléfono")
                    selectedColumn = "Phone";
                else if (cb_columns.SelectedItem.ToString() == "Referencia")
                    selectedColumn = "Reference";
                else if (cb_columns.SelectedItem.ToString() == "Dirección")
                    selectedColumn = "Address";
                else if (cb_columns.SelectedItem.ToString() == "Tipo de Pago")
                    selectedColumn = "PaymentTypeName";
                else if (cb_columns.SelectedItem.ToString() == "Observación")
                    selectedColumn = "Observation";
                else if (cb_columns.SelectedItem.ToString() == "Canal")
                    selectedColumn = "Channel";
                else if (cb_columns.SelectedItem.ToString() == "Condición de Pago")
                    selectedColumn = "PaymentConditionName";
                else if (cb_columns.SelectedItem.ToString() == "Total")
                    selectedColumn = "Total";
                else if (cb_columns.SelectedItem.ToString() == "Pago Efectivo")
                    selectedColumn = "CashPayment";
                else if (cb_columns.SelectedItem.ToString() == "Pago Crédito")
                    selectedColumn = "CreditPayment";
                else if (cb_columns.SelectedItem.ToString() == "Días Crédito")
                    selectedColumn = "CreditDays";
                else if (cb_columns.SelectedItem.ToString() == "Usuario")
                    selectedColumn = "UserName";
                else if (cb_columns.SelectedItem.ToString() == "Distrito")
                    selectedColumn = "District";
                else if (cb_columns.SelectedItem.ToString() == "Ganancia")
                    selectedColumn = "Profit";


                FilterSales(selectedColumn, txt_search.Text);
                e.Handled = true;
            }
        }




        private async void btn_add_Click(object sender, EventArgs e)
        {
            var addSaleForm = new AddSaleForm();
            addSaleForm.ShowDialog();
            await loadSales();
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

        private async void btn_delete_Click(object sender, EventArgs e)
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
                sale.Id = Convert.ToInt32(dt_sales.CurrentRow.Cells["Id"].Value);


                        

                var saleRepository = new SaleRepository();
                await saleRepository.DeleteSaleAsync(sale.Id);
                await loadSales();
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
                var sale = new Sale();
                sale.Id = Convert.ToInt32(dt_sales.CurrentRow.Cells["Id"].Value);
                sale.SaleType = dt_sales.CurrentRow.Cells["SaleType"].Value.ToString();
                sale.ClientName = dt_sales.CurrentRow.Cells["ClientName"].Value.ToString();
                sale.Date = Convert.ToDateTime(dt_sales.CurrentRow.Cells["Date"].Value);
                sale.Phone = dt_sales.CurrentRow.Cells["Phone"].Value.ToString();
                sale.Reference = dt_sales.CurrentRow.Cells["Reference"].Value.ToString();
                sale.Address = dt_sales.CurrentRow.Cells["Address"].Value.ToString();
                sale.PaymentTypeName = dt_sales.CurrentRow.Cells["PaymentTypeName"].Value.ToString();
                sale.Observation = dt_sales.CurrentRow.Cells["Observation"].Value.ToString();
                sale.Channel = dt_sales.CurrentRow.Cells["Channel"].Value.ToString();
                sale.PaymentConditionName = dt_sales.CurrentRow.Cells["PaymentConditionName"].Value.ToString();
                sale.Total = Convert.ToDecimal(dt_sales.CurrentRow.Cells["Total"].Value);
                sale.CashPayment = Convert.ToDecimal(dt_sales.CurrentRow.Cells["CashPayment"].Value);
                sale.CreditPayment = Convert.ToDecimal(dt_sales.CurrentRow.Cells["CreditPayment"].Value);
                sale.CreditDays = Convert.ToInt32(dt_sales.CurrentRow.Cells["CreditDays"].Value);
                sale.UserName = dt_sales.CurrentRow.Cells["UserName"].Value.ToString();
                sale.Profit = Convert.ToDecimal(dt_sales.CurrentRow.Cells["Profit"].Value);

                var productSaledRepository = new SaleRepository();
                var productsSaled = productSaledRepository.getAllProductsWithSaleId(sale.Id);

                var saleTicket = new Ticket80mm(sale, productsSaled);
                saleTicket.CreateTicket80mm();
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //reset el filtro
            FilterSales("ClientName", "");
            txt_search.Text = "";
        }

    }
}