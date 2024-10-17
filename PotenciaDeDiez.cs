namespace Calculadora
{
    public class PotenciaDeDiez
    {
        private double exponente;

        public PotenciaDeDiez(double exponente)
        {
            this.exponente = exponente;
        }

        public double Calcular()
        {
            return System.Math.Pow(10, exponente);
        }
    }
}
