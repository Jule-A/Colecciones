using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoDobleEnlazado<Tipo> : clsNodo<Tipo> where Tipo : IComparable
    {
        #region Atributos
        private clsNodoDobleEnlazado<Tipo> atrAnterior;
        private clsNodoDobleEnlazado<Tipo> atrSiguiente;
        #endregion
        #region Métodos   
        #region Constructores
        public clsNodoDobleEnlazado(Tipo prmItem) : base(prmItem) { }
        public clsNodoDobleEnlazado<Tipo> darAnterior() { return atrAnterior; }
        #endregion
        #region Accesores - Mutadores
        public void ponerAnterior(clsNodoDobleEnlazado<Tipo> prmNodo) { atrAnterior = prmNodo; }
        public clsNodoDobleEnlazado<Tipo> darSiguiente() { return atrSiguiente; }
        public void ponerSiguiente(clsNodoDobleEnlazado<Tipo> prmNodo) { atrSiguiente = prmNodo; }
        #endregion
        #region Conectores y Desconectores
        public bool ConectarSiguiente(clsNodoDobleEnlazado<Tipo> prmNodo)
        {
            if (prmNodo != null)
            {
                prmNodo.atrAnterior = this;
                if (this.atrSiguiente != null)
                {
                    prmNodo.atrSiguiente = this.atrSiguiente;
                    this.atrSiguiente.atrAnterior = prmNodo;
                }
                this.atrSiguiente = prmNodo;
                return true;
            }
            return false;
        }
        public bool DesconectarSiguiente(ref Tipo prmItem)
        {
            clsNodoDobleEnlazado<Tipo> varNodoDesconectado;
            if (atrSiguiente != null)
            {
                varNodoDesconectado = atrSiguiente;
                atrSiguiente = atrSiguiente.atrSiguiente;
                atrSiguiente.ponerAnterior(this);
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
