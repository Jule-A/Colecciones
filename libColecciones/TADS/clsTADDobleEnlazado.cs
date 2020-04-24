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
        protected override bool IntercambiarEntre(int prmIndice1, int prmIndice2)
        {
            if (EsValido(prmIndice1) && EsValido(prmIndice2))
            {
                if (prmIndice1 != prmIndice2)
                {
                    IrIndice(prmIndice1);
                    clsNodoDobleEnlazado<Tipo> varNodoIndice1 = atrNodoActual;
                    IrIndice(prmIndice2);
                    clsNodoDobleEnlazado<Tipo> varNodoIndice2 = atrNodoActual;
                    if (varNodoIndice1 != null && varNodoIndice2 != null)
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
                //atrNodoUltimo.ponerSiguiente(varNodoNuevo);
                //varNodoNuevo.ponerAnterior(atrNodoUltimo);
                atrNodoUltimo.ConectarSiguiente(varNodoNuevo);
                atrNodoUltimo = varNodoNuevo;
                atrLongitud++;
                return true;
            }
            if (IrIndice(prmIndice - 1))
            {
                //varNodoNuevo.ponerSiguiente(atrNodoActual);
                //varNodoNuevo.ponerAnterior(atrNodoActual.darAnterior());
                //atrNodoActual.darAnterior().ponerSiguiente(varNodoNuevo);
                //atrNodoActual.ponerAnterior(varNodoNuevo);
                atrNodoActual.ConectarSiguiente(varNodoNuevo);
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
                    atrLongitud--;
                    return true;
                }
                if (prmIndice == 0)
                {
                    varNodoNuevo = this.atrNodoActual.darSiguiente();
                    varNodoNuevo.ponerAnterior(null);
                    this.atrNodoActual = varNodoNuevo;
                    atrNodoPrimero = varNodoNuevo;
                    atrLongitud--;
                    return true;
                }
                if (prmIndice == atrLongitud - 1)
                {
                    varNodoNuevo = atrNodoActual.darAnterior();
                    atrNodoUltimo = varNodoNuevo;
                    atrNodoActual = varNodoNuevo;
                    atrLongitud--;
                    return true;
                }
                varNodoNuevo = atrNodoActual.darSiguiente();
                atrNodoActual.ponerSiguiente(varNodoNuevo);
                varNodoNuevo.darSiguiente().ponerAnterior(atrNodoActual);
                varNodoNuevo.ponerSiguiente(null);
                varNodoNuevo.ponerAnterior(null);
                atrLongitud--;
                return true;
            }
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
            if (EsValido(prmIndice))
            {
                if (prmIndice >= 0 && prmIndice < atrLongitud / 2)
                {
                    IrPrimero();
                    while (atrIndiceActual < prmIndice)
                        IrSiguiente();
                    return true;
                }
                if (prmIndice >= atrLongitud / 2 && prmIndice <= atrLongitud - 1)
                {
                    IrUltimo();
                    while (atrIndiceActual > prmIndice)
                        IrAnterior();
                    return true;
                }
            }
            return false;
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
        protected override bool Retroceder()
        {
            atrIndiceActual--;
            atrNodoActual = atrNodoActual.darAnterior();
            atrItemActual = atrNodoActual.darItem();
            return true;
        }
        protected override bool Avanzar()
        {
            atrIndiceActual++;
            atrNodoActual = atrNodoActual.darSiguiente();
            atrItemActual = atrNodoActual.darItem();
            return true;
        }
        protected override void PonerItemActual(Tipo prmItem) { atrNodoActual.ponerItem(prmItem); }
        #endregion
        #endregion
    }
}