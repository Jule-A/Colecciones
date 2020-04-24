namespace Servicios.Mensajería
{
    public class clsMensajero
    {
        #region Atributos
        protected string atrMensajeUltimoMetodo;
        protected bool atrModoMensajero;
        protected bool atrModoCronometro;
        protected clsCronometro atrCronometro = new clsCronometro();
        #endregion
        #region Métodos
        #region Accesores - Mutadores
        public virtual string darNombreEntidad() { return null; }
        public string darMensajeUltimoMetodo()
        {
            return atrMensajeUltimoMetodo;
        }
        public void ponerMensajeUltimo(string prmMensaje)
        {
            atrMensajeUltimoMetodo = prmMensaje;
        }
        #endregion
        #region Mensajería
        protected void Mensajero(string prmMetodoEnEjecucion)
        {
            atrMensajeUltimoMetodo = "El método <" + prmMetodoEnEjecucion + "> de <" + darNombreEntidad() + "> ha finalizado correctamente";
        }
        protected void Mensajero(string prmMetodoEnejecucion, string prmDescripcion)
        {

        }
        protected void Mensajero(string prmMetodoEnejecucion, string prmDescripcion, bool prmReportarExito)
        {

        }
        protected void Mensajero(string prmMetodoEnEjecucion, bool prmReportarExito)
        {
            if (!atrModoMensajero && !atrModoCronometro)
                atrMensajeUltimoMetodo = "";
            if (atrModoMensajero && !atrModoCronometro)
                Mensajero(prmMetodoEnEjecucion, atrMensajeUltimoMetodo, prmReportarExito);
            if (atrModoCronometro && !atrModoMensajero)
                atrMensajeUltimoMetodo = atrCronometro.darMensajeTiempoEjecucion();
            if (atrModoMensajero && atrModoCronometro)
                Mensajero(prmMetodoEnEjecucion, atrMensajeUltimoMetodo + "\n" + atrCronometro.darMensajeTiempoEjecucion(), prmReportarExito);
        }
        #endregion
        #endregion
    }
}
