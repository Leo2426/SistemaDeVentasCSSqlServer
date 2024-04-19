using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            //lanzar form para agregar usuario
            var userForm = new User.AddUserForm();
            userForm.ShowDialog();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //cargar form para eliminar usuario
            var deleteUserForm = new User.DeleteUserForm();
            deleteUserForm.ShowDialog();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //lanzar form para actualizar usuario
            var updateUserForm = new User.UpdateUserForm();
            updateUserForm.ShowDialog();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            loadPrinters();
        }

        private void loadPrinters()
        {
            //cargar las impresoras a los combobox
            foreach( var printer in PrinterSettings.InstalledPrinters)
            {
                cb_printer_delivery.Items.Add(printer);
                cb_printer_ticket.Items.Add(printer);
            }

            //cargar el valor de la impresora por el app.config
            cb_printer_delivery.SelectedItem = ConfigurationManager.AppSettings["printerDelivery"];
            cb_printer_ticket.SelectedItem = ConfigurationManager.AppSettings["printerTicket"]; 

        }


        public void UpdateAppSetting(string key, string value)
        {
            // Cargar el archivo de configuración
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Modificar el valor
            config.AppSettings.Settings[key].Value = value;

            // Guardar los cambios
            config.Save(ConfigurationSaveMode.Modified);

            // Actualizar la sección de configuraciones de la aplicación
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btn_save_printer_ticket_Click(object sender, EventArgs e)
        {
            //guardar la impresora de ticket en el app.config
            UpdateAppSetting("printerTicket", cb_printer_ticket.SelectedItem.ToString());

            //mostrar mensaje de que se guardo correctamente
            MessageBox.Show("Impresora de ticket guardada correctamente");

        }

        private void btn_save_printer_delivery_Click(object sender, EventArgs e)
        {
            //guardar la impresora de delivery en el app.config
            UpdateAppSetting("printerDelivery", cb_printer_delivery.SelectedItem.ToString());

            //mostrar mensaje de que se guardo correctamente
            MessageBox.Show("Impresora de delivery guardada correctamente");
        }
    }
}
