namespace Calculadora
{
    public class Cuadrado
    {
        private double valor;

        public Cuadrado(double valor)
        {
            this.valor = valor;
        }

        public double Calcular()
        {
            return System.Math.Pow(valor, 2);
        }
    }
}
