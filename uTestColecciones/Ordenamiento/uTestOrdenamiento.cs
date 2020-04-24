using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestOrdenamiento
        {
        #region Atributos de Prueba
        clsPilaVector<int> atrPilaDatos;
        clsPilaVector<clsPersona> atrPilaObjetos;
        int[] atrVectorDeItemsEsperado;
        string atrMensajeResultado;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba Ordenamiento
        #region Burbuja Simple
        #region Colección Vacía
        [TestMethod]
        public void testOrdenarBurbujaSimplePilaVaciaDeEnterosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "La Pila Vector está vacía.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePilaVaciaDeEnterosDescendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePilaVaciaDeObjetosAscendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePilaVaciaDeObjetosDescendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOdrenarBurbujaSimplePeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :7.\n";
            atrMensajeResultado += "-Comparaciones      :21.\n";
            atrMensajeResultado += "-Intercambios       :21.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(21, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :7.\n";
            atrMensajeResultado += "-Comparaciones      :21.\n";
            atrMensajeResultado += "-Intercambios       :21.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(21, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :10.\n";
            atrMensajeResultado += "-Comparaciones      :45.\n";
            atrMensajeResultado += "-Intercambios       :45.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(45, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :10.\n";
            atrMensajeResultado += "-Comparaciones      :45.\n";
            atrMensajeResultado += "-Intercambios       :45.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(45, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :10.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :10.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");

            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :10.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :10.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :7.\n";
            atrMensajeResultado += "-Comparaciones      :21.\n";
            atrMensajeResultado += "-Intercambios       :4.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :7.\n";
            atrMensajeResultado += "-Comparaciones      :21.\n";
            atrMensajeResultado += "-Intercambios       :17.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(17, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :10.\n";
            atrMensajeResultado += "-Comparaciones      :45.\n";
            atrMensajeResultado += "-Intercambios       :25.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(25, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :10.\n";
            atrMensajeResultado += "-Comparaciones      :45.\n";
            atrMensajeResultado += "-Intercambios       :20.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(20, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :6.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :4.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :6.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :4.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por descendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por ascendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.ponerModoInteligente(true);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :7.\n";
            atrMensajeResultado += "-Comparaciones      :21.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :7.\n";
            atrMensajeResultado += "-Comparaciones      :21.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por descendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.ponerModoInteligente(true);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por ascendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.ponerModoInteligente(true);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :10.\n";
            atrMensajeResultado += "-Comparaciones      :45.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :10.\n";
            atrMensajeResultado += "-Comparaciones      :45.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        //TODO: error de compilacion con darCronometro
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeEnterosFuerzaBrutaVsInteligenteAscendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>(1000);
            clsPilaVector<int> varPilaDatosBruta = new clsPilaVector<int>(atrPilaDatos.darCapacidad());
            atrVectorDeItemsEsperado = new int[atrPilaDatos.darCapacidad()];
            for (int varIndice = 0; varIndice < atrPilaDatos.darCapacidad(); varIndice++)
                {
                atrVectorDeItemsEsperado[varIndice] = varIndice + 1;
                atrPilaDatos.Apilar(varIndice + 1);
                varPilaDatosBruta.Apilar(varIndice + 1);
                }
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            varPilaDatosBruta.ponerModoInteligente(false);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            varPilaDatosBruta.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darCronometro().darTicks() < varPilaDatosBruta.darCronometro().darTicks());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por descendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, this.atrPilaObjetos.darMensajeUltimoMetodo().Contains(this.atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por ascendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por descendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por ascendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;

            clsPilaVector<clsPersona> atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por descendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por ascendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :7.\n";
            atrMensajeResultado += "-Comparaciones      :21.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :7.\n";
            atrMensajeResultado += "-Comparaciones      :21.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por descendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por ascendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :10.\n";
            atrMensajeResultado += "-Comparaciones      :45.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por descendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por ascendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, this.atrPilaObjetos.darMensajeUltimoMetodo().Contains(this.atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por descendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado, sin embargo presentó algunos problemas:\n";
            atrMensajeResultado += "No debe ordenar, la colección ya está ordenada por ascendente.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, atrPilaObjetos.darMensajeUltimoMetodo().Contains(atrMensajeResultado));
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            atrMensajeResultado += "-Items              :5.\n";
            atrMensajeResultado += "-Comparaciones      :10.\n";
            atrMensajeResultado += "-Intercambios       :0.\n";
            atrMensajeResultado += "-Inserciones        :0.\n";
            atrMensajeResultado += "-Llamados Recursivos:0.\n";
            atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            atrMensajeResultado += "\n-Dias:\t\t0,000.";
            atrMensajeResultado += "\n-Horas:\t\t0,000.";
            atrMensajeResultado += "\n-Minutos:\t0,000.";
            atrMensajeResultado += "\n-Segundos:";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //TODO: Sin mensajero
            //Assert.AreEqual(true, this.atrPilaObjetos.darMensajeUltimoMetodo().Contains(this.atrMensajeResultado));
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Burbuja Mejorado
        #region Colección Vacía
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPilaVaciaDeEnterosAscendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPilaVaciaDeEnterosDescendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPilaVaciaDeObjetosAscendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPilaVaciaDeObjetosDescendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(21, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(21, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(45, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(45, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(15, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(20, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(17, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(39, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(25, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(35, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(20, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(9, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(9, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Burbuja BiDireccional
        #region Colección Vacía
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPilaVaciaDeEnterosAscendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPilaVaciaDeEnterosDescendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPilaVaciaDeObjetosAscendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPilaVaciaDeObjetosDescendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(42, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(21, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(42, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(21, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10,true,true, true);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(90, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(45, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(90, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(45, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(20, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(20, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(20, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(20, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(18, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(36, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(17, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(63, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(25, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(54, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(20, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(20, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(20, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);

            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;

            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Inserción
        #region Colección Vacía
        [TestMethod]
        public void testOrdenarInsercionPilaVaciaDeEnterosAscendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPilaVaciaDeEnterosDescendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPilaVaciaDeObjetosAscendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPilaVaciaDeObjetosDescendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(27, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(6, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(27, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(6, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(54, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(9, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(54, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(9, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(14, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(14, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(14, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(14, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(10, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(6, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(23, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(6, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(34, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(9, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(29, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(9, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(8, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(8, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(6, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(6, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(9, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(9, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(6, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(6, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(6, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(9, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(9, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(9, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarInsercion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Selección
        #region Colección Vacía
        [TestMethod]
        public void testOrdenarSeleccionPilaVaciaDeEnterosAscendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPilaVaciaDeEnterosDescendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPilaVaciaDeObjetosAscendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPilaVaciaDeObjetosDescendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(2, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(7, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(8, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(21, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(9, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(45, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjCristina;
            atrVectorDeItemsEsperado[2] = varObjMartin;
            atrVectorDeItemsEsperado[3] = varObjEmilio;
            atrVectorDeItemsEsperado[4] = varObjLucero;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjCristina;
            atrVectorDeItemsEsperado[2] = varObjMartin;
            atrVectorDeItemsEsperado[3] = varObjEmilio;
            atrVectorDeItemsEsperado[4] = varObjLucero;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region QuickSort
        #region Colección Vacía
        [TestMethod]
        public void testOrdenarQuickSortPilaVaciaDeEnterosAscendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPilaVaciaDeEnterosDescendente()
            {
            #region Inicializar
            atrPilaDatos = new clsPilaVector<int>();
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPilaVaciaDeObjetosAscendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPilaVaciaDeObjetosDescendente()
            {
            #region Inicializar
            atrPilaObjetos = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(16, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(16, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(34, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(11, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(34, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(11, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(25, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(4, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(31, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(7, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(5, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(39, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(-2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(-4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(-6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(-8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(-10);
            atrPilaDatos.AjustarOrdenColeccion("Promedio");

            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(49, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(10, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(8, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaNormalDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(18, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(3, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaNormalDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(14, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaLlenaDeObjetosDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(18, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(4, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(3, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaLlenaDeObjetosAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(14, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(16, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(16, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.AjustarOrdenColeccion("Descendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Ascendente");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(31, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(5, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(10);
            atrPilaDatos.Apilar(9);
            atrPilaDatos.Apilar(8);
            atrPilaDatos.Apilar(7);
            atrPilaDatos.Apilar(6);
            atrPilaDatos.Apilar(5);
            atrPilaDatos.Apilar(4);
            atrPilaDatos.Apilar(3);
            atrPilaDatos.Apilar(2);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(31, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(5, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Descendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.AjustarOrdenColeccion("Ascendente");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCarlos;
            atrVectorDeItemsEsperado[1] = varObjLucero;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjMartin;
            atrVectorDeItemsEsperado[4] = varObjCristina;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjCarlos);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(12, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(3, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(16, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(8, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(16, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(8, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeEnterosInteligenteDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeEnterosInteligenteAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.AjustarOrdenColeccion("Constante");
            atrPilaDatos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(0, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(30, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(15, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            atrPilaDatos.Apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaDatos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaDatos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darVectorItems());
            Assert.AreEqual(30, atrPilaDatos.darNumeroComparaciones());
            Assert.AreEqual(15, atrPilaDatos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaDatos.darNumeroInserciones());
            Assert.AreEqual(6, atrPilaDatos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #region Con Objetos
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjLucero;
            atrVectorDeItemsEsperado[1] = varObjCarlos;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjCristina;
            atrVectorDeItemsEsperado[4] = varObjMartin;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[5];
            atrVectorDeItemsEsperado[0] = varObjLucero;
            atrVectorDeItemsEsperado[1] = varObjCarlos;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjCristina;
            atrVectorDeItemsEsperado[4] = varObjMartin;
            atrPilaObjetos = new clsPilaVector<clsPersona>(5);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeObjetosInteligenteDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeObjetosInteligenteAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjCristina;
            atrVectorDeItemsEsperado[1] = varObjMartin;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjLucero;
            atrVectorDeItemsEsperado[4] = varObjCarlos;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            atrPilaObjetos.AjustarOrdenColeccion("Constante");
            atrPilaObjetos.ponerModoInteligente(true);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeObjetosFuerzaBrutaDescendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjLucero;
            atrVectorDeItemsEsperado[1] = varObjCarlos;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjCristina;
            atrVectorDeItemsEsperado[4] = varObjMartin;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar

            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeObjetosFuerzaBrutaAscendente()
            {
            #region Inicializar
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 40);
            clsPersona[] atrVectorDeItemsEsperado = new clsPersona[10];
            atrVectorDeItemsEsperado[0] = varObjLucero;
            atrVectorDeItemsEsperado[1] = varObjCarlos;
            atrVectorDeItemsEsperado[2] = varObjEmilio;
            atrVectorDeItemsEsperado[3] = varObjCristina;
            atrVectorDeItemsEsperado[4] = varObjMartin;
            atrPilaObjetos = new clsPilaVector<clsPersona>(10);
            atrPilaObjetos.Apilar(varObjCarlos);
            atrPilaObjetos.Apilar(varObjLucero);
            atrPilaObjetos.Apilar(varObjEmilio);
            atrPilaObjetos.Apilar(varObjMartin);
            atrPilaObjetos.Apilar(varObjCristina);
            #endregion
            #region Probar
            atrPilaObjetos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar

            Assert.AreEqual(true, atrPilaObjetos.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, atrPilaObjetos.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaObjetos.darVectorItems());
            Assert.AreEqual(10, atrPilaObjetos.darNumeroComparaciones());
            Assert.AreEqual(5, atrPilaObjetos.darNumeroIntercambios());
            Assert.AreEqual(0, atrPilaObjetos.darNumeroInserciones());
            Assert.AreEqual(2, atrPilaObjetos.darNumeroLlamadosRecursivos());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #endregion
        #endregion
        }
    }
