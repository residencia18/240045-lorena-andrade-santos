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
    Veiculo veiculo;
    Cliente cliente;
    Funcionario funcionario;
    string dataInicio;
    string dataTermino;
    string dataDevolucao;
    //float desconto;
    float adicional;
    //Calcula o valor total com base no período de aluguel e no preço por dia do veículo. 
    float calcular_valor_final();
    //retorna o status da reserva: agendada, iniciada, atrasada, finalizada.
    string verifica_status();
};
class Cliente : public Usuario {
public:
    string habilitacao;
    vector<Aluguel> historicoAlugueis; 
    //retorna o valor do aluguel no  período ou -1 se o veículo estiver alugado. 
    float cotar_aluguel(Veiculo veiculo, string dataInicio, string dataTermino);
    //solicita o aluguel do veículo entre as datas informadas 
    void solicita_aluguel(Veiculo veiculo, string dataInicio, string dataTermino);
    // devolve o veículo e solicita finalização do aluguel
    void devolver_veiculo(Aluguel aluguel, string dataDevolucao);
};
class Funcionario : public Usuario {
public:
    string habilitacao;
    vector<Aluguel> historicoAlugueis;
    //retorna um objeto da classe Aluguel com status em aberto
    Aluguel alugar_veiculo(Cliente cliente, Veiculo veiculo, string dataInicio, string dataTermino);
    //finaliza um aluguel
    void finalizar_aluguel(Aluguel aluguel, string dataDevolucao);
};