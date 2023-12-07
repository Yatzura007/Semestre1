
package com.mycompany.p_9_u4;

/**
 *
 * @author Yatzura
 */
public class P_9_U4 {

    public static void main(String[] args) {
        
        String[] nombres = {"Juan", "Ana", "Carlos"};
        String[] apellidos = {"Pérez", "Gómez", "Ramírez"};

        String[] nombresCompletos = new String[nombres.length];
        for (int i = 0; i < nombres.length; i++) {
            nombresCompletos[i] = nombres[i] + " " + apellidos[i];
        }

        for (String nombreCompleto : nombresCompletos) {
            System.out.println(nombreCompleto);
        }    
    }
}
