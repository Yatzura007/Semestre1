
package com.mycompany.programa22u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa22U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int suma=0, num ;
        do{
            System.out.println("Escribe el numero");
            num=sc.nextInt();
            suma=suma+num;
        }while (num!=0);
        System.out.println("Resultado es: "+suma);
    }
}
