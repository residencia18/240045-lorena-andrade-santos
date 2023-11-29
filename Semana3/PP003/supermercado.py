

def inserirProduto(produtos):
    codigo = input("Digite o código do produto (13 caracteres numéricos): ")
    while len(codigo) != 13 or not codigo.isdigit():
        print("Código inválido. Deve conter 13 caracteres numéricos.")
        codigo = input("Digite novamente o código do produto: ")

    nome = input("Digite o nome do produto: ").capitalize()
    
    preco = input("Digite o preço do produto: ")
    while not preco.replace(".", "").isdigit():
        preco = input("Digite novamente o preço do produto: ")
    preco = round(float(preco), 2)    
    produtos.append({"codigo": codigo, "nome": nome, "preco": float(preco)})
    print(f"Produto {nome} cadastrado!")
    print("---------------------------------------------")
    print("")   
def excluirProduto(produtos):
    nomeProduto = ""
    codigo = input("Digite o código do produto que deseja excluir: ")
    print("")
    for produto in produtos:
        if produto["codigo"] == codigo:
            nomeProduto =  produto["nome"]          
            produtos.remove(produto)
            print(f"O produto {nomeProduto} foi removido.")
            return
    print(f"Produto com código {codigo} não encontrado.")
    print("---------------------------------------------")
    print("")   
def listarProdutos(produtos):
    print("Produtos cadastrados")
    print("---------------------------------------------")
    print("")
    
    produtosOrder = sorted(produtos, key=lambda x: x['preco'])
    iterador = iter(range(0, len(produtosOrder), 10))
    indice_inicial = 0
    while True:
        try:
            indice_inicial = next(iterador)
        except StopIteration:
            break

        pagina = produtosOrder[indice_inicial:indice_inicial + 10]
        print("")
        for produto in pagina:
            print(f"Código: {produto['codigo']}, Nome: {produto['nome']}, Preço: R${produto['preco']:.2f}")

        continuar = input("Pressione Enter para ver mais 10 produtos ou digite 's' para sair: ")
        if continuar.lower() == 's':
            break
    print("---------------------------------------------")
    print("")       
def consultarPreco(produtos):
    codigo = input("Digite o código do produto para consultar o preco: ")
    print("")
    for produto in produtos:
        if produto["codigo"] == codigo:
            print(f"Preço: R${produto['preco']:.2f} - Código: {produto['codigo']}, Nome: {produto['nome']}")
            return
    print(f"Produto com código {codigo} não encontrado.")
    print("---------------------------------------------")
    print("")   

def main():
    pass

if __name__ == "__main__":
    main()