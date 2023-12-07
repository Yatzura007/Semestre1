
package com.mycompany.p_14_u4;

/**
 *
 * @author Yatzura
 */
public class P_14_U4 {

    public static void main(String[] args) {
        
        int[][] num = {{1,2,3} , {4,5,6} , {7,8,9}};
        int suma =0;
        for (int i=0; i<num.length; i++){
            for(int j=0; j<num[i].length;j++){
                suma += num[i][j];
            }
        }
        System.out.println("La suma de todos los elementos es: "+ suma);
    }
}
