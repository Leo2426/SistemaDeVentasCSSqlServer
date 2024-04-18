using FontAwesome.Sharp;
using SistemaDeVentas.Clientes;
using SistemaDeVentas.Configuration;
using SistemaDeVentas.Home;
using SistemaDeVentas.Productos;
using SistemaDeVentas.Ventas;
using SistemaDeVentas.Ventas.Delivery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Shared
{
    public partial class PrincipalForm : Form
    {
        private IconButton currentButton;
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            lbl_user.Text = GlobalClass.Username;
            lbl_heading.Text = "Home";
            //dar click al boton home
            btn_home.PerformClick();

            //desabilitar boton configuracion si no eres admin
            if (GlobalClass.Username != "admin")
            {
                //bloquear iconbutton5
                iconButton5.Enabled = false;
                iconButton5.ForeColor = Color.Gray;
            }

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            if (currentButton.Text == "Home")
            
                configForm(new HomeForm());
            
            else if (currentButton.Text == "Ventas")
            
                configForm(new VentasForm());
            
            else if (currentButton.Text == "Productos")
            
                configForm(new ProductosForm());
            
            else if (currentButton.Text == "Clientes")
           
                configForm(new ClientsForm());

            else if (currentButton.Text == "Config")

                configForm(new ConfigurationForm());

            else if (currentButton.Text == "Delivery")

                configForm(new ShowDeliveryForm());
            else
            
                MessageBox.Show("No se ha encontrado el formulario");
            


        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (IconButton)sender)
                {
                    lbl_heading.Text = ((IconButton)sender).Text;
                    DisableButton();
                    currentButton = (IconButton)sender;
                    currentButton.BackColor = Color.Teal;

                }
            }

        }


        #region Botones
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 64, 64);
                }
            }
        }

        #endregion


        private void configForm(Form form)
        {
            form.TopLevel = false;
            principal_panel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.BringToFront();


            form.Show();

        }

    } 
}
