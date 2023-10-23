using System;

namespace Programa5U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1, P2, P3, total;
            Console.Write("Escribe el precio del producto 1: ");
            P1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escribe el precio del producto 2: ");
            P2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escribe el precio del producto 3: ");
            P3 = Convert.ToDouble(Console.ReadLine());
            total = P1 + P2 + P3;
            if (total >= 1500)
            {
                total = total - (total * 0.30);
                Console.Write("El Total (30%desc): " + total);
            }
            else if (total < 1500 && total >= 1000)
            {
                total = total - (total * 0.20);
                Console.Write("El Total (20%desc): " + total);
            }
            else if (total < 1000 && total >= 7008)
            {
                total = total - (total * 0.10);
                Console.Write("El Total (10%desc): " + total);
            }
            else
            {
                Console.Write("El Total (Sin desc): " + total);
            }
        }
    }
}