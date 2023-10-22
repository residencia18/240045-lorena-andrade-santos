#include <iostream>
#include <vector>
#include <string>

using namespace std;

//Foi criada na classe base chamada Pessoa
//e Cliente e Dependente herdarão de Pessoa
//a classe Dependente contém um ponteiro para Cliente chamado responsavel
//que indica qual cliente é o responsável pelo dependente.
class Pessoa {
     
protected:
    string nome;
    int idade;
public:
    ~Pessoa(){

    }
    Pessoa(){
        nome = "";
        idade = 0;
    }
    Pessoa(string _nome, int _idade) {
        nome = _nome;
        idade = _idade;
    }
};

class Cliente : public Pessoa {
private:
    //relacionamento entre Cliente e PacoteTurismo, podemos usar agregação.
    //pois um pacote de turismo pode estar vinculado a um ou mais clientes, mas não é completamente dependente deles.
    vector<PacoteTurismo> pacotes;
public:
    ~Cliente(){

    }
    Cliente(){
        nome = "";
        idade = 0;
    }
    Cliente(string _nome, int _idade) {
        nome = _nome;
        idade = _idade;
    }

    void adicionarPacote(PacoteTurismo pacote) {
        pacotes.push_back(pacote);
    }
};

class Dependente : public Pessoa {
private:
    Cliente* responsavel;
public:
    ~Dependente(){

    }
    Dependente(){
        nome = "";
        idade = 0;
    }
    Dependente(string _nome, int _idade, Cliente* _responsavel){
        nome = _nome;
        idade = _idade;
        responsavel = _responsavel;

    }
};
//Podemos utilizar composição para criar a classe PacoteTurismo contém outros objetos para representar roteiros, deslocamentos e pernoites.
class PacoteTurismo {
private:
    string nome;
    Evento evento;
    Roteiro roteiro;
    Deslocamento deslocamento;
    Pernoite pernoite;
public:
    ~PacoteTurismo(){

    }
    PacoteTurismo(){
        nome = "";
    }
    PacoteTurismo(string _nome, Evento _evento, Roteiro _roteiro, Deslocamento _deslocamento, Pernoite _pernoite){
        nome = _nome;
        evento = _evento;
        roteiro = _roteiro;
        deslocamento = _deslocamento;
        pernoite = _pernoite;
    }        
};
//Representa um evento específico que faz parte do pacote de turismo. 
class Evento {
private:
    string nome;
    int vagas;
public:
    ~Evento(){

    }
    Evento(){
        nome = "";
        vagas = 0;
    }
    Evento(string _nome, int _vagas) {
       nome = _nome;
       vagas = _vagas; 
    }
};

class Roteiro {
private:
    string descricao;
public:
    ~Roteiro(){

    }
    Roteiro(){
        descricao = "";
    }
    Roteiro(string _descricao){
        descricao = _descricao;
    } 
};

class Deslocamento {
private:
    string meioDeTransporte;
public:
    ~Deslocamento(){

    }
    Deslocamento(){
        meioDeTransporte = "";
    }
    Deslocamento(string _meioDeTransporte) {
        meioDeTransporte = _meioDeTransporte
    }
};

class Pernoite {
private:
    string hotel;
public:
    ~Pernoite(){

    }
    Pernoite(){
        hotel = "";
    }
    Pernoite(string _hotel){
        hotel = _hotel;
    } 
};

int main() {
    // Implemente a lógica para criar eventos, pacotes, clientes, vender pacotes e consultar informações aqui.
    // Certifique-se de criar objetos das classes apropriadas e usar os métodos correspondentes.
    return 0;
}
