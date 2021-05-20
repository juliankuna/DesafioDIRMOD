using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desafio_Dirmod;

namespace Pruebas_unitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Proyecto_Codificador_evaluarCaracter()
        {       string esperado= "2";
                string resultado = Codificador.evaluarCaracter('A');
                Assert.AreEqual(esperado, resultado);
        }
        
        [TestMethod]
        public void Proyecto_Codificador_VerificarMismaTecla()
        {
                bool result = Codificador.verificarMismaTecla(65,66,66,67);
                Assert.IsTrue(result, "NO ESTAN EN LA MISMA TECLA");
        }

        [TestMethod]
        public void Proyecto_Codificador_EvaluarSiguiente()
        {       string esperado= " ";
                string resultado = Codificador.evaluarSiguiente('A', 'B');
                Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Proyecto_Codificador_Codificar()
        {       
                string esperado = "44 444 ";
                string resultado = Codificador.codificar("HI");
                 
                 Assert.AreEqual(esperado, resultado);
        }

        
    }
}
