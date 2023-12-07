using System;

namespace P_3_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitud del total de temperaturas
            Console.Write("Ingresa el total de temperaturas a procesar: ");
            //Lectura del total de temperaturas
            int total = Convert.ToInt32(Console.ReadLine());
            //Creación del arreglo de temperaturas
            double[] temperaturas = new double[total];
            //Lectura de las temperaturas
            for (int i = 0; i < total; i++)
            {
                Console.Write($"Ingresa la temperatura {i + 1} en °C: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }
            //Conversión e impresión de las temperaturas
            for (int i = 0; i < total; i++)
            {
                double fahrenheit = temperaturas[i] * 9 / 5 + 32;
                double kelvin = temperaturas[i] + 273.15;

                Console.WriteLine($"Temperatura {i + 1}: {temperaturas[i]}°C = {fahrenheit}°F = {kelvin}K");
            }

        }
    }
}