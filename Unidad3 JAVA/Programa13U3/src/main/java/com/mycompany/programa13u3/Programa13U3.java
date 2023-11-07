
package com.mycompany.programa13u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa13U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
         int positivos = 0;
        int negativos = 0;

        for (int i = 0; i < 100; i++) {
            System.out.println("Introduce el número " + (i + 1) + ":");
            int numero = sc.nextInt();

            if (numero > 0) {
                positivos++;
            } else if (numero < 0) {
                negativos++;
            }
        }

        System.out.println("Cantidad de números positivos: " + positivos);
        System.out.println("Cantidad de números negativos: " + negativos);
    }
}
