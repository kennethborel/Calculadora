namespace Calculadora
{
    public class Resta
    {
        private double minuendo;
        private double sustraendo;

        public Resta(double minuendo, double sustraendo)
        {
            this.minuendo = minuendo;
            this.sustraendo = sustraendo;
        }

        public double Calcular()
        {
            return minuendo - sustraendo;
        }
    }
}
