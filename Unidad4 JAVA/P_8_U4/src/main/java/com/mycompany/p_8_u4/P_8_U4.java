
package com.mycompany.p_8_u4;
import java.util.ArrayList;
/**
 *
 * @author Yatzura
 */
public class P_8_U4 {

    public static void main(String[] args) {
        
        int[] array = {5, 3, 8, 1, 2};
        ArrayList<Integer> even = new ArrayList<Integer>();
        ArrayList<Integer> odd = new ArrayList<Integer>();

        for (int i = 0; i < array.length; i++) {
            if (array[i] % 2 == 0) {
                even.add(array[i]);
            } else {
                odd.add(array[i]);
            }
        }

        System.out.println("Números pares: " + even);
        System.out.println("Números impares: " + odd);
    }
}
