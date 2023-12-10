
package com.mycompany.p_4_u5;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_4_U5 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.print("Introduce un número: ");
        int numero = sc.nextInt();
        System.out.println(esPrimo(numero) ? "El número es primo" : "El número no es primo");
    }

    public static boolean esPrimo(int numero) {
        if (numero <= 1) {
            return false;
        }
        for (int i = 2; i < numero; i++) {
            if (numero % i == 0) {
                return false;
            }
        }
        return true;
    }
}
