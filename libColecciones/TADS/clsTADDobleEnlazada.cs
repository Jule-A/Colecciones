using System;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.TADS
{
    public class clsTADDobleEnlazado<Tipo> : clsTAD<Tipo> where Tipo : IComparable
    {
        #region Atributos
        private clsNodoDobleEnlazado<Tipo> atrNodoPrimero;
        private clsNodoDobleEnlazado<Tipo> atrNodoUltimo;
        #endregion
        #region CRUDS
        protected override bool InsertarEn(int prmIndice, Tipo prmItem)
        {
            return false;
        }
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        protected override bool ModificarEn(int prmIndice, Tipo prmItem)
        {
            return false;
        }
        protected override bool RecuperarEn(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        #endregion
    }
}