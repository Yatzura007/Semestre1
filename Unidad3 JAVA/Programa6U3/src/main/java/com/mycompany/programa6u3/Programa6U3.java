
package com.mycompany.programa6u3;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class Programa6U3 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingresa un número entero positivo: ");
        int numero = scanner.nextInt();

        if (numero % 2 == 0)
        {
            System.out.println("El número es par.");
        }
        else
        {
            System.out.println("El número es impar.");
        }
    }
}
