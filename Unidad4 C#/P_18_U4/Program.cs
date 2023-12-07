using System;

namespace P_18_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sumaDiagonalPrincipal = 0, sumaDiagonalSecundaria = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sumaDiagonalPrincipal += matriz[i, i];
                sumaDiagonalSecundaria += matriz[i, matriz.GetLength(0) - 1 - i];
            }

            Console.WriteLine("La suma de la diagonal principal es: " + sumaDiagonalPrincipal);
            Console.WriteLine("La suma de la diagonal secundaria es: " + sumaDiagonalSecundaria);
        }
    }
}