using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.SimpleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestPilaSimpleEnlazadaCRUDV1
        {
        #region Atributos de Prueba
        clsPilaSimpleEnlazada<int> atrPilaDatos;
        #endregion
        #region Casos de Prueba CRUDs Sin Modo: Inteligente-Mensajero-Cronometro
        #region Casos de Prueba Apilar
        [TestMethod]
        public void testApilarUnItem()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            bool varResultadoDeApilar;
            #endregion
            #region Probar
            varResultadoDeApilar = atrPilaDatos.Apilar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeApilar);
            Assert.AreEqual(2000, atrPilaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2000, atrPilaDatos.darNodoUltimo().darItem());
            Assert.AreEqual(1, atrPilaDatos.darLongitud());
            #endregion
            }
        [TestMethod]
        public void testApilarDosItems()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            #endregion
            #region Probar
            Assert.AreEqual(true, atrPilaDatos.Apilar(999));
            Assert.AreEqual(true, atrPilaDatos.Apilar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(2, atrPilaDatos.darLongitud());
            Assert.AreEqual(500, atrPilaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(999, atrPilaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testApilarVariosItems()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            bool varResultadoDeApilar = true;
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeApilar = varResultadoDeApilar && atrPilaDatos.Apilar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeApilar);
            Assert.AreEqual(500, atrPilaDatos.darLongitud());
            Assert.AreEqual(499, atrPilaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(0, atrPilaDatos.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Desapilar
        [TestMethod]
        public void testDesapilarConPilaVacia()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = atrPilaDatos.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoDesapilar);
            Assert.AreEqual(0, varElementoDesapilado);
            Assert.AreEqual(0, atrPilaDatos.darLongitud());
            Assert.AreEqual(null, atrPilaDatos.darNodoPrimero());
            Assert.AreEqual(null, atrPilaDatos.darNodoPrimero());
            #endregion
            }
        [TestMethod]
        public void testDesapilarUnItemCaso1()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            atrPilaDatos.Apilar(2000);
            atrPilaDatos.Apilar(5000);

            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = atrPilaDatos.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(5000, varElementoDesapilado);
            Assert.AreEqual(1, atrPilaDatos.darLongitud());
            Assert.AreEqual(2000, atrPilaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2000, atrPilaDatos.darNodoPrimero().darItem());
            #endregion
            }
        [TestMethod]
        public void testDesapilarUnItemCaso2()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            atrPilaDatos.Apilar(2000);
            atrPilaDatos.Apilar(5000);
            atrPilaDatos.Apilar(8000);

            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = atrPilaDatos.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(8000, varElementoDesapilado);
            Assert.AreEqual(2, atrPilaDatos.darLongitud());
            Assert.AreEqual(5000, atrPilaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2000, atrPilaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testDesapilarVaciarItemsCaso1()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            atrPilaDatos.Apilar(2000);

            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = atrPilaDatos.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(2000, varElementoDesapilado);
            Assert.AreEqual(0, atrPilaDatos.darLongitud());
            Assert.AreEqual(null, atrPilaDatos.darNodoPrimero());
            #endregion
            }
        [TestMethod]
        public void testDesapilarVaciarItemsCaso2()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            atrPilaDatos.Apilar(2000);
            atrPilaDatos.Apilar(5000);

            bool varResultadoDesapilar;
            int varElementoDesapilado1 = 0;
            int varElementoDesapilado2 = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = atrPilaDatos.Desapilar(ref varElementoDesapilado1) && atrPilaDatos.Desapilar(ref varElementoDesapilado2);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(5000, varElementoDesapilado1);
            Assert.AreEqual(2000, varElementoDesapilado2);
            Assert.AreEqual(0, atrPilaDatos.darLongitud());
            Assert.AreEqual(null, atrPilaDatos.darNodoPrimero());
            Assert.AreEqual(null, atrPilaDatos.darNodoPrimero());
            #endregion
            }
        #endregion
        #region Casos de Prueba Revisar
        [TestMethod]
        public void testRevisarPilaConItems()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            atrPilaDatos.Apilar(2000);
            atrPilaDatos.Apilar(5000);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrPilaDatos.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(5000, varElementoRevisado);
            #endregion
            }
        [TestMethod]
        public void testRevisarPilaVacia()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrPilaDatos.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoRevisar);
            Assert.AreEqual(default(int), varElementoRevisado);
            #endregion
            }
        #endregion
        #endregion
        }
    }
