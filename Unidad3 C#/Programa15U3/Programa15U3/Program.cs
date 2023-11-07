using System;

namespace Programa15U3
{
   public class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, c = 1;
            while (c <= 20)
            {
                Console.WriteLine(c);
                suma = suma + c;
                c++;
            }
            Console.WriteLine("Suma= " + suma);
        }
    }
}
