using System;

namespace P_13_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] temp = new float[5, 7];
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.WriteLine("Escribe temperatura en (" + f + ",");
                    temp[f, c] = float.Parse(Console.ReadLine());
                }
            }
        }
    }
}