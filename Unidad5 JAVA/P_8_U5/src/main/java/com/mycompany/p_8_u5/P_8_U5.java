
package com.mycompany.p_8_u5;
import java.util.Random;
/**
 *
 * @author Yatzura
 */
public class P_8_U5 {

    public static void main(String[] args) {
        
        System.out.println("El resultado de lanzar el dado es: " + lanzarDado());
    }

    public static int lanzarDado() {
        Random rand = new Random();
        return rand.nextInt(6) + 1; 
    }
}
