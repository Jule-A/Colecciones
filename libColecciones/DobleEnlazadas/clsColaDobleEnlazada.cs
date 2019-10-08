using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.DobleEnlazadas
{
    public class clsColaDobleEnlazada<Tipo> : iCola<Tipo> where Tipo : IComparable
    {
        #region Métodos
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
    }
}
