namespace Calculadora
{
    public class CambioSigno
    {
        private double valor;

        public CambioSigno(double valor)
        {
            this.valor = valor;
        }

        public double Calcular()
        {
            return valor * -1;
        }
    }
}
