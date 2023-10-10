using System;

namespace P_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo realice las operaciones basicas de una calculadora(suma, resta, multiplicación, división) a partir de 2 números.
            double num1, num2;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma de {0} y {1} es {2}",num1, num2, num1 + num2);
            Console.WriteLine("La resta de {0} y {1} es {2}", num1, num2, num1 - num2);
            Console.WriteLine("La multiplicacion de {0} y {1} es {2}", num1, num2, num1 * num2);
            Console.WriteLine("La division de {0} y {1} es {2}", num1, num2, num1 / num2);
        }
    }
}