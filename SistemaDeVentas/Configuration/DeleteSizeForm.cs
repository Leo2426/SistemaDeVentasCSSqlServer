using SistemaDeVentas.Productos;
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
    public partial class DeleteSizeForm : Form
    {
        public DeleteSizeForm()
        {
            InitializeComponent();
        }

        private void UpdateSizeForm_Load(object sender, EventArgs e)
        {
            //cargar sizes
            LoadSizes();
        }

        private void LoadSizes()
        {
            var sizeRepository = new SizeRepository();
            var sizes = sizeRepository.GetAllSizes();
            cb_sizes.DataSource = sizes;
            cb_sizes.DisplayMember = "SizeName";
            cb_sizes.ValueMember = "Id";
            cb_sizes.SelectedIndex = 0;
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            //no puedes borrar (en blanco)
            if (cb_sizes.Text == "(en blanco)")
            {
                MessageBox.Show("No puedes borrar (en blanco) porque es el valor por defecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //seleccionar la talla
            var size = (Productos.Size)cb_sizes.SelectedItem;

            //Comprobar si la talla tiene
            if (SizeRepository.sizeHasProduct(size.Id))
            {
                MessageBox.Show("No se puede eliminar la porque tiene productos asociadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //borrar talla seleccionada en el combobox
            if (size == null)
            {
                MessageBox.Show("La talla no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var sizeRepository = new SizeRepository();
            sizeRepository.DeleteSize(size.Id);
            this.Close();
        }
    }
}
