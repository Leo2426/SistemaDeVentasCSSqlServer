using SistemaDeVentas.Shared;
using SistemaDeVentas.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //set focus al txt_password
            txt_password.Focus();
            
            //agregar autocomplete a el cb_usuarios
            UserRepository userRepository = new UserRepository();
            var users = userRepository.getAllUsers();

            cb_users.DataSource = users;
            cb_users.DisplayMember = "Name";
            cb_users.ValueMember = "Id";
            cb_users.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_users.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            User.User user = new User.User();
            user.Name = cb_users.Text;
            user.Password = txt_password.Text;
            if (userRepository.Login(user))
            {
                GlobalClass.ActualUser.Name = user.Name;
                
                GlobalClass.ActualUser.Rol = userRepository.getRol(user.Name);


                PrincipalForm principalForm = new PrincipalForm();
                this.Hide();
                principalForm.ShowDialog();
                this.Close();
                
            }
            else
            {
                txt_password.Text = "";
                txt_password.Focus();
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                iconButton1_Click(sender, e);
            }
        }
    }
}
