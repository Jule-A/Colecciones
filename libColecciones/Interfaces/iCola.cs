using System;

namespace Servicios.Colecciones.Interfaces
{
    interface iCola<Tipo> where Tipo : IComparable
    {
        bool Encolar(Tipo prmItem);
        bool Desencolar(ref Tipo prmItem);
        bool Revisar(ref Tipo prmItem);
    }
}
