
package com.mycompany.p_20_u4;

/**
 *
 * @author Yatzura
 */
public class P_20_U4 {

    public static void main(String[] args) {
        
         int[][] matrizOriginal = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        int[][] matrizCuadrada = new int[matrizOriginal.length][matrizOriginal[0].length];

        for (int i = 0; i < matrizOriginal.length; i++) {
            for (int j = 0; j < matrizOriginal[i].length; j++) {
                matrizCuadrada[i][j] = matrizOriginal[i][j] * matrizOriginal[i][j];
            }
        }

        // Imprimir la matriz cuadrada
        for (int i = 0; i < matrizCuadrada.length; i++) {
            for (int j = 0; j < matrizCuadrada[i].length; j++) {
                System.out.print(matrizCuadrada[i][j] + " ");
            }
            System.out.println();
        }
    }
}
