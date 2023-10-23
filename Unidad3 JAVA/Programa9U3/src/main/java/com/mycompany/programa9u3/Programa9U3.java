
package com.mycompany.programa9u3;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class Programa9U3 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Ingresa la hora de entrada (formato 24 horas): ");
        int horaEntrada = scanner.nextInt();

        System.out.print("Ingresa la hora de salida (formato 24 horas): ");
        int horaSalida = scanner.nextInt();

        int totalHoras = horaSalida - horaEntrada;

        double costo = 0;
        if (totalHoras > 10)
        {
            costo += 10 * 2;
            totalHoras -= 10;
            costo += totalHoras * 2;
        }
        else if (totalHoras > 5)
        {
            costo += 5 * 3;
            totalHoras -= 5;
            costo += totalHoras * 2;
        }
        else if (totalHoras > 2)
        {
            costo += 2 * 5;
            totalHoras -= 2;
            costo += totalHoras * 4;
        }
        else
        {
            costo += totalHoras * 5;
        }

        System.out.println("El costo total es: $" + costo);
    }
}
