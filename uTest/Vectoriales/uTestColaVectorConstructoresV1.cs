using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestColaVectorConstructoresV1
        {
        #region Atributos de Prueba
        clsColaVector<int> atrColaDatos;
        clsColaVector<clsPersona> atrColaObjetos;
        #endregion
        #region Casos de Prueba Sin Modo: Inteligente-Mensajero-Cronometro
        #region Casos de Prueba para el Constructor no Parametrizado
        [TestMethod]
        public void testConstructor1ConDatos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>();
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaDatos.darCapacidad());
            Assert.AreEqual(100, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor1ConObjetos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>();
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaObjetos.darCapacidad());
            Assert.AreEqual(100, atrColaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrColaObjetos.darVectorItems().GetType());
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
            atrColaDatos = new clsColaVector<int>(-3);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaDatos.darCapacidad());
            Assert.AreEqual(100, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadCero()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>(0);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaDatos.darCapacidad());
            Assert.AreEqual(100, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadMinValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>(int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaDatos.darCapacidad());
            Assert.AreEqual(0, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosConMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>(int.MaxValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrColaDatos.darCapacidad());
            Assert.AreEqual(null, atrColaDatos.darVectorItems());
            Assert.AreEqual(1, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaDatos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadValida()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>(3000);
            #endregion
            #region Comprobar
            Assert.AreEqual(3000, atrColaDatos.darCapacidad());
            Assert.AreEqual(3000, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2DatosCapacidadCercaMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>(int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrColaDatos.darCapacidad());
            Assert.AreEqual(null, atrColaDatos.darVectorItems());
            Assert.AreEqual(1, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaDatos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadNegativa()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>(-3);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaObjetos.darCapacidad());
            Assert.AreEqual(100, atrColaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosCapacidadCero()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>(0);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaObjetos.darCapacidad());
            Assert.AreEqual(100, atrColaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrColaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosCapacidadMinValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>(int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaObjetos.darCapacidad());
            Assert.AreEqual(100, atrColaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>(int.MaxValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrColaObjetos.darCapacidad());
            Assert.AreEqual(null, atrColaObjetos.darVectorItems());
            Assert.AreEqual(1, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaObjetos.darCapacidadFlexible());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadValida()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>(3000);
            #endregion
            #region Comprobar
            Assert.AreEqual(3000, atrColaObjetos.darCapacidad());
            Assert.AreEqual(3000, atrColaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrColaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor2ObjetosConCapacidadCercanaAMaxValue()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>(int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(0, atrColaObjetos.darCapacidad());
            Assert.AreEqual(null, atrColaObjetos.darVectorItems());
            Assert.AreEqual(1, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaObjetos.darCapacidadFlexible());
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
            atrColaDatos = new clsColaVector<int>(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaDatos.darCapacidad());
            Assert.AreEqual(100, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3DatosCapacidadNoFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaDatos.darCapacidad());
            Assert.AreEqual(100, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3ObjetosCapacidadFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaObjetos.darCapacidad());
            Assert.AreEqual(100, atrColaObjetos.darVectorItems().Length);
            Assert.AreEqual(1, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrColaObjetos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor3ObjetosCapacidadNoFlexible()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaVector<clsPersona>(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaObjetos.darCapacidad());
            Assert.AreEqual(100, atrColaObjetos.darVectorItems().Length);
            Assert.AreEqual(0, atrColaObjetos.darFactorDeCrecimiento());
            Assert.AreEqual(false, atrColaObjetos.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), atrColaObjetos.darVectorItems().GetType());
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
            atrColaDatos = new clsColaVector<int>(int.MinValue, 10);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaDatos.darCapacidad());
            Assert.AreEqual(100, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(10, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor4MCapacidadNoValidaFactoCrecimientoNoValido()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>(int.MinValue, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(100, atrColaDatos.darCapacidad());
            Assert.AreEqual(100, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        [TestMethod]
        public void testConstructor4CapacidadValidoFactoCrecimientoNoValido()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaVector<int>(1500, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(1500, atrColaDatos.darCapacidad());
            Assert.AreEqual(1500, atrColaDatos.darVectorItems().Length);
            Assert.AreEqual(1, atrColaDatos.darFactorDeCrecimiento());
            Assert.AreEqual(true, atrColaDatos.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), atrColaDatos.darVectorItems().GetType());
            #endregion
            }
        #endregion
        #endregion
        }
    }
