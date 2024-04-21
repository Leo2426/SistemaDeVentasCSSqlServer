using SistemaDeVentas.Shared;
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
            //agregar autocomplete a el cb_usuarios
            UserRepository userRepository = new UserRepository();
            var users = userRepository.getAllUsers();

            cb_users.DataSource = users;
            cb_users.DisplayMember = "Username";
            cb_users.ValueMember = "Id";
            cb_users.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_users.AutoCompleteSource = AutoCompleteSource.ListItems;
                }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            User user = new User();
            user.Username = cb_users.Text;
            user.Password = textBox2.Text;
            if (userRepository.Login(user))
            {
                GlobalClass.Username = user.Username;
                PrincipalForm principalForm = new PrincipalForm();
                this.Hide();
                principalForm.ShowDialog();
                this.Close();
                
            }
            else
            {
                textBox2.Text = "";
                textBox2.Focus();
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
