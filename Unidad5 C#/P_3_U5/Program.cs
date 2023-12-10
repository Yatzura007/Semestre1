using System;

namespace P_3_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el valor para X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe el valor para Y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Resultado ecuacional: " + Ecuacion1(x, y));
Console.WriteLine("Resultado ecuaciona2: " + Ecuacion2(x, y));
    }

    public static double Ecuacion1(double x, double y)
{
    double r = Math.Pow(x, 2) + (2 * Math.Pow(y, 4));
    return r;
}

public static double Ecuacion2(double x, double y)
{
    double r = Math.Sqrt(Math.Pow(x, 4) + 5 * y);
    return r;
    }
  }
}