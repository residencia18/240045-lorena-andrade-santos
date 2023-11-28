#region Culture Definition

using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

#endregion

// List<(string nome, DateTime nascimeto)> pessoas = new();
// pessoas.Add(("Lorena", new DateTime(1982, 6, 8)));
// var tupla = (nome: "Demmi", nascimeto: new DateTime(1950, 8, 6));

// pessoas.Add(tupla);

// for (int i =0; i < 10; i++)
// {
//     pessoas.Add(("Lorena " + i, new DateTime(1970 + i, i+1, 6)));
// }
// var pessoaIniciamComL = pessoas.Where(p => p.nome.StartsWith("L"));

// List<(string nome, int idade)> pessoasComIdade = pessoas.Select(p => getPessoaIdade(p.nome, p.nascimeto)).ToList();

// var pessoasMaioresde50 = pessoasComIdade.Where(p => p.idade > 50);
// System.Console.WriteLine("Pessoas maiores de 50:");
// System.Console.WriteLine("----------------------------------------------------");

// foreach (var pessoa in pessoasMaioresde50)
// {
//     Console.WriteLine($"{pessoa}");
// }
// System.Console.WriteLine("Pessoas que começam com L na tupla:");
// System.Console.WriteLine("----------------------------------------------------");

// foreach (var pessoa in pessoaIniciamComL)
// {
//     Console.WriteLine($"{getPessoaIdade(pessoa.nome, pessoa.nascimeto)}");
// }

// (string,int) getPessoaIdade(string nome, DateTime dtNascimento){
//    var yearsOld = DateTime.Today.Year - dtNascimento.Year;
//    if (dtNascimento.Date.DayOfYear >= DateTime.Now.DayOfYear) yearsOld--;
//    return (nome, yearsOld);
// }

// Func<int,int,int> sumSquares = (x,y) => (x * x)+(y * y);
// Console.WriteLine($"2*2+3*3 = {sumSquares(2,3)}");


// List<int> numerosInteiros = new List<int>() {1,2,3,99,55,100,870,948,215,065,015,94,652,255,326,123,1234,125,126,129};
// var numerosPares = numerosInteiros.Where(num => num % 2 == 0);

// Console.WriteLine($"Lista de numeros pares: {string.Join(", ", numerosPares)}");

// var numerosParesOrdenadosCresc = numerosPares.OrderByDescending(num => num);
// var numerosParesOrdenadosDecresc = numerosPares.OrderByDescending(num => num);
// Console.WriteLine($"Lista de numeros pares crescente: {string.Join(", ", numerosParesOrdenadosCresc)}");
// Console.WriteLine($"Lista de numeros pares decrescente: {string.Join(", ", numerosParesOrdenadosDecresc)}");

//   List<(string Nome, int Altura)> pessoas = new List<(string, int)>
//         {
//             ("Lorena", 166),
//             ("Demi", 168),
//             ("Gabriel", 180),
//             ("Diego", 140),
//             ("Jo", 144),
            
//         };
// List<(string nome, int altura)> pessoasAltura = new();

// pessoasAltura.Add(("Lorena", 188));
// pessoasAltura.Add(("ddddddddddddd", 190));

// double alturaMedia2 = pessoasAltura.Select(pessoasAltura => pessoasAltura.altura).Average();
// Console.WriteLine($"Altura média das pessoas: {alturaMedia2} centímetros");
//     double alturaMedia = pessoas.Select(pessoa => pessoa.Altura).Average();

//         Console.WriteLine($"Altura média das pessoas: {alturaMedia} centímetros");

//         // Pessoa mais alta
//         var pessoaMaisAlta = pessoas.OrderByDescending(pessoa => pessoa.Altura).First();
//         Console.WriteLine($"A pessoa mais alta é {pessoaMaisAlta.Nome} com {pessoaMaisAlta.Altura} cm");

//         // Pessoa mais baixa
//         var pessoaMaisBaixa = pessoas.OrderBy(pessoa => pessoa.Altura).First();
//         Console.WriteLine($"A pessoa mais baixa é {pessoaMaisBaixa.Nome} com {pessoaMaisBaixa.Altura} cm");


        
//         // Calcular mediana
//         var pessoasOrdenadasPorAltura = pessoas.OrderBy(pessoa => pessoa.Altura).ToList();
//         int quantidadePessoas = pessoasOrdenadasPorAltura.Count;

//         double mediana;
//         if (quantidadePessoas % 2 == 0)
//         {
//             // Média dos dois valores centrais se houver um número par de elementos
//             mediana = (pessoasOrdenadasPorAltura[quantidadePessoas / 2 - 1].Altura +
//                        pessoasOrdenadasPorAltura[quantidadePessoas / 2].Altura) / 2.0;
//         }
//         else
//         {
//             // Valor central se houver um número ímpar de elementos
//             mediana = pessoasOrdenadasPorAltura[quantidadePessoas / 2].Altura;
//         }

//         Console.WriteLine($"A mediana das alturas é: {mediana} cm");
