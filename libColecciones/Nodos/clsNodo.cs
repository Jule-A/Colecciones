using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodo<Tipo> where Tipo: IComparable
    {
        private Tipo atrItem;

        public Tipo darItem() { return atrItem; }
        public void ponerItem(Tipo prmItem) { atrItem=prmItem; }
    }
}
