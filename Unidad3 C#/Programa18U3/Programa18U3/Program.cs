using System;

class Program
{
    static void Main(string[] args)
    {
        double salario = 1500;
        double incremento = 0.1;
        double nuevo_salario;

        for (int i = 1; i <= 6; i++)
        {
            nuevo_salario = salario + (salario * incremento);
            Console.WriteLine($"El salario del año {i} es: ${nuevo_salario:F2}");
            salario = nuevo_salario;
        }

        Console.WriteLine($"El salario total recibido durante los 6 años es: ${salario - 1500:F2}");
    }
}
