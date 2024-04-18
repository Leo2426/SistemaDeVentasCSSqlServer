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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            //cargar los rols
            var rolRepository = new RolRepository();
            var rols = rolRepository.getRols();

            //llenar el combobox
            cb_rol.DataSource = rols;
            cb_rol.DisplayMember = "Name";
            cb_rol.ValueMember = "Id";
            cb_rol.SelectedIndex = 1;
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

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            //validar que los campos no esten vacios
            if (txt_name.Text == "" || txt_password.Text == "" || txt_confirm_password.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            //crear el usuario
            var user = new User();
            user.Name = txt_name.Text;
            user.Password = txt_password.Text;
            user.Rol = cb_rol.Text;

            //guardar el usuario
            var userRepository = new UserRepository();
            userRepository.addUser(user);

            MessageBox.Show("Usuario agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }
    }
}
