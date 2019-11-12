using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoDobleEnlazado<Tipo> : clsNodo<Tipo> where Tipo : IComparable
    {
        private clsNodoDobleEnlazado<Tipo> atrAnterior;
        private clsNodoDobleEnlazado<Tipo> atrSiguiente;
        public clsNodoDobleEnlazado(Tipo prmItem) : base(prmItem) { }
        public clsNodoDobleEnlazado<Tipo> darAnterior() { return atrAnterior; }
        public void ponerAnterior(clsNodoDobleEnlazado<Tipo> prmNodo) { atrAnterior = prmNodo; }
        public clsNodoDobleEnlazado<Tipo> darSiguiente() { return atrSiguiente; }
        public void ponerSiguiente(clsNodoDobleEnlazado<Tipo> prmNodo) { atrSiguiente = prmNodo; }
    }
}
