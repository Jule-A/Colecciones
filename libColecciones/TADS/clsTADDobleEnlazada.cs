using System;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.TADS
{
    public class clsTADDobleEnlazado<Tipo> : clsTAD<Tipo> where Tipo : IComparable
    {
        #region Atributos
        private clsNodoDobleEnlazado<Tipo> atrNodoPrimero;
        private clsNodoDobleEnlazado<Tipo> atrNodoUltimo;
        #endregion
        #region Métodos
        #region Auxiliares
        protected bool ReversarNodos()
        {
            if (!EstaVacia())
            {
                clsNodoDobleEnlazado<Tipo> varNodoNuevo = atrNodoUltimo;
                clsNodoDobleEnlazado<Tipo> varNodoTemporal = atrNodoUltimo.darAnterior();
                varNodoNuevo.ponerAnterior(null);
                varNodoNuevo.ponerSiguiente(varNodoTemporal);
                varNodoTemporal.ponerSiguiente(varNodoTemporal.darAnterior());
                varNodoTemporal.ponerAnterior(varNodoNuevo);
                atrNodoUltimo.ponerSiguiente(varNodoNuevo);
                varNodoNuevo.ponerAnterior(atrNodoUltimo);
                atrNodoUltimo = varNodoNuevo;
            }
            return false;
        }
        #endregion
        #region CRUDS
        protected override bool InsertarEn(int prmIndice, Tipo prmItem)
        {
            clsNodoDobleEnlazado<Tipo> varNodoNuevo = new clsNodoDobleEnlazado<Tipo>(prmItem);
            if (EstaVacia())
            {
                atrNodoPrimero = varNodoNuevo;
                atrNodoUltimo = varNodoNuevo;
                atrNodoPrimero.ponerSiguiente(atrNodoUltimo);
                atrNodoUltimo.ponerAnterior(atrNodoPrimero);
                atrLongitud++;
                return true;
            }
            if (prmIndice == 0)
            {
                varNodoNuevo.ponerSiguiente(atrNodoPrimero);
                atrNodoPrimero.ponerAnterior(varNodoNuevo);
                atrNodoPrimero = varNodoNuevo;
                atrLongitud++;
                return true;
            }
            if (prmIndice == atrLongitud)
            {
                atrNodoUltimo.ponerSiguiente(varNodoNuevo);
                varNodoNuevo.ponerAnterior(atrNodoUltimo);
                atrNodoUltimo = varNodoNuevo;
                return true;
            }
            if (EsValido(prmIndice))
            {
                clsNodoDobleEnlazado<Tipo> varNodoActual = new clsNodoDobleEnlazado<Tipo>(default);
                if (prmIndice > 0 && prmIndice < atrLongitud / 2)
                {
                    varNodoActual = atrNodoPrimero;
                    for (int varIndice = 1; varIndice < prmIndice; varIndice++)
                        varNodoActual = varNodoActual.darSiguiente();
                }
                if (prmIndice >= atrLongitud / 2 && prmIndice < atrLongitud - 1)
                {
                    varNodoActual = atrNodoUltimo;
                    for (int varIndice = atrLongitud - 2; varIndice >= prmIndice; varIndice--)
                        varNodoActual = varNodoActual.darAnterior();
                }
                varNodoNuevo.ponerSiguiente(varNodoActual);
                varNodoNuevo.ponerAnterior(varNodoActual.darAnterior());
                varNodoActual.darAnterior().ponerSiguiente(varNodoNuevo);
                varNodoActual.ponerAnterior(varNodoNuevo);
                atrLongitud++;
                return true;
            }
            return false;
        }
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            clsNodoDobleEnlazado<Tipo> varNodoNuevo;
            if (IrIndice(prmIndice))
            {
                prmItem = atrItemActual;
                if (atrLongitud - 1 == 0)
                {
                    atrNodoPrimero = null;
                    atrNodoUltimo = null;
                    return true;
                }
                if (prmIndice == 0)
                {
                    varNodoNuevo = atrNodoActual.darSiguiente();
                    varNodoNuevo.ponerAnterior(null);
                    atrNodoActual = varNodoNuevo;
                    return true;
                }
                clsNodoDobleEnlazado<Tipo> varNodoActual = atrNodoPrimero;
                for (int varIndice = 1; varIndice < prmIndice; varIndice++)
                    varNodoActual = varNodoActual.darSiguiente();
                varNodoNuevo = varNodoActual.darSiguiente();
                prmItem = varNodoNuevo.darItem();
                if (prmIndice == atrLongitud - 1)
                {
                    varNodoActual.ponerSiguiente(null);
                    atrNodoUltimo = varNodoActual;
                    atrLongitud--;
                    return true;
                }
                varNodoActual.ponerSiguiente(varNodoNuevo.darSiguiente());
                varNodoNuevo.darSiguiente().ponerAnterior(varNodoActual);
                varNodoNuevo.ponerSiguiente(null);
                varNodoNuevo.ponerAnterior(null);
                atrLongitud--;
                return true;
            }
            return false;
        }
        protected override bool ModificarEn(int prmIndice, Tipo prmItem)
        {
            if (!EstaVacia() && IrIndice(prmIndice))
            {
                atrNodoActual.ponerItem(prmItem);
                return true;
            }
            return false;
        }
        protected override bool RecuperarEn(int prmIndice, ref Tipo prmItem)
        {
            if (!EstaVacia())
                return IrIndice(prmIndice);
            return false;
        }
        #endregion
        #region Accesores
        public clsNodoDobleEnlazado<Tipo> darNodoPrimero() { return atrNodoPrimero; }
        public clsNodoDobleEnlazado<Tipo> darNodoUltimo() { return atrNodoUltimo; }
        #endregion
        #region Iterador
        protected clsNodoDobleEnlazado<Tipo> atrNodoActual;
        protected override bool IrIndice(int prmIndice)
        {
            atrNodoActual = new clsNodoDobleEnlazado<Tipo>(default);
            if (prmIndice == 0)
            {
                atrIndiceActual = 0;
                atrNodoActual = atrNodoPrimero;
                atrItemActual = atrNodoActual.darItem();
                return true;
            }
            if (prmIndice == atrLongitud - 1)
            {
                atrIndiceActual = atrLongitud - 1;
                atrNodoActual = atrNodoUltimo;
                atrItemActual = atrNodoActual.darItem();
                return true;
            }
            if (EsValido(prmIndice))
            {
                if(prmIndice > 0 && prmIndice < atrLongitud / 2)
                {
                    atrNodoActual = atrNodoPrimero;
                    for (atrIndiceActual = 1; atrIndiceActual < prmIndice; atrIndiceActual++)
                        atrNodoActual = atrNodoActual.darSiguiente();
                    return true;
                }
                if (prmIndice >= atrLongitud / 2 && prmIndice < atrLongitud - 1)
                {
                    atrNodoActual = atrNodoUltimo;
                    for (atrIndiceActual = atrLongitud - 2; atrIndiceActual >= prmIndice; atrIndiceActual--)
                        atrNodoActual = atrNodoActual.darAnterior();
                    return true;
                }
                atrItemActual = atrNodoActual.darItem();
            }
            return false;
        }
        #endregion
        #endregion
    }
}