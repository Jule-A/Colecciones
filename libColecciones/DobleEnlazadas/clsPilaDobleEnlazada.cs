using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.TADS;
using System;

namespace Servicios.Colecciones.DobleEnlazadas
{
    public class clsPilaDobleEnlazada<Tipo> : clsTADDobleEnlazado<Tipo>, iPila<Tipo> where Tipo : IComparable
    {
        #region Métodos
        public bool Apilar(Tipo prmItem)
        {
            return InsertarEn(0, prmItem);
        }

        public bool Desapilar(ref Tipo prmItem)
        {
            return ExtraerEn(0, prmItem);
        }

        public bool Revisar(ref Tipo prmItem)
        {
            return RecuperarEn(0, ref prmItem);
        }
        #endregion
    }
}
