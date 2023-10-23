using System;

namespace Programa7U3 {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa la temperatura actual: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura > 27)
            {
                Console.WriteLine("Hace Calor");
            }
            else if (temperatura > 20 && temperatura <= 27)
            {
                Console.WriteLine("Clima agradable");
            }
            else
            {
                Console.WriteLine("Clima fresco o frío");
            }
        }
    }
}