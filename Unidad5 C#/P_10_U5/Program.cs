using System;

namespace P_10_U5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la longitud de la contraseña: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La contraseña generada es: " + GenerarContrasena(longitud));
        }

        static string GenerarContrasena(int longitud)
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            Random rand = new Random();
            char[] contrasena = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                contrasena[i] = caracteres[rand.Next(caracteres.Length)];
            }
            return new string(contrasena);
        }
    }
}