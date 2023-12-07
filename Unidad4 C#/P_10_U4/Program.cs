using System;

namespace P_10_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] paises = { "México", "Estados Unidos", "Canadá", "Brasil", "Argentina" };
            int totalLength = 0;

            foreach (string pais in paises)
            {
                totalLength += pais.Length;
            }

            double promedio = (double)totalLength / paises.Length;
            Console.WriteLine("Longitud promedio de los nombres de los países: " + promedio);
        }
    }
}