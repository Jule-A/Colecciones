using System;
using Servicios.Colecciones.TADS;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.DobleEnlazadas
{
    public class clsPilaDobleEnlazada<Tipo> : clsTADDobleEnlazado<Tipo>, iPila<Tipo> where Tipo : IComparable
    {
        #region Métodos
        #region CRUDS
        public bool Apilar(Tipo prmItem) { return InsertarEn(0, prmItem); }
        public bool Desapilar(ref Tipo prmItem) { return ExtraerEn(0, ref prmItem); }
        public bool Revisar(ref Tipo prmItem) { return RecuperarEn(0, ref prmItem); }
        #endregion
        #endregion
    }
}
