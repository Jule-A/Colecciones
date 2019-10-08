using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoSimpleEnlazado<Tipo>:clsNodo<Tipo> where Tipo: IComparable
    {
        private clsNodoSimpleEnlazado<Tipo> atrSiguiente;
        public clsNodoSimpleEnlazado<Tipo> darSiguiente() { return atrSiguiente; }
        public void ponerSiguiente(clsNodoSimpleEnlazado<Tipo> prmNodo) { atrSiguiente = prmNodo; }
    }
}
