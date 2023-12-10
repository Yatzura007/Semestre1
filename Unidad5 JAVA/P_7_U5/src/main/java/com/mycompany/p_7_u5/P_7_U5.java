
package com.mycompany.p_7_u5;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_7_U5 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.print("Introduce el precio sin IVA: ");
        double precioSinIVA = sc.nextDouble();
        double iva = calcularIVA(precioSinIVA);
        double total = calcularTotal(precioSinIVA, iva);
        System.out.println("IVA: " + iva);
        System.out.println("Total: " + total);
    }

    public static double calcularIVA(double precioSinIVA) {
        return precioSinIVA * 0.16;  
    }

    public static double calcularTotal(double precioSinIVA, double iva) {
        return precioSinIVA + iva;
    }
}
