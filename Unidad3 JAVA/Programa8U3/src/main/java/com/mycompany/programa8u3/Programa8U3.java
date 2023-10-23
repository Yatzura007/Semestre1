
package com.mycompany.programa8u3;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class Programa8U3 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Por favor, ingresa el primer número: ");
        double numero1 = scanner.nextDouble();

        System.out.print("Por favor, ingresa el segundo número: ");
        double numero2 = scanner.nextDouble();

        if (numero1 > numero2)
        {
            System.out.println("El primer número es mayor.");
        }
        else if (numero1 < numero2)
        {
            System.out.println("El segundo número es mayor.");
        }
        else
        {
            System.out.println("Ambos números son iguales.");
        }
    }
}
