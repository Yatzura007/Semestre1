using System;

namespace P_7_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el precio sin IVA: ");
            double precioSinIVA = Convert.ToDouble(Console.ReadLine());
            double iva = CalcularIVA(precioSinIVA);
            double total = CalcularTotal(precioSinIVA, iva);
            Console.WriteLine("IVA: " + iva);
            Console.WriteLine("Total: " + total);
        }

        static double CalcularIVA(double precioSinIVA)
        {
            return precioSinIVA * 0.16;
        }

        static double CalcularTotal(double precioSinIVA, double iva)
        {
            return precioSinIVA + iva;
        }
    }
}