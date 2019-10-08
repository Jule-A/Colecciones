using System;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.TADS
{
    public class clsTADSimpleEnlazado<Tipo>:clsTAD<Tipo> where Tipo: IComparable
    {
        #region Atributos
        private clsNodoSimpleEnlazado<Tipo> atrNodoPrimero;
        private clsNodoSimpleEnlazado<Tipo> atrNodoUltimo;
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
