using System;

public class Programa13u3
{
    static void Main(string[] args)
    {
        int positivos = 0;
        int negativos = 0;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Introduce el número " + (i + 1) + ":");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                positivos++;
            }
            else if (numero < 0)
            {
                negativos++;
            }
        }

        Console.WriteLine("Cantidad de números positivos: " + positivos);
        Console.WriteLine("Cantidad de números negativos: " + negativos);
    }
}
