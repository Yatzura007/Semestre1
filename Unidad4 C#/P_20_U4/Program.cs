using System;

namespace P_20_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizOriginal = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrizCuadrada = new int[matrizOriginal.GetLength(0), matrizOriginal.GetLength(1)];

            for (int i = 0; i < matrizOriginal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizOriginal.GetLength(1); j++)
                {
                    matrizCuadrada[i, j] = matrizOriginal[i, j] * matrizOriginal[i, j];
                }
            }

            // Imprimir la matriz cuadrada
            for (int i = 0; i < matrizCuadrada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizCuadrada.GetLength(1); j++)
                {
                    Console.Write(matrizCuadrada[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}