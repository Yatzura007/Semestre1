using System;

namespace P_3
{
    internal class Promedio
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que determine el promedio de 6 calificaciones.
            int C1 = 7, C2 = 6, C3 = 8, C4 =10 , C5 = 9, C6 = 7,suma, promedio;
            suma = C1 + C2 + C3 + C4 + C5 + C6;
            promedio = suma / 6;
            Console.WriteLine(promedio);


        }
    }
}