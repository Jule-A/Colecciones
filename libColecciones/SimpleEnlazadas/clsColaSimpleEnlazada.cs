using System;
using Servicios.Colecciones.TADS;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.SimpleEnlazadas
{
    public class clsColaSimpleEnlazada<Tipo> : clsTADSimpleEnlazado<Tipo>, iCola<Tipo> where Tipo : IComparable
    {
        #region Métodos
        #region CRUDS
        public bool Encolar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool Desencolar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool Revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
