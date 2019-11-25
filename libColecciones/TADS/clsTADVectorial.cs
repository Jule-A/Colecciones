using System;

namespace Servicios.Colecciones.TADS
{
    public class clsTADVectorial<Tipo> : clsTAD<Tipo> where Tipo : IComparable
    {
        #region Atributos
        protected Tipo[] atrVectorDeItems;// = new Tipo[int.MaxValue/16];
        private bool atrCapacidadFlexible = true;
        private int atrCapacidad;// = int.MaxValue/16;
        private int atrFactorDeCrecimiento = 1;
        private bool atrOrdenDescendente = true;
        private int atrNumeroComparaciones;
        private int atrNumeroIntercambios;
        private int atrNumeroInserciones;
        private int atrNumeroLlamadosRecursivos;
        private bool atrModoInteligente;
        #endregion
        #region Metodos
        #region Auxiliares
        public bool estaLlena()
        {
            return atrCapacidad == atrLongitud;
        }
        private bool DesplazarItems(bool prmHaciaDerecha, int prmIndice)
        {
            if (estaLlena() && prmHaciaDerecha && atrCapacidadFlexible)
            {
                Tipo[] varVectorAuxiliar = new Tipo[atrCapacidad + atrFactorDeCrecimiento];
                atrCapacidad += atrFactorDeCrecimiento;
                int varIndice2 = 0;
                for (int varIndice1 = 0; varIndice1 < prmIndice; varIndice1++)
                {
                    if (varIndice1 != prmIndice)
                    {
                        varVectorAuxiliar[varIndice1] = atrVectorDeItems[varIndice2];
                        varIndice2++;
                    }
                    else
                    {
                        varIndice2--;
                    }
                    atrVectorDeItems = varVectorAuxiliar;
                }
            }

            if (!estaLlena() && prmHaciaDerecha)
                for (int varIndice = atrLongitud - 1; varIndice >= prmIndice; varIndice--)
                    atrVectorDeItems[varIndice + 1] = atrVectorDeItems[varIndice];

            if (!prmHaciaDerecha)
                for (int varIndice = prmIndice; varIndice < atrLongitud; varIndice++)
                    atrVectorDeItems[varIndice] = atrVectorDeItems[varIndice + 1];
            return true;
        }

        #endregion
        #region CRUDS - Query
        protected override bool InsertarEn(int prmIndice, Tipo prmItem)
        {
            if (EsValido(prmIndice))
            {
                if (DesplazarItems(true, prmIndice))
                {
                    atrVectorDeItems[prmIndice] = prmItem;
                    atrLongitud += 1;
                    return true;
                }
            }
            return false;
        }
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            if (EsValido(prmIndice))
            {
                prmItem = atrVectorDeItems[prmIndice];
                DesplazarItems(false, prmIndice);
                atrLongitud--;
                return true;
            }
            return false;
        }
        protected override bool ModificarEn(int prmIndice, Tipo prmItem)
        {
            if (EsValido(prmIndice))
            {
                atrVectorDeItems[prmIndice] = prmItem;
                return true;
            }
            return false;
        }
        protected override bool RecuperarEn(int prmIndice, ref Tipo prmItem)
        {
            if (EsValido(prmIndice))
            {
                prmItem = atrVectorDeItems[prmIndice];
                return true;
            }
            return false;
        }
        #endregion
        #region Ordenamiento
        public bool OrdenarBurbujaSimple(bool prmOrdenDescendente) { return false; }
        public bool OrdenarBurbujaMejorado(bool prmOrdenDescendente) { return false; }
        public bool OrdenarBurbujaBiDireccional(bool prmOrdenDescendente) { return false; }
        public bool OrdenarSeleccion(bool prmOrdenDescendente) { return false; }
        public bool OrdenarQuickSort(bool prmOrdenDescendente) { return false; }
        public bool OrdenarInsercion(bool prmOrdenDescendente) { return false; }
        #endregion
        #region Accesores
        public int darCapacidad() { return atrCapacidad; }
        public Tipo[] darVectorItems() { return atrVectorDeItems; }
        public bool darCapacidadFlexible() { return atrCapacidadFlexible; }
        public int darFactorDeCrecimiento() { return atrFactorDeCrecimiento; }
        public bool darEstaOrdenadaDescendente() { return atrOrdenDescendente == true; }
        public bool darEstaOrdenadaAscendente() { return atrOrdenDescendente == false; }
        public int darNumeroComparaciones() { return atrNumeroComparaciones; }
        public int darNumeroIntercambios() { return atrNumeroIntercambios; }
        public int darNumeroInserciones() { return atrNumeroInserciones; }
        public int darNumeroLlamadosRecursivos() { return atrNumeroLlamadosRecursivos; }
        #endregion
        #region Mutadores
        public bool AjustarOrdenColeccion(String prmNuevoOrden) { return false; }
        public void ponerModoInteligente(bool prmModoInteligente) { atrModoInteligente = prmModoInteligente; }
        #endregion
        #endregion
    }
}
