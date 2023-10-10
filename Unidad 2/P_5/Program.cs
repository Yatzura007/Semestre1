using System;

namespace P_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que calcule el area y perimetro de un triangulo.
            int h, L, B;
            float Perimetro, Area;
            Console.WriteLine("ingrese la medida de la altura: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la medida de los lados: ");
            L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la medida de la base: ");
            B = Convert.ToInt32(Console.ReadLine());
            Perimetro = L + L + L;
            Area = (h * B) / 2;
            Console.WriteLine("El area del triangulo es:" + Area);
            Console.WriteLine("Y el perimetro del triamgulo es: " + Perimetro);
        }
    }
}