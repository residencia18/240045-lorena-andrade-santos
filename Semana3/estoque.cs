class GerenciadorDeEstooque
{
    static int codigo = 1;
    static List<(int id, string nome, int estoque, double preco)> produtos = new();

        static void Main()
        {
            string opcao ="";
            do
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Sistema de Gerenciamento de Estoque");
                Console.WriteLine("1. Cadastrar Produto");
                Console.WriteLine("2. Consultar Produtos");
                Console.WriteLine("3. Atualização de Estoque");
                Console.WriteLine("4. Listar de produtos com quantidade em estoque abaixo do limite");
                Console.WriteLine("5. Lista de produtos com valor entre um mínimo e um máximo");
                Console.WriteLine("6. Informar o valor total do estoque e o valor total de cada produto");
                Console.WriteLine("0. Sair");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Escolha uma opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {   
                    case "1":
                        cadastrarProduto();
                        break;
                    case "2":
                        consultarProduto();
                        break;
                    case "3":
                        atualizarEstoque();
                        break;
                    case "4":
                        listarProdutosAbaixoDoLimite();
                        break;
                    case "5":
                        listarProdutosMinMax();
                        break;
                    case "6":
                        valorTotal();
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

        #region funcoes estoque
            
            static void cadastrarProduto(){
                try
                {

                    Console.WriteLine("Digite o nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite a quantidade em estoque: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o preço unitário: ");
                    double preco = Convert.ToDouble(Console.ReadLine());

                    var novoProduto = (id: codigo, nome: nome, estoque: quantidade, preco: preco);
                    produtos.Add(novoProduto);
                    codigo++;
                    Console.WriteLine("Produto cadastrado com sucesso!\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao cadastrar o produto: {ex.Message}\n");
                }
        
            }
            static void consultarProduto(){
                int codigo = LeInteiro("Digite o codigo do Produto para busca: ");
                try
                {
                    var produtoConsultado = produtos.First(p => p.id == codigo);
                    Console.WriteLine($"Produto: ID: {produtoConsultado.id}, Nome: {produtoConsultado.nome}, Estoque: {produtoConsultado.estoque}, Preço: {produtoConsultado.preco}");
                }
                catch (System.Exception)
                {
                    Console.WriteLine($"Produto com código {codigo} não encontrado. ");
                }
            }

            static int LeInteiro(string mensagem){
                do
                {
                    try
                    {
                        Console.WriteLine(mensagem);
                        return Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um número inteiro válido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Um inteiro não comporta esse valor.");
                    }
                    
                } while (true);

            }

            static double LeDouble(string mensagem){
                do
                {
                    try
                    {
                        Console.WriteLine(mensagem);
                        return Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um número double válido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Um double não comporta esse valor.");
                    }
                    
                } while (true);

            }

            
            static void entradaEstoque(){
                int codigo = LeInteiro("Digite o codigo do Produto para busca: ");
                int quantidade = LeInteiro("Digite a quantidade para dar entrada: ");
                try
                {
                    var indice = produtos.FindIndex(p => p.id == codigo);

                    if (indice == -1)
                    {
                        Console.WriteLine($"Produto com código {codigo} não encontrado. ");
                    }
                    else
                    {
                        produtos = produtos.Select((p, index) => index == indice ? p with { estoque = p.estoque + quantidade } : p).ToList();
                        Console.WriteLine($"Estoque do produto {produtos[indice].nome} atualizado com sucesso!");
                    }

                }catch (System.Exception)
                {
                    Console.WriteLine($"Produto com código {codigo} não encontrado. ");
                }
            }

            static void saidaEstoque(){
                int codigo = LeInteiro("Digite o codigo do Produto para busca: ");
                int quantidade = LeInteiro("Digite a quantidade para dar saida: ");
                try
                {
                    var produtoConsultado = produtos.First(p => (p.id == codigo));
                    var indice = produtos.FindIndex(p => p.id == codigo);

                    if (indice == -1)
                    {
                        Console.WriteLine($"Produto com código {codigo} não encontrado. ");
                    }
                    else
                    {
                        int estoque = produtoConsultado.estoque;
                        if((estoque - quantidade) >= 0){
                            produtos = produtos.Select((p, index) => index == indice ? p with { estoque = p.estoque - quantidade } : p).ToList();
                            Console.WriteLine($"Estoque do produto {produtos[indice].nome} atualizado com sucesso!");
                        }
                        else{
                            Console.WriteLine($"A quantidade de saída: {quantidade} é maior que o estoque{estoque}");
                        }
                    }


                   
                }
                catch (System.Exception)
                {
                    Console.WriteLine($"Produto com código {codigo} não encontrado. ");
                }


            }

            static void atualizarEstoque(){
                 Console.WriteLine("Digite a opcao para atualiza o estoque. 1 para entrada e 2 para saida: ");
                string? opcao = Console.ReadLine();
                if (opcao == "1")
                {                      
                    entradaEstoque();
                }
                else if (opcao == "2")
                {
                    saidaEstoque();
                }
            }
            static void listarProdutosAbaixoDoLimite(){
                int quantidadeLimiteEstoque = LeInteiro("Digite a quantidade limite de estoque: ");
                var produtosAbaixoLimite = produtos.Where(p => p.estoque < quantidadeLimiteEstoque);

                Console.WriteLine($"Produtos abaixo da quantidade: {quantidadeLimiteEstoque}");
                Console.WriteLine("------------------------------------------------------------------");
                foreach (var produto in produtosAbaixoLimite){
                    Console.WriteLine($"Produto: ID: {produto.id}, Nome: {produto.nome}, Estoque: {produto.estoque}, Preço: {produto.preco}");    
                }
                Console.WriteLine("");                
            }
        static void listarProdutosMinMax(){
            double valorMinimo = LeDouble("Digite o valor mínimo: ");
            double valorMaximo = LeDouble("Digite o valor máximo: ");

            var produtosEntreValores = produtos.Where(p => p.preco >= valorMinimo && p.preco <= valorMaximo);
            
                Console.WriteLine($"Produtos entre os valores {valorMinimo} e {valorMaximo}");
                Console.WriteLine("------------------------------------------------------------------");
                foreach (var produto in produtosEntreValores){
                    Console.WriteLine($"Produto: ID: {produto.id}, Nome: {produto.nome}, Estoque: {produto.estoque}, Preço: {produto.preco}");    
                }
                Console.WriteLine("");  
        }
        static void valorTotal(){
            double valorTotalEstoque = produtos.Sum(p => p.estoque * p.preco);
            Console.WriteLine($"Valor total do estoque: {valorTotalEstoque}");

            foreach (var produto in produtos)
            {
                double valorTotalProduto = produto.estoque * produto.preco;
                Console.WriteLine($"Produto: {produto.nome}, Valor Total: {valorTotalProduto}");
            }

        }
        #endregion
}