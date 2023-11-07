using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa la cantidad de números: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingresa el número {i}: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int cubo = num * num * num;
            Console.WriteLine($"El cubo de {num} es: {cubo}");
        }
    }
}
