using System;

namespace Programa2U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cal1, Cal2, Cal3, Cal4, Cal5, Cal6, promedio;
            Console.WriteLine("Escribe califificacion 1: ");
            Cal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe califificacion 2: ");
            Cal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe califificacion 3: ");
            Cal3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe califificacion 4: ");
            Cal4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe califificacion 5: ");
            Cal5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe califificacion 6: ");
            Cal6 = Convert.ToInt32(Console.ReadLine());
            promedio = (Cal1 + Cal2 + Cal3 + Cal4 + Cal5 + Cal6) / 6;
            Console.WriteLine("Tu promedio es: " + promedio);
            if (promedio >= 70)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado!!!!:°");

            }
        }
    }
}