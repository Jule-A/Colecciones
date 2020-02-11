using System;

namespace Servicios.Colecciones.TADS
{
    public class clsTADVectorial<Tipo> : clsTAD<Tipo> where Tipo : IComparable
    {
        #region Atributos
        protected Tipo[] atrVectorDeItems;
        private bool atrCapacidadFlexible;
        private int atrCapacidad;
        private int atrFactorDeCrecimiento;
        #endregion
        #region Metodos
        #region Constructores
        public clsTADVectorial()
        {
            atrCapacidad = 100;
            atrVectorDeItems = new Tipo[atrCapacidad];
        }
        public clsTADVectorial(int prmCapacidad)
        {
            ValidarCapacidad(prmCapacidad);
        }
        public clsTADVectorial(int prmCapacidad, int prmFactorDeCrecimiento)
        {
            ValidarCapacidad(prmCapacidad);
            atrCapacidadFlexible = true;
            if (prmFactorDeCrecimiento <= 0 ||
                prmFactorDeCrecimiento >= (int.MaxValue / 16))
                atrFactorDeCrecimiento = 1;
            else
                atrFactorDeCrecimiento = prmFactorDeCrecimiento;
        }
        public clsTADVectorial(bool prmCapacidadFlexible)
        {
            atrCapacidad = 100;
            atrVectorDeItems = new Tipo[atrCapacidad];
            atrCapacidadFlexible = prmCapacidadFlexible;
            if (prmCapacidadFlexible)
                atrFactorDeCrecimiento = 1;
            else
                atrFactorDeCrecimiento = 0;
        }
        public clsTADVectorial(int prmCapacidad, bool prmCapacidadFlexible, bool prmOrdenDescendente, bool prmModoInteligente)
        {
            ValidarCapacidad(prmCapacidad);
            atrCapacidadFlexible = prmCapacidadFlexible;
            if(prmCapacidadFlexible)
                atrFactorDeCrecimiento = 1;
            else
                atrFactorDeCrecimiento = 0;
            if (prmOrdenDescendente)
            {
                atrEstaOrdenadaAscendente = false;
                atrEstaOrdenadaDescendente = true;
            }
            else
            {
                atrEstaOrdenadaAscendente = true;
                atrEstaOrdenadaDescendente = false;
            }
            atrModoInteligente = prmModoInteligente;
        }
        #endregion
        #region Auxiliares
        private void ValidarCapacidad(int prmCapacidad)
        {
            if (prmCapacidad <= 0)
            {
                atrCapacidad = 100;
                atrVectorDeItems = new Tipo[atrCapacidad];
            }
            else
            {
                if (prmCapacidad >= (int.MaxValue / 16))
                {
                    atrCapacidad = 0;
                    atrCapacidadFlexible = true;
                    atrFactorDeCrecimiento = 1;
                }
                else
                {
                    atrCapacidad = prmCapacidad;
                    atrVectorDeItems = new Tipo[atrCapacidad];
                }
            }
        }
        public bool estaLlena() { return atrCapacidad == atrLongitud; }
        private bool DesplazarItems(bool prmHaciaDerecha, int prmIndice)
        {
            if (estaLlena() && prmHaciaDerecha && atrCapacidadFlexible)
            {
                Tipo[] varVectorAuxiliar = new Tipo[atrCapacidad + atrFactorDeCrecimiento];
                int varIndice2 = 0;
                for (int varIndice1 = 0; varIndice1 <= atrLongitud; varIndice1++)
                {
                    if (varIndice1 != prmIndice)
                    {
                        varVectorAuxiliar[varIndice1] = atrVectorDeItems[varIndice2];
                        varIndice2++;
                    }
                }
                atrCapacidad += atrFactorDeCrecimiento;
                atrVectorDeItems = varVectorAuxiliar;
                return true;
            }
            if (!estaLlena() && prmHaciaDerecha)
            {
                for (int varIndice = atrLongitud - 1; varIndice >= prmIndice; varIndice--)
                    atrVectorDeItems[varIndice + 1] = atrVectorDeItems[varIndice];
                return true;
            }
            if (!prmHaciaDerecha)
            {
                for (int varIndice = prmIndice; varIndice < atrLongitud-1; varIndice++)
                    atrVectorDeItems[varIndice] = atrVectorDeItems[varIndice + 1];
                return true;
            }
            return false;
        }
        protected bool AbrirEspacioNuevo(int prmIndice)
        {
            if (prmIndice == atrLongitud && atrLongitud < atrCapacidad)
                return true;
            if (EsValido(prmIndice) || prmIndice == atrLongitud)
                return DesplazarItems(true, prmIndice);
            return false;
        }
        #endregion
        #region CRUDS - Query
        protected override bool InsertarEn(int prmIndice, Tipo prmItem)
        {
            if (prmIndice==atrLongitud && atrLongitud < atrCapacidad)
            {
                atrVectorDeItems[prmIndice] = prmItem;
                atrLongitud++;
                return true;
            }
            if ((EsValido(prmIndice) || prmIndice==atrLongitud) && (DesplazarItems(true, prmIndice)))
            {
                atrVectorDeItems[prmIndice] = prmItem;
                atrLongitud++;
                return true;
            }
            return false;
        }
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            if (!EstaVacia() && EsValido(prmIndice))
            {
                prmItem = atrVectorDeItems[prmIndice];
                DesplazarItems(false, prmIndice);
                atrLongitud--;
                return true;
            }
            return false;
        }
        #endregion
        #region Accesores
        public int darCapacidad() { return atrCapacidad; }
        public Tipo[] darVectorItems() { return atrVectorDeItems; }
        public bool darCapacidadFlexible() { return atrCapacidadFlexible; }
        public int darFactorDeCrecimiento() { return atrFactorDeCrecimiento; }
        #endregion
        #region Ordenamiento
        #region Auxiliares Ordenamiento
        private void CambiarItemsDelVector(int prmPrimerIndice, int prmSegundoIndice)
        {
            Tipo varItemTemp = atrVectorDeItems[prmPrimerIndice];
            atrVectorDeItems[prmPrimerIndice] = atrVectorDeItems[prmSegundoIndice];
            atrVectorDeItems[prmSegundoIndice] = varItemTemp;
            atrNumeroIntercambios++;
        }
        private bool CompararItems(bool prmOrdenDescendente, int prmPrimerIndice, int prmSegundoIndice)
        {
            atrNumeroComparaciones++;
            if (prmOrdenDescendente)
            {
                if (atrVectorDeItems[prmPrimerIndice].CompareTo(atrVectorDeItems[prmSegundoIndice]) < 0)
                    return true;
                else
                    return false;
            }
            else
            {
                if (atrVectorDeItems[prmPrimerIndice].CompareTo(atrVectorDeItems[prmSegundoIndice]) > 0)
                    return true;
                else
                    return false;
            }
        }
        #endregion
        protected override bool MetodoBurbujaSimple(bool prmOrdenDescendente)
        {
            try
            {
                for (int i = 0; i < atrLongitud - 1; i++)
                {
                    for (int j = 0; j < atrLongitud - i - 1; j++)
                    {
                        if (CompararItems(prmOrdenDescendente, j, (j + 1)))
                            CambiarItemsDelVector(j, (j + 1));
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        protected override bool MetodoBurbujaMejorado(bool prmOrdenDescendente)
        {
            try
            {
                bool varIntercambioRealizado;
                for (int i = 0; i < atrLongitud - 1; i++)
                {
                    varIntercambioRealizado = false;
                    for (int j = 0; j < atrLongitud - i - 1; j++)
                    {
                        if (CompararItems(prmOrdenDescendente, j, (j + 1)))
                        {
                            CambiarItemsDelVector(j, (j + 1));
                            varIntercambioRealizado = true;
                        }
                    }
                    if (!varIntercambioRealizado)
                        return true;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        protected override bool MetodoBurbujaBiDireccional(bool prmOrdenDescendente)
        {
            try
            {
                bool varIntercambioRealizado = true;
                while (varIntercambioRealizado)
                {
                    varIntercambioRealizado = false;
                    for (int j = 0; j < atrLongitud - 1; j++)
                    {
                        if (CompararItems(prmOrdenDescendente, j, (j + 1)))
                        {
                            CambiarItemsDelVector(j, (j + 1));
                            varIntercambioRealizado = true;
                        }
                    } 
                    if (!varIntercambioRealizado)
                        return true;
                    varIntercambioRealizado = false;
                    for (int j = atrLongitud - 2; j >= 0; j--)
                    {
                        if (CompararItems(prmOrdenDescendente, j, (j + 1)))
                        {
                            CambiarItemsDelVector(j, (j + 1));
                            varIntercambioRealizado = true;
                        }
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        protected override bool MetodoSeleccion(bool prmOrdenDescendente) { return false; }
        protected override bool MetodoQuickSort(bool prmOrdenDescendente) { return false; }
        protected override bool MetodoInsercion(bool prmOrdenDescendente) { return false; }
        protected bool ReversarVector()
        {
            try
            {
                if (!EstaVacia())
                {
                    Tipo[] varVectorAuxiliar = new Tipo[atrCapacidad];
                    int varIndice2 = atrLongitud - 1;
                    for (int varIndice1 = 0; varIndice1 < atrLongitud; varIndice1++)
                    {
                        varVectorAuxiliar[varIndice1] = atrVectorDeItems[varIndice2];
                        varIndice2--;
                    }
                    atrVectorDeItems = varVectorAuxiliar;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion
        #region Iterador
        protected override bool IrIndice(int prmIndice)
        {
            if (!EstaVacia() && EsValido(prmIndice))
            {
                atrIndiceActual = prmIndice;
                atrItemActual = atrVectorDeItems[atrIndiceActual];
                return true;
            }
            return false;
        }
        protected override void PonerItemActual(){atrVectorDeItems[atrIndiceActual] = atrItemActual;}
        #endregion
        #endregion
    }
}
