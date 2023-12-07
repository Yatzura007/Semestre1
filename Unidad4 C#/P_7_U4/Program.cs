using System;

namespace P_7_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] array = { 5, 3, 8, 1, 2 };
            Array.Sort(array);

            double sum = array.Sum();
            double mean = sum / array.Length;

            double median;
            if (array.Length % 2 == 0)
                median = (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2.0;
            else
                median = array[array.Length / 2];

            Console.WriteLine("Media: " + mean);
            Console.WriteLine("Mediana: " + median);
        }
    }
}