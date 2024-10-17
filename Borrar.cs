using System.Windows.Controls;

namespace Calculadora
{
    public class Borrar
    {
        public void Ejecutar(ref TextBox txtResultado)
        {
            if (txtResultado.Text.Length > 0)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
                if (txtResultado.Text == "")
                {
                    txtResultado.Text = "0";
                }
            }
        }
    }
}
