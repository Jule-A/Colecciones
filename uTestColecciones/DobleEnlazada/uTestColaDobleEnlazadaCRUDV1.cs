using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.DobleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestColaDobleEnlazadaCRUDV1
        {
        #region Atributos de Prueba
        clsColaDobleEnlazada<int> atrColaDatos;
        #endregion
        #region Casos de Prueba Encolar
        [TestMethod]
        public void testEncolarUnItem()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            bool varResultadoDeEncolar;
            #endregion
            #region Probar
            varResultadoDeEncolar = atrColaDatos.Encolar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeEncolar);
            Assert.AreEqual(2000, atrColaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2000, atrColaDatos.darNodoUltimo().darItem());
            Assert.AreEqual(1, atrColaDatos.darLongitud());
            #endregion
            }
        [TestMethod]
        public void testEncolarDosItems()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            #endregion
            #region Probar
            Assert.AreEqual(true, atrColaDatos.Encolar(999));
            Assert.AreEqual(true, atrColaDatos.Encolar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(2, atrColaDatos.darLongitud());
            Assert.AreEqual(999, atrColaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(500, atrColaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testEncolarLlenarCola()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            bool varResultadoDeEncolar = true;
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeEncolar = varResultadoDeEncolar && atrColaDatos.Encolar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeEncolar);
            Assert.AreEqual(500, atrColaDatos.darLongitud());
            Assert.AreEqual(0, atrColaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(499, atrColaDatos.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Desencolar
        [TestMethod]
        public void testDesencolarConColaVacia()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrColaDatos.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoDesencolar);
            Assert.AreEqual(0, varElementoDesencolado);
            Assert.AreEqual(0, atrColaDatos.darLongitud());
            Assert.AreEqual(null, atrColaDatos.darNodoPrimero());
            Assert.AreEqual(null, atrColaDatos.darNodoPrimero());
            #endregion
            }
        [TestMethod]
        public void testDesencolarUnItemCaso1()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            atrColaDatos.Encolar(2000);
            atrColaDatos.Encolar(5000);
            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrColaDatos.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado);
            Assert.AreEqual(1, atrColaDatos.darLongitud());
            Assert.AreEqual(5000, atrColaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(5000, atrColaDatos.darNodoPrimero().darItem());
            #endregion
            }
        [TestMethod]
        public void testDesencolarUnItemCaso2()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            atrColaDatos.Encolar(2000);
            atrColaDatos.Encolar(5000);
            atrColaDatos.Encolar(8000);
            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrColaDatos.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado);
            Assert.AreEqual(2, atrColaDatos.darLongitud());
            Assert.AreEqual(5000, atrColaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(8000, atrColaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testDesencolarVaciarItemsCaso1()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            atrColaDatos.Encolar(2000);
            bool varResultadoDesencolar;
            int varElementoDesencolado = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrColaDatos.Desencolar(ref varElementoDesencolado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado);
            Assert.AreEqual(0, atrColaDatos.darLongitud());
            Assert.AreEqual(null, atrColaDatos.darNodoPrimero());
            #endregion
            }
        [TestMethod]
        public void testDesencolarVaciarItemsCaso2()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            atrColaDatos.Encolar(2000);
            atrColaDatos.Encolar(5000);
            bool varResultadoDesencolar;
            int varElementoDesencolado1 = 0;
            int varElementoDesencolado2 = 0;
            #endregion
            #region Probar
            varResultadoDesencolar = atrColaDatos.Desencolar(ref varElementoDesencolado1) && atrColaDatos.Desencolar(ref varElementoDesencolado2);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesencolar);
            Assert.AreEqual(2000, varElementoDesencolado1);
            Assert.AreEqual(5000, varElementoDesencolado2);
            Assert.AreEqual(0, atrColaDatos.darLongitud());
            Assert.AreEqual(null, atrColaDatos.darNodoPrimero());
            Assert.AreEqual(null, atrColaDatos.darNodoPrimero());
            #endregion
            }
        #endregion
        #region Casos de Prueba Revisar
        [TestMethod]
        public void testRevisarColaConItems()
            {
            #region Inicializar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            atrColaDatos.Encolar(2000);
            atrColaDatos.Encolar(5000);
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrColaDatos.Revisar(ref varElementoRevisado);
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
            atrColaDatos = new clsColaDobleEnlazada<int>();
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = atrColaDatos.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoRevisar);
            Assert.AreEqual(default(int), varElementoRevisado);
            #endregion
            }
        #endregion
        }
    }
