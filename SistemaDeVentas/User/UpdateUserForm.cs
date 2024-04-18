using SistemaDeVentas.Login;
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
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            //validar que los campos no esten vacios
            if (cb_user.Text == "" || txt_password.Text == "" || txt_confirm_password.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           
            //validar que las contraseñas sean iguales
            if (txt_password.Text != txt_confirm_password.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_password.Text = "";
                txt_confirm_password.Text = "";
                txt_password.Focus();
                return;
            }

            //obtener el usuario seleccionado
            var user = (User)cb_user.SelectedItem;
            user.Password = txt_password.Text;
            user.Rol = cb_rol.Text;

            //actualizar el usuario
            var userRepository = new UserRepository();
            userRepository.updateUser(user);

            MessageBox.Show("Usuario actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();



        }

        private void txt_confirm_password_Leave(object sender, EventArgs e)
        {
            //si no esta vacio continuar
            if (txt_password.Text == "" || txt_confirm_password.Text == "")
            {
                return;
            }


            //si no es igual a la contraseña mostrar mensaje
            if (txt_password.Text != txt_confirm_password.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_password.Text = "";
                txt_confirm_password.Text = "";
                txt_password.Focus();
            }
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            
            //cargar usuarios en el combobox
            var userRepository = new UserRepository();
            var users = userRepository.getAllUsers();
            cb_user.DataSource = users;
            cb_user.DisplayMember = "Name";
            cb_user.ValueMember = "Id";
            cb_user.SelectedIndex = 0;

            
            //cargar los roles
            var rolRepository = new RolRepository();
            var rols = rolRepository.getRols();

            //llenar el combobox
            cb_rol.DataSource = rols;
            cb_rol.DisplayMember = "Name";
            cb_rol.ValueMember = "Id";

            //seleccionar el rol del usuario
            var user = (User)cb_user.SelectedItem;
            cb_rol.Text = user.Rol;


        }

        private void cb_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = (User)cb_user.SelectedItem;
            cb_rol.Text = user.Rol;
        }
    }
}
