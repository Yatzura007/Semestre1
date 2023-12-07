
package com.mycompany.p_5_u4;

/**
 *
 * @author Yatzura
 */
public class P_5_U4 {

    public static void main(String[] args) {
         String[] frutas = {"Manzana", "Banana", "Cereza", "Durazno", "Fresa"};
        String[] frutasInversas = new String[frutas.length];

        for (int i = 0; i < frutas.length; i++) {
            frutasInversas[i] = frutas[frutas.length - 1 - i];
        }

        for (String fruta : frutasInversas) {
            System.out.println(fruta);
        }
    }
}
