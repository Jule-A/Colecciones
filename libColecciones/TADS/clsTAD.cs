using System;
using Servicios.Mensajería;
namespace Servicios.Colecciones.TADS
{
    public class clsTAD<Tipo> : clsMensajero where Tipo : IComparable
    {
        #region Atributos
        protected int atrLongitud;
        #endregion
        #region Metodos
        #region Auxiliares
        protected bool EsValido(int prmIndice) { return prmIndice >= 0 && prmIndice < atrLongitud; }
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
                PonerItemActual(prmItem);
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
        #region Atributos
        protected bool atrEstaOrdenadaDescendente;
        protected bool atrEstaOrdenadaAscendente;
        protected int atrNumeroComparaciones;
        protected int atrNumeroIntercambios;
        protected int atrNumeroInserciones;
        protected int atrNumeroLlamadosRecursivos;
        protected bool atrModoInteligente;
        #endregion
        #region Métodos
        #region Mutadores
        protected bool Ordenar(string prmMetodoOrdenamiento, bool prmOrdenDescendente)
        {
            if (!EstaVacia() && DebeOrdenar(prmOrdenDescendente))
            {
                try
                {
                    switch (prmMetodoOrdenamiento)
                    {
                        case "Burbuja Simple": BurbujaSimple(prmOrdenDescendente); break;
                        case "Burbuja Mejorado": BurbujaMejorado(prmOrdenDescendente); break;
                        case "Burbuja BiDireccional": BurbujaBiDireccional(prmOrdenDescendente); break;
                        case "Seleccion": Seleccion(prmOrdenDescendente); break;
                        case "QuickSort": QuickSort(prmOrdenDescendente, 0, atrLongitud - 1); break;
                        case "Insercion": Insercion(prmOrdenDescendente); break;
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
        protected virtual bool BurbujaSimple(bool prmOrdenDescendente) { return false; }
        protected virtual bool BurbujaMejorado(bool prmOrdenDescendente) { return false; }
        protected virtual bool BurbujaBiDireccional(bool prmOrdenDescendente) { return false; }
        protected virtual bool Seleccion(bool prmOrdenDescendente) { return false; }
        protected virtual bool QuickSort(bool prmOrdenDescendente, int prmIndiceInicial, int prmIndiceFinal) { return false; }
        protected virtual bool Insercion(bool prmOrdenDescendente) { return false; }
        protected virtual bool IntercambiarEntre(int prmIndice1, int prmIndice2) { return false; }
        public bool Reversar()
        {
            if (!EstaVacia())
            {
                int varTopeIzquierdo = 0;
                int varTopeDerecho = atrLongitud - 1;
                do
                {
                    IntercambiarEntre(varTopeIzquierdo, varTopeDerecho);
                    varTopeIzquierdo++;
                    varTopeDerecho--;
                } while (varTopeIzquierdo < varTopeDerecho);
                atrEstaOrdenadaAscendente = !atrEstaOrdenadaAscendente;
                atrEstaOrdenadaDescendente = !atrEstaOrdenadaDescendente;
            }
            return false;
        }
        #endregion
        #region Consultores
        protected bool DebeOrdenar(bool prmOrdenDescendente)
        {
            if (atrModoInteligente)
            {
                if (prmOrdenDescendente)
                    return !atrEstaOrdenadaDescendente;
                else
                    return !atrEstaOrdenadaAscendente;
            }
            return true;
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
        #endregion
        #endregion 
        #region Iterador
        #region Atributos
        protected int atrIndiceActual;
        protected Tipo atrItemActual;
        #endregion
        #region Métodos
        #region Mutadores
        protected virtual bool IrIndice(int prmIndice) { return false; }
        protected virtual void PonerItemActual(Tipo prmItem) { }
        protected virtual bool IrPrimero() { return false; }
        protected virtual bool IrUltimo() { return false; }
        protected virtual bool Retroceder() { return false; }
        protected virtual bool Avanzar() { return false; }
        protected bool IrAnterior()
        {
            if (ExisteAnterior())
                return Retroceder();
            return false;
        }
        protected bool IrSiguiente()
        {
            if (ExisteSiguiente())
                return Avanzar();
            return false;
        }
        #endregion
        #region Consultores
        protected bool ExisteAnterior() { return !EstaVacia() && atrIndiceActual > 0; }
        protected bool ExisteSiguiente() { return !EstaVacia() && atrIndiceActual < atrLongitud - 1; }
        #endregion
        #endregion
        #endregion
        #endregion
    }
}
