
package com.mycompany.p_16_u4;

/**
 *
 * @author Yatzura
 */
public class P_16_U4 {

    public static void main(String[] args) {
        
         char[][] matriz = { {'a', 'b', 'c'}, {'d', 'e', 'f'}, {'g', 'h', 'i'} };

        for (int i = matriz.length - 1; i >= 0; i--) {
            for (int j = matriz[i].length - 1; j >= 0; j--) {
                System.out.print(matriz[i][j] + " ");
            }
            System.out.println();
        }
    }
}
