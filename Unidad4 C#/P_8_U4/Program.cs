using System;

namespace P_8_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 5, 3, 8, 1, 2 };
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even.Add(array[i]);
                }
                else
                {
                    odd.Add(array[i]);
                }
            }

            Console.WriteLine("Números pares: " + string.Join(", ", even));
            Console.WriteLine("Números impares: " + string.Join(", ", odd));
        }
    }
}
