using System;

namespace P_1_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int suma = 0;
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    suma += num[i, j];
                }
            }
            Console.WriteLine("La suma de todos los elementos es: " + suma);
        }
    }
}