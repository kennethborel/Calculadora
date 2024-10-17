namespace Calculadora
{
    public class Multiplicacion
    {
        private double multiplicando;
        private double multiplicador;

        public Multiplicacion(double multiplicando, double multiplicador)
        {
            this.multiplicando = multiplicando;
            this.multiplicador = multiplicador;
        }

        public double Calcular()
        {
            return multiplicando * multiplicador;
        }
    }
}
