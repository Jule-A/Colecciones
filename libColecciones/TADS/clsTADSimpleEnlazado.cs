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
        protected override bool IntercambiarEntre(int prmIndice1, int prmIndice2)
        {
            if (EsValido(prmIndice1) && EsValido(prmIndice2))
            {
                if (prmIndice1 != prmIndice2)
                {
                    IrIndice(prmIndice1);
                    clsNodoSimpleEnlazado<Tipo> varNodoIndice1 = atrNodoActual;
                    IrIndice(prmIndice2);
                    clsNodoSimpleEnlazado<Tipo> varNodoIndice2 = atrNodoActual;
                    if(varNodoIndice1 != null && varNodoIndice2 != null)
                    {
                        Tipo varItemIndice1 = varNodoIndice1.darItem();
                        varNodoIndice1.ponerItem(varNodoIndice2.darItem());
                        varNodoIndice2.ponerItem(varItemIndice1);
                        return true;
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
            if (IrIndice(prmIndice - 1))
            {  
                atrNodoActual.ponerSiguiente(varNodoNuevo);
                atrLongitud++;
                return true;
            }
            return false;
        }
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoNuevo;
            if (!EstaVacia())
            {
                if (prmIndice == 0 && atrLongitud == 1)
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
                if (IrIndice(prmIndice - 1))
                {
                    if (atrNodoActual.DesconectarSiguiente(ref prmItem))
                    {
                        if (prmIndice == atrLongitud - 1)
                            atrNodoUltimo = atrNodoActual;
                        atrLongitud--;
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
        #endregion
        #region Accesores
        public clsNodoSimpleEnlazado<Tipo> darNodoPrimero() { return atrNodoPrimero; }
        public clsNodoSimpleEnlazado<Tipo> darNodoUltimo() { return atrNodoUltimo; }
        #endregion
        #region Iterador
        clsNodoSimpleEnlazado<Tipo> atrNodoActual;
        protected override bool IrIndice(int prmIndice)
        {
            if (prmIndice == 0)
                return IrPrimero();
            if (prmIndice == atrLongitud - 1)
                return IrUltimo();
            if (EsValido(prmIndice) && (atrIndiceActual > 0) && (atrIndiceActual < prmIndice))
            {
                IrPrimero();
                while (atrIndiceActual < prmIndice)
                    IrSiguiente();
            }
            if (EsValido(prmIndice))
            {
                IrPrimero();
                while (atrIndiceActual < prmIndice)
                    IrSiguiente();
            }
            return true;
        }
        protected override bool IrPrimero()
        {
            if (!EstaVacia())
            {
                atrIndiceActual = 0;
                atrNodoActual = atrNodoPrimero;
                atrItemActual = atrNodoActual.darItem();
                return true;
            }
            return false;
        }
        protected override bool IrUltimo()
        {
            if (!EstaVacia())
            {
                atrIndiceActual = atrLongitud - 1;
                atrNodoActual = atrNodoUltimo;
                atrItemActual = atrNodoActual.darItem();
                return true;
            }
            return false;
        }
        protected override bool Avanzar()
        {
            atrIndiceActual++;
            atrNodoActual = atrNodoActual.darSiguiente();
            atrItemActual = atrNodoActual.darItem();
            return true;
        }
        protected override void PonerItemActual(Tipo prmItem){atrNodoActual.ponerItem(prmItem);}
        #endregion
        #endregion
    }
}
