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
	public static void main(String[] args) {
		ListaNumeros meusNumeros = new ListaNumeros();

		float numero;
		do {
			System.out.println("Digite um float para compor uma Lista de numeros: Para sair digite -1 ");

			Scanner entrada = new Scanner(System.in);
			
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
	}
}
