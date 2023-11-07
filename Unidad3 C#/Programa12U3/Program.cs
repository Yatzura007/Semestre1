using System;

public class Programa12U3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe el total de numeros a procesar: ");
        int total = Convert.ToInt32(Console.ReadLine());
        for (int c = 1; c <= total; c++)
        {
            Console.WriteLine("Escribe un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}
