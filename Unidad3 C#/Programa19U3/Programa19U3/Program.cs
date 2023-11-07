using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa la cantidad de números: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int num, cant_cero = 0, cant_mayor = 0, cant_menor = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingresa el número {i}: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                cant_cero++;
            }
            else if (num > 0)
            {
                cant_mayor++;
            }
            else
            {
                cant_menor++;
            }
        }

        Console.WriteLine($"Cantidad de números iguales a cero: {cant_cero}");
        Console.WriteLine($"Cantidad de números mayores a cero: {cant_mayor}");
        Console.WriteLine($"Cantidad de números menores a cero: {cant_menor}");
    }
}
