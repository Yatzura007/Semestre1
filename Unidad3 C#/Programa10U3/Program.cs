using System;

namespace Programa10U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa las horas trabajadas: ");
            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el pago por hora: ");
            double pagoPorHora = Convert.ToDouble(Console.ReadLine());

            double sueldo;
            if (horasTrabajadas > 40)
            {
                sueldo = 40 * pagoPorHora;
                sueldo += (horasTrabajadas - 40) * pagoPorHora * 2;
            }
            else
            {
                sueldo = horasTrabajadas * pagoPorHora;
            }

            Console.WriteLine("El sueldo semanal es: $" + sueldo);
        }
    }
}