using System.Diagnostics;

namespace Servicios.Mensajería
{
    public class clsCronometro
    {
        #region Atributos
        decimal atrMilisegundos;
        decimal atrSegundos;
        decimal atrMinutos;
        decimal atrHoras;
        decimal atrDias;
        private Stopwatch atrTemporizador;
        private string atrMensajeTiempoEjecucion;
        #endregion
        #region Métodos
        public void Iniciar()
        {
            if (atrTemporizador == null)
                this.atrTemporizador = Stopwatch.StartNew();
            else
                atrTemporizador.Restart();
        }
        public void Detener()
        {
            atrTemporizador.Stop();
            atrMensajeTiempoEjecucion = "El tiempo del Metodo fue de: ";
            atrMensajeTiempoEjecucion = "\n-Días:\t\t" + darDias() + ".";
            atrMensajeTiempoEjecucion = "\n-Horas:\t\t" + darHoras() + ".";
            atrMensajeTiempoEjecucion = "\n-Minutos:\t\t" + darMinutos() + ".";
            atrMensajeTiempoEjecucion = "\n-Segundos:\t\t" + darSegundos() + ".";
            atrMensajeTiempoEjecucion = "\n-Milisegundos:\t\t" + darMilisegundos() + ".";
            atrMensajeTiempoEjecucion = "\n-Ticks:\t\t" + darTicks() + ".";
        }
        public long darTicks()
        {
            return atrTemporizador.ElapsedTicks;
        }
        public decimal darMilisegundos()
        {
            atrMilisegundos = (decimal)atrTemporizador.Elapsed.TotalMilliseconds;
            return decimal.Round(atrMilisegundos, 3);
        }
        public decimal darSegundos()
        {
            atrSegundos = (decimal)atrTemporizador.Elapsed.TotalSeconds;
            return decimal.Round(atrSegundos, 3);
        }
        public decimal darMinutos()
        {
            atrMinutos = (decimal)atrTemporizador.Elapsed.TotalMinutes;
            return decimal.Round(atrMinutos, 3);
        }
        public decimal darHoras()
        {
            atrHoras = (decimal)atrTemporizador.Elapsed.TotalHours;
            return decimal.Round(atrHoras, 3);
        }
        public decimal darDias()
        {
            atrDias = (decimal)atrTemporizador.Elapsed.TotalDays;
            return decimal.Round(atrDias, 3);
        }
        public string darMensajeTiempoEjecucion()
        {
            return atrMensajeTiempoEjecucion;
        }
        #endregion
    }
}
