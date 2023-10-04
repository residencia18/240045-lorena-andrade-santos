#include <iostream>
#include <string>
#include <vector>
#include <iomanip> // std::setprecision
#define TRACO "------------------------------------------------------------------------"

using namespace std;

struct Produto
{
    string codigo;
    string nome;
    double preco;
};
void inserirProduto(vector<Produto> &produto);
void listarProdutos(vector<Produto> produtos);
bool codigoJaExiste(vector<Produto> produtos, string codigo);
void excluirProduto(vector<Produto>& produtos);
void consultarPreco(vector<Produto> produtos);
int main()
{
    vector<Produto> produtos;

    int opcao;
    bool sair = false;
    do
    {
        cout << TRACO << endl;
        cout << "Menu" << endl;
        cout << TRACO << endl;
        cout << "Opcao 1: Inserir um novo produto" << endl;
        cout << "Opcao 2: Excluir um produto cadastrado" << endl;
        cout << "Opcao 3: Listar todos os produtos com seus respectivos códigos e preços" << endl;
        cout << "Opcao 4: Consultar o preço de um produto através de seu código" << endl;
        cout << "Opcao 0: Sair" << endl;
        cout << TRACO << endl;

        cin >> opcao;
        switch (opcao){
        case (1):
            if (produtos.size() < 3)
                inserirProduto(produtos);
            else
                cout << "Ops! Já chegamos no limite de 300 produtos cadastrados." << endl;

            break;
        case (2):
            excluirProduto(produtos);
            break;
        case (3):
            listarProdutos(produtos);
            break;
        case (4):
            consultarPreco(produtos);
            break;
        case (0):
            sair = true;
            break;
        default:
            cout << "Opção invalida. Tente novamente." << endl;
            break;
        }
    } while (!sair);

    return 0;
}

void inserirProduto(vector<Produto> &produto)
{
    Produto ProdutoAtual;
    string codigo = "";
    string nome = "";

    do
    {
        cout << "Digite o cógigo do Produto: [ate 13 caracteres]" << endl;
        cin >> codigo;
        if (codigo.length() > 13)
        {
            codigo = "";
        }
        else if (codigoJaExiste(produto, codigo))
        {
            cout << "Ops! O código " << codigo << "já foi cadastrado" << endl;
            codigo = "";
        }
    } while (codigo == "");

    do
    {
        cout << "Digite o nome do Produto: [ate 20 caracteres]" << endl;
        cin >> nome;
        if (nome.length() > 20)
        {
            nome = "";
        }

    } while (nome == "");
    do
    {
        cout << "Digite o preço do Produto: " << endl;
        cin >> ProdutoAtual.preco;

    } while (ProdutoAtual.preco <= 0);

    ProdutoAtual.codigo = codigo;
    ProdutoAtual.nome = nome;
    produto.push_back(ProdutoAtual);
}

bool codigoJaExiste(vector<Produto> produtos, string codigo)
{
    for (const Produto &p : produtos)
    {
        if (p.codigo == codigo)
            return true;
    }

    return false;
}

void listarProdutos(vector<Produto> produtos){
    cout << TRACO << endl;
    cout << right << setw(16) << "CODIGO"
         << "  " << left << setw(40) << "NOME"
         << right << setw(12) << "PRECO" << endl;
    cout << TRACO << endl;
    for (const Produto &p : produtos)
        cout << right << setw(16) << p.codigo << "  " << left<< setw(40)  << p.nome << right << setw(12) << fixed << std ::setprecision(2) << p.preco << endl;

    cout << endl;
    cout << endl;
}
void excluirProduto(vector<Produto>& produtos) {
    string codigo;
    cout << "Digite o código do produto que deseja excluir: ";
    cin >> codigo;

    for (int i = 0; i < produtos.size(); i++) {
        if (produtos[i].codigo == codigo) {
            produtos.erase(produtos.begin() + i);

            cout << TRACO << endl;
            cout << "Produto excluído com sucesso!" << endl;
            cout << TRACO << endl << endl;
            return;
        }
    }

    cout << TRACO << endl;
    cout << "Produto não encontrado." << endl;
    cout << TRACO << endl << endl;
}
void consultarPreco(vector<Produto> produtos) {
    string codigo;
    cout << "Digite o código do produto para consultar o preço: ";
    cin >> codigo;

    for (const Produto& produto : produtos) {
        if (produto.codigo == codigo) {
            cout << "Preço do produto " << produto.nome << ": " << fixed << setprecision(2) << produto.preco << endl;
            return;
        }
    }
    cout << TRACO << endl;
    cout << "Produto não encontrado." << endl;
    cout << TRACO << endl << endl;

}