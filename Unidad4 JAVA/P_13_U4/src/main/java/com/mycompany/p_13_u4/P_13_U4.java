
package com.mycompany.p_13_u4;
import java.util.Scanner;
/**
 *
 * @author Yatzura
 */
public class P_13_U4 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        float[][] temp = new float [5][7];
        for(int f=0; f<5; f++){
            for (int c=0; c<7; c++){
            System.out.println("Escribe temperatura en ("+f+",");
            temp[f][c]=sc.nextFloat();
            }
        }
    }
}
