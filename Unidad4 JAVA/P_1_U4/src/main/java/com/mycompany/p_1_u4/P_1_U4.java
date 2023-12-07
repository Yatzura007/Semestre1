
package com.mycompany.p_1_u4;

/**
 *
 * @author Yatzura
 */
public class P_1_U4 {

    public static void main(String[] args) {
        int[] edades = {15, 18, 21, 17, 22};

        for (int i = 0; i < edades.length; i++) {
            if (edades[i] >= 18) {
                System.out.println("La edad " + edades[i] + " es mayor de edad.");
            } else {
                System.out.println("La edad " + edades[i] + " es menor de edad.");
            }
        }
    }
}
