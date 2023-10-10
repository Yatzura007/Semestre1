using System;

namespace P_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que convierta de grados centrigrados a grados fahrenheit
            float celsius = 20;
            float fahrenheit = (celsius * 9/5) + 32;
            Console.WriteLine("{0} grados celcius es igual a {1} grados fahrenheit.", celsius,fahrenheit);
        }
    }
}