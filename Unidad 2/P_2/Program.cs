using System; 

namespace P_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, suma;
            Console.WriteLine("Introducir primer numero ");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introducir segundo numero ");
            numero2 = Int32.Parse(Console.ReadLine());
            suma = numero1 + numero2;
            Console.WriteLine(suma);
        }
    }
}