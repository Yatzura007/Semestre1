
package com.mycompany.p_7_u4;
import java.util.Arrays;
/**
 *
 * @author Yatzura
 */
public class P_7_U4 {

    public static void main(String[] args) {
        
         double[] array = {5, 3, 8, 1, 2};
        Arrays.sort(array);

        double sum = 0;
        for (int i = 0; i < array.length; i++) {
            sum += array[i];
        }
        double mean = sum / array.length;

        double median;
        if (array.length % 2 == 0)
            median = ((double)array[array.length/2] + (double)array[array.length/2 - 1])/2;
        else
            median = (double) array[array.length/2];

        System.out.println("Media: " + mean);
        System.out.println("Mediana: " + median);
    }
}
