using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.DobleEnlazadas;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestListaDobleEnlazadaCRUDV1
        {
        #region Atributos de Prueba
        clsListaDobleEnlazada<int> atrLista;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba Agregar
        [TestMethod]
        public void testAgregarUnItem()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            bool varResultadoDeAgregar = false;
            #endregion
            #region Probar
            varResultadoDeAgregar = atrLista.Agregar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeAgregar);
            Assert.AreEqual(1, atrLista.darLongitud());
            Assert.AreEqual(2000, atrLista.darNodoPrimero().darItem());
            #endregion
            }
        [TestMethod]
        public void testAgregar2Items()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            #endregion
            #region Probar
            Assert.AreEqual(true, atrLista.Agregar(999));
            Assert.AreEqual(true, atrLista.Agregar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(2, atrLista.darLongitud());
            Assert.AreEqual(999, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(500, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testAgregarMuchosItems()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            bool varResultadoDeAgregar = true;
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeAgregar = varResultadoDeAgregar && atrLista.Agregar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeAgregar);
            Assert.AreEqual(500, atrLista.darLongitud());
            Assert.AreEqual(499, atrLista.darNodoUltimo().darItem());
            Assert.AreEqual(0, atrLista.darNodoPrimero().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Insertar 
        [TestMethod]
        public void testInsertarUnItemEnListaConIndiceValido()
            {
            #region Configurar
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            bool varResultado = atrLista.Insertar(1, 2);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultado);
            Assert.AreEqual(4, atrLista.darLongitud());
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrLista.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testInsertarUnItemEnListaConIndiceInvalido()
            {
            #region Configurar
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(3);
            #endregion
            #region Probar
            int varItemRemovido = 0;
            bool varResultado = atrLista.Remover(2, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultado);
            Assert.AreEqual(2, atrLista.darLongitud());
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(3, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Extraer 
        [TestMethod]
        public void testExtraerUnItemEnLista()
            {
            #region Configurar
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(3);
            int varItemRemovido = 0;
            #endregion
            #region Probar
            bool varResultado = atrLista.Remover(1, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultado);
            Assert.AreEqual(1, atrLista.darLongitud());
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(1, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testExtraerUnItemEnListaVacia()
            {
            #region Configurar
            atrLista = new clsListaDobleEnlazada<int>();
            #endregion
            #region Probar
            int varItemRemovido = 0;
            bool varResultado = atrLista.Remover(1, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultado);
            Assert.AreEqual(0, atrLista.darLongitud());
            #endregion
            }
        [TestMethod]
        public void testExtraerUnItemConIndiceInvalido()
            {
            #region Configurar
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            int varItemRemovido = 0;
            bool varResultado = atrLista.Remover(3, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultado);
            Assert.AreEqual(3, atrLista.darLongitud());
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(3, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(4, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Reversar
        [TestMethod]
        public void testReversar()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(2);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            atrLista.Reversar();
            #endregion
            #region Comprobar
            Assert.AreEqual(4, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(3, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(2, atrLista.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(1, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testReversarConListaVacia()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            #endregion
            #region Probar
            #endregion
            #region Comprobar
            Assert.AreEqual(false, atrLista.Reversar());
            #endregion
            }
        #endregion
        #region Casos de Prueba Modificar
        [TestMethod]
        public void testModificarEnColeccionVacia()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, atrLista.Modificar(0, -1));
            #endregion
            }
        [TestMethod]
        public void testModificarPrimero()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(2);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            atrLista.Modificar(0, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(-1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrLista.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testModificarUltimo()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(2);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            atrLista.Modificar(3, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrLista.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(-1, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testModificarEnMedio()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(2);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            atrLista.Modificar(2, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(-1, atrLista.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        #endregion
        #region Casos de Prueba Recuperar
        [TestMethod]
        public void testRecuperarEnColeccionVacia()
            {
            #region Inicializar
            atrLista = new clsListaDobleEnlazada<int>();
            int varItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, atrLista.Recuperar(0, ref varItem));
            Assert.AreEqual(0, varItem);
            #endregion
            }
        [TestMethod]
        public void testRecuperarPrimero()
            {
            #region Inicializar
            int varItem = 0;
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(2);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrLista.Recuperar(0, ref varItem));
            Assert.AreEqual(1, varItem);
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrLista.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrLista.darNodoUltimo().darItem());
            #endregion
            }
        [TestMethod]
        public void testRecuperarUltimo()
            {
            #region Inicializar
            int varItem = 0;
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(2);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrLista.Recuperar(atrLista.darLongitud()-1, ref varItem));
            Assert.AreEqual(4, varItem);
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrLista.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrLista.darNodoUltimo().darItem());
            #endregion

            }
        [TestMethod]
        public void testRecuperarEnMedio()
            {
            #region Inicializar
            int varItem = 0;
            atrLista = new clsListaDobleEnlazada<int>();
            atrLista.Agregar(1);
            atrLista.Agregar(2);
            atrLista.Agregar(3);
            atrLista.Agregar(4);
            #endregion
            #region Probar
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrLista.Recuperar(2, ref varItem));
            Assert.AreEqual(3, varItem);
            Assert.AreEqual(1, atrLista.darNodoPrimero().darItem());
            Assert.AreEqual(2, atrLista.darNodoPrimero().darSiguiente().darItem());
            Assert.AreEqual(3, atrLista.darNodoPrimero().darSiguiente().darSiguiente().darItem());
            Assert.AreEqual(4, atrLista.darNodoUltimo().darItem());
            #endregion

            }
        #endregion
        #endregion
        }
    }