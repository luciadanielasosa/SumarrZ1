using Microsoft.VisualStudio.TestTools.UnitTesting;
using sumar.Controllers;

namespace UnitTestSumar1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //arrange
            sumacontroller sumaController = new sumacontroller();
            int a = 5;
            int b = 8;
            int esperado = 13;

            //act
            int resultado = sumaController.Add(a, b);

            //assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
