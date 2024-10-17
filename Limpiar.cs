using System.Windows.Controls;

namespace Calculadora
{
    public class Limpiar
    {
        public void Ejecutar(ref TextBox txtResultado, ref double currentValue, ref double previousValue, ref string currentOperation)
        {
            txtResultado.Text = "0";
            currentValue = 0;
            previousValue = 0;
            currentOperation = "";
        }
    }
}
