using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;
        char operatorChar;

        while (true)
        {
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el operador (+, -, *, /) o 'q' para salir: ");
            operatorChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operatorChar == 'q')
            {
                break;
            }

            double result;

            switch (operatorChar)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    continue;
            }

            Console.WriteLine($"{num1} {operatorChar} {num2} = {result}");
        }
    }
}
