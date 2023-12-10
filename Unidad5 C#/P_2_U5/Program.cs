using System;
using System.Security.Cryptography.X509Certificates;

namespace P_5_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Temperatura C a F");
            Console.WriteLine("Temperatura F a K");
            Console.WriteLine("medida pulgadas a metros");
            Console.WriteLine("tiempo hrs a seg");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int c;
                    Console.WriteLine("opcion 1");
                    break;
                case 2:
                    Console.WriteLine("opcion 2");
                    break;
                case 3:
                    Console.WriteLine("opcion 3");
                    break;
                case 4:
                    Console.WriteLine("opcion 4");
                    break;


            }
        }

            public static double temperaturaCF(double c) 
            {
                double resultado = (c * 1.8) + 32;
                return resultado;

            }

            public static double temperaturaFK() 
            {
                double F, resultado;
                Console.Write("Escribe la temperatura K a convertir: ");
                F= Convert.ToDouble(Console.ReadLine());
                resultado = (F - 32) * (5 / 9) + 273.15;
                return resultado;
            }
        
    }
}