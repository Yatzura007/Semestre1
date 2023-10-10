using System;

namespace P_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que calcule el área de un hexágono.
            double a, area;
            
            Console.WriteLine("Ingrese la longuitud de un lado del hexagono: ");
            a = Convert.ToInt32(Console.ReadLine());
            area = (9 * Math.Sqrt(3) * Math.Pow(a, 2)) / 2;
            Console.WriteLine("El area del hexagono es: " + area);
        }
    }
}