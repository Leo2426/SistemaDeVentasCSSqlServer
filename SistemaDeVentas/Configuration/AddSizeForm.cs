using SistemaDeVentas.Clientes;
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
    public partial class AddSizeForm : Form
    {
        public AddSizeForm()
        {
            InitializeComponent();
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            SizeRepository sizeRepository = new SizeRepository();

            //validar que este elemento no este vacio
            if (txt_name.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío");
                return;
            }

            //validar que la talla no exista previamente en la base de datos
            foreach (Productos.Size sizeT in sizeRepository.GetAllSizes())
            {
                if (sizeT.SizeName == txt_name.Text)
                {
                    MessageBox.Show("La talla ya existe");
                    return;
                }
            }

            //agregar talla
            Productos.Size size = new Productos.Size(txt_name.Text);

            sizeRepository.AddSize(size);

            this.Close();
        }
    }
}
