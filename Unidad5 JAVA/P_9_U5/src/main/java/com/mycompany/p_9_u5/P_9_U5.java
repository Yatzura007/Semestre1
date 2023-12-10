
package com.mycompany.p_9_u5;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_9_U5 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.print("Introduce el sueldo diario: ");
        double sueldoDiario = sc.nextDouble();
        System.out.print("Introduce los días trabajados: ");
        int diasTrabajados = sc.nextInt();
        System.out.println("El finiquito es: " + calcularFiniquito(sueldoDiario, diasTrabajados));
    }

    public static double calcularFiniquito(double sueldoDiario, int diasTrabajados) {
        return sueldoDiario * diasTrabajados;
    }
}
