
package com.mycompany.programa24u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa24U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
    int num;

    do {
      System.out.print("Ingresa un número: ");
      num = sc.nextInt();

      if (num >= 0) {
        if (num % 2 == 0) {
          System.out.println("El número es par.");
        } else {
          System.out.println("El número es impar.");
        }
      }
    } while (num >= 0);
    }
}
