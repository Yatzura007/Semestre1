
package com.mycompany.programa18u3;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa18U3 {

    public static void main(String[] args) {
        double salario = 1500;
    double incremento = 0.1;
    double nuevo_salario;

    for (int i = 1; i <= 6; i++) {
      nuevo_salario = salario + (salario * incremento);
      System.out.printf("El salario del año %d es: $%.2f\n", i, nuevo_salario);
      salario = nuevo_salario;
    }

    System.out.printf("El salario total recibido durante los 6 años es: $%.2f\n", salario - 1500);
    }
}
