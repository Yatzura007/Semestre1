
package com.mycompany.p_10_u5;
import java.util.Random;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_10_U5 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.print("Introduce la longitud de la contraseña: ");
        int longitud = sc.nextInt();
        System.out.println("La contraseña generada es: " + generarContrasena(longitud));
    }

    public static String generarContrasena(int longitud) {
        String caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
        Random rand = new Random();
        StringBuilder contrasena = new StringBuilder();
        for (int i = 0; i < longitud; i++) {
            int indice = rand.nextInt(caracteres.length());
            contrasena.append(caracteres.charAt(indice));
        }
        return contrasena.toString();
    }
}
