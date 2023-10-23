using System;

namespace Programa1U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Escribe tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
                Console.WriteLine("Eres Mayor de edad!!!");
            else
                Console.WriteLine("Eres Menor de edad!!");
        }
    }
}