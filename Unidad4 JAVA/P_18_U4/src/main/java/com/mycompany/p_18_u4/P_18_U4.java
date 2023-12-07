
package com.mycompany.p_18_u4;

/**
 *
 * @author Yatzura
 */
public class P_18_U4 {

    public static void main(String[] args) {
        
        int[][] matriz = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        int sumaDiagonalPrincipal = 0, sumaDiagonalSecundaria = 0;

        for (int i = 0; i < matriz.length; i++) {
            sumaDiagonalPrincipal += matriz[i][i];
            sumaDiagonalSecundaria += matriz[i][matriz.length - 1 - i];
        }

        System.out.println("La suma de la diagonal principal es: " + sumaDiagonalPrincipal);
        System.out.println("La suma de la diagonal secundaria es: " + sumaDiagonalSecundaria);
    }
}
