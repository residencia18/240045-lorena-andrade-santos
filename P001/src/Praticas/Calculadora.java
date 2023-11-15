package Praticas;

import java.util.Scanner;

public class Calculadora {
	private float numero1;
	private float numero2;
	public Calculadora() {
		super();
	}
	public float getNumero1() {
		return numero1;
	}
	public void setNumero1(float numero1) {
		this.numero1 = numero1;
	}
	public float getNumero2() {
		return numero2;
	}
	public void setNumero2(float numero2) {
		this.numero2 = numero2;
	}
	
	public void soma() {
		System.out.println(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
	}
	
	public void subtracao() {
		System.out.println(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
	}
	
	public void divisao() {
		if(numero2 == 0)
			System.out.println("Não é possivel dividir por 0");
		else
			System.out.println(numero1 + " / " + numero2 + " = " + (numero1 /  numero2));
	}
	public void multiplicacao() {
		System.out.println(numero1 + " * " + numero2 + " = " + (numero1 * numero2));
		
	}
	public static void main(String[] args) {
		String sn;
		do {
			
			Calculadora nova = new Calculadora();
			float numero1, numero2;
			String operacao;

			Scanner entrada = new Scanner(System.in);
			
			System.out.println("Digite seu primeiro numero: ");
			numero1 = entrada.nextFloat();
			System.out.println("Digite seu segundo numero: ");
			numero2 = entrada.nextFloat();
			
			do {
				System.out.println("Digite a operacao (+ - * /): ");
				operacao = entrada.nextLine();
			} while ((!operacao.equals("+") && !operacao.equals("-") && !operacao.equals("*") && !operacao.equals("/") ));

			
			nova.setNumero1(numero1);
			nova.setNumero2(numero2);
			
			if(operacao.equals("+"))
				nova.soma();
			else if(operacao.equals("-"))
				nova.subtracao();
			else if(operacao.equals("*"))
				nova.multiplicacao();
			else if(operacao.equals("/"))
				nova.divisao();
				

			System.out.println("Deseja realizar outra operacao?");
			sn = entrada.nextLine();
			
		
		} while (!sn.equals("n"));
	}
	
}
