using EjercicioDependencyInjection;
using NUnit.Framework;

namespace Tests
{
    public class UnitTests
    {
        private Persona p;
        private ICuenta c;

        [SetUp]
        public void SetUp()
        {
            c = new CuentaOro();
            p = new Persona("Fabricio", c);
        }

        [Test]
        public void Test()
        {
            var tipo = p.TipoDeCuenta();
            Assert.That(tipo, Is.EqualTo("ORO"));
        }
    }
}