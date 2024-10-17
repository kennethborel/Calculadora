namespace Calculadora
{
    public class Logaritmo
    {
        private double valor;

        public Logaritmo(double valor)
        {
            this.valor = valor;
        }

        public double Calcular()
        {
            return System.Math.Log10(valor);
        }
    }
}
