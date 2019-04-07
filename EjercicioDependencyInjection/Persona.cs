namespace EjercicioDependencyInjection
{
    public class Persona : IPersona
    {
        private readonly string _nombre;
        private readonly ICuenta _cuenta;

        public Persona(string nombre, ICuenta cuenta)
        {
            _nombre = nombre;
            _cuenta = cuenta;
        }

        public void Mostrar() => _cuenta.MostrarPorConsolta();

        public string TipoDeCuenta() => _cuenta.TipoDeCuenta();
    }
}
