package Aula05;

import java.util.Scanner;

public class somaInteiros {
	int numero1;
	int numero2;
	
	public somaInteiros(int numero1, int numero2) {
		super();
		this.numero1 = numero1;
		this.numero2 = numero2;
	}

	public int getNumero1() {
		return numero1;
	}

	public void setNumero1(int numero1) {
		this.numero1 = numero1;
	}

	public int getNumero2() {
		return numero2;
	}

	public void setNumero2(int numero2) {
		this.numero2 = numero2;
	}
	public int soma() {
		return (numero1 + numero2);
	}

		public static void main(String[] args) {
			int num1, num2;
		
			Scanner entrada = new Scanner(System.in);
			
			System.out.println("Digite o primeiro numero: ");
			num1 = entrada.nextInt();
			System.out.println("Digite o segundo numero: ");
			num2 = entrada.nextInt();
			somaInteiros somaI = new somaInteiros(num1, num2);
			System.out.println("A soma dos seus numeros é:" + somaI.soma());
		}
}
