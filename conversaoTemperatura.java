package Aula05;

import java.util.Scanner;

public class conversaoTemperatura {
	public static float fahrParCelsius(float fahr) {
		return (fahr - 32) * 5 / 9;
	}

	public static float celciusParaFahr(float celcius) {
		return (celcius * 9/5) + 32;
	}
	public static float conversao(float temperatura, int opcao) {
		if (opcao == 0) {
			return (temperatura * 9/5) + 32;
		}
		else {
			return (temperatura - 32) * 5 / 9;
		}
	}
	public static void main(String[] args) {
		int opcao;
		float temperatura;
		float temperaturaConvertida;
		Scanner entrada = new Scanner(System.in);
		
		System.out.println("Digite 0 para converter de Celcius para Fahrenheit\n" +
							"Digite 1 para converter de Fahrenheit para Celcius: ");
		opcao = entrada.nextInt();
		System.out.println("Digite a temperatura:");
		temperatura = entrada.nextFloat();
		temperaturaConvertida = conversao(temperatura, opcao);
		if (opcao == 0) {
			System.out.println("A temperatura convertida é: " + temperaturaConvertida + "°C");

			float temperaturaCelcius = celciusParaFahr(temperatura);
			System.out.println("A temperatura convertida utilizando duas funcoes é: " + temperaturaCelcius + "°C");
		}
		else {
			System.out.println("A temperatura convertida é: " + temperaturaConvertida + "°F");
			
			float temperaturaFahr = fahrParCelsius(temperatura);
			System.out.println("A temperatura convertida utilizando duas funcoes é: " + temperaturaFahr + "°F");
		}
		entrada.close();
	}
}
