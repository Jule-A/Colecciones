using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.DobleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestColaDobleEnlazadaConstructoresV1
        {
        #region Atributos de Prueba
        clsColaDobleEnlazada<int> atrColaDatos;
        clsColaDobleEnlazada<clsPersona> atrColaObjetos;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba para el Constructor no Parametrizado
        [TestMethod]
        public void testConstructor1ConDatos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaDatos = new clsColaDobleEnlazada<int>();
            #endregion
            #region Comprobar
            Assert.AreEqual(atrColaDatos!=null, true);
            #endregion
            }
        [TestMethod]
        public void testConstructor1ConObjetos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrColaObjetos = new clsColaDobleEnlazada<clsPersona>();
            #endregion
            #region Comprobar
            Assert.AreEqual(atrColaObjetos != null, true);
            #endregion
            }
        #endregion
        #endregion
        }
    }

