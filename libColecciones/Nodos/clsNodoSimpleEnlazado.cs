using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoSimpleEnlazado<Tipo> : clsNodo<Tipo> where Tipo : IComparable
    {
        #region Atributos
        private clsNodoSimpleEnlazado<Tipo> atrSiguiente;
        #endregion
        #region Metodos
        #region Constructores
        public clsNodoSimpleEnlazado(Tipo prmItem) : base(prmItem) { }
        #endregion
        #region Accesores - Mutadores
        public clsNodoSimpleEnlazado<Tipo> darSiguiente() { return atrSiguiente; }
        public void ponerSiguiente(clsNodoSimpleEnlazado<Tipo> prmNodo) { atrSiguiente = prmNodo; }
        #endregion
        #region Conectores y Desconectores
        public bool ConectarSiguiente(clsNodoSimpleEnlazado<Tipo> prmNodo)
        {
            if(prmNodo != null)
            {
                prmNodo.atrSiguiente = this.atrSiguiente;
                this.atrSiguiente = prmNodo;
                return true;
            }
            return false;
        }
        public bool DesconectarSiguiente(ref Tipo prmItem)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoDesconectado;
            if (atrSiguiente != null)
            {
                varNodoDesconectado = atrSiguiente;
                atrSiguiente = atrSiguiente.atrSiguiente;
                prmItem = varNodoDesconectado.darItem();
                varNodoDesconectado = null;
                return true;
            }
            return false;
        }
        #endregion
        #endregion
    }
}
