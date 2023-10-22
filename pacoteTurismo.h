#ifndef PACOTETURISMO_H
#define PACOTETURISMO_H
using namespace std;
#include <string>
#include <vector>

class Evento {
private:
    std::string nome;
    int vagas;

public:
    Evento();
    Evento(string _nome, int _vagas);

    // Adicione métodos relevantes para a classe Evento, se necessário.
};

class Roteiro {
private:
    string descricao;

public:
    Roteiro();
    Roteiro(string _descricao);

    // Adicione métodos relevantes para a classe Roteiro, se necessário.
};

class Deslocamento {
private:
    std::string meioDeTransporte;

public:
    Deslocamento();
    Deslocamento(std::string _meioDeTransporte);

    // Adicione métodos relevantes para a classe Deslocamento, se necessário.
};

class Pernoite {
private:
    std::string hotel;

public:
    Pernoite();
    Pernoite(std::string _hotel);

    // Adicione métodos relevantes para a classe Pernoite, se necessário.
};

class PacoteTurismo {
private:
    string nome;
    Evento evento;
    Roteiro roteiro;
    Deslocamento deslocamento;
    Pernoite pernoite;

public:
    PacoteTurismo();
    PacoteTurismo(
        string _nome,
        Evento _evento,
        Roteiro _roteiro,
        Deslocamento _deslocamento,
        Pernoite _pernoite);

    // Adicione métodos relevantes para a classe PacoteTurismo, se necessário.
};

class Pessoa {
protected:
    std::string nome;
    int idade;

public:
    Pessoa();
    Pessoa(string _nome, int _idade);

    // Adicione métodos relevantes para a classe Pessoa, se necessário.
};

class Cliente : public Pessoa {
private:
    vector<PacoteTurismo> pacotes;

public:
    Cliente();
    Cliente(string _nome, int _idade);

    void adicionarPacote(PacoteTurismo pacote);

    // Adicione métodos relevantes para a classe Cliente, se necessário.
};

class Dependente : public Pessoa {
private:
    Cliente* responsavel;

public:
    Dependente();
    Dependente(string _nome, int _idade, Cliente* _responsavel);

    // Adicione métodos relevantes para a classe Dependente, se necessário.
};

#endif
