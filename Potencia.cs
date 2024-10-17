namespace Calculadora
{
    public class Potencia
    {
        private double baseNumero;
        private double exponente;

        public Potencia(double baseNumero, double exponente)
        {
            this.baseNumero = baseNumero;
            this.exponente = exponente;
        }

        public double Calcular()
        {
            return System.Math.Pow(baseNumero, exponente);
        }
    }
}
