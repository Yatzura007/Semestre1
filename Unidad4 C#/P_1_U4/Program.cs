using System;

namespace P_1_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edades = { 15, 18, 21, 17, 22 };

            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] >= 18)
                {
                    Console.WriteLine("La edad " + edades[i] + " es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("La edad " + edades[i] + " es menor de edad.");
                }
            }
        }
    }
}
