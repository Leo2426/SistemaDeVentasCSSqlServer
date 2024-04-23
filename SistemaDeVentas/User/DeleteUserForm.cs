using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.User
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {
            //cargar los usuarios
            var userRepository = new UserRepository();
            var users = userRepository.getAllUsers();

            //llenar el combobox
            cb_user.DataSource = users;
            cb_user.DisplayMember = "name";
            cb_user.ValueMember = "Id";



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //validar que se haya seleccionado un usuario
            if (cb_user.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }

            //validar que el usuario no sea admin
            if (cb_user.Text == "admin")
            {
                MessageBox.Show("No se puede eliminar el usuario admin");
                return;
            }


            //eliminar el usuario
            var userRepository = new UserRepository();

            //validar que el usuario no tenga ventas
            if (userRepository.userHasSales(Convert.ToInt32(cb_user.SelectedValue)))
            {
                MessageBox.Show("No se puede eliminar el usuario porque tiene ventas registradas");
                return;
            }

            userRepository.deleteUser(Convert.ToInt32(cb_user.SelectedValue));

            MessageBox.Show("Usuario eliminado correctamente");

            this.Close();
        }
    }
}
