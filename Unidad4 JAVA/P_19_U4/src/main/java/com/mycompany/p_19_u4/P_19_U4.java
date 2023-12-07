
package com.mycompany.p_19_u4;

/**
 *
 * @author Yatzura
 */
public class P_19_U4 {

    public static void main(String[] args) {
        
        int[][] matriz = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        int contadorPares = 0, contadorImpares = 0;

        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                if (matriz[i][j] % 2 == 0) {
                    contadorPares++;
                } else {
                    contadorImpares++;
                }
            }
        }

        System.out.println("Cantidad de números pares: " + contadorPares);
        System.out.println("Cantidad de números impares: " + contadorImpares);
    }
}
