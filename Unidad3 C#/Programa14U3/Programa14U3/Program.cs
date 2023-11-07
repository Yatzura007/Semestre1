using System;

namespace Programa14U3
{
     public class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 1; contador < 200; contador++)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
            }
        }
    }
}
