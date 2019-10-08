using System;

namespace Servicios.Colecciones
{
    class Class1
    {
        static Tipo Leer <Tipo>(string prmEtiqueta) where Tipo: IComparable
        {
            Console.Write(prmEtiqueta);
            return (Tipo)Convert.ChangeType(Console.ReadLine(), typeof(Tipo));
        }
    }
}
