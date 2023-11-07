
package com.mycompany.programa20u3;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa20U3 {

    public static void main(String[] args) {
        double ahorro = 3;
    double nuevo_ahorro;

    for (int i = 1; i <= 365; i++) {
      System.out.printf("El ahorro del día %d es: $%.2f\n", i, ahorro);
      nuevo_ahorro = ahorro * 3;
      ahorro = nuevo_ahorro;
    }

    System.out.printf("El ahorro total acumulado durante el año es: $%.2f\n", ahorro - 3);
    }
}
