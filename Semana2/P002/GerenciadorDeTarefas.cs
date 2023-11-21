
class Tarefa
{
    private string titulo;
    private string descricao;
    private DateTime dataVencimento;
    private bool concluida;
    public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        public bool Concluida
        {
            get { return concluida; }
            set { concluida = value; }
        }

    public Tarefa(string _titulo, string _descricao, DateTime _dataVencimento)
    {
        titulo = _titulo;
        descricao = _descricao;
        dataVencimento = _dataVencimento;
        concluida = false;
    }

    public string ToString()
    {
        return $"Tarefa: {titulo}\nDescrição: {descricao}\nData de Vencimento: {dataVencimento:dd/MM/yyyy}\nConcluída: {(concluida ? "Sim" : "Não")}\n";
    }
}
class GerenciadorDeTarefas
{
    static List<Tarefa> tarefas = new List<Tarefa>();

    static void Main()
    {
        string opcao ="";
        do
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Sistema de Gerenciamento de Tarefas");
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2. Listar Tarefas");
            Console.WriteLine("3. Marcar Tarefa como Concluída");
            Console.WriteLine("4. Listar Tarefas Pendentes");
            Console.WriteLine("5. Listar Tarefas Concluídas");
            Console.WriteLine("6. Excluir Tarefa");
            Console.WriteLine("7. Encontrar Tarefas");
            Console.WriteLine("8. Estatísticas");
            Console.WriteLine("0. Sair");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Escolha uma opção: ");

            opcao = Console.ReadLine();

            switch (opcao)
            {   
                case "1":
                    criarTarefa();
                    break;
                case "2":
                    listarTodasTarefas();
                    break;
                case "3":
                    marcarTarefaComoConcluida();
                    break;
                case "4":
                    listarPendentes();
                    break;
                case "5":
                    listarConcluidas();
                    break;
                case "6":
                    excluirTarefa();
                    break;
                case "7":
                    listarPalavrasChave();
                    break;
                case "8":
                    estatisticasBasicas();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao!="0");
    }
#region Funcoes de gerenciamento de tarefas


    static void criarTarefa(){
        //O sistema deve permitir a criação de tarefas, incluindo um título, descrição e data de vencimento.
        string titulo;
        string descricao;
        string data;
        DateTime dataVencimento;

        Console.Write("Digite o titulo da tarefa: ");
        titulo = Console.ReadLine();
        
        Console.Write("Digite a descrição: ");
        descricao = Console.ReadLine();
        do
        {
            Console.Write("Digite a data de vencimento (no formato dd/MM/yyyy): ");
            data = Console.ReadLine();

            if (DateTime.TryParseExact(data, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataVencimento))
            {
                tarefas.Add(new Tarefa(titulo, descricao, dataVencimento));
                Console.WriteLine("Tarefa criada com sucesso!");
                break;
            }
            else
            {
                Console.WriteLine("A data digitada está no formato inválido.");
            }    
        } while (true);
    }
    static void listarTodasTarefas(){
        Console.WriteLine();
        Console.WriteLine("Lista das Tarefas:");
        Console.WriteLine("-----------------------------------");
        int i=1;
        //listar todas as tarefas criadas.
        foreach (Tarefa tarefa in tarefas)
        {  
            Console.WriteLine(i + "." + tarefa.ToString());
            i++;
        }
    }

    static void marcarTarefaComoConcluida(){
        //marcar tarefas como concluídas
        Console.WriteLine();
        int codigo;
        Console.Write("Digite o codigo da tarefa: ");
        codigo = int.Parse(Console.ReadLine());
        if (codigo>=1 && codigo<=tarefas.Count)
        {
            tarefas[codigo-1].Concluida = true;

            Console.WriteLine($"Tarefa {tarefas[codigo-1].Titulo} marcada como concluída.");
        }
        else{
        
            Console.WriteLine("Codigo fora do intervalo das tarefas.");

        }

    }
    static void listarPendentes()
    {
        Console.WriteLine();
        Console.WriteLine("Lista das Tarefas Pendentes:");
        Console.WriteLine("-----------------------------------");
        int i=1;
        //listar todas as tarefas criadas.
        foreach (Tarefa tarefa in tarefas)
        {  
            if(!tarefa.Concluida){
                Console.WriteLine(i + "." + tarefa.ToString());
            }

            i++;
        }

    }
    static void listarConcluidas()
    {
        
        Console.WriteLine();
        Console.WriteLine("Lista das Tarefas Concluídas:");
        Console.WriteLine("-----------------------------------");
        int i=1;
        //listar todas as tarefas criadas.
        foreach (Tarefa tarefa in tarefas)
        {  
            if(tarefa.Concluida){
                Console.WriteLine(i + "." + tarefa.ToString());
            }
            i++;
        }

        
    }

    static void excluirTarefa(){
        //excluir tarefas
        Console.WriteLine();
        int codigo;
        Console.Write("Digite o codigo da tarefa: ");
        codigo = int.Parse(Console.ReadLine());
        if (codigo>=1 && codigo<=tarefas.Count)
        {   
            string tituloStr = tarefas[codigo-1].Titulo;
            tarefas.RemoveAt(codigo - 1);
            Console.WriteLine($"Tarefa {tituloStr} excluída com sucesso.");   
        }
        else{     
            Console.WriteLine("Codigo fora do intervalo das tarefas.");
        }
    }

    static void listarPalavrasChave(){
        Console.WriteLine();
        Console.Write("Digite uma palavra-chave: ");
        string palavraChave = Console.ReadLine().ToLower();

        Console.WriteLine("Resultados da Pesquisa:");
        foreach (Tarefa tarefa in tarefas)
        {
            if (tarefa.Titulo.ToLower().Contains(palavraChave) || tarefa.Descricao.ToLower().Contains(palavraChave))
            {
                Console.WriteLine(tarefa.ToString());
            }
        }
    }

    static void estatisticasBasicas()
    {
        Console.WriteLine("Estatísticas");
        Console.WriteLine($"Total de Tarefas: {tarefas.Count}");
     
    int tarefasConcluidas = 0;
    int tarefasPendentes = 0;

    foreach (Tarefa tarefa in tarefas)
    {
        if (tarefa.Concluida)
            tarefasConcluidas++;
        else
            tarefasPendentes++;
    }

    Console.WriteLine($"Tarefas Concluídas: {tarefasConcluidas}");
    Console.WriteLine($"Tarefas Pendentes: {tarefasPendentes}");

    if (tarefas.Count > 0)
    {
        DateTime tarefaMaisAntiga = tarefas[0].DataVencimento;
        DateTime tarefaMaisRecente = tarefas[0].DataVencimento;

        foreach (Tarefa tarefa in tarefas)
        {
            if (tarefa.DataVencimento < tarefaMaisAntiga)
                tarefaMaisAntiga = tarefa.DataVencimento;

            if (tarefa.DataVencimento > tarefaMaisRecente)
                tarefaMaisRecente = tarefa.DataVencimento;
        }

        Console.WriteLine($"Tarefa Mais Antiga: {tarefaMaisAntiga:dd/MM/yyyy}");
        Console.WriteLine($"Tarefa Mais Recente: {tarefaMaisRecente:dd/MM/yyyy}");
    }
    }
#endregion
}