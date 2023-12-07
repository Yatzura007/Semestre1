
package com.mycompany.p_3_u4;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_3_U4 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);

        // Solicitud del total de temperaturas
        System.out.print("Ingresa el total de temperaturas a procesar: ");
        // Lectura del total de temperaturas
        int total = sc.nextInt();
        // Creación del arreglo de temperaturas
        double[] temperaturas = new double[total];
        // Lectura de las temperaturas
        for (int i = 0; i < total; i++) {
            System.out.print("Ingresa la temperatura " + (i + 1) + " en °C: ");
            temperaturas[i] = sc.nextDouble();
        }
        // Conversión e impresión de las temperaturas
        for (int i = 0; i < total; i++) {
            double fahrenheit = temperaturas[i] * 9 / 5 + 32;
            double kelvin = temperaturas[i] + 273.15;

            System.out.println("Temperatura " + (i + 1) + ": " + temperaturas[i] + "°C = " + fahrenheit + "°F = " + kelvin + "K");
        }

        sc.close();
    }
}
