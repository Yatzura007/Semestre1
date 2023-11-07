using System;

class Program
{
    static void Main(string[] args)
    {
        double ahorro = 3;
        double nuevo_ahorro;

        for (int i = 1; i <= 365; i++)
        {
            Console.WriteLine($"El ahorro del día {i} es: ${ahorro:F2}");
            nuevo_ahorro = ahorro * 3;
            ahorro = nuevo_ahorro;
        }

        Console.WriteLine($"El ahorro total acumulado durante el año es: ${ahorro - 3:F2}");
    }
}
