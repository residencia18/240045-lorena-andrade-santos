package Aula05;

import java.util.Scanner;

public class concatenar {
	public static void main(String[] args) {
		String str1;
		String str2;
		String str3;

		Scanner entrada = new Scanner(System.in);

		System.out.println("Digite a primeira string: ");
		str1 = entrada.nextLine();
		System.out.println("Digite a segunda string: ");
		str2 = entrada.nextLine();
		System.out.println("Concatenando as strings temos: " + str1.concat(str2));
	}
}
