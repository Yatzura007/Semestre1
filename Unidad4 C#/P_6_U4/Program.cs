using System;

namespace P_6_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 5, 3, 8, 1, 2 };
            Array.Sort(array);
            Console.WriteLine(string.Join(", ", array));
        }
    }
}