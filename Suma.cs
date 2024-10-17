namespace Calculadora
{
    public class Suma
    {
        private double sumando1;
        private double sumando2;

        public Suma(double sumando1, double sumando2)
        {
            this.sumando1 = sumando1;
            this.sumando2 = sumando2;
        }

        public double Calcular()
        {
            return sumando1 + sumando2;
        }
    }
}
