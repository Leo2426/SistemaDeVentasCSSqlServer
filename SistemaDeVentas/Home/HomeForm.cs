using SistemaDeVentas.Print;
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
            loadChart();

            //cargar las ventas totales en el label
            loadTotalSales();
        }

        private void loadChart()
        {
             

        }

        private void loadTotalSales()
        {
            var saleRepository = new SaleRepository();
            var sales = saleRepository.GetAllSales();
            var totalSales = sales.Sum(s => s.Total);
            lbl_total_sales.Text = totalSales.ToString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //colocar en el label el valor de la fecha seleccionada
            lbl_date.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");

            //cargar las ventas de la fecha seleccionada
            loadSalesByDate();
        }

        private void loadSalesByDate()
        {
            var saleRepository = new SaleRepository();
            var sales = saleRepository.getSalesbyDate(monthCalendar1.SelectionStart.Day.ToString(),monthCalendar1.SelectionStart.Month.ToString(), monthCalendar1.SelectionStart.Year.ToString());
            dt_sales.DataSource = sales;
        }
    }
}
