
package com.mycompany.p_15_u4;

/**
 *
 * @author Yatzura
 */
public class P_15_U4 {

    public static void main(String[] args) {
        
        int[][] matriz = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

        for (int i = 0; i < matriz.length; i++) {
            double suma = 0;
            for (int j = 0; j < matriz[i].length; j++) {
                suma += matriz[i][j];
            }
            double media = suma / matriz[i].length;
            System.out.println("La media de la fila " + (i+1) + " es: " + media);
        }
    }
}
