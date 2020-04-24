using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.SimpleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestColaSimpleEnlazadaCRUDV1
        {
        #region Atributos de Prueba
        clsColaSimpleEnlazada<int> atrCola;
        #endregion
        #region Casos de Prueba Encolar
        [TestMethod]
        public void testEncolarUnItem()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
            bool varResultadoDeEncolar;
            #endregion
            #region Probar
            varResultadoDeEncolar = atrCola.Encolar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeEncolar);
            Assert.AreEqual(2000, atrCola.darNodoPrimero().darItem());
            Assert.AreEqual(2000, atrCola.darNodoUltimo().darItem());
            Assert.AreEqual(1, atrCola.darLongitud());
            #endregion
            }
        [TestMethod]
        public void testEncolarDosItems()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
            #endregion
            #region Probar
            Assert.AreEqual(true, atrCola.Encolar(999));
            Assert.AreEqual(true, atrCola.Encolar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(2, atrCola.darLongitud());
            Assert.AreEqual(999, atrCola.darNodoPrimero().darItem());
            Assert.AreEqual(500, atrCola.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testEncolarLlenarCola()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
            bool varResultadoDeEncolar = true;
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeEncolar = varResultadoDeEncolar && atrCola.Encolar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeEncolar);
            Assert.AreEqual(500, atrCola.darLongitud());
            Assert.AreEqual(0, atrCola.darNodoPrimero().darItem());
            Assert.AreEqual(499, atrCola.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Desencolar
        [TestMethod]
        public void testDesencolarConColaVacia()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
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
            Assert.AreEqual(null, atrCola.darNodoPrimero());
            Assert.AreEqual(null, atrCola.darNodoPrimero());
            #endregion
            }
        [TestMethod]
        public void testDesencolarUnItemCaso1()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
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
            Assert.AreEqual(5000, atrCola.darNodoPrimero().darItem());
            Assert.AreEqual(5000, atrCola.darNodoPrimero().darItem());
            #endregion
            }
        [TestMethod]
        public void testDesencolarUnItemCaso2()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);
            atrCola.Encolar(8000);

            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrCola.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado);
            Assert.AreEqual(2, atrCola.darLongitud());
            Assert.AreEqual(5000, atrCola.darNodoPrimero().darItem());
            Assert.AreEqual(8000, atrCola.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testDesencolarVaciarItemsCaso1()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
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
            Assert.AreEqual(null, atrCola.darNodoPrimero());
            #endregion
            }
        [TestMethod]
        public void testDesencolarVaciarItemsCaso2()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
            atrCola.Encolar(2000);
            atrCola.Encolar(5000);

            bool varResultadoDesencolar;
            int varElementoDesencolado1 = 0;
            int varElementoDesencolado2 = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrCola.Desencolar(ref varElementoDesencolado1) && atrCola.Desencolar(ref varElementoDesencolado2);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado1);
            Assert.AreEqual(5000, varElementoDesencolado2);
            Assert.AreEqual(0, atrCola.darLongitud());
            Assert.AreEqual(null, atrCola.darNodoPrimero());
            Assert.AreEqual(null, atrCola.darNodoPrimero());
            #endregion
            }
        #endregion
        #region Casos de Prueba Revisar
        [TestMethod]
        public void testRevisarColaConItems()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();
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
            #endregion
            }
        [TestMethod]
        public void testRevisarColaVacia()
            {
            #region Inicializar
            atrCola = new clsColaSimpleEnlazada<int>();

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrCola.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoRevisar);
            Assert.AreEqual(default(int), varElementoRevisado);
            #endregion
            }
        #endregion
        }
    }
