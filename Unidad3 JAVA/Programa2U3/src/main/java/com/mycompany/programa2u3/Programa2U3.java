/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa2u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa2U3 {

    public static void main(String[] args) { 
        Scanner sc= new Scanner(System.in);
        int Cal1, Cal2, Cal3,Cal4, Cal5, Cal6, promedio;
        System.out.println("Escribe califificacion 1: " );
        Cal1 = sc.nextInt();
        System.out.println("Escribe califificacion 2: " );
        Cal2 = sc.nextInt();
        System.out.println("Escribe califificacion 3: " );
        Cal3 = sc.nextInt();
        System.out.println("Escribe califificacion 4: " );
        Cal4 = sc.nextInt();
        System.out.println("Escribe califificacion 5: " );
        Cal5 = sc.nextInt();
        System.out.println("Escribe califificacion 6: " );
        Cal6 = sc.nextInt();
        promedio = (Cal1 + Cal2 + Cal3 + Cal4 + Cal5 + Cal6)/6;
        System.out.println("Tu promedio es: " + promedio);
        if (promedio>=70){
            System.out.println("Aprovado");
        }else{
            System.out.println("Reprovado!!!!:°");
        
        }
    } 
}        
