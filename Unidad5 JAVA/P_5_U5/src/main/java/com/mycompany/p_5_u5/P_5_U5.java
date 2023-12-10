
package com.mycompany.p_5_u5;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_5_U5 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.print("Introduce una frase: ");
        String frase = sc.nextLine();
        System.out.println("La frase tiene " + contarPalabras(frase) + " palabras.");
    }

    public static int contarPalabras(String frase) {
        if (frase == null || frase.isEmpty()) {
            return 0;
        }
        String[] palabras = frase.split("\\s+");
        return palabras.length;
    }
}
