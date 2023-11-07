
package com.mycompany.programa17u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa17U3 {

    public static void main(String[] args) {
         Scanner sc = new Scanner(System.in);
                char opcion;
                do{
                    System.out.println("Bienvenido a una sola ejecucion!");
                    System.out.println("Escribe n para salir!!");
                    opcion=sc.next().charAt(0);
                }while(opcion != 'n' ); 
    }
}
