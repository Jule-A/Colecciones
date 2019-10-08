using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    interface iLista<Tipo> where Tipo : IComparable
    {
        bool Agregar(Tipo prmItem);
        bool Insertar(Tipo prmItem, int prmIndice);
        bool Remover(ref Tipo prmItem, int prmIndice);
        bool Modificar(ref Tipo prmItem, int prmIndice);
        bool Revisar(ref Tipo prmItem);
    }
}
