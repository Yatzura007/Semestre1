using System;

namespace P_1_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma = " + Suma(7, 8));
            Console.WriteLine("Resta = " + Resta(9, 8));
            Console.WriteLine("Multiplicacion = " + Multi(5, 8));
            Console.WriteLine("Division = " + Div(16, 8));
        }

        public static int Suma(int a, int b)
        {
            int s = a + b;
            return s;
        }

        public static int Resta(int a, int b)
        {
            int r = a - b;
            return r;
        }

        public static int Multi(int a, int b)
        {
            int m = a * b;
            return m;
        }

        public static int Div(int a, int b)
        {
            int d = a / b;
            return d;
        }
    }
}