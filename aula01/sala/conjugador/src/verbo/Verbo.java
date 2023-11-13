package verbo;

import java.util.Scanner;

public class Verbo {
	private String radical, sufixo;
	
	
	public Verbo(String radical, String sufixo) {
		super();
		this.radical = radical;
		this.sufixo = sufixo;
	}

	public String getRadical() {
		return radical;
	}

	public void conjugar() {
		System.out.println("Eu " + radical + "o");
		System.out.println("Tu " + radical + "as");
		System.out.println("Ele " + radical + "a");
		System.out.println("Nos " + radical + "amos");
		System.out.println("Vos " + radical + "ais");
		System.out.println("Eles " + radical + "am");
				
	}
	public void setRadical(String radical) {
		this.radical = radical;
	}

	public String getSufixo() {
		return sufixo;
	}

	public void setSufixo(String sufixo) {
		this.sufixo = sufixo;
	}


	public static void main(String[] args) {
		String radical, sufixo;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Digite o radical:");
		radical = sc.nextLine();
		System.out.println("Digite o sufixo:");
		sufixo = sc.nextLine();
		Verbo verbo = new Verbo(radical, sufixo);
		
		verbo.conjugar();
	}	
}