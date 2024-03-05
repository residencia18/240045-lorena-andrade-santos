import json
from supermercado import inserirProduto, excluirProduto, listarProdutos, consultarPreco

def main():
    try:
        with open('produtos.json', 'r') as arquivo:
            produtos = json.load(arquivo)
    except FileNotFoundError:
        #Caso o arquivo não exista. Inicia com a com alguns elementos
        produtos = [
            {'codigo': '0000000000001', 'nome': 'Arroz', 'preco': 5.99},
            {'codigo': '0000000000002', 'nome': 'Feijão', 'preco': 3.49},
            {'codigo': '0000000000003', 'nome': 'Farinha de Trigo', 'preco': 8.49},
            {'codigo': '0000000000004', 'nome': 'Alcatra', 'preco': 33.49},
            {'codigo': '0000000000005', 'nome': 'Manteiga', 'preco': 9.49},
            {'codigo': '0000000000006', 'nome': 'Azeitona', 'preco': 4.49},
            {'codigo': '0000000000007', 'nome': 'Cerveja', 'preco': 5.99},    
            {'codigo': '0000000000008', 'nome': 'Azeite', 'preco': 33.99},
            {'codigo': '0000000000009', 'nome': 'Queijo', 'preco': 47.49},
            {'codigo': '0000000000010', 'nome': 'Presunto', 'preco': 29.49},
            {'codigo': '0000000000011', 'nome': 'Ovo', 'preco': 21.09},
            {'codigo': '0000000000012', 'nome': 'Milho Verde', 'preco': 4.49},
            {'codigo': '0000000000013', 'nome': 'Fermento em pó', 'preco': 6.49},
         ]

    while True:
        print("1 - Inserir um novo produto")
        print("2 - Excluir um produto cadastrado")
        print("3 - Listar todos os produtos com seus respectivos códigos e preços")
        print("4 - Consultar o preço de um produto através de seu código.")
        print("0 - Sair")

        opcao = input("Escolha uma opção: ")

        if opcao == "1":
            inserirProduto(produtos)  
        elif opcao == "2":
            excluirProduto(produtos)
        elif opcao == "3":
            listarProdutos(produtos)
        elif opcao == "4":
            consultarPreco(produtos)
        elif opcao == "0":
            print("Saindo ... ")
            with open('produtos.json', 'w') as arquivo:
                json.dump(produtos, arquivo)
            break
        else:
            print("Opção inválida. Tente novamente.")

if __name__ == "__main__":
    main()