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
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var addSaleForm = new AddSaleForm();
            addSaleForm.ShowDialog();
            loadSales();
        }
    }
}
