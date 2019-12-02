using System;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.TADS
{
    public class clsTADSimpleEnlazado<Tipo>:clsTAD<Tipo> where Tipo: IComparable
    {
        #region Atributos
        private clsNodoSimpleEnlazado<Tipo> atrNodoPrimero;
        private clsNodoSimpleEnlazado<Tipo> atrNodoUltimo;
        #endregion
        #region Métodos
        #region Auxiliares
        protected bool ReversarNodos()
        {
            if (!EstaVacia())
            {
                clsNodoSimpleEnlazado<Tipo> varNodoNuevo = atrNodoUltimo;
                clsNodoSimpleEnlazado<Tipo> varNodoActual;
                clsNodoSimpleEnlazado<Tipo> varNodoAuxiliar;
                varNodoAuxiliar = varNodoNuevo;
                for (int varIndice1 = 1; varIndice1 < atrLongitud; varIndice1++)
                {
                    varNodoActual = atrNodoPrimero;
                    for (int varIndice2 = 1; varIndice2 < atrLongitud - varIndice1; varIndice2++)
                        varNodoActual = varNodoActual.darSiguiente();
                    if (varIndice1 == 0)
                    {
                        varNodoNuevo.ponerSiguiente(varNodoActual);
                        varNodoAuxiliar = varNodoNuevo.darSiguiente();
                    }
                    else if(varIndice1 == atrLongitud - 1)
                    {
                        varNodoAuxiliar.ponerSiguiente(null);
                        atrNodoUltimo = atrNodoPrimero;
                        atrNodoPrimero = varNodoNuevo;
                        return true;
                    }
                    else
                    {
                        varNodoAuxiliar.ponerSiguiente(varNodoActual);
                        varNodoAuxiliar = varNodoAuxiliar.darSiguiente();
                    }
                }

            }
            return false;
        }

        #endregion
        #region CRUDS
        protected override bool InsertarEn(int prmIndice, Tipo prmItem)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoNuevo = new clsNodoSimpleEnlazado<Tipo>(prmItem);
            if (EstaVacia())
            {
                atrNodoPrimero = varNodoNuevo;
                atrNodoUltimo = varNodoNuevo;
                atrNodoPrimero.ponerSiguiente(atrNodoUltimo);
                atrLongitud++;
                return true;
            }
            if (prmIndice==0)
            {
                varNodoNuevo.ponerSiguiente(atrNodoPrimero);
                atrNodoPrimero = varNodoNuevo;
                atrLongitud++;
                return true;
            }
            if (prmIndice == atrLongitud)
            {
                atrNodoUltimo.ponerSiguiente(varNodoNuevo);
                atrNodoUltimo = varNodoNuevo;
                atrLongitud++;
                return true;
            }
            if (EsValido(prmIndice))
            {
                clsNodoSimpleEnlazado<Tipo> varNodoActual = atrNodoPrimero;
                for (int varIndice = 1; varIndice < prmIndice; varIndice++)
                    varNodoActual = varNodoActual.darSiguiente();
                varNodoNuevo.ponerSiguiente(varNodoActual.darSiguiente());
                varNodoActual.ponerSiguiente(varNodoNuevo);
                atrLongitud++;
                return true;
            }
            return false;
        }
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoNuevo;
            if (!EstaVacia() && EsValido(prmIndice))
            {
                if (atrLongitud - 1 == 0)
                {
                    prmItem = atrNodoPrimero.darItem();
                    atrNodoPrimero = null;
                    atrNodoUltimo = null;
                    atrLongitud--;
                    return true;
                }
                if (prmIndice == 0)
                {
                    prmItem = atrNodoPrimero.darItem();
                    varNodoNuevo = atrNodoPrimero.darSiguiente();
                    atrNodoPrimero = varNodoNuevo;
                    atrLongitud--;
                    return true;
                }
                clsNodoSimpleEnlazado<Tipo> varNodoActual = atrNodoPrimero;
                for (int varIndice = 1; varIndice < prmIndice; varIndice++)
                    varNodoActual = varNodoActual.darSiguiente();
                varNodoNuevo = varNodoActual.darSiguiente();
                prmItem = varNodoNuevo.darItem();
                if (prmIndice == atrLongitud-1)
                {
                    varNodoActual.ponerSiguiente(null);
                    atrNodoUltimo = varNodoActual;
                    atrLongitud--;
                    return true;
                }
                varNodoActual.ponerSiguiente(varNodoNuevo.darSiguiente());
                varNodoNuevo.ponerSiguiente(null);
                atrLongitud--;
                return true;
            }
            return false;
        }
        protected override bool ModificarEn(int prmIndice, Tipo prmItem)
        {
            if (!EstaVacia() && EsValido(prmIndice))
            {
                if (prmIndice == 0)
                {
                    atrNodoPrimero.ponerItem(prmItem);
                    return true;
                }
                else if (prmIndice == atrLongitud)
                {
                    atrNodoUltimo.ponerItem(prmItem);
                    return true;
                }
                clsNodoSimpleEnlazado<Tipo> varNodoActual = atrNodoPrimero;
                for (int varIndice = 1; varIndice <= prmIndice; varIndice++)
                    varNodoActual = varNodoActual.darSiguiente();
                varNodoActual.ponerItem(prmItem);
                return true;
            }
            return false;
        }
        protected override bool RecuperarEn(int prmIndice, ref Tipo prmItem)
        {
            if (!EstaVacia() && EsValido(prmIndice))
            {
                if (prmIndice == 0)
                {
                    prmItem = atrNodoPrimero.darItem();
                    return true;
                } else if (prmIndice == atrLongitud-1)
                {
                    prmItem = atrNodoUltimo.darItem();
                    return true;
                }
                clsNodoSimpleEnlazado<Tipo> varNodoActual = atrNodoPrimero;
                for (int varIndice = 1; varIndice <= prmIndice; varIndice++)
                    varNodoActual = varNodoActual.darSiguiente();
                prmItem = varNodoActual.darItem();
                return true;
            }
            return false;
        }
        #endregion
        #region Accesores
        public clsNodoSimpleEnlazado<Tipo> darNodoPrimero() { return atrNodoPrimero; }
        public clsNodoSimpleEnlazado<Tipo> darNodoUltimo() { return atrNodoUltimo; }
        #endregion
        #endregion
    }
}
