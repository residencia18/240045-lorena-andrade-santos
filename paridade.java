package Aula05;

import java.util.Scanner;

public class paridade {
	public static boolean ehPar(int numero) {
		return (numero % 2)==0;
	}
	public static void main(String[] args) {
		int num1;
		
		Scanner entrada = new Scanner(System.in);
		
		System.out.println("Digite um numero: ");
		num1 = entrada.nextInt();
		entrada.close();
		
		if(ehPar(num1)) {
			System.out.println("O número " + num1 + " é par");
		}
		else {
			System.out.println("O número " + num1 + " é ímpar");
		}
		
	}
}
