using System;

namespace Programa9U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa la hora de entrada (formato 24 horas): ");
            int horaEntrada = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa la hora de salida (formato 24 horas): ");
            int horaSalida = Convert.ToInt32(Console.ReadLine());

            int totalHoras = horaSalida - horaEntrada;

            double costo = 0;
            if (totalHoras > 10)
            {
                costo += 10 * 2;
                totalHoras -= 10;
                costo += totalHoras * 2;
            }
            else if (totalHoras > 5)
            {
                costo += 5 * 3;
                totalHoras -= 5;
                costo += totalHoras * 2;
            }
            else if (totalHoras > 2)
            {
                costo += 2 * 5;
                totalHoras -= 2;
                costo += totalHoras * 4;
            }
            else
            {
                costo += totalHoras * 5;
            }

            Console.WriteLine("El costo total es: $" + costo);
        
        }
    }
}