namespace Calculadora
{
    public class RaizCuadrada
    {
        private double numero;

        public RaizCuadrada(double numero)
        {
            this.numero = numero;
        }

        public double Calcular()
        {
            return System.Math.Sqrt(numero);
        }
    }
}
