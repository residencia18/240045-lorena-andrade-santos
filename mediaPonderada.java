package Aula05;

import java.util.Scanner;

public class mediaPonderada {

	public static float resultadoMedia(float nota1, float nota2, float nota3, float peso1, float peso2, float peso3) {
		return ((nota1 * peso1) + (nota2 * peso2) +(nota3 * peso3))/(peso1 + peso2 + peso3);
	}
	public static void main(String[] args) {
		float n1, n2, n3;
		float p1, p2, p3;
		
		Scanner entrada = new Scanner(System.in);

		System.out.println("Digite a primeira nota: ");
		n1 = entrada.nextFloat();
		System.out.println("Digite o peso da nota 1: ");
		p1 = entrada.nextFloat();
		
		System.out.println("Digite a segunda nota: ");
		n2 = entrada.nextFloat();
		System.out.println("Digite o peso da nota 2: ");
		p2 = entrada.nextFloat();
		

		System.out.println("Digite a terceira nota: ");
		n3 = entrada.nextFloat();
		System.out.println("Digite o peso da nota 3: ");
		p3 = entrada.nextFloat();
		entrada.close();
		
		System.out.println("A media ponderada das notas digitadas é: " + resultadoMedia(n1, n2, n3, p1, p2, p3));
		
	}
}
