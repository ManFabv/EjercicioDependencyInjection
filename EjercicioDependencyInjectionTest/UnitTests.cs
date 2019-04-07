using EjercicioDependencyInjection;
using NUnit.Framework;

namespace Tests
{
    public class UnitTests
    {
        private Persona p;
        private const string TipoOro = "ORO";

        [SetUp]
        public void SetUp()
        {
            Contenedor.Registrar<CuentaOro>(TipoOro);
            p = new Persona("Fabricio", Contenedor.Resolver<CuentaOro>(TipoOro));
        }

        [Test]
        public void TestTipo()
        {
            var tipo = p.TipoDeCuenta();
            Assert.That(tipo, Is.EqualTo(TipoOro));
        }
    }
}