
using Escrevendo_Celular;

namespace UnitTestProject
{
    public class UnitTest
    {
        EscrevendoCelular e = new();

        [Test]
        public void TestMethod()
        {
            var teste = e.NumerosToFrase("33_555_2_66_2_666_8_33_77_88_33_777");


            Assert.AreEqual("2", e.FraseToNumeros("a"));
        }
        [Test]
        public void TestMethodDojo()
        {
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", e.FraseToNumeros("SEMPRE ACESSO O DOJOPUZZLES"));
        }
        [Test]
        public void TestMethodTest()
        {
            Assert.AreEqual("26_666077773399666", e.FraseToNumeros("amo sexo"));
        }
        [Test]
        public void TestMethodMelDaBracatinga()
        {
            Assert.AreEqual("633555_0320227772_222284446642", e.FraseToNumeros("Mel Da Bracatinga"));
        }
        [Test]
        public void DeveRetornar2()
        {
            Assert.AreEqual("2", e.FraseToNumeros("A"));
        }
        [Test]
        public void DeveRetornar3()
        {
            Assert.AreEqual("3", e.FraseToNumeros("D"));
        }
        [Test]
        public void DeveRetornar4()
        {
            Assert.AreEqual("4", e.FraseToNumeros("G"));
        }
        [Test]
        public void DeveRetornar5()
        {
            Assert.AreEqual("5", e.FraseToNumeros("J"));
        }
        [Test]
        public void DeveRetornar6()
        {
            Assert.AreEqual("6", e.FraseToNumeros("M"));
        }
        [Test]
        public void DeveRetornar7()
        {
            Assert.AreEqual("7", e.FraseToNumeros("P"));
        }
        [Test]
        public void DeveRetornar8()
        {
            Assert.AreEqual("8", e.FraseToNumeros("T"));
        }
        [Test]
        public void DeveRetornar9()
        {
            Assert.AreEqual("9", e.FraseToNumeros("W"));
        }
        [Test]
        public void DeveRetornar0()
        {
            Assert.AreEqual("0", e.FraseToNumeros(" "));
        }
        [Test]
        public void DeveRetornar5_5()
        {
            Assert.AreEqual("5_5", e.FraseToNumeros("JJ"));
        }
        public void DeveRetornar7777_77779()
        {
            Assert.AreEqual("7777_77779_997", e.FraseToNumeros("SSWXP"));
        }
        [Test]
        public void DeveRetornarErro()
        {
            Assert.AreEqual("Frase muito grande!", e.FraseToNumeros("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"));
        }
    }
}