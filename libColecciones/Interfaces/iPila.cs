using System;

namespace Servicios.Colecciones.Interfaces
{
    interface iPila<Tipo> where Tipo : IComparable
    {
        bool Apilar(Tipo prmItem);
        bool Desapilar(ref Tipo prmItem);
        bool Revisar(ref Tipo prmItem);
    }
}
