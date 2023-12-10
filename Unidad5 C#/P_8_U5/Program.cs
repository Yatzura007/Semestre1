using System;

namespace P_8_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El resultado de lanzar el dado es: " + LanzarDado());
        }

        static int LanzarDado()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}