package com.mycompany.programa7u3;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class Programa7U3 {

    public static void main(String[] args) {
         Scanner scanner = new Scanner(System.in);
        System.out.print("Por favor, ingresa la temperatura actual: ");
        double temperatura = scanner.nextDouble();

        if (temperatura > 27)
        {
            System.out.println("Hace Calor");
        }
        else if (temperatura > 20 && temperatura <= 27)
        {
            System.out.println("Clima agradable");
        }
        else
        {
            System.out.println("Clima fresco o frío");
        }
    }
}
