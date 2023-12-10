
package com.mycompany.p_6_u5;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_6_U5 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.print("Introduce el número de términos de la secuencia Fibonacci que deseas generar: ");
        int terminos = sc.nextInt();
        Fibonacci(terminos);
    }

    public static void Fibonacci(int terminos) {
        int t1 = 0, t2 = 1;
        for (int i = 1; i <= terminos; ++i) {
            System.out.print(t1 + ", ");
            int suma = t1 + t2;
            t1 = t2;
            t2 = suma;
        }
    }
}
