using System;
using Servicios.Colecciones.TADS;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo> where Tipo : IComparable
    {
        #region Métodos
        public bool Agregar(Tipo prmItem)
        {
            return InsertarEn(atrLongitud, prmItem);
        }
        public bool Insertar(Tipo prmItem, int prmIndice)
        {
            return InsertarEn(prmIndice, prmItem);
        }
        public bool Modificar(ref Tipo prmItem, int prmIndice)
        {
            throw new NotImplementedException();
        }
        public bool Remover(ref Tipo prmItem, int prmIndice)
        {
            return ExtraerEn(prmIndice, ref prmItem);
        }
        public bool Revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
