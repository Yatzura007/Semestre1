
package com.mycompany.p_12_u4;

/**
 *
 * @author Yatzura
 */
public class P_12_U4 {

    public static void main(String[] args) {
        
        int[][] calf = { {5,7,9,5} , {6,8,7,5} , {10,3,1,5} };

        int fila = calf.length;
        int columna = calf[0].length;

        for (int f = 0; f < fila; f++){
            for (int c = 0; c < columna; c++)
            {
                System.out.print(calf[f][c] + ",");
            }
            System.out.println();
        }
    }
}
