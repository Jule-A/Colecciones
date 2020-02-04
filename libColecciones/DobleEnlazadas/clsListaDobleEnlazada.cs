using System;
using Servicios.Colecciones.TADS;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.DobleEnlazadas
{
    public class clsListaDobleEnlazada<Tipo> : clsTADDobleEnlazado<Tipo>, iLista<Tipo> where Tipo : IComparable
    {
        #region Métodos
        #region CRUDS
        public bool Agregar(Tipo prmItem) { return InsertarEn(atrLongitud, prmItem); }
        public bool Insertar(int prmIndice, Tipo prmItem) { return InsertarEn(prmIndice, prmItem); }
        public bool Modificar(int prmIndice, Tipo prmItem) { return ModificarEn(prmIndice, prmItem); }
        public bool Remover(int prmIndice, ref Tipo prmItem) { return ExtraerEn(prmIndice, ref prmItem); }
        public bool Recuperar(int prmIndice, ref Tipo prmItem) { return RecuperarEn(prmIndice, ref prmItem); }
        public bool Reversar() { return ReversarNodos(); }
        #endregion
        #endregion
    }
}
