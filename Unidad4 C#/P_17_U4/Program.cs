using System;

namespace P_17_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño de las matrices:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] numA = new int[n, n];
            int[,] numB = new int[n, n];
            int[,] R = new int[n, n];

            Console.WriteLine("Introduce los valores para la primera matriz: ");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    numA[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Introduce los valores para la segunda matriz: ");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    numB[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        R[f, c] += numA[f, k] * numB[k, c];
                    }
                }
            }

            Console.WriteLine("Los resultados son estos: ");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(R[f, c] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}