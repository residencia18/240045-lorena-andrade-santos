using Aula03.Exercicio4;
using Aula03.Exercicio1;
using Aula03.Exercicio5;
enum Exercicios
{
    Academia = 1,
    Luta = 2,
    Corrida = 3

}
class Program
{
    static void Main(string[] args)
    {
        #region ContaBancaria - Exercício 1

        Console.WriteLine("Exercício 1: ");
        Console.WriteLine();

        var conta = new ContaBancaria();
        var conta2 = new ContaBancaria();

        //Gerar erros
        conta.Depositar(-100);
        conta.Transferir(10, conta2);


        conta.Depositar(100);
        conta.Transferir(50, conta2);
        #endregion

        #region Exercício 2
        Console.WriteLine("Exercício 2: ");
        Console.WriteLine();
        object o = null;
        try
        {
            Console.WriteLine(o.ToString());
        }
        catch (System.NullReferenceException)
        {
            Console.WriteLine("O objeto é nulo.");
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro.{ex.Message}");
        }

        #endregion


        #region Exercício 3


        Console.WriteLine("Exercício 3: ");
        Console.WriteLine();
        Console.WriteLine("Temos as opções de exercícios: ");
        foreach (var exercicio in Exercicios.GetValues(typeof(Exercicios)))
        {
            Console.WriteLine($"{(int)exercicio} - {exercicio}");
        }
        Console.Write("Informe qual exercício deseja executar: ");
        string? opcao = Console.ReadLine();

        try
        {
            int exercicioEscolhido = int.Parse(opcao);
            if( Enum.IsDefined(typeof(Exercicios), exercicioEscolhido))
            {
               Console.WriteLine($"Exercício {(Exercicios)exercicioEscolhido} selecionado."); 
            }
            else
            {
                Console.WriteLine("Exercício não encontrado.");
            }
        }
        catch (System.FormatException ex)
        {
            Console.WriteLine($"Ocorreu um erro.{ex.Message}");
        }
       catch (System.Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro.{ex.Message}");
        }

        #endregion


        #region Exercício 4
            ServicoFabrica<ServicoPadrao> fabrica = new ServicoFabrica<ServicoPadrao>();
            ServicoPadrao instanciaServicoPadrao = fabrica.NovaInstancia();
            instanciaServicoPadrao.Executar();
        #endregion
        #region Exercício 5

        Triangulo<int> trianguloInt = new Triangulo<int>(
            new Ponto<int>(1, 2, 3),
            new Ponto<int>(4, 5, 6),
            new Ponto<int>(7, 8, 9)
        );

        Triangulo<double> trianguloDouble = new Triangulo<double>(
            new Ponto<double>(10.1, 20.2, 30.3),
            new Ponto<double>(10.4, 22.5, 33.6),
            new Ponto<double>(70.7, 80.8, 90.9)
        );
        Console.WriteLine("Exemplos de triângulos criados:");
        Console.WriteLine("Triângulo de inteiros:"); 
        Console.WriteLine(
            $" P1({trianguloInt.P1.X}, {trianguloInt.P1.Y}, {trianguloInt.P1.Z}), " +
            $"P2({trianguloInt.P2.X}, {trianguloInt.P2.Y}, {trianguloInt.P2.Z}), " +
            $"P3({trianguloInt.P3.X}, {trianguloInt.P3.Y}, {trianguloInt.P3.Z})");

        Console.WriteLine("Triângulo de double:"); 
        Console.WriteLine(
            $" P1({trianguloDouble.P1.X}, {trianguloDouble.P1.Y}, {trianguloDouble.P1.Z}), " +
            $"P2({trianguloDouble.P2.X}, {trianguloDouble.P2.Y}, {trianguloDouble.P2.Z}), " +
            $"P3({trianguloDouble.P3.X}, {trianguloDouble.P3.Y}, {trianguloDouble.P3.Z})");

        #endregion
    }
}
