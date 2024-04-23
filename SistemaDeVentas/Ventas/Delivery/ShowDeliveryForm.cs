using SistemaDeVentas.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Ventas.Delivery
{
    public partial class ShowDeliveryForm : Form
    {
        List<Delivery> deliveries = new List<Delivery>();
        DataTable deliberiestable = new DataTable();
        DataTable tabletemp = new DataTable();


        public ShowDeliveryForm()
        {
            InitializeComponent();
        }

        private void ShowDeliveryForm_Load(object sender, EventArgs e)
        {
            //cargar todos los deliverys

            var deliveryRepository = new DeliveryRepository();
            deliveries = deliveryRepository.GetAllDeliveries();

            setupTable();
            setupTempTable();

            //agregar columnas cb_columns con los nombres de las columnas
            cb_columns.Items.Add("Correlativo");
            cb_columns.Items.Add("Cliente");
            cb_columns.Items.Add("Fecha");
            cb_columns.Items.Add("Dirección");
            cb_columns.Items.Add("Referencia");
            cb_columns.Items.Add("Instrucciones");
            cb_columns.Items.Add("C.de Pago");
            cb_columns.Items.Add("Teléfono");
            cb_columns.Items.Add("Monto");
            cb_columns.Items.Add("Saldo a cobrar");

            //seleccionar por defecto la primera columna
            cb_columns.SelectedIndex = 1;


            loadDataGrid();

        }


        private void FilterSales(string filterColumn, string filterValue)
        {
            var filteredList = deliveries.Where(sale =>
                sale.GetType().GetProperty(filterColumn)?.GetValue(sale, null)?.ToString().IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            UpdateDataGridView(filteredList);
        }

        private void UpdateDataGridView(List<Delivery> filteredDelivery)
        {
            tabletemp.Rows.Clear();
            foreach (var delivery in filteredDelivery)
            {
                tabletemp.Rows.Add(delivery.SaleId, delivery.ClientName, delivery.Date, delivery.Address, delivery.Reference, delivery.Instructions, delivery.PaymentCondition, delivery.Phone, delivery.Amount, delivery.Amount_due);
            }

            dt_deliverys.DataSource = tabletemp;
        }



        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string selectedColumn;

                switch (selectedColumn = cb_columns.Text)
                {
                    case "Correlativo":
                        selectedColumn = "SaleId";
                        break;
                    case "Cliente":
                        selectedColumn = "ClientName";
                        break;
                    case "Fecha":
                        selectedColumn = "Date";
                        break;
                    case "Dirección":
                        selectedColumn = "Address";
                        break;
                    case "Referencia":
                        selectedColumn = "Reference";
                        break;
                    case "Instrucciones":
                        selectedColumn = "Instructions";
                        break;
                    case "C.de Pago":
                        selectedColumn = "PaymentCondition";
                        break;
                    case "Teléfono":
                        selectedColumn = "Phone";
                        break;
                    case "Monto":
                        selectedColumn = "Amount";
                        break;
                    case "Saldo a cobrar":
                        selectedColumn = "Amount_due";
                        break;
                    default:
                        selectedColumn = "ClientName";
                        break;
                }




                FilterSales(selectedColumn, txt_search.Text);
                e.Handled = true;
            }
        }


        private void loadDataGrid()
        {
            //limpiar la tabla
            deliberiestable.Clear();

            foreach (var delivery in deliveries)
            {
                deliberiestable.Rows.Add(delivery.SaleId, delivery.ClientName, delivery.Date, delivery.Address, delivery.Reference, delivery.Instructions, delivery.PaymentCondition, delivery.Phone, delivery.Amount, delivery.Amount_due);
            }

            dt_deliverys.DataSource = deliberiestable;
        }

        private void setupTempTable()
        {
            tabletemp.Columns.Add("Correlativo");
            tabletemp.Columns.Add( "Cliente");
            tabletemp.Columns.Add("Fecha");
            tabletemp.Columns.Add("Dirección");
            tabletemp.Columns.Add("Referencia");
            tabletemp.Columns.Add( "Instrucciones");
            tabletemp.Columns.Add( "C.de Pago");
            tabletemp.Columns.Add( "Teléfono");
            tabletemp.Columns.Add( "Monto");
            tabletemp.Columns.Add("Saldo a cobrar");
        }

        private void setupTable()
        {
            deliberiestable.Columns.Add("Correlativo");
            deliberiestable.Columns.Add("Cliente");
            deliberiestable.Columns.Add("Fecha");
            deliberiestable.Columns.Add("Dirección");
            deliberiestable.Columns.Add("Referencia");
            deliberiestable.Columns.Add("Instrucciones");
            deliberiestable.Columns.Add("C.de Pago");
            deliberiestable.Columns.Add("Teléfono");
            deliberiestable.Columns.Add("Monto");
            deliberiestable.Columns.Add("Saldo a cobrar");
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //validar que se haya seleccionado un delivery
            if (dt_deliverys.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un delivery");
                return;
            }



            try
            {
                //preguntar si esta seguro de imprimir el delivey
                var result = MessageBox.Show("¿Está seguro de imprimir el delivery?", "Imprimir delivery", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //obtener el delivery seleccionado
                    var selectedRow = dt_deliverys.CurrentRow;
                    var delivery = new Delivery();
                    delivery.ClientName = selectedRow.Cells["ClientName"].Value.ToString();
                    delivery.Date = selectedRow.Cells["Date"].Value.ToString();
                    delivery.Address = selectedRow.Cells["Address"].Value.ToString();
                    delivery.Reference = selectedRow.Cells["Reference"].Value.ToString();
                    delivery.Instructions = selectedRow.Cells["Instructions"].Value.ToString();
                    delivery.PaymentCondition = selectedRow.Cells["PaymentCondition"].Value.ToString();
                    delivery.Phone = selectedRow.Cells["Phone"].Value.ToString();
                    delivery.Amount = decimal.Parse(selectedRow.Cells["Amount"].Value.ToString());
                    delivery.Amount_due = decimal.Parse(selectedRow.Cells["Amount_due"].Value.ToString());
                    delivery.SaleId = int.Parse(selectedRow.Cells["SaleId"].Value.ToString());

                    //obtener los productos del delivery
                    var productSaledRepository = new SaleRepository();
                    var products = productSaledRepository.getAllProductsWithSaleId(delivery.SaleId);
                    delivery.products = products;

                    //imprimir el delivery
                    var ticketDelivery = new TicketDelivery(delivery);
                    ticketDelivery.createTicketDelivery();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir el delivery: " + ex.Message);
            }
        
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dt_deliverys.DataSource = deliberiestable;
        }
    }
}