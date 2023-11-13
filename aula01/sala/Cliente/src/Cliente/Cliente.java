package Cliente;

import java.util.Scanner;

public class Cliente {
	private String nome;
	private int idade;
	private String cpf;
	public Cliente(String nome, String cpf) {
		super();
		this.nome = nome;
		this.cpf = cpf;
		this.idade = 0;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public int getIdade() {
		return idade;
	}
	public void setIdade(int idade) {
		this.idade = idade;
	}
	public String getCpf() {
		return cpf;
	}
	public void setCpf(String cpf) {
		this.cpf = cpf;
	}
	public void mostrarCliente() {
		System.out.println("Nome: " + nome);
		System.out.println("CPF: " + cpf);
		System.out.println("Idade: " + idade);
	}
	public static void main(String[] args) {
		String nome, cpf;
		int idade;
		Scanner entrada = new Scanner(System.in);
		
		System.out.println("Digite seu nome: ");
		nome = entrada.nextLine();
		System.out.println("Digite seu cpf: ");
		cpf = entrada.nextLine();
		
		Cliente novo = new Cliente(nome, cpf);

		System.out.println("Digite sua idade: ");
		idade = entrada.nextInt();
		novo.setIdade(idade);
		
		novo.mostrarCliente();
	}
}
