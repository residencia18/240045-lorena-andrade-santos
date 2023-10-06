#include <iostream>
#include <vector>
#include <string>
#include <iomanip>
#include <map>
#define TRACO "---------------------------------------------------------------------------------------------------"
using namespace std;

// ESPAÇO PARA AS STRUCTS ---------------
// Struct para representar um livro na biblioteca
struct Livro
{
    int codigo_do_livro;
    string titulo = "";
    string autor;
    int ano_publicacao;
    int disponibilidade = 0; //O tipo pode ser alterado depois!
    
};

// Struct para representar uma estante da biblioteca
struct Estante { 
    string nomeDaEstante;
    vector<Livro> livrosNaEstante;//adicionar livros na estante baseado em uma ordem especifica
};


//Estrucut para reresentar emprestimo de livros
struct Emprestimo {
    int codigoLivro; //codigo para busca de livros
    int idCartaoDeCadastro; //codigo de busca de usuairo para o emprestimo;
    string dataDeEmprestimo; //registrar a data de emprestimo
    string dataPrevistaDeDevolucao;//registrar a data prevista de devolução
};
//estrutura de devoluções;
struct Devolucao{
    int codigoLivro;
    string dataDeDevolucao;
};

// Struct para representar um usuario da biblioteca.
struct Leitor {
    int idCartaoDeCadastro;
    string nome;
    string  dataDeNascimeto;
    string endereço;
    string telefone;
    string email;
    bool altorizao; //caso tenha alguma pendencia posso bloquear o acesso aos emprestimo.
    Emprestimo livrosEmprestados[5];//maximo de emprestimos
    vector<Devolucao> devolucoes; //historio de devoluções

};

// Struct para representar a contratação de serviços terceirizados
struct EmpresaTerceirizada
{
    string servico;
    string nome_empresa;
    int duracao_contrato;
    int inicio_contrato;
    int quantidade_funcionarios;
};

// Struct para representar um espaço com mesas na biblioteca destinado à leitura
struct EspacoLeitura
{
    int codigo_mesas[5];
    bool ocupacao_mesas[5];
};

// Struct para representar a biblioteca como um todo
struct Biblioteca {
    string nomeDaInstituicao;
    map<string, Estante> estantes; // Usando um mapa para mapear nomes de estantes para estantes
    vector<Leitor> leitores; //cria o registro de usuarios/
    vector<Emprestimo> emprestimos; //cria o registro de emprestimo
    vector<Devolucao> devolucoes; //cria o registro de devoluções
};


int main()
{


    return 0; 
}

