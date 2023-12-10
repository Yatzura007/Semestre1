using System;

namespace P_9_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el sueldo diario: ");
            double sueldoDiario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce los días trabajados: ");
            int diasTrabajados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El finiquito es: " + CalcularFiniquito(sueldoDiario, diasTrabajados));
        }

        static double CalcularFiniquito(double sueldoDiario, int diasTrabajados)
        {
            return sueldoDiario * diasTrabajados;
        }
    }
}