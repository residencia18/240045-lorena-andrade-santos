package Aula05;

public class troca {
	
	public static void main(String[] args) {
		int num1=3;
		int num2=4;

	    System.out.println("Num1: " + num1);
	    System.out.println("Num2: " + num2);
		num1 = num1 ^ num2;
		num2 = num1 ^ num2;
	    num1 = num1 ^ num2;
	    System.out.println("Depois da troca: ");
	    System.out.println("Num1: " + num1);
	    System.out.println("Num2: " + num2);
	}
}
