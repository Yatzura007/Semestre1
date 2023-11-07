
package com.mycompany.programa21u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa21U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
    int n, num;

    System.out.print("Ingresa la cantidad de números: ");
    n = sc.nextInt();

    for (int i = 1; i <= n; i++) {
      System.out.printf("Ingresa el número %d: ", i);
      num = sc.nextInt();

      int cubo = num * num * num;
      System.out.printf("El cubo de %d es: %d\n", num, cubo);
    }
    }
}
