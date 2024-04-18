using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Configuration
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void btn_add_size_Click(object sender, EventArgs e)
        {
            //lanzar form para agregar talla
            var addSizeForm = new AddSizeForm();
            addSizeForm.ShowDialog();
        }

        private void btn_delete_size_Click(object sender, EventArgs e)
        {
            //lanzar form para eliminar talla
            var deleteSizeForm = new DeleteSizeForm();
            deleteSizeForm.ShowDialog();
        }

    }
}
