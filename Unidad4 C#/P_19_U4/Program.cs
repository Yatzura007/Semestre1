using System;

namespace P_19_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int contadorPares = 0, contadorImpares = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        contadorPares++;
                    }
                    else
                    {
                        contadorImpares++;
                    }
                }
            }

            Console.WriteLine("Cantidad de números pares: " + contadorPares);
            Console.WriteLine("Cantidad de números impares: " + contadorImpares);
        }
    }
}