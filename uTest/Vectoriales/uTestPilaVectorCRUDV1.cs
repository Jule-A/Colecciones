using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestPilaVectorCRUDV1
        {
        #region Atributos de Prueba
        clsPilaVector<int> atrPila;
        int[] atrVectorDeItemsEsperado;
        #endregion
        #region Casos de Prueba CRUDs Sin Modo: Inteligente-Mensajero-Cronometro
        #region Casos de Prueba Apilar
        [TestMethod]
        public void testApilarUnItem()
            {
            #region Inicializar
            atrPila = new clsPilaVector<int>();
            bool varResultadoDeApilar = false;
            #endregion
            #region Probar
            varResultadoDeApilar = atrPila.Apilar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeApilar);
            Assert.AreEqual(1, atrPila.darLongitud());
            Assert.AreEqual(100, atrPila.darCapacidad());
            #endregion
            }
        [TestMethod]
        public void testApilar2ItemsConCapacidadFlexible()
            {
            #region Inicializar
            atrPila = new clsPilaVector<int>(1, 20);
            #endregion
            #region Probar
            Assert.AreEqual(true, atrPila.Apilar(999));
            Assert.AreEqual(true, atrPila.Apilar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(2, atrPila.darLongitud());
            Assert.AreEqual(21, atrPila.darCapacidad());
            Assert.AreEqual(21, atrPila.darVectorItems().Length);
            #endregion
            }
        [TestMethod]
        public void testApilar3HastaLlenar()
            {
            #region Inicializar
            atrPila = new clsPilaVector<int>(500);
            bool varResultadoDeApilar = true;
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeApilar = varResultadoDeApilar && atrPila.Apilar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeApilar);
            Assert.AreEqual(500, atrPila.darLongitud());
            Assert.AreEqual(atrPila.darLongitud(), atrPila.darCapacidad());
            Assert.AreEqual(500, atrPila.darCapacidad());
            Assert.AreEqual(0, atrPila.darVectorItems()[atrPila.darLongitud() - 1]);
            Assert.AreEqual(499, atrPila.darVectorItems()[0]);
            #endregion
            }
        #endregion
        #region Casos de Prueba Desapilar
        [TestMethod]
        public void testDesapilarUnItem()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[3];
            atrVectorDeItemsEsperado[0] = 2000;
            atrVectorDeItemsEsperado[1] = 2000;
            atrVectorDeItemsEsperado[2] = 0;

            atrPila = new clsPilaVector<int>(3);
            atrPila.Apilar(2000);
            atrPila.Apilar(5000);

            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = atrPila.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(5000, varElementoDesapilado);
            Assert.AreEqual(1, atrPila.darLongitud());
            Assert.AreEqual(3, atrPila.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPila.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testDesapilarSobrePilaVacia()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2];
            atrVectorDeItemsEsperado[0] = 0;
            atrVectorDeItemsEsperado[1] = 0;
            atrPila = new clsPilaVector<int>(2);
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            Assert.AreEqual(false, atrPila.Desapilar(ref varElementoDesapilado));
            #endregion
            #region Comprobar
            Assert.AreEqual(0, varElementoDesapilado);
            Assert.AreEqual(0, atrPila.darLongitud());
            Assert.AreEqual(2, atrPila.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPila.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testDesapilarEnPilaConUnItem()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2];
            atrVectorDeItemsEsperado[0] = 2000;
            atrVectorDeItemsEsperado[1] = 0;
            atrPila = new clsPilaVector<int>(2);
            atrPila.Apilar(2000);
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            Assert.AreEqual(true, atrPila.Desapilar(ref varElementoDesapilado));
            #endregion
            #region Comprobar
            Assert.AreEqual(2000, varElementoDesapilado);
            Assert.AreEqual(0, atrPila.darLongitud());
            Assert.AreEqual(2, atrPila.darCapacidad());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPila.darVectorItems());
            #endregion
            }
        #endregion
        #region Casos de Prueba Revisar
        [TestMethod]
        public void testRevisarUnItem()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[3] { 5000, 2000, 0 };
            atrPila = new clsPilaVector<int>(3);
            atrPila.Apilar(2000);
            atrPila.Apilar(5000);
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(5000, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPila.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testRevisarSobrePilaVacia()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[2] { 0, 0 };
            atrPila = new clsPilaVector<int>(2);
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoRevisar);
            Assert.AreEqual(0, varElementoRevisado);
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPila.darVectorItems());
            #endregion
            }
        #endregion
        #endregion
        }
    }
