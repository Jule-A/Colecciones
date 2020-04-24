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
            if (prmCapacidadFlexible)
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
                for (int varIndice = prmIndice; varIndice < atrLongitud - 1; varIndice++)
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
            if (prmIndice == atrLongitud && atrLongitud < atrCapacidad)
            {
                atrVectorDeItems[prmIndice] = prmItem;
                atrLongitud++;
                return true;
            }
            if ((EsValido(prmIndice) || prmIndice == atrLongitud) && (DesplazarItems(true, prmIndice)))
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
        protected override bool BurbujaSimple(bool prmOrdenDescendente)
        {
            try
            {
                for (int i = 0; i < atrLongitud - 1; i++)
                {
                    for (int j = 0; j < atrLongitud - i - 1; j++)
                    {
                        int varResultadoComparar = atrVectorDeItems[j].CompareTo(atrVectorDeItems[j + 1]);
                        atrNumeroComparaciones++;
                        if (varResultadoComparar != 0 && (prmOrdenDescendente ^ varResultadoComparar > 0))
                        {
                            Tipo varItemTemp = atrVectorDeItems[j];
                            atrVectorDeItems[j] = atrVectorDeItems[j + 1];
                            atrVectorDeItems[j + 1] = varItemTemp;
                            atrNumeroIntercambios++;
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
        protected override bool BurbujaMejorado(bool prmOrdenDescendente)
        {
            try
            {
                bool varIntercambioRealizado;
                for (int i = 0; i < atrLongitud - 1; i++)
                {
                    varIntercambioRealizado = false;
                    for (int j = 0; j < atrLongitud - i - 1; j++)
                    {
                        int varResultadoComparar = atrVectorDeItems[j].CompareTo(atrVectorDeItems[j + 1]);
                        atrNumeroComparaciones++;
                        if (varResultadoComparar != 0 && (prmOrdenDescendente ^ varResultadoComparar > 0))
                        {
                            Tipo varItemTemp = atrVectorDeItems[j];
                            atrVectorDeItems[j] = atrVectorDeItems[j + 1];
                            atrVectorDeItems[j + 1] = varItemTemp;
                            atrNumeroIntercambios++;
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
        protected override bool BurbujaBiDireccional(bool prmOrdenDescendente)
        {
            try
            {
                bool varIntercambioRealizado = true;
                while (varIntercambioRealizado)
                {
                    varIntercambioRealizado = false;
                    for (int j = 0; j < atrLongitud - 1; j++)
                    {
                        int varResultadoComparar = atrVectorDeItems[j].CompareTo(atrVectorDeItems[j + 1]);
                        atrNumeroComparaciones++;
                        if (varResultadoComparar != 0 && (prmOrdenDescendente ^ varResultadoComparar > 0))
                        {
                            Tipo varItemTemp = atrVectorDeItems[j];
                            atrVectorDeItems[j] = atrVectorDeItems[j + 1];
                            atrVectorDeItems[j + 1] = varItemTemp;
                            atrNumeroIntercambios++;
                            varIntercambioRealizado = true;
                        }
                    }
                    if (!varIntercambioRealizado)
                        return true;
                    varIntercambioRealizado = false;
                    for (int j = atrLongitud - 2; j >= 0; j--)
                    {
                        int varResultadoComparar = atrVectorDeItems[j].CompareTo(atrVectorDeItems[j + 1]);
                        atrNumeroComparaciones++;
                        if (varResultadoComparar != 0 && (prmOrdenDescendente ^ varResultadoComparar > 0))
                        {
                            Tipo varItemTemp = atrVectorDeItems[j];
                            atrVectorDeItems[j] = atrVectorDeItems[j + 1];
                            atrVectorDeItems[j + 1] = varItemTemp;
                            atrNumeroIntercambios++;
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
        protected override bool Seleccion(bool prmOrdenDescendente)
        {
            try
            {
                int varPosExterior, varPosInterior, varPosDelMinimo;
                Tipo varElementoTemporal;

                for (varPosExterior = 0; varPosExterior < atrLongitud - 1; varPosExterior++)
                {
                    varPosDelMinimo = varPosExterior;
                    for (varPosInterior = varPosExterior + 1; varPosInterior < atrLongitud; varPosInterior++)
                    {
                        atrNumeroComparaciones++;
                        if (prmOrdenDescendente ^ atrVectorDeItems[varPosDelMinimo].CompareTo(atrVectorDeItems[varPosInterior]) > 0)
                        {
                            varPosDelMinimo = varPosInterior;
                        }
                    }
                    if (varPosDelMinimo != varPosExterior)
                    {
                        varElementoTemporal = atrVectorDeItems[varPosDelMinimo];
                        atrVectorDeItems[varPosDelMinimo] = atrVectorDeItems[varPosExterior];
                        atrVectorDeItems[varPosExterior] = varElementoTemporal;
                        atrNumeroIntercambios++;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override bool QuickSort(bool prmOrdenDescendente, int prmIndiceInicial, int prmIndiceFinal)
        {
            try
            {
                Tipo varPivote = atrVectorDeItems[(prmIndiceInicial + prmIndiceFinal) / 2];
                int varPosIzquierdo = prmIndiceInicial;
                int varPosDerecho = prmIndiceFinal;
                Tipo varAuxiliar;
                while ((varPosIzquierdo <= varPosDerecho) && (prmIndiceFinal - prmIndiceInicial > 0))
                {
                    while ((prmOrdenDescendente ^ atrVectorDeItems[varPosIzquierdo].CompareTo(varPivote) < 0) && atrVectorDeItems[varPosIzquierdo].CompareTo(varPivote) != 0)
                    {
                        varPosIzquierdo++;
                        atrNumeroComparaciones++;
                    }
                    atrNumeroComparaciones++;
                    while ((prmOrdenDescendente ^ atrVectorDeItems[varPosDerecho].CompareTo(varPivote) > 0) && atrVectorDeItems[varPosDerecho].CompareTo(varPivote) != 0)
                    {
                        varPosDerecho--;
                        atrNumeroComparaciones++;
                    }
                    atrNumeroComparaciones++;
                    if ((varPosIzquierdo <= varPosDerecho))
                    {
                        varAuxiliar = atrVectorDeItems[varPosIzquierdo];
                        atrVectorDeItems[varPosIzquierdo] = atrVectorDeItems[varPosDerecho];
                        atrVectorDeItems[varPosDerecho] = varAuxiliar;
                        atrNumeroIntercambios++;
                        varPosIzquierdo++;
                        varPosDerecho--;
                    }
                }
                if ((prmIndiceInicial < varPosDerecho))
                {
                    QuickSort(prmOrdenDescendente, prmIndiceInicial, varPosDerecho);
                    atrNumeroLlamadosRecursivos++;
                }
                if ((varPosIzquierdo < prmIndiceFinal))
                {
                    QuickSort(prmOrdenDescendente, varPosIzquierdo, prmIndiceFinal);
                    atrNumeroLlamadosRecursivos++;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override bool Insercion(bool prmOrdenDescendente)
        {
            try
            {
                int varCicloExterior;
                int varCicloInterior;
                Tipo varObjetoInsertado;
                for (varCicloExterior = 1; varCicloExterior < atrLongitud; varCicloExterior++)
                {
                    varObjetoInsertado = atrVectorDeItems[varCicloExterior];
                    varCicloInterior = varCicloExterior - 1;
                    while ((varCicloInterior >= 0) && (atrVectorDeItems[varCicloInterior].CompareTo(varObjetoInsertado) != 0 && (prmOrdenDescendente ^ atrVectorDeItems[varCicloInterior].CompareTo(varObjetoInsertado) > 0)))
                    {
                        atrNumeroComparaciones++;
                        atrVectorDeItems[varCicloInterior + 1] = atrVectorDeItems[varCicloInterior];
                        varCicloInterior = varCicloInterior - 1;
                    }
                    atrVectorDeItems[varCicloInterior + 1] = varObjetoInsertado;
                    atrNumeroComparaciones++;
                    atrNumeroInserciones++;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override bool IntercambiarEntre(int prmIndice1, int prmIndice2)
        {
            if (EsValido(prmIndice1) && EsValido(prmIndice2))
            {
                if (prmIndice1 != prmIndice2)
                {
                    Tipo varItemIndice1 = atrVectorDeItems[prmIndice1];
                    atrVectorDeItems[prmIndice1] = atrVectorDeItems[prmIndice2];
                    atrVectorDeItems[prmIndice2] = varItemIndice1;
                    return true;
                }
            }
            return false;
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
        protected override void PonerItemActual(Tipo prmItem) { atrVectorDeItems[atrIndiceActual] = prmItem; }
        #endregion
        #endregion
    }
}
