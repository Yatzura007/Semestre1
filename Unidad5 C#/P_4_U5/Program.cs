using System;

namespace P_4_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EsPrimo(numero) ? "El número es primo" : "El número no es primo");
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}