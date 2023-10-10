using System;

namespace P_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //.Realizar un algoritmo que permita calcular la siguiente formula: x=y+a+3
            int x, y, a;
            Console.WriteLine("ingrese el valor de Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());
            x= y + a + 3;
            Console.WriteLine("El resultado de la formula x=y+a+3 es: " + x);
            Console.ReadLine();
        }
    }
}