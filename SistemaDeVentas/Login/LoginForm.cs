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

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            User user = new User();
            user.Username = textBox1.Text;
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
