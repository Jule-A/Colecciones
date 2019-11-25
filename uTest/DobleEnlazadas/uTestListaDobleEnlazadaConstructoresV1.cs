using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.DobleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestListaDobleEnlazadaConstructoresV1
        {
        #region Atributos de Prueba
        clsListaDobleEnlazada<int> atrListaDatos;
        clsListaDobleEnlazada<clsPersona> atrListaObjetos;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba para el Constructor no Parametrizado
        [TestMethod]
        public void testConstructor1ConDatos()
            {
            #region Inicializar
            #endregion
            #region Probar
            atrListaDatos = new clsListaDobleEnlazada<int>();
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
            atrListaObjetos = new clsListaDobleEnlazada<clsPersona>();
            #endregion
            #region Comprobar
            Assert.AreEqual(atrListaObjetos != null, true);
            #endregion
            }
        #endregion
        #endregion
        }
    }

