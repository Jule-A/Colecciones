using System;

namespace Servicios.Colecciones.TADS
{
    public class clsTADVectorial<Tipo>: clsTAD<Tipo> where Tipo : IComparable
    {
        #region Atributos
        protected Tipo[] atrVectorDeItems = new Tipo[int.MaxValue/16];
        private bool atrCapacidadFlexible=true;
        private int atrCapacidad=int.MaxValue/16;
        private int atrFactorDeCrecimiento=1;
        private int varIndice;
        #endregion
        #region Metodos
        #region Auxiliares
        public bool estaLlena()
        {
            return atrCapacidad == atrLongitud;
        }

       private bool DezplazarItems(bool prmHaciaDerecha, int prmIndice)
        {
            if (prmHaciaDerecha)
                for (varIndice = atrLongitud - 1; varIndice >= atrCapacidad; varIndice--)
                    atrVectorDeItems[varIndice + 1] = atrVectorDeItems[varIndice];
            else
                for (varIndice = prmIndice; varIndice < atrLongitud; varIndice++)
                    atrVectorDeItems[varIndice] = atrVectorDeItems[varIndice + 1];
            return true;
        }

        #endregion
        #region CRUDS - Query
        protected override bool InsertarEn(int prmIndice, Tipo prmItem)
        {
            if (estaLlena())
            {
                if (atrCapacidadFlexible)
                {
                    Tipo[] varVectorAuxiliar = new Tipo[atrCapacidad + atrFactorDeCrecimiento];
                    varVectorAuxiliar[prmIndice] = prmItem;

                    //for (int varIndice = 0; varIndice < prmIndice; varIndice++)
                    //    varVectorAuxiliar[varIndice] = atrVectorDeItems[varIndice];
                    //for (int varIndice = prmIndice + 1; varIndice < atrLongitud; varIndice++)
                    //    varVectorAuxiliar[varIndice] = atrVectorDeItems[varIndice];

                    int varIndice2 = 0;

                    //for (int varIndice1 = 0; varIndice1  )
                    atrCapacidad += atrFactorDeCrecimiento;
                    atrLongitud += 1;
                    atrVectorDeItems = varVectorAuxiliar;
                    for (int varIndice = atrLongitud - 1; varIndice >= prmIndice; varIndice--)
                        atrVectorDeItems[varIndice + 1] = atrVectorDeItems[varIndice];
                    atrVectorDeItems[prmIndice] = prmItem;
                }
                atrLongitud += 1;
            }
            return false;
        }
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        protected override bool ModificarEn(int prmIndice, Tipo prmItem)
        {
            return false;
        }
        protected override bool RecuperarEn(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        #endregion
        #endregion
    }
}
