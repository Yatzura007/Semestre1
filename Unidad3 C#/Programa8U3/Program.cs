using System;

namespace Programa8U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El primer número es mayor.");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("El segundo número es mayor.");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }
    }
}