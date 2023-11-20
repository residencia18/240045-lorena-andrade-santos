package Praticas;

import java.util.Scanner;

public class Temperatura {
	public static float fahrParCelsius(float fahr) {
		return (fahr - 32) * 5 / 9;
	}

	public static float celciusParaFahr(float celcius) {
		return (celcius * 9/5) + 32;
	}
	
	public static void main(String[] args) {
		int opcao;
		float temperatura;
		Scanner entrada = new Scanner(System.in);
		
		System.out.println( "Digite 0 para converter de Celcius para Fahrenheit\n" +
							"Digite 1 para converter de Fahrenheit para Celcius: ");
		opcao = entrada.nextInt();
		System.out.println("Digite a temperatura:");
		temperatura = entrada.nextFloat();
		
		if (opcao == 0) {
			
			float temperaturaFahr = celciusParaFahr(temperatura);
			System.out.println("A temperatura em Fahrenheit: " + temperaturaFahr + "°F");
		}
		else {
					
			float temperaturaCelcius = fahrParCelsius(temperatura);
			System.out.println("A temperatura convertida utilizando duas funcoes é: " + temperaturaCelcius + "°C");
		}
		entrada.close();
	}
}