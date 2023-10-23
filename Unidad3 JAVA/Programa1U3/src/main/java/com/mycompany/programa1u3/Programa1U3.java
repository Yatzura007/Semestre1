/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa1u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa1U3 {

    public static void main(String[] args) { //paso1
        Scanner sc= new Scanner(System.in);
        int edad ;//declarar vaariables
        System.out.println("Escribe tu edad: ");
        edad = sc.nextInt();
        if (edad >=18){
                System.out.println("Usted es mayor de edad.  c:");
        }
        else {
                System.out.println("Usted no es mayor de edad. :/");
        }
    }
}
