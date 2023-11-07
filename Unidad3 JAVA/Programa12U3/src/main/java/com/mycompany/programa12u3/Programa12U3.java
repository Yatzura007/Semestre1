
package com.mycompany.programa12u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa12U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int c, total, num;
        System.out.println("Escribe el total de numeros a procesar: ");
        total= sc.nextInt();
        for(c=1; c<=total; c++){
        System.out.println("Escribe un numero");
        num = sc.nextInt();
        if(num%2 ==0)
            System.out.println("PAR");
        else
            System.out.println("IMPAR");
        }
    }
}
