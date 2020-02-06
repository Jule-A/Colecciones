using System;

namespace Servicios.Colecciones.TADS
{
    public class clsTAD<Tipo> where Tipo : IComparable
    {
        #region Atributos
        protected int atrLongitud;
        protected bool atrEstaOrdenadaDescendente;
        protected bool atrEstaOrdenadaAscendente;
        protected int atrNumeroComparaciones;
        protected int atrNumeroIntercambios;
        protected int atrNumeroInserciones;
        protected int atrNumeroLlamadosRecursivos;
        protected bool atrModoInteligente;
        #endregion
        #region Metodos
        #region Auxiliares
        protected bool EsValido(int prmIndice){ return prmIndice >= 0 && prmIndice < atrLongitud; }
        protected bool EstaVacia() { return atrLongitud == 0; }
        public int darLongitud() { return atrLongitud; }
        #endregion
        #region CRUDS - Query
        protected virtual bool InsertarEn(int prmIndice, Tipo prmItem) { return false; }
        protected virtual bool ExtraerEn(int prmIndice, ref Tipo prmItem) { return false; }
        protected bool ModificarEn(int prmIndice, Tipo prmItem)
        {
            if (IrIndice(prmIndice))
            {
                atrItemActual = prmItem;
                PonerItemActual();
                return true;
            }
            return false;
        }
        protected bool RecuperarEn(int prmIndice, ref Tipo prmItem)
        {
            if (IrIndice(prmIndice))
            {
                prmItem = atrItemActual;
                return true;
            }
            return false;
        }
        public bool Encontrar(Tipo prmItem, ref int prmIndice) { return false; }
        public bool Existe(Tipo prmItem) { return false; }
        #endregion
        #region Ordenamiento
        protected bool Ordenar(string prmMetodoOrdenamiento, bool prmOrdenDescendente)
        {
            if (!EstaVacia() && DebeOrdenar(prmOrdenDescendente))
            {
                try
                {
                    switch (prmMetodoOrdenamiento)
                    {
                        case "Burbuja Simple": MetodoBurbujaSimple(prmOrdenDescendente); break;
                        case "Burbuja Mejorado": MetodoBurbujaMejorado(prmOrdenDescendente); break;
                        case "Burbuja BiDireccional": MetodoBurbujaBiDireccional(prmOrdenDescendente); break;
                        case "Seleccion": MetodoSeleccion(prmOrdenDescendente); break;
                        case "QuickSort": MetodoQuickSort(prmOrdenDescendente); break;
                        case "Insercion": MetodoInsercion(prmOrdenDescendente); break;
                        default: return false;
                    }

                    if (prmOrdenDescendente)
                        AjustarOrdenColeccion("Descendente");
                    else
                        AjustarOrdenColeccion("Ascendente");
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
                return false;
        }
        protected virtual bool MetodoBurbujaSimple(bool prmOrdenDescendente) { return false; }
        protected virtual bool MetodoBurbujaMejorado(bool prmOrdenDescendente) { return false; }
        protected virtual bool MetodoBurbujaBiDireccional(bool prmOrdenDescendente) { return false; }
        protected virtual bool MetodoSeleccion(bool prmOrdenDescendente) { return false; }
        protected virtual bool MetodoQuickSort(bool prmOrdenDescendente) { return false; }
        protected virtual bool MetodoInsercion(bool prmOrdenDescendente) { return false; }
        #region Auxiliares-Consultores
        protected bool DebeOrdenar(bool prmOrdenDescendente)
        {
            switch (prmOrdenDescendente)
            {
                case true:
                    if (atrEstaOrdenadaDescendente == true)
                        return false;
                    else
                        return true;
                case false:
                    if (atrEstaOrdenadaAscendente == true)
                        return false;
                    else
                        return true;
            }
            return false;
        }
        public bool AjustarOrdenColeccion(string prmCriterio)
        {
            switch (prmCriterio)
            {
                case "Ascendente":
                    atrEstaOrdenadaAscendente = true; atrEstaOrdenadaDescendente = false;
                    return true;
                case "Descendente":
                    atrEstaOrdenadaAscendente = false; atrEstaOrdenadaDescendente = true;
                    return true;
                case "Aleatorio":
                    atrEstaOrdenadaAscendente = false; atrEstaOrdenadaDescendente = false;
                    return true;
                case "Constante":
                    atrEstaOrdenadaAscendente = true; atrEstaOrdenadaDescendente = true;
                    return true;
                default:
                    return false;
            }
        }
        public void ponerModoInteligente(bool prmModoInteligente) { atrModoInteligente = prmModoInteligente; }
        #endregion
        #region  Fachada
        public bool OrdenarBurbujaSimple(bool prmOrdenDescendente) { return Ordenar("Burbuja Simple", prmOrdenDescendente); }
        public bool OrdenarBurbujaMejorado(bool prmOrdenDescendente) { return Ordenar("Burbuja Mejorado", prmOrdenDescendente); }
        public bool OrdenarBurbujaBiDireccional(bool prmOrdenDescendente) { return Ordenar("Burbuja BiDireccional", prmOrdenDescendente); }
        public bool OrdenarSeleccion(bool prmOrdenDescendente) { return Ordenar("Seleccion", prmOrdenDescendente); }
        public bool OrdenarQuickSort(bool prmOrdenDescendente) { return Ordenar("QuickSort", prmOrdenDescendente); }
        public bool OrdenarInsercion(bool prmOrdenDescendente) { return Ordenar("Insercion", prmOrdenDescendente); }
        #endregion
        #region Accesores
        public bool darEstaOrdenadaDescendente() { return atrEstaOrdenadaDescendente; }
        public bool darEstaOrdenadaAscendente() { return atrEstaOrdenadaAscendente; ; }
        public int darNumeroComparaciones() { return atrNumeroComparaciones; }
        public int darNumeroIntercambios() { return atrNumeroIntercambios; }
        public int darNumeroInserciones() { return atrNumeroInserciones; }
        public int darNumeroLlamadosRecursivos() { return atrNumeroLlamadosRecursivos; }
        #endregion
        #endregion}
        #region Iterador
        #region Atributos
        protected int atrIndiceActual;
        protected Tipo atrItemActual;
        #endregion
        #region Métodos
        protected virtual bool IrIndice(int prmIndice) { return false; }
        protected virtual void PonerItemActual() { }
        protected bool IrPrimero()
        {
            return IrIndice(0);
        }
        protected bool IrUltimo()
        {
            return IrIndice(atrLongitud - 1);
        }
        protected bool IrAnterior()
        {
            if (ExisteAnterior())
                return IrIndice(atrIndiceActual-1);
            return false;
        }
        protected bool IrSiguiente()
        {
            if (ExisteSiguiente())
                return IrIndice(atrIndiceActual+1);
            return false;
        }
        protected bool ExisteAnterior() { return !EstaVacia() && atrIndiceActual > 0; }
        protected bool ExisteSiguiente() { return !EstaVacia() && atrIndiceActual < atrLongitud; }

        #endregion
        #endregion
        #endregion
    }
}
