/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa5u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa5U3 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        double P1, P2, P3,total;
        System.out.println("Escribe el precio del producto 1: ");
        P1 = sc.nextInt();
        System.out.println("Escribe el precio del producto 2: ");
        P2 = sc.nextInt();
        System.out.println("Escribe el precio del producto 3: ");
        P3 = sc.nextInt();
        total = P1+P2+P3;
        if (total>=1500){
             total = total - (total * 0.30);
             System.out.println("El Total (30%desc): "+total);
        }else if(total<1500 && total>=1000){ 
            total = total - (total * 0.20);
            System.out.println("El Total (20%desc): "+total);
        }else if(total<1000 && total>=7008){ 
            total = total - (total * 0.10);
            System.out.println("El Total (10%desc): "+total);
        }else{
            System.out.println("El Total (Sin desc): "+total);
        }
                
    }
}
