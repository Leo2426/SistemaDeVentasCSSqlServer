using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            label1.Text = $"Bienvenido {GlobalClass.Username}";
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (IconButton)sender)
                {
                    DisableButton();
                    currentButton = (IconButton)sender;
                    currentButton.BackColor = Color.Teal;

                }
            }

        }

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
    } 
}
