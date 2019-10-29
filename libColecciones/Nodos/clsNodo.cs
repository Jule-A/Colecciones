using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodo<Tipo> where Tipo: IComparable
    {
        #region Atributos
        private Tipo atrItem;
        #endregion
        #region Metodos
        #region Constructores
        public clsNodo(Tipo prmItem) { atrItem = prmItem; }
        #endregion
        public Tipo darItem() { return atrItem; }
        public void ponerItem(Tipo prmItem) { atrItem=prmItem; }
        #endregion
    }
}
