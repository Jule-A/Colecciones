using System.Diagnostics;

namespace Servicios.Colecciones
{
    class clsCronometro
    {
        decimal atrmilisegundos;
        decimal atrsegundos;
        decimal atrminutos;
        decimal atrHoras;
        decimal atrDias;
        private Stopwatch atrTemporizador;
        private string atrMensajeTiempoEjecucion;
        public void Iniciar()
        {

        }
        public void Detener()
        {

        }
        public long darTicks()
        {
            return 1;
        }
        public decimal darMilisegundos()
        {
            return 1;
        }
        public decimal darSegundos()
        {
            return 1;
        }
        public decimal darMinutos()
        {
            return 1;
        }
        public decimal darHoras()
        {
            return 1;
        }
        public decimal darDias()
        {
            return 1;
        }
        public string darMensajeTiempoEjecucion()
        {
            return 1;
        }
    }
}
