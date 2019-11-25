using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestPilaVectorConstructoresV1
        {
        #region Atributos de Prueba
        clsPilaVector<int> atrPilaDatos;
        clsPilaVector<clsPersona> atrPilaObjetos;
        #endregion
        #region Casos de Prueba Sin Modo: Inteligente-Mensajero-Cronometro
        #region Casos de Prueba para el Constructor no Parametrizado
        [TestMethod]
        public void testConstructor1ConDatos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaDatos.darCapacidad());
            Assert.AreEqual(100, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor1ConObjetos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(100, atrPilaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrPilaObjetos.darVectorItems().GetType());
            #endregion
            }
        #endregion
        #region Casos de Prueba para el Constructor Parametrizado 2
        [TestMethod]
        public void testConstructor2DatosConCapacidadNegativa()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(-3);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaDatos.darCapacidad());
            Assert.AreEqual(100, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadCero()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(0);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaDatos.darCapacidad());
            Assert.AreEqual(100, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadMinValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaDatos.darCapacidad());
            Assert.AreEqual(0, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosConMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(int.MaxValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrPilaDatos.darCapacidad());
            Assert.AreEqual(null, atrPilaDatos.darVectorItems());
            Assert.AreEqual(1, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaDatos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadValida()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(3000);
            #endregion
            #region Comprobar
            Assert.AreEqual(3000, atrPilaDatos.darCapacidad());
            Assert.AreEqual(3000, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadCercaMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrPilaDatos.darCapacidad());
            Assert.AreEqual(null, atrPilaDatos.darVectorItems());
            Assert.AreEqual(1, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaDatos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadNegativa()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>(-3);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(100, atrPilaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosCapacidadCero()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>(0);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(100, atrPilaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrPilaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosCapacidadMinValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>(int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(100, atrPilaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>(int.MaxValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(null, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(1, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadValida()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>(3000);
            #endregion
            #region Comprobar
            Assert.AreEqual(3000, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(3000, atrPilaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrPilaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadCercanaAMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>(int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(null, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(1, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaObjetos.darCapacidadFlexible());
            #endregion
            }
        #endregion
        #region Casos de Prueba para el Constructor Parametrizado 3
        [TestMethod]
        public void testConstructor3DatosCapacidadFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaDatos.darCapacidad());
            Assert.AreEqual(100, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3DatosCapacidadNoFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaDatos.darCapacidad());
            Assert.AreEqual(100, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3ObjetosCapacidadFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(100, atrPilaObjetos.darVectorItems().Length);
            Assert.AreEqual(1, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrPilaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3ObjetosCapacidadNoFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaVector<clsPersona>(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaObjetos.darCapacidad());
            Assert.AreEqual(100, atrPilaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrPilaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrPilaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrPilaObjetos.darVectorItems().GetType());
            #endregion
            }
        #endregion
        #region Casos de Prueba para el Constructor Parametrizado 4
        [TestMethod]
        public void testConstructor4CapacidadNoValidaCrecimientoValido()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(int.MinValue, 10);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaDatos.darCapacidad());
            Assert.AreEqual(100, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(10, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor4MCapacidadNoValidaFactoCrecimientoNoValido()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(int.MinValue, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrPilaDatos.darCapacidad());
            Assert.AreEqual(100, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor4CapacidadValidoFactoCrecimientoNoValido()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaVector<int>(1500, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(1500, atrPilaDatos.darCapacidad());
            Assert.AreEqual(1500, atrPilaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrPilaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrPilaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrPilaDatos.darVectorItems().GetType());
            #endregion
            }
        #endregion
        #endregion
        }
    }
