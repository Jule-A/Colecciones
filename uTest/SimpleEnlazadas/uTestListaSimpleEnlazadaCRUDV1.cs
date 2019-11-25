using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.SimpleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestListaSimpleEnlazadaCRUDV1
        {
        #region Atributos de Prueba
        clsListaSimpleEnlazada<int> atrListaDatos;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba Agregar
        [TestMethod]
        public void testAgregarUnItem()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            bool varResultadoDeAgregar = false;
            #endregion
            #region Probar
            varResultadoDeAgregar = atrListaDatos.Agregar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeAgregar);
            Assert.AreEqual(1, atrListaDatos.darLongitud());
            Assert.AreEqual(2000, atrListaDatos.darNodoPrimero().darItem());
            #endregion
            }
        [TestMethod]
        public void testAgregar2Items()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            #endregion
            #region Probar
            Assert.AreEqual(true, atrListaDatos.Agregar(999));
            Assert.AreEqual(true, atrListaDatos.Agregar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(2, atrListaDatos.darLongitud());
            Assert.AreEqual(999, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(500, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testAgregarMuchosItems()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            bool varResultadoDeAgregar = true;
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeAgregar = varResultadoDeAgregar && atrListaDatos.Agregar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeAgregar);
            Assert.AreEqual(500, atrListaDatos.darLongitud());
            Assert.AreEqual(499, atrListaDatos.darNodoUltimo().darItem());
            Assert.AreEqual(0, atrListaDatos.darNodoPrimero().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Insertar 
        [TestMethod]
        public void testInsertarUnItemEnListaConIndiceValido()
            {
            #region Configurar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(3);
            #endregion
            #region Probar
            bool varResultado = atrListaDatos.Insertar(1, 2);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultado);
            Assert.AreEqual(3, atrListaDatos.darLongitud());
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testInsertarUnItemEnListaConIndiceInvalido()
            {
            #region Configurar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(3);
            #endregion
            #region Probar
            int varItemRemovido = 0;
            bool varResultado = atrListaDatos.Remover(2, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultado);
            Assert.AreEqual(2, atrListaDatos.darLongitud());
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Extraer 
        [TestMethod]
        public void testExtraerUnItemEnLista()
            {
            #region Configurar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(3);
            int varItemRemovido = 0;
            #endregion
            #region Probar
            bool varResultado = atrListaDatos.Remover(1, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultado);
            Assert.AreEqual(1, atrListaDatos.darLongitud());
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(1, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testExtraerUnItemEnListaVacia()
            {
            #region Configurar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            #endregion
            #region Probar
            int varItemRemovido = 0;
            bool varResultado = atrListaDatos.Remover(1, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultado);
            Assert.AreEqual(0, atrListaDatos.darLongitud());
            #endregion
            }
        [TestMethod]
        public void testExtraerUnItemConIndiceInvalido()
            {
            #region Configurar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            int varItemRemovido = 0;
            bool varResultado = atrListaDatos.Remover(3, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultado);
            Assert.AreEqual(3, atrListaDatos.darLongitud());
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(4, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Reversar
        [TestMethod]
        public void testReversar()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Reversar();
            #endregion
            #region Comprobar
            Assert.AreEqual(4, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(2, atrListaDatos.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(1, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testReversarConListaVacia()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            #endregion
            #region Probar
            
            #endregion
            #region Comprobar
            Assert.AreEqual(false, atrListaDatos.Reversar());
            #endregion
            }
        #endregion
        #region Casos de Prueba Modificar
        [TestMethod]
        public void testModificarEnColeccionVacia()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, atrListaDatos.Modificar(0, -1));
            #endregion
            }
        [TestMethod]
        public void testModificarPrimero()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Modificar(0, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(-1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testModificarUltimo()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Modificar(3, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(-1, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testModificarEnMedio()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Modificar(2, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(-1, atrListaDatos.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Recuperar
        [TestMethod]
        public void testRecuperarEnColeccionVacia()
            {
            #region Inicializar
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            int varItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, atrListaDatos.Recuperar(0, ref varItem));
            Assert.AreEqual(0, varItem);
            #endregion
            }
        [TestMethod]
        public void testRecuperarPrimero()
            {
            #region Inicializar
            int varItem = 0;
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrListaDatos.Recuperar(0, ref varItem));
            Assert.AreEqual(1, varItem);
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testRecuperarUltimo()
            {
            #region Inicializar
            int varItem = 0;
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrListaDatos.Recuperar(atrListaDatos.darLongitud() - 1, ref varItem));
            Assert.AreEqual(4, varItem);
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrListaDatos.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testRecuperarEnMedio()
            {
            #region Inicializar
            int varItem = 0;
            atrListaDatos = new clsListaSimpleEnlazada<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrListaDatos.Recuperar(2, ref varItem));
            Assert.AreEqual(3, varItem);
            Assert.AreEqual(1, atrListaDatos.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrListaDatos.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrListaDatos.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrListaDatos.darNodoUltimo().darItem());
            #endregion

            }
        #endregion
        #endregion
        }
    }

