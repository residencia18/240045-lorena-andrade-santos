using Aula04.Exercicio2;


class Program
{
    static async Task Main(string[] args)
    {
        #region Exercicio 1 - Delegates

        var lista = new List<double>() { 3, 7, 2, 4, 6 };
        var novaLista = lista.ConvertAll(x => x / 2);

        novaLista.ForEach(x => Console.WriteLine(x));

        #endregion

        #region Exercicio 2 - Linq
        var listaMercado = new List<ItemMercado>();
        listaMercado.Add(new ItemMercado() { Nome = "Arroz", Tipo = "Comida", Preco = 3.9 });
        listaMercado.Add(new ItemMercado() { Nome = "Azeite", Tipo = "Comida", Preco = 300.5 });
        listaMercado.Add(new ItemMercado() { Nome = "Macarrão", Tipo = "Comida", Preco = 3.9 });
        listaMercado.Add(new ItemMercado() { Nome = "Cerveja", Tipo = "Bebida", Preco = 22.9 });
        listaMercado.Add(new ItemMercado() { Nome = "Refrigerante", Tipo = "Bebida", Preco = 5.5 });
        listaMercado.Add(new ItemMercado() { Nome = "Shampoo", Tipo = "Higiene", Preco = 7.0 });
        listaMercado.Add(new ItemMercado() { Nome = "Sabonete", Tipo = "Higiene", Preco = 2.4 });
        listaMercado.Add(new ItemMercado() { Nome = "Cotonete", Tipo = "Higiene", Preco = 5.7 });
        listaMercado.Add(new ItemMercado() { Nome = "Sabao em po", Tipo = "Limpeza", Preco = 8.2 });
        listaMercado.Add(new ItemMercado() { Nome = "Detergente", Tipo = "Limpeza", Preco = 2.6 });
        listaMercado.Add(new ItemMercado() { Nome = "Amaciante", Tipo = "Limpeza", Preco = 6.4 });

        var listaHigiene = listaMercado.Where(x => x.Tipo == "Higiene").OrderByDescending(x => x.Preco).ToList();

        Console.WriteLine("Produtos Higiene em ordem decrescente:");
        Console.WriteLine("Nome, Tipo, Preco");
        Console.WriteLine("---------------------------------------");
        listaHigiene.ForEach(x => Console.WriteLine(x));

        var listaMaioresQueCinco = listaMercado.Where(x => x.Preco >= 5).OrderBy(x => x.Preco).ToList();

        Console.WriteLine("Produtos com Preco maior ou igual a cinco em ordem crescente:");
        Console.WriteLine("Nome, Tipo, Preco");
        Console.WriteLine("---------------------------------------");
        listaMaioresQueCinco.ForEach(x => Console.WriteLine(x));

        var listaComidaOuBebida = listaMercado.Where(x => x.Tipo == "Comida" || x.Tipo == "Bebida").OrderBy(x => x.Nome).ToList();
        Console.WriteLine("Produtos Comida ou Bebida em ordem alfabetica:");
        Console.WriteLine("Nome, Tipo, Preco");
        Console.WriteLine("---------------------------------------");
        listaComidaOuBebida.ForEach(x => Console.WriteLine(x));

        var listaTipos = listaMercado.Select(x => x.Tipo).Distinct().ToList();
        Console.WriteLine("Tipos de Produtos:");
        Console.WriteLine("Tipo, Quantidade");
        Console.WriteLine("---------------------------------------");
        listaTipos.ForEach(x => Console.WriteLine(x + " - " + listaMercado.Where(y => y.Tipo == x).Count()));



        var listaTiposPrecos = listaMercado.GroupBy(x => x.Tipo)
                                     .Select(group => new { Tipo = group.Key, PrecoMax = group.Max(x => x.Preco), PrecoMin = group.Min(x => x.Preco), PrecoMedio = group.Average(x => x.Preco) })
                                     .ToList();
        Console.WriteLine("Tipo, Preco Maximo, Preco Minimo, Preco Medio");
        Console.WriteLine("---------------------------------------");

        listaTiposPrecos.ForEach(x => Console.WriteLine(x.Tipo + ", " + x.PrecoMax + ", " + x.PrecoMin + ", " + x.PrecoMedio.ToString("F2")));

        #endregion


        #region Exercicio 3 - Threads

        Thread.CurrentThread.Name = "Main()";
        Thread t1 = new Thread(Run);
        t1.Name = "Tread t1()";
        t1.Start();

        Thread t2 = new Thread(Run);
        t2.Name = "Tread t2()";
        t2.Start();

        t1.Join();
        t2.Join();

        #endregion

        #region Exercicio 4 - Async/Await
        
            await DoWorkAsync("Tarefa 1");
            await DoWorkAsync("Tarefa 2");
        
            Console.WriteLine("Ambas as tarefas foram concluídas.");
        #endregion
    }
    static void Run(object param)
    {
        string p = (string)param;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"O {Thread.CurrentThread.Name} está realizando o trabalho {i}/10");
            Thread.Sleep(1000);
        }
        Thread.Sleep(500);
    }
    static async Task DoWorkAsync(string taskName)
    {
        Console.WriteLine($"Iniciando a execução da {taskName}...");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Executando {taskName} - Progresso: {i}/10");
            await Task.Delay(500);
        }
        Console.WriteLine($"A {taskName} foi concluída.");
    }
}