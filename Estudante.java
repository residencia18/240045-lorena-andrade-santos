package Aula05;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.Period;
import java.time.ZoneId;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;

public class Estudante {
	String nome;
	Date dataNascimento;
	String CPF;
	
	public Estudante(String nome, Date dataNascimento, String cPF) {
		super();
		this.nome = nome;
		this.dataNascimento = dataNascimento;
		CPF = cPF;
	}
	
	public void mostrarDataDeNascimento() {
		SimpleDateFormat dataNascimentoF = new SimpleDateFormat("dd/MM/yyyy");
		String strDate = dataNascimentoF.format(dataNascimento);  
		System.out.println("A data de nascimento do estudante é: " + strDate);
	}

	public int calculaIdade() {
		LocalDate dataAtual = LocalDate.now();
        LocalDate dtNascimentoL = dataNascimento.toInstant().atZone(ZoneId.systemDefault()).toLocalDate();
        Period periodo = Period.between(dtNascimentoL, dataAtual);
        
       return periodo.getYears();
	}

	public static void main(String[] args) throws ParseException {
		
		String nome;
		String CPF;
		String nascimento;
		
		Scanner entrada = new Scanner(System.in);
		
		System.out.println("Digite o nome do estudante: ");
		nome = entrada.nextLine();

		System.out.println("Digite o CPF: ");
		CPF = entrada.nextLine();

		System.out.println("Digite a data de nascimento no formato dd/MM/yyyy: ");
		nascimento = entrada.nextLine();
		SimpleDateFormat dataNascimentoF = new SimpleDateFormat("dd/MM/yyyy");
		
		Date dtNascimento = dataNascimentoF.parse(nascimento);
		
		Estudante novoEstudante = new Estudante(nome, dtNascimento, CPF);
		novoEstudante.mostrarDataDeNascimento();
		System.out.println("A idade do estudante é: " + novoEstudante.calculaIdade());
	}
}
