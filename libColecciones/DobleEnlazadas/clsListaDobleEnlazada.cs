using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.SimpleEnlazadas
{
    public class clsListaDobleEnlazada<Tipo> : iLista<Tipo> where Tipo : IComparable
    {
        #region Métodos
        public bool Agregar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Tipo prmItem, int prmIndice)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(ref Tipo prmItem, int prmIndice)
        {
            throw new NotImplementedException();
        }

        public bool Remover(ref Tipo prmItem, int prmIndice)
        {
            throw new NotImplementedException();
        }

        public bool Revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
