
package com.mycompany.p_3_u5;
import java.util.Scanner;

/**
 *
 * @author Yatzura
 */
public class P_3_U5 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        double x, y;
        System.out.println("Escribe el valor para X: ");
        x = sc.nextDouble();
        System.out.println("Escribe el valor para Y: ");
        y = sc.nextDouble();
        System.out.println("Resultado ecuacional: "+ecuacion1(x,y));
        System.out.println("Resultado ecuaciona2: "+ecuacion2(x,y));
    }
    
    public static double ecuacion1(double x, double y){
        double r;
        r = Math.pow(x, 2)+ (2*Math.pow(y, 4));
        return r;
    }
        public static double ecuacion2(double x, double y){
        double r;
        r = Math.sqrt(Math.pow(x,4) + 5*y);
        return r;
    }
    
}
