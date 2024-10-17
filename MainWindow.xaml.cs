using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculadora
{
    public partial class MainWindow : Window
    {
        private double currentValue = 0;
        private double previousValue = 0;
        private string currentOperation = "";
        private bool isOperationPerformed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Numero_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (txtResultado.Text == "0" || isOperationPerformed)
                txtResultado.Clear();

            isOperationPerformed = false;
            txtResultado.Text += button.Content.ToString();
        }

        private void Operacion_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            currentOperation = button.Content.ToString();
            previousValue = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "0";
            isOperationPerformed = true;
        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            currentValue = Convert.ToDouble(txtResultado.Text);
            double resultado = 0;

            switch (currentOperation)
            {
                case "+":
                    var suma = new Suma(previousValue, currentValue);
                    resultado = suma.Calcular();
                    break;
                case "−":
                    var resta = new Resta(previousValue, currentValue);
                    resultado = resta.Calcular();
                    break;
                case "×":
                    var multiplicacion = new Multiplicacion(previousValue, currentValue);
                    resultado = multiplicacion.Calcular();
                    break;
                case "÷":
                    try
                    {
                        var division = new Division(previousValue, currentValue);
                        resultado = division.Calcular();
                    }
                    catch (DivideByZeroException)
                    {
                        txtResultado.Text = "Error";
                        return;
                    }
                    break;
                case "xʸ":
                    var potencia = new Potencia(previousValue, currentValue);
                    resultado = potencia.Calcular();
                    break;
            }

            txtResultado.Text = resultado.ToString();
            currentOperation = "";
            isOperationPerformed = true;
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            var limpiar = new Limpiar();
            limpiar.Ejecutar(ref txtResultado, ref currentValue, ref previousValue, ref currentOperation);
        }

        private void OperacionAvanzada_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            double number = Convert.ToDouble(txtResultado.Text);
            double resultado = 0;

            switch (button.Content.ToString())
            {
                case "√x":
                    var raizCuadrada = new RaizCuadrada(number);
                    resultado = raizCuadrada.Calcular();
                    break;
                case "x²":
                    var cuadrado = new Cuadrado(number);
                    resultado = cuadrado.Calcular();
                    break;
                case "log":
                    var logaritmo = new Logaritmo(number);
                    resultado = logaritmo.Calcular();
                    break;
                case "10ˣ":
                    var potenciaDeDiez = new PotenciaDeDiez(number);
                    resultado = potenciaDeDiez.Calcular();
                    break;
                case "n!":
                    var factorial = new Factorial((int)number);
                    resultado = factorial.Calcular();
                    break;
                case "xʸ":
                    previousValue = number;
                    currentOperation = "xʸ";
                    txtResultado.Clear();
                    return;
            }

            txtResultado.Text = resultado.ToString();
        }

        private void CambioSigno_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtResultado.Text, out double number))
            {
                var cambioSigno = new CambioSigno(number);
                txtResultado.Text = cambioSigno.Calcular().ToString();
            }
        }

        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            var borrar = new Borrar();
            borrar.Ejecutar(ref txtResultado);
        }
    }
}
