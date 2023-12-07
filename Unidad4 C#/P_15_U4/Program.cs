using System;

namespace P_15_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                double suma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    suma += matriz[i, j];
                }
                double media = suma / matriz.GetLength(1);
                Console.WriteLine("La media de la fila " + (i + 1) + " es: " + media);
            }
        }
    }
}