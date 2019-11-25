using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestListaVectorCRUDV1
        {
        #region Atributos de Prueba
        clsListaVector<int> atrListaDatos;
        int[] atrVectorDeItemsEsperado;
        string atrMensajeResultado;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba Agregar
        [TestMethod]
        public void testAgegarUnItem()
            {
            #region Inicializar
            atrListaDatos = new clsListaVector<int>();
            bool varResultadoDeAgregar = false;
            #endregion
            #region Probar
            varResultadoDeAgregar = atrListaDatos.Agregar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeAgregar);
            Assert.AreEqual(1, atrListaDatos.darLongitud());
            Assert.AreEqual(100, atrListaDatos.darCapacidad());
            #endregion
            }
        [TestMethod]
        public void testAgregar2ItemsConCapacidadFlexible()
            {
            #region Inicializar
            atrMensajeResultado += "\n-Segundos:";
            atrListaDatos = new clsListaVector<int>(1, 20);
            #endregion
            #region Probar
            Assert.AreEqual(true, atrListaDatos.Agregar(999));
            Assert.AreEqual(true, atrListaDatos.Agregar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(2, atrListaDatos.darLongitud());
            Assert.AreEqual(21, atrListaDatos.darCapacidad());
            Assert.AreEqual(21, atrListaDatos.darVectorItems().Length);
            #endregion
            }
        [TestMethod]
        public void testAgregar3HastaLlenar()
            {
            #region Inicializar
            atrListaDatos = new clsListaVector<int>(500);
            bool varResultadoDeAgregar = true;
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeAgregar = varResultadoDeAgregar && atrListaDatos.Agregar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeAgregar);
            Assert.AreEqual(500, atrListaDatos.darLongitud());
            Assert.AreEqual(atrListaDatos.darLongitud(), atrListaDatos.darCapacidad());
            Assert.AreEqual(500, atrListaDatos.darCapacidad());
            Assert.AreEqual(499, atrListaDatos.darVectorItems()[atrListaDatos.darLongitud() - 1]);
            Assert.AreEqual(0, atrListaDatos.darVectorItems()[0]);
            #endregion
            }
        #endregion
        #region Casos de Prueba Insertar 
        [TestMethod]
        public void testInsertarUnItemEnListaNoLlenaNoFlexible()
            {
            #region Configurar
            atrListaDatos = new clsListaVector<int>(3);
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(3);
            #endregion
            #region Probar
            bool varResultado = atrListaDatos.Insertar(1, 2);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultado);
            Assert.AreEqual(3, atrListaDatos.darLongitud());
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(2, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[2]);
            #endregion
            }
        [TestMethod]
        public void testInsertarUnItemEnListaLlenaNoFlexible()
            {
            #region Configurar
            atrListaDatos = new clsListaVector<int>(3);
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            bool varResultado = atrListaDatos.Insertar(1, 2);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultado);
            Assert.AreEqual(3, atrListaDatos.darLongitud());
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[2]);
            #endregion
            }
        [TestMethod]
        public void testInsertarUnItemEnListaLlenaFlexible()
            {
            #region Configurar
            atrListaDatos = new clsListaVector<int>(2, 1);
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(3);
            #endregion
            #region Probar
            bool varResultado = atrListaDatos.Insertar(1, 2);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultado);
            Assert.AreEqual(3, atrListaDatos.darLongitud());
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(2, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[2]);
            #endregion
            }
        [TestMethod]
        public void testInsertarUnItemEnListaNoLlenaConIndiceInvalido()
            {
            #region Configurar
            atrListaDatos = new clsListaVector<int>(3);
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
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(0, atrListaDatos.darVectorItems()[2]);
            #endregion
            }
        #endregion
        #region Casos de Prueba Extraer 
        [TestMethod]
        public void testExtraerUnItemEnListaNoLlena()
            {
            #region Configurar
            atrListaDatos = new clsListaVector<int>(3);
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
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(0, atrListaDatos.darVectorItems()[2]);
            #endregion
            }
        [TestMethod]
        public void testExtraerUnItemEnListaLlena()
            {
            #region Configurar
            atrListaDatos = new clsListaVector<int>(3);
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            int varItemRemovido = 0;
            bool varResultado = atrListaDatos.Remover(1, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultado);
            Assert.AreEqual(2, atrListaDatos.darLongitud());
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[2]);
            #endregion
            }
        [TestMethod]
        public void testExtraerUnItemEnListaVacia()
            {
            #region Configurar
            atrListaDatos = new clsListaVector<int>(3);
            #endregion
            #region Probar
            int varItemRemovido = 0;
            bool varResultado = atrListaDatos.Remover(1, ref varItemRemovido);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultado);
            Assert.AreEqual(0, atrListaDatos.darLongitud());
            Assert.AreEqual(0, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(0, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(0, atrListaDatos.darVectorItems()[2]);
            #endregion
            }
        [TestMethod]
        public void testExtraerUnItemEnListaLlenaConIndiceInvalido()
            {
            #region Configurar
            atrListaDatos = new clsListaVector<int>(3);
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
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[2]);
            #endregion
            }
        #endregion
        #region Casos de Prueba Reversar
        [TestMethod]
        public void testReversarConListaSemiLLena()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[5] { 4, 3, 2, 1, 0 };
            atrListaDatos = new clsListaVector<int>(5);
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Reversar();
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrListaDatos.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConListaLLena()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[4] { 4, 3, 2, 1 };
            atrListaDatos = new clsListaVector<int>(4);
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Reversar();
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrListaDatos.darVectorItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConListaVacia()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[4] { 0, 0, 0, 0 };
            atrListaDatos = new clsListaVector<int>(4);
            #endregion
            #region Probar
            atrListaDatos.Reversar();
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrListaDatos.darVectorItems());
            #endregion
            }
        #endregion
        #region Casos de Prueba Modificar
        [TestMethod]
        public void testModificarEnColeccionVacia()
            {
            #region Inicializar
            atrListaDatos = new clsListaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, atrListaDatos.Modificar(0, -1));
            #endregion
            }
        [TestMethod]
        public void testModificarPrimero()
            {
            #region Inicializar
            atrListaDatos = new clsListaVector<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Modificar(0, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(-1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(2, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[2]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[3]);
            #endregion
            }
        [TestMethod]
        public void testModificarUltimo()
            {
            #region Inicializar
            atrListaDatos = new clsListaVector<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Modificar(3, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(2, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[2]);
            Assert.AreEqual(-1, atrListaDatos.darVectorItems()[3]);
            #endregion
            }
        [TestMethod]
        public void testModificarEnMedio()
            {
            #region Inicializar
            atrListaDatos = new clsListaVector<int>();
            atrListaDatos.Agregar(1);
            atrListaDatos.Agregar(2);
            atrListaDatos.Agregar(3);
            atrListaDatos.Agregar(4);
            #endregion
            #region Probar
            atrListaDatos.Modificar(2, -1);
            #endregion
            #region Comprobar
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(2, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(-1, atrListaDatos.darVectorItems()[2]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[3]);
            #endregion
            }
        #endregion
        #region Casos de Prueba Recuperar
        [TestMethod]
        public void testRecuperarEnColeccionVacia()
            {
            #region Inicializar
            atrListaDatos = new clsListaVector<int>();
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
            atrListaDatos = new clsListaVector<int>();
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
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(2, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[2]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[3]);
            #endregion
            }
        [TestMethod]
        public void testRecuperarUltimo()
            {
            #region Inicializar
            int varItem = 0;
            atrListaDatos = new clsListaVector<int>();
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
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(2, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[2]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[3]);
            #endregion
            }
        [TestMethod]
        public void testRecuperarEnMedio()
            {
            #region Inicializar
            int varItem = 0;
            atrListaDatos = new clsListaVector<int>();
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
            Assert.AreEqual(1, atrListaDatos.darVectorItems()[0]);
            Assert.AreEqual(2, atrListaDatos.darVectorItems()[1]);
            Assert.AreEqual(3, atrListaDatos.darVectorItems()[2]);
            Assert.AreEqual(4, atrListaDatos.darVectorItems()[3]);
            #endregion
            }
        #endregion
        #endregion
        }
    }
