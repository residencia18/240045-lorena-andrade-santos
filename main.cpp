#include <iostream>
#include <vector>
#include <string>
#include <iomanip>
#define TRACO "---------------------------------------------------------------------------------------------------"
using namespace std;

// ESPAÇO PARA AS STRUCTS ---------------
// Struct para representar um livro na biblioteca
struct Livro
{
    string titulo = "";
    string autor;
    int ano_publicacao;
    int disponibilidade = 0; //O tipo pode ser alterado depois!
};
// Struct para representar um leitor da biblioteca
//vector<Livro> livrosEmprestados
struct Leitor {


}
// Struct para representar uma estante da biblioteca

/*string genero;
    vector<Livro> livrosNaEstante;*/
struct Estante {
    
};

// Struct para representar a biblioteca como um todo
struct Biblioteca {
    string nome;
    vector<Estante> estantes;
    vector<Leitor> leitores;
};

// ESPAÇO PARA AS STRUCTS ---------------
// Funcionalidades
// void adicionarLivroNaEstante(Estante& estante, const Livro& livro);
// void emprestarLivro(Leitor& leitor, Livro& livro);
// void devolverLivro(Leitor& leitor, Livro& livro);
// void listarLivrosNaEstante(const Estante& estante);
// void listarLivrosEmprestados(const Leitor& leitor);

int main()
{

// // Criando alguns livros
//     Livro livro1 = {"Dom Casmurro", "Machado de Assis", 1899};
//     Livro livro2 = {"A Moreninha", "Joaquim Manuel de Macedo", 1844};
//     Livro livro3 = {"Memórias Póstumas de Brás Cubas", "Machado de Assis", 1881};

//     // Criando algumas estantes
//     Estante estante1 = {"Romance", {livro1, livro2}};
//     Estante estante2 = {"Ficção Científica", {livro3}};

//     // Criando alguns leitores
//     Leitor leitor1 = {"Alice", 28, {livro1}};
//     Leitor leitor2 = {"Bob", 32, {livro2}};

//     // Criando a biblioteca
//     Biblioteca minhaBiblioteca = {"Biblioteca Municipal", {estante1, estante2}, {leitor1, leitor2}};

    return 0; 
}

// void adicionarLivroNaEstante(Estante& estante, const Livro& livro) {
//     // Adicionar o livro à estante
// }

// void emprestarLivro(Leitor& leitor, Livro& livro) {
//     // Verificar se o livro está na estante
//     // Se sim, emprestar o livro ao leitor e removê-lo da estante
//     // Adicionar o livro à lista de livros emprestados do leitor
// }

// void devolverLivro(Leitor& leitor, Livro& livro) {
//     // Verificar se o livro está na lista de livros emprestados do leitor
//     // Se sim, devolver o livro à estante e removê-lo da lista de livros emprestados
// }

// void listarLivrosNaEstante(const Estante& estante) {
//     // Listar todos os livros na estante (título, autor, ano de publicação)
// }

// void listarLivrosEmprestados(const Leitor& leitor) {
//     // Listar todos os livros emprestados pelo leitor (título, autor, ano de publicação)
// }
