
package com.mycompany.p_4_u4;

/**
 *
 * @author Yatzura
 */
public class P_4_U4 {

    public static void main(String[] args) {
        
        int[] Num = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

        int contadorNegativos = 0;

        for (int i = 0; i < Num.length; i++) {
            if (Num[i] < 0) {
                contadorNegativos++;
            }
        }

        System.out.println("El total de números negativos es: " + contadorNegativos);
    }
}
