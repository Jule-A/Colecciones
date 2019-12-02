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
        bool Insertar(int prmIndice, Tipo prmItem);
        bool Remover(int prmIndice, ref Tipo prmItem);
        bool Modificar(int prmIndice, Tipo prmItem);
        bool Recuperar(int prmIndice, ref Tipo prmItem);
    }
}
