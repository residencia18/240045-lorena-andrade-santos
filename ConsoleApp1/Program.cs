
using ConsoleApp1;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");
List<Pessoa> pessoa = App.AdicionaPessoa();

foreach (Pessoa p in pessoa)
{
   Console.WriteLine($"Nome: {p.Nome}");
   Console.WriteLine($"Documento: {p.Documento}");
   Console.WriteLine($"Data de nascimento: {p.DtNascimento.ToShortDateString()}");
   Console.WriteLine();
}