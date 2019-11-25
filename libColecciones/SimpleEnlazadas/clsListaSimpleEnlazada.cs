using System;
using Servicios.Colecciones.TADS;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.SimpleEnlazadas
{
    public class clsListaSimpleEnlazada<Tipo> : clsTADSimpleEnlazado<Tipo>, iLista<Tipo> where Tipo : IComparable
    {
        #region Métodos
        #region CRUDS
        public bool Agregar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool Insertar(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool Modificar(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool Remover(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
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
