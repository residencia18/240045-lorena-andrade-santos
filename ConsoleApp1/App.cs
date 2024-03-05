
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class App
    {
        public static List<Pessoa> AdicionaPessoa()
        {
            List<Pessoa> pessoa = new List<Pessoa>();

            string answer = "s";

            do
            {
                Console.WriteLine("Informe o nome da pessoa:");
                string nome = Console.ReadLine()!;

                Console.WriteLine("Informe o documento de identificacao:");
                string documento = Console.ReadLine()!;

                try
                {
                    Console.WriteLine("Informe a data de nascimento (dd/mm/yyyy):");
                    DateTime dtNasc = DateTime.Parse(Console.ReadLine()!);

                    Pessoa novaPessoa = new Pessoa(nome, documento, dtNasc);
                    pessoa.Add(novaPessoa);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Data de nascimento inválida!");
                    continue;
                }
                finally
                {
                    Console.WriteLine("Deseja continuar? (s/n)");
                    answer = Console.ReadLine()!;
                }

            } while (answer.ToLower() == "s");

            return pessoa;
        }
    }
}