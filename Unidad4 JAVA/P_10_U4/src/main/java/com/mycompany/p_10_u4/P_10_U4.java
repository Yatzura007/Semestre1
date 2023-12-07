
package com.mycompany.p_10_u4;

/**
 *
 * @author Yatzura
 */
public class P_10_U4 {

    public static void main(String[] args) {
        
        String[] paises = {"México", "Estados Unidos", "Canadá", "Brasil", "Argentina"};
        int totalLength = 0;

        for (String pais : paises) {
            totalLength += pais.length();
        }

        double promedio = (double) totalLength / paises.length;
        System.out.println("Longitud promedio de los nombres de los países: " + promedio);
    }
}
