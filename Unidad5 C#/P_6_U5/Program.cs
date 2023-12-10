using System;

namespace P_6_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el número de términos de la secuencia Fibonacci que deseas generar: ");
            int terminos = Convert.ToInt32(Console.ReadLine());
            Fibonacci(terminos);
        }

        static void Fibonacci(int terminos)
        {
            int t1 = 0, t2 = 1;
            for (int i = 1; i <= terminos; ++i)
            {
                Console.Write(t1 + ", ");
                int suma = t1 + t2;
                t1 = t2;
                t2 = suma;
            }
        }
    }
}