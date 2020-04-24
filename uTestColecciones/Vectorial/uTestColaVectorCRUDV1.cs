using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestColaVectorCRUDV1
        {
        #region Atributos de Prueba
        clsColaVector<int> atrCola;
        int[] atrVectorDeItemsEsperado;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba de Encolar
        [TestMethod]
        public void testEncolarUnItemCaso1()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[100];
            atrVectorDeItemsEsperado[0] = 2000;
            atrCola = new clsColaVector<int>();
            bool varResultadoDeEncolar;
            #endregion
            #region Probar
            varResultadoDeEncolar = atrCola.Encolar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeEncolar);
            Assert.AreEqual(1, atrCola.darLongitud());
            Assert.AreEqual(100, atrCola.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testEncolarUnItemCaso2()
            {
            #region Inicializar
            atrCola = new clsColaVector<int>(0);
            bool varResultadoEncolar;
            #endregion
            #region Probar
            varResultadoEncolar = atrCola.Encolar(1973);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoEncolar);
            Assert.AreEqual(1, atrCola.darLongitud());
            Assert.AreEqual(100, atrCola.darCapacidad());
            #endregion
            }
        [TestMethod]
        public void testEncolarUnItemCaso3()
            {
            #region Inicializar
            atrCola = new clsColaVector<int>(0, 1);
            bool varResultadoEncolar;
            #endregion
            #region Probar
            varResultadoEncolar = atrCola.Encolar(1973);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoEncolar);
            Assert.AreEqual(1, atrCola.darLongitud());
            //Assert.AreEqual(1, atrCola.darCapacidad());
            //Assert.AreEqual(atrCola.darLongitud(), atrCola.darCapacidad());
            //Assert.AreEqual(1, atrCola.darVectorItems().Length);
            Assert.AreEqual(1973, atrCola.darVectorItems()[0]);
            #endregion
            }
        [TestMethod]
        public void testEncolarUnItemCaso4()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2] { 500, 1973 };
            atrCola = new clsColaVector<int>(2, 1);
            atrCola.Encolar(500);
            bool varResultadoEncolar;
            #endregion
            #region Probar
            varResultadoEncolar = atrCola.Encolar(1973);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoEncolar);
            Assert.AreEqual(2, atrCola.darLongitud());
            Assert.AreEqual(atrCola.darLongitud(), atrCola.darCapacidad());
            Assert.AreEqual(2, atrCola.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testLlenarCola()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[500];
            for (int varNumero = 0; varNumero < atrVectorDeItemsEsperado.Length; varNumero++)
                atrVectorDeItemsEsperado[varNumero] = varNumero;
            bool varResultadoDeEncolar = true;
            atrCola = new clsColaVector<int>(500);
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeEncolar = varResultadoDeEncolar && atrCola.Encolar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeEncolar);
            Assert.AreEqual(500, atrCola.darLongitud());
            Assert.AreEqual(atrCola.darLongitud(), atrCola.darCapacidad());
            Assert.AreEqual(500, atrCola.darCapacidad());
            Assert.AreEqual(499, atrCola.darVectorItems()[atrCola.darLongitud() - 1]);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testEncolarCaso6()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[21];
            atrVectorDeItemsEsperado[0] = 999;
            atrVectorDeItemsEsperado[1] = 500;
            #endregion
            #region Probar
            atrCola = new clsColaVector<int>(1, 20);
            Assert.AreEqual(true, atrCola.Encolar(999));
            Assert.AreEqual(true, atrCola.Encolar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(2, atrCola.darLongitud());
            Assert.AreEqual(21, atrCola.darCapacidad());
            Assert.AreEqual(21, atrCola.darVectorItems().Length);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        #endregion
        #region Casos de Prueba Desencolar
        [TestMethod]
        public void testDesencolarCaso1()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[3];
            atrVectorDeItemsEsperado[0] = 5000;
            atrVectorDeItemsEsperado[1] = 5000;
            atrVectorDeItemsEsperado[2] = 0;

            atrCola = new clsColaVector<int>(3);
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);

            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrCola.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado);
            Assert.AreEqual(1, atrCola.darLongitud());
            Assert.AreEqual(3, atrCola.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testDesencolarCaso2()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2];
            atrVectorDeItemsEsperado[0] = 5000;
            atrVectorDeItemsEsperado[1] = 5000;

            atrCola = new clsColaVector<int>(2);
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);

            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrCola.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado);
            Assert.AreEqual(1, atrCola.darLongitud());
            Assert.AreEqual(2, atrCola.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testDesencolarCaso3()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2];
            atrVectorDeItemsEsperado[0] = 5000;
            atrVectorDeItemsEsperado[1] = 5000;

            atrCola = new clsColaVector<int>(2, 1);
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);

            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrCola.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado);
            Assert.AreEqual(1, atrCola.darLongitud());
            Assert.AreEqual(2, atrCola.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testDesencolarCaso4()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2];
            atrVectorDeItemsEsperado[0] = 0;
            atrVectorDeItemsEsperado[1] = 0;

            atrCola = new clsColaVector<int>(2);

            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrCola.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoDesencolar);
            Assert.AreEqual(0, varElementoDesencolado);
            Assert.AreEqual(0, atrCola.darLongitud());
            Assert.AreEqual(2, atrCola.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testDesencolarCaso5()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2];
            atrVectorDeItemsEsperado[0] = 2000;
            atrVectorDeItemsEsperado[1] = 0;

            atrCola = new clsColaVector<int>(2);
            atrCola.Encolar(2000);

            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrCola.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado);
            Assert.AreEqual(0, atrCola.darLongitud());
            Assert.AreEqual(2, atrCola.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testDesencolarCaso6()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2];
            atrVectorDeItemsEsperado[0] = 0;
            atrVectorDeItemsEsperado[1] = 0;

            atrCola = new clsColaVector<int>(2, 20);

            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrCola.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoDesencolar);
            Assert.AreEqual(0, varElementoDesencolado);
            Assert.AreEqual(0, atrCola.darLongitud());
            Assert.AreEqual(2, atrCola.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        #endregion
        #region Casos de Prueba Revisar
        [TestMethod]
        public void testRevisarDeColaCaso1()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[3] { 2000, 5000, 0 };
            atrCola = new clsColaVector<int>(3, 1);
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrCola.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(2000, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testRevisarDeColaCaso2()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[3] { 2000, 5000, 0 };

            atrCola = new clsColaVector<int>(3);
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrCola.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(2000, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testRevisarDeColaCaso3()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2] { 2000, 5000 };

            atrCola = new clsColaVector<int>(2);
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrCola.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(2000, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testRevisarDeColaVacia()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2] { 0, 0 };
            atrCola = new clsColaVector<int>(2, 1);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrCola.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
             Assert.AreEqual(false, varResultadoRevisar);
            Assert.AreEqual(0, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testRevisarDeColaCaso5()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2] { 2000, 0 };

            atrCola = new clsColaVector<int>(2, 1);
            atrCola.Encolar(2000);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrCola.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
             Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(2000, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testRevisarDeColaCaso6()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2] { 2000, 5000 };

            atrCola = new clsColaVector<int>(2, 1);
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrCola.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
             Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(2000, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testRevisarDeColaCaso7()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2] { 0, 0 };
            atrCola = new clsColaVector<int>(2);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrCola.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
             Assert.AreEqual(false, varResultadoRevisar);
            Assert.AreEqual(0, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrCola.darVectorItems());
            #endregion
            }
        #endregion
        #endregion
        }
    }
