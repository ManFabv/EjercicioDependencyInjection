namespace EjercicioDependencyInjection
{
    public interface IPersona
    {
        void Mostrar();
        string TipoDeCuenta();
        string Nombre { get; }
    }
}
