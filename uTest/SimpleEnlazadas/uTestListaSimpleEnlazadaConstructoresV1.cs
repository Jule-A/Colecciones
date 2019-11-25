using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.SimpleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestListaSimpleEnlazadaConstructoresV1
        {
        #region Atributos de Prueba
        clsListaSimpleEnlazada<int> atrListaDatos;
        clsListaSimpleEnlazada<clsPersona> atrListaObjetos;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba para el Constructor no Parametrizado
        [TestMethod]
        public void testConstructor1ConDatos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            #endregion
            #region Comprobar
            Assert.AreEqual(atrListaDatos!=null, true);
            #endregion
            }
        [TestMethod]
        public void testConstructor1ConObjetos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaObjetos = new clsListaSimpleEnlazada<clsPersona>();
            #endregion
            #region Comprobar
            Assert.AreEqual(atrListaObjetos != null, true);
            #endregion
            }
        #endregion
        #endregion
        }
    }

