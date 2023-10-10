using System;

namespace P_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que convierta de metros a pies.
            float metros = 10 ;
            double pies = metros / 0.3048 ;
            Console.WriteLine("{0} metros es igual a {1} pies.", metros, pies);
        }
    }
}