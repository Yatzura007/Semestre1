using System;

class Program
{
    static void Main()
    {
        int[] Num = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

        int contadorNegativos = 0;

        for (int i = 0; i < Num.Length; i++)
        {
            if (Num[i] < 0)
            {
                contadorNegativos++;
            }
        }

        Console.WriteLine("El total de números negativos es: " + contadorNegativos);
    }
}
