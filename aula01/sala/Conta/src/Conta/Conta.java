package Conta;

import java.util.Scanner;

public class Conta {
	private int numero;
	private String nome;
	private float saldo;
	public Conta(String nome, float saldo) {
		super();
		
		this.nome = nome;
		
		if (saldo < 0) {
			this.saldo = 0;
		}
		else {
			this.saldo = saldo;	
		}
	}
	public void deposita(float valor) {
		saldo += valor;
	}
	public void consulta() {
		System.out.println("Cliente: " + nome);
		System.out.println("Seu saldo é: " + saldo);
		System.out.println("----------------------");
	}
	public int saque(float valor) {
		if(valor > saldo) {
			return 0;
		}
		else {
			saldo -= valor;
			return 1;
		}
	}
	public static void main(String[] args) {
		String nome;
		float valor;

		Scanner entrada = new Scanner(System.in);
		
		System.out.println("Digite seu nome: ");
		nome = entrada.nextLine();
		System.out.println("O valor: ");
		valor = entrada.nextFloat();
		entrada.close();
		
		Conta minhaConta = new Conta(nome, valor);
		
		minhaConta.deposita(12.75f);
		System.out.println();
		
		minhaConta.consulta();
		minhaConta.saque(15.00f);
		
		System.out.println();
		minhaConta.consulta();
		
	}
}
