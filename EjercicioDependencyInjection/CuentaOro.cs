namespace EjercicioDependencyInjection
{
    public class CuentaOro : ICuenta
    {
        public void MostrarPorConsolta() => System.Console.WriteLine("Cuenta ORO");

        public string TipoDeCuenta() => "ORO";
    }
}
