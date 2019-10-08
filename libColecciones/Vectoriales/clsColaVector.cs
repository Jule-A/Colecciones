using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.TADS;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsColaVector<Tipo> : clsTADVectorial<Tipo>, iCola<Tipo> where Tipo : IComparable
    {
        #region Métodos
        public bool Encolar(Tipo prmItem) {return InsertarEn(atrLongitud, prmItem);}

        public bool Desencolar(ref Tipo prmItem) { return ExtraerEn(0, ref prmItem); }

        public bool Revisar(ref Tipo prmItem) { return RecuperarEn(0, ref prmItem); }
        #endregion
    }
}
