using System;

namespace P_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que solicite al usuario la edad y determine si es mayor o menor, considerando la mayoria de edad 18 años.
            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor edad.");
            }
            else 
            {
                Console.WriteLine("Usted es menor de edad.");
            }
        }
    }
}