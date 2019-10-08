using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.TADS
{
    public class clsTAD<Tipo> where Tipo : IComparable
    {
        protected int atrLongitud = int.MaxValue/16;
        protected virtual bool InsertarEn(int prmIndice, Tipo prmItem) { return false; }
        protected virtual bool ExtraerEn(int prmIndice, ref Tipo prmItem) { return false; }
        protected virtual bool ModificarEn(int prmIndice, Tipo prmItem) { return false; }
        protected virtual bool RecuperarEn(int prmIndice, ref Tipo prmItem) { return false; }
        public bool Encontrar(Tipo prmItem, ref int prmIndice) { return false; }
        public bool Existe(Tipo prmItem) { return false; }
    }
}
