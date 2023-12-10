//realizar un programa que le solicite al usuasrioel tipo de conversion a realizar donde seleccione una opcion de acuerdo a lo siguiente
//1)temperatura C a F, 2)temperatura F a K, 3)medida pulgadas a metros, 4)tiempo hrs a seg.
package com.mycompany.p_2_u5;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_2_U5 {

    public static void main(String[] args) {
        
         Scanner sc = new Scanner(System.in);
        System.out.println("Temperatura C a F");
        System.out.println("Temperatura F a K");
        System.out.println("medida pulgadas a metros");
        System.out.println("tiempo hrs a seg");
        int opcion = sc.nextInt();

        switch (opcion) {
            case 1:
                System.out.println("opcion 1");
                break;
            case 2:
                System.out.println("opcion 2");
                break;
            case 3:
                System.out.println("opcion 3");
                break;
            case 4:
                System.out.println("opcion 4");
                break;
            default:
                System.out.println("Opción no válida.");
                break;
        }
    }

    public static double temperaturaCF(double c) {
        double resultado = (c * 1.8) + 32;
        return resultado;
    }

    public static double temperaturaFK() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Escribe la temperatura K a convertir: ");
        double F = scanner.nextDouble();
        double resultado = (F - 32) * (5.0 / 9) + 273.15;
        return resultado;
        
    }
}
