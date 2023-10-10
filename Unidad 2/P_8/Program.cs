using System;

namespace P_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que a partir del precio de 3(con iva incluido) productos calcule el iva subtotal y el total.
            double precio1 = 100 ;
            double precio2 = 200;
            double precio3 = 300;
            double subtotal = precio1 + precio2 + precio3;
            double iva = subtotal * 0.16;
            double total = subtotal + iva;
            Console.WriteLine("El Subtotal es :  " + subtotal);
            Console.WriteLine("El IVA es :  " + iva);
            Console.WriteLine("El Total es :  " + total);
        }
    }
}