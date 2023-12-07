
package com.mycompany.p_17_u4;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_17_U4 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        System.out.println("Introduce el tamaño de las matrices:");
        int n = sc.nextInt();
        
        int[][] numA = new int[n][n];
        int[][] numB = new int[n][n];
        int[][] R = new int[n][n];
        
        System.out.println("Introduce los valores para la primera matriz: ");
        for (int f = 0; f<n; f++){
            for (int c=0; c<n; c++){
                numA[f][c] = sc.nextInt();
            }
        }
        
        System.out.println("Introduce los valores para la segunda matriz: ");
        for (int f = 0; f<n; f++){
            for (int c=0; c<n; c++){
                numB[f][c] = sc.nextInt();
            }
        }

        for (int f=0; f<n; f++) {
            for(int c=0; c<n; c++){
                for(int k=0; k<n; k++){
                    R[f][c] += numA[f][k] * numB[k][c];
                }
            }
        }
        
        System.out.println("Los resultados son estos: ");
        for (int f = 0; f<n; f++){
            for (int c=0; c<n; c++){
                System.out.print(R[f][c]+",");
            }
            System.out.println();
        }
    }
}
