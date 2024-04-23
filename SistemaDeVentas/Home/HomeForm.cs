using SistemaDeVentas.Print;
using SistemaDeVentas.Shared;
using SistemaDeVentas.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace SistemaDeVentas.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //cargar el chart con las ventas
            loadDataGrid();

            //valor por defect de dt_end sea 1 dia mas
            dt_end.Value = dt_end.Value.AddDays(1);

            //si el usuario actual no es administrador ocultar el lbl_profit y lbl_total_sales
            if (GlobalClass.ActualUser.Rol != "ADMINISTRADOR")
            {
                lbl_profit.Visible = false;
                lbl_total_sales.Visible = false;
            }


        }

        private void loadDataGrid()
        {
             //Cargar el chart con las ventas con los rangos de fecha
             var saleRepository = new SaleRepository();

            //obtener fecha de incio de dt_start
            var start = dt_start.Value;
            var end = dt_end.Value;

            //obtener las ventas por fecha
            var sales = saleRepository.GetSalesBetweenDates(start, end);


            //cargar el datagridview
            dt_sales.DataSource = sales;

            //ocultar columnas
            dt_sales.Columns["SaleType"].Visible = false;
            dt_sales.Columns["Phone"].Visible = false;
            dt_sales.Columns["Reference"].Visible = false;
            dt_sales.Columns["Address"].Visible = false;
            dt_sales.Columns["Observation"].Visible = false;
            dt_sales.Columns["CashPayment"].Visible = false;
            dt_sales.Columns["CreditPayment"].Visible = false;
            dt_sales.Columns["CreditDays"].Visible = false;
            dt_sales.Columns["UserName"].Visible = false;
            dt_sales.Columns["Channel"].Visible = false;
            dt_sales.Columns["District"].Visible = false;

            //renombrar columnas
            dt_sales.Columns["Id"].HeaderText = "Correlativo";
            dt_sales.Columns["ClientName"].HeaderText = "Cliente";
            dt_sales.Columns["Date"].HeaderText = "Fecha";
            dt_sales.Columns["PaymentTypeName"].HeaderText = "Tipo de pago";
            dt_sales.Columns["PaymentConditionName"].HeaderText = "Condición de pago";
            dt_sales.Columns["Total"].HeaderText = "Total";
            dt_sales.Columns["Profit"].HeaderText = "Ganancia";

            //reordenar columnas
            dt_sales.Columns["Id"].DisplayIndex = 0;


        }



        private void dt_start_ValueChanged(object sender, EventArgs e)
        {
            loadDataGrid();

            //sumar todos los totales y mostrarlo en el lbl_total_sales
            var total = dt_sales.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Total"].Value));
            lbl_total_sales.Text = "Total de ventas: " + GlobalClass.SymbolCurrency + total.ToString();

            //sumar todas las ganancias y mostrarlo en el lbl_total_profit
            var totalProfit = dt_sales.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Profit"].Value));
            lbl_profit.Text = "Ganancia Total: " + GlobalClass.SymbolCurrency + totalProfit.ToString();
        }
    }
}
