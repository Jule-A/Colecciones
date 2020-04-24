using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.TADS;

namespace uTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsTADVectorial<int> varMiTad = new clsTADVectorial<int>();
            varMiTad.Insertar(1, 0);
        }
    }
}
