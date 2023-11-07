
package com.mycompany.programa19u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa19U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
    int n, num, cant_cero = 0, cant_mayor = 0, cant_menor = 0;

    System.out.print("Ingresa la cantidad de números: ");
    n = sc.nextInt();

    for (int i = 1; i <= n; i++) {
      System.out.printf("Ingresa el número %d: ", i);
      num = sc.nextInt();

      if (num == 0) {
        cant_cero++;
      } else if (num > 0) {
        cant_mayor++;
      } else {
        cant_menor++;
      }
    }

    System.out.printf("Cantidad de números iguales a cero: %d\n", cant_cero);
    System.out.printf("Cantidad de números mayores a cero: %d\n", cant_mayor);
    System.out.printf("Cantidad de números menores a cero: %d\n", cant_menor);
    }
}
