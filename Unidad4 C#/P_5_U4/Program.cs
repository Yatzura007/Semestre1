using System;

namespace P_5_U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Manzana", "Banana", "Cereza", "Durazno", "Fresa" };
            string[] frutasInversas = new string[frutas.Length];

            for (int i = 0; i < frutas.Length; i++)
            {
                frutasInversas[i] = frutas[frutas.Length - 1 - i];
            }

            foreach (string fruta in frutasInversas)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}