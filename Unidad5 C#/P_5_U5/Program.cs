using System;

namespace P_5_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("La frase tiene " + ContarPalabras(frase) + " palabras.");
        }

        static int ContarPalabras(string frase)
        {
            if (string.IsNullOrEmpty(frase))
            {
                return 0;
            }
            string[] palabras = frase.Split(' ');
            return palabras.Length;
        }
    }
}