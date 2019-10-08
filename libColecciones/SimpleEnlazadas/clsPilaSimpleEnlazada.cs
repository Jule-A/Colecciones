using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.TADS;

namespace Servicios.Colecciones.SimpleEnlazadas
{
    public class clsPilaSimpleEnlazada<Tipo> : clsTADSimpleEnlazado<Tipo>, iPila<Tipo> where Tipo : IComparable
    {
        #region Métodos
        public bool Apilar(Tipo prmItem)
        {
            return InsertarEn(0, prmItem);
        }

        public bool Desapilar(ref Tipo prmItem)
        {
            return ExtraerEn(0, ref prmItem);
        }

        public bool Revisar(ref Tipo prmItem)
        {
            return RecuperarEn(0, ref prmItem);
        }
        #endregion
    }
}
