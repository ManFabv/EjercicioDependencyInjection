using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDependencyInjection
{
    public sealed class Contenedor
    {
        private Contenedor() { }

        private static Dictionary<string, Type> dependencias = new Dictionary<string, Type>();

        public static void Registrar<T>(string name) => dependencias.Add(name, typeof(T));

        public static T Resolver<T>(string name) => (T) Activator.CreateInstance(dependencias[name]);
    }
}
