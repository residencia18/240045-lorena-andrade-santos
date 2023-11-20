package Aula05;

import java.util.Scanner;

public class calculaArea {
	public static int calculaAreaRetangulo(int altura, int largura) {
		return altura * largura;
	}
	public static void main(String[] args) {
		int altura, largura;
		
		Scanner entrada = new Scanner(System.in);
		
		System.out.println("Digite a altura do retangulo: ");
		altura = entrada.nextInt();

		System.out.println("Digite a largura do retangulo: ");
		largura = entrada.nextInt();
		
		System.out.println("A area do retangulo é: " + calculaAreaRetangulo(altura, largura));
	}
}
