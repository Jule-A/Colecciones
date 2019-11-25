using System;

namespace uTestColecciones
    {
    class clsPersona : IComparable
        {
        private int atrOID;
        private string atrNombre;
        private int atrEdad;

        public clsPersona() { }
        public clsPersona(int prmOID, string prmNombre, int prmEdad)
            {
            atrOID = prmOID;
            atrNombre = prmNombre;
            atrEdad = prmEdad;
            }
        public int CompareTo(object Objeto)
            {
            clsPersona varObjetoPersona = (clsPersona)Objeto;
            if (this.atrEdad > varObjetoPersona.atrEdad)
                return 1;
            if (this.atrEdad < varObjetoPersona.atrEdad)
                return -1;
            return 0;
            }
        }
    }
