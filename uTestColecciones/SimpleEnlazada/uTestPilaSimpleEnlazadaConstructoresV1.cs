using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.SimpleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestPilaSimpleEnlazadaConstructoresV1
        {
        #region Atributos de Prueba
        clsPilaSimpleEnlazada<int> atrPilaDatos;
        clsPilaSimpleEnlazada<clsPersona> atrPilaObjetos;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba para el Constructor no Parametrizado
        [TestMethod]
        public void testConstructor1ConDatos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaDatos = new clsPilaSimpleEnlazada<int>();
            #endregion
            #region Comprobar
            Assert.AreEqual(atrPilaDatos!=null, true);
            #endregion
            }
        [TestMethod]
        public void testConstructor1ConObjetos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrPilaObjetos = new clsPilaSimpleEnlazada<clsPersona>();
            #endregion
            #region Comprobar
            Assert.AreEqual(atrPilaObjetos != null, true);
            #endregion
            }
        #endregion
        #endregion
        }
    }

