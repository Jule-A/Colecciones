//capa de servicios.mensajero
namespace Servicios.Colecciones
{
    class clsMensajero
    {
        #region Atributos
        protected string atrMensajeUltimoMetodo;
        protected bool atrModoMensajero;
        protected bool atrModoCronometro;
        protected clsCronometro clsCronometro = new clsCronometro();
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
        protected void Mensajero(string prmMetodoEnejecucion)
        {
            "El metodo<+ prmmetodoenejecucion + > de + ha finalizado correctamente;
        }
        protected void Mensajero(string prmMetodoEnejecucion, string prmDescripcion)
        {

        }
        protected void Mensajero(string prmMetodoEnejecucion, string prmDescripcion, bool prmReportarExito)
        {

        }
        protected void Mensajero(string prmMetodoEnejecucion, bool prmReportarExito)
        {

        }
        #endregion
        #endregion
    }
}
