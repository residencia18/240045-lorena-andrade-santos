#include <iostream>
#include <string>
#include <vector>
using namespace std;
class Usuario {
public:
    string cpf;
    string nome;
    string endereco;
    string telefone;
};

class Veiculo {
public:
    string identificador;
    string marca;
    string modelo;
    int anoFabricacao;
    float precoPorDia;
};
class Aluguel {
public:
    string identificador;
    // Veiculo veiculo;
    // Cliente cliente;
    // Funcionario funcionario;
    string dataInicio;
    string dataTermino;
    string dataDevolucao;
    //float desconto;
    float adicional;
};
class Cliente : public Usuario {
public:
    string habilitacao;
    vector<Aluguel> historicoAlugueis;
};
class Funcionario : public Usuario {
public:
    string habilitacao;
    vector<Aluguel> historicoAlugueis;
};