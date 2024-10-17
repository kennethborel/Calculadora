namespace Calculadora
{
    public class Factorial
    {
        private int numero;

        public Factorial(int numero)
        {
            this.numero = numero;
        }

        public double Calcular()
        {
            if (numero < 0) return 0; // El factorial de un número negativo no existe
            if (numero == 0) return 1; // El factorial de 0 es 1

            return CalcularFactorial(numero);
        }

        private double CalcularFactorial(int n)
        {
            if (n == 1) return 1;
            return n * CalcularFactorial(n - 1);
        }
    }
}
