using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestListaVectorConstructoresV1
        {
        #region Atributos de Prueba
        clsListaVector<int> atrListaDatos;
        clsListaVector<clsPersona> atrListaObjetos;
        #endregion
        #region Casos de Prueba Constructores: Sin Mensajería, Sin Cronómetro    
        #region Casos de Prueba para el Constructor no Parametrizado
        [TestMethod]
        public void testConstructor1ConDatos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>();
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            Assert.AreEqual(100, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor1ConObjetos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>();
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaObjetos.darCapacidad());
            Assert.AreEqual(100, atrListaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrListaObjetos.darVectorItems().GetType());
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
            atrListaDatos = new clsListaVector<int>(-3);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            Assert.AreEqual(100, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadCero()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>(0);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            Assert.AreEqual(100, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadMinValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>(int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            Assert.AreEqual(0, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosConMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>(int.MaxValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrListaDatos.darCapacidad());
            Assert.AreEqual(null, atrListaDatos.darVectorItems());
            Assert.AreEqual(1, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaDatos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadValida()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>(3000);
            #endregion
            #region Comprobar
            Assert.AreEqual(3000, atrListaDatos.darCapacidad());
            Assert.AreEqual(3000, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadCercaMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>(int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrListaDatos.darCapacidad());
            Assert.AreEqual(null, atrListaDatos.darVectorItems());
            Assert.AreEqual(1, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaDatos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadNegativa()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>(-3);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaObjetos.darCapacidad());
            Assert.AreEqual(100, atrListaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosCapacidadCero()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>(0);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaObjetos.darCapacidad());
            Assert.AreEqual(100, atrListaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrListaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosCapacidadMinValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>(int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaObjetos.darCapacidad());
            Assert.AreEqual(100, atrListaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>(int.MaxValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrListaObjetos.darCapacidad());
            Assert.AreEqual(null, atrListaObjetos.darVectorItems());
            Assert.AreEqual(1, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadValida()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>(3000);
            #endregion
            #region Comprobar
            Assert.AreEqual(3000, atrListaObjetos.darCapacidad());
            Assert.AreEqual(3000, atrListaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrListaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadCercanaAMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>(int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrListaObjetos.darCapacidad());
            Assert.AreEqual(null, atrListaObjetos.darVectorItems());
            Assert.AreEqual(1, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaObjetos.darCapacidadFlexible());
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
            atrListaDatos = new clsListaVector<int>(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            Assert.AreEqual(100, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3DatosCapacidadNoFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            Assert.AreEqual(100, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3ObjetosCapacidadFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaObjetos.darCapacidad());
            Assert.AreEqual(100, atrListaObjetos.darVectorItems().Length);
            Assert.AreEqual(1, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrListaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3ObjetosCapacidadNoFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaVector<clsPersona>(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaObjetos.darCapacidad());
            Assert.AreEqual(100, atrListaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrListaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrListaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrListaObjetos.darVectorItems().GetType());
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
            atrListaDatos = new clsListaVector<int>(int.MinValue, 10);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            Assert.AreEqual(100, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(10, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor4MCapacidadNoValidaFactoCrecimientoNoValido()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>(int.MinValue, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            Assert.AreEqual(100, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor4CapacidadValidoFactoCrecimientoNoValido()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaVector<int>(1500, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(1500, atrListaDatos.darCapacidad());
            Assert.AreEqual(1500, atrListaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrListaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrListaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrListaDatos.darVectorItems().GetType());
            #endregion
            }
        #endregion
        #endregion
        }
    }
