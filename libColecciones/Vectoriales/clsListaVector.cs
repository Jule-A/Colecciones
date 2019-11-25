using System;
using Servicios.Colecciones.TADS;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo> where Tipo : IComparable
    {
        #region Métodos
        #region Constructores
        public clsListaVector() { }
        public clsListaVector(int prmCapacidad) { }
        public clsListaVector(int prmCapacidad, int prmFactorDeCrecimiento) { }
        public clsListaVector(bool prmCapacidadFlexible) { }
        #endregion
        #region CRUDS
        public bool Agregar(Tipo prmItem)
        {
            return InsertarEn(atrLongitud, prmItem);
        }
        public bool Insertar(int prmIndice, Tipo prmItem)
        {
            return InsertarEn(prmIndice, prmItem);
        }
        public bool Modificar(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool Remover(int prmIndice, ref Tipo prmItem)
        {
            return ExtraerEn(prmIndice, ref prmItem);
        }
        public bool Revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool Recuperar(int prmIndice, ref Tipo prmItem) { return false; }
        public bool Reversar() { return false; }
        #endregion
        #endregion
    }
}
