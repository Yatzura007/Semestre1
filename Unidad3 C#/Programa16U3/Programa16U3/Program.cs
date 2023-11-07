using System;

public class Programa16U3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
        int horas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el pago por hora:  ");
        int pago = Convert.ToInt32(Console.ReadLine());

        int sueldo = horas * pago;

        Console.WriteLine("Sueldo de trabajor: " + sueldo);
    }
}
