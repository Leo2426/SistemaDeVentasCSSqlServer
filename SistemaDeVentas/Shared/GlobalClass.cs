using SistemaDeVentas.Login;
using SistemaDeVentas.Productos;
using SistemaDeVentas.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Shared
{
    public static class GlobalClass
    {

        
        public static Product SelectedProduct { get; set; }
        public static User.User ActualUser { get; set; } = new User.User();
        public static string SymbolCurrency { get; } = "S/";

        public static bool isProductSelectProperly { get; set; } = false;

        public static void validateOnlyNumbersAndDecimalKeyPress(KeyPressEventArgs e, TextBox textBox)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }

            //que solo acepte la coma 1 vez y que solo haya 2 decimales
            if (ch == 44 && textBox.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
            }



            //que solo acepte 2 decimales
            if (textBox.Text.IndexOf(',') != -1 && textBox.Text.Substring(textBox.Text.IndexOf(',')).Length > 2)
            {
                e.Handled = true;
            }

            //permitir el backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

        }


    }
}
