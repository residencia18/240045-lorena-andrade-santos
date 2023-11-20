package Aula05;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class ListaNumeros {
	ArrayList<Float> numeros;

	public ListaNumeros() {
		super();
		numeros = new ArrayList<Float>();
	}
	public void novoNumero(float numero) {
		numeros.add(numero);
	}
	public void listaNumeros() {
		for (Float numero : numeros) {
			System.out.println(numero);
		}
	}
	public float media() {
		int quantos=0;
		float soma=0;
		for (Float numero : numeros) {
			soma+=numero;
			quantos++;
		}
		return soma/quantos;
	}
	public void ordenar() {
		Collections.sort(numeros);
	}
	public float mediana() {
		int quantos = numeros.size();
		int meio = quantos / 2;
		
		if (quantos % 2 == 0) {
			float n1 = numeros.get(meio-1);
			float n2 = numeros.get(meio);
			return (n1 + n2) / 2;
		}
		else {
			return numeros.get(meio);
		}
	}
	public float colocadoEm(int index) 
	{
		int quantos = numeros.size();
		if(index < quantos) 
		{
			if (index +1 < quantos) {
				return numeros.get(index +1);	
			}
			else
			{
				System.out.println("Seu maior número já esta no indice: " + index);
				return -1;
			}
			
		}
		else {
			System.out.println("Ops... O index digitado é maior que a quentidade de itens da minha lista.");
			return -1;
		}
	}
	public static void main(String[] args) {
		ListaNumeros meusNumeros = new ListaNumeros();

		float numero;
		Scanner entrada = new Scanner(System.in);
		
		do {
			System.out.println("Digite um float para compor uma Lista de numeros: Para sair digite -1 ");

			numero = entrada.nextFloat();
			if(numero != -1) {
				meusNumeros.novoNumero(numero);
			}
		} while (numero!=-1);
		meusNumeros.listaNumeros();
		System.out.println();
		System.out.println("A média desses numeros é: " + meusNumeros.media());
		System.out.println();
		
		meusNumeros.ordenar();
		meusNumeros.listaNumeros();
		
		System.out.println("A mediana é: " + meusNumeros.mediana());
		
		int index;
		System.out.println("Digite um indice para eu retorna que é o maior dele: ");		
		index = entrada.nextInt();
		float enesimoMaior = meusNumeros.colocadoEm(index);
		if (enesimoMaior != -1)
		{
			System.out.println("O o N ésimoMAIOR número dessa lista é: " + enesimoMaior); ;
		}
		
	}
}
