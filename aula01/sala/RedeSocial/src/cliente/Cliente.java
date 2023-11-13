package cliente;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;

public class Cliente {

	private String nome, email, nacionalidade;
	private ArrayList<String> postagens;
	private int quantidadeDePostagens, contador, potuacao;
	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getNacionalidade() {
		return nacionalidade;
	}

	public void setNacionalidade(String nacionalidade) {
		this.nacionalidade = nacionalidade;
	}
	public void alteraPontuacao(int delta) {
		if(potuacao - delta<0) {
			potuacao = 0;
		}
		else {
			potuacao = potuacao - delta;
		}
		
	}
	public Cliente() {
		super();
		postagens = new ArrayList<String>();
		quantidadeDePostagens = 0;
		contador = 0;
		potuacao = 0;
	}
	public void adicionaPostagem(String textoPostagem) {
		postagens.add(textoPostagem);
		quantidadeDePostagens++;
	}
	public void mostrarPostagens() {
		for (Iterator it = postagens.iterator(); it.hasNext();) {
			System.out.println((String) it.next());
		}
	}
	public static void main(String[] args) {
		ArrayList<Cliente> listaUsuarios = new ArrayList<Cliente> ();
		String sn;
		do {

			Cliente novo = new Cliente();
			String nome, email, nacionalidade;
			Scanner entrada = new Scanner(System.in);
			
			System.out.println("Digite seu nome: ");
			nome = entrada.nextLine();
			System.out.println("Digite seu e-mail: ");
			email = entrada.nextLine();

			System.out.println("Digite sua nacionalidade: ");
			nacionalidade = entrada.nextLine();
			
			novo.setNome(nome);
			novo.setEmail(email);
			novo.setNacionalidade(nacionalidade);
			
			listaUsuarios.add(novo);
			String postarMaisSn; 
			do {
				String postagemString;
				System.out.println("Digite seu post: ");
				postagemString = entrada.nextLine();
				
				novo.adicionaPostagem(postagemString);

				System.out.println("Deseja postar mais coisas?");
				postarMaisSn = entrada.nextLine();
			}while (!postarMaisSn.equals("n"));
			
			System.out.println("Timeline do usuario " + novo.getNome() + ":");
			novo.mostrarPostagens();
			System.out.println();
			
			System.out.println("Deseja incluir novo usuario?");
			sn = entrada.nextLine();
			
			
		} while (!sn.equals("n"));
		

	}
	
}
