using System;

namespace P_7_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Juan", "Ana", "Carlos" };
            string[] apellidos = { "Pérez", "Gómez", "Ramírez" };

            string[] nombresCompletos = new string[nombres.Length];
            for (int i = 0; i < nombres.Length; i++)
            {
                nombresCompletos[i] = nombres[i] + " " + apellidos[i];
            }

            foreach (string nombreCompleto in nombresCompletos)
            {
                Console.WriteLine(nombreCompleto);
            }
        }
    }
}
