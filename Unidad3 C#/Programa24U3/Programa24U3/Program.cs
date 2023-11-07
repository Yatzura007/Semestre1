using System;

class Program
{
    static void Main(string[] args)
    {
        int num;

        do
        {
            Console.Write("Ingresa un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }
            }
        } while (num >= 0);
    }
}
