
package com.mycompany.programa25u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa25U3 {

    public static void main(String[] args) {
        try (Scanner input = new Scanner(System.in)) {
            double num1, num2;
            char operator;
            while (true) {
                System.out.print("Ingrese el primer número: ");
                num1 = input.nextDouble();
                
                System.out.print("Ingrese el segundo número: ");
                num2 = input.nextDouble();
                
                System.out.print("Ingrese el operador (+, -, *, /) o 'q' para salir: ");
                operator = input.next().charAt(0);
                
                if (operator == 'q') {
                    break;
                }
                
                double result;
                
                switch (operator) {
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
                        System.out.println("Operador inválido.");
                        continue;
                }
                
                System.out.println(num1 + " " + operator + " " + num2 + " = " + result);
            }
        }
    }
}
