
package com.mycompany.programa10u3;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class Programa10U3 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Ingresa las horas trabajadas: ");
        int horasTrabajadas = scanner.nextInt();

        System.out.print("Ingresa el pago por hora: ");
        double pagoPorHora = scanner.nextDouble();

        double sueldo;
        if (horasTrabajadas > 40)
        {
            sueldo = 40 * pagoPorHora;
            sueldo += (horasTrabajadas - 40) * pagoPorHora * 2;
        }
        else
        {
            sueldo = horasTrabajadas * pagoPorHora;
        }

        System.out.println("El sueldo semanal es: $" + sueldo);
    }
}
