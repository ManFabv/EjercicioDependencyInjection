namespace EjercicioDependencyInjection
{
    public class CuentaPlata : ICuenta
    {
        public void MostrarPorConsolta() => System.Console.WriteLine("Cuenta PLATA");

        public string TipoDeCuenta() => "PLATA";
    }
}
