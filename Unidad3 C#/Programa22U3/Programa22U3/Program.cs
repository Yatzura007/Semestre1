using System;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0, num;
        do
        {
            Console.WriteLine("Escribe el numero");
            num = Convert.ToInt32(Console.ReadLine());
            suma = suma + num;
        } while (num != 0);
        Console.WriteLine("Resultado es: " + suma);
    }
}
