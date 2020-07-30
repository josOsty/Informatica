using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informatica.Negocio.Tests
{
    [TestClass]
    public class ComparadorTest
    {
        [TestMethod]
        public void ObtenerMenor()
        {
            //Triple A => AAA = Arrange Act Assert
            //Organizar datos -- Arrange
            var primerElemento = 56;
            var segundoElemento = 20;
            var esperado = 20;
            //Ejecute -- Act
            Comparador comparador = new Comparador();
            int actual = comparador.ObtenerMenor(primerElemento, segundoElemento);

            //Comprobar --Assert
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void ObtenerMayor()
        {
            //Triple A => AAA = Arrange Act Assert
            //Organizar datos -- Arrange
            var primerElemento = 56;
            var segundoElemento = 20;
            var esperado = 56;
            //Ejecute -- Act
            Comparador comparador = new Comparador();
            int actual = comparador.ObtenerMayor(primerElemento, segundoElemento);

            //Comprobar --Assert
            Assert.AreEqual(esperado, actual);
        }
    }
}
