namespace Calculadora
{
    public class Division
    {
        private double dividendo;
        private double divisor;

        public Division(double dividendo, double divisor)
        {
            this.dividendo = dividendo;
            this.divisor = divisor;
        }

        public double Calcular()
        {
            if (divisor == 0)
            {
                throw new System.DivideByZeroException("No se puede dividir entre cero.");
            }
            return dividendo / divisor;
        }
    }
}
