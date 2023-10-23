#include <iostream>
#include <vector>
#include <string>
#include "pacoteTurismo.h"

using namespace std;

    PacoteTurismo ::  ~PacoteTurismo(){

    }
    PacoteTurismo :: PacoteTurismo(){
        nome = "";
    }
    PacoteTurismo :: PacoteTurismo(
        string _nome, 
        Evento _evento, 
        Roteiro _roteiro, 
        Deslocamento _deslocamento, 
        Pernoite _pernoite){
        nome = _nome;
        evento = _evento;
        roteiro = _roteiro;
        deslocamento = _deslocamento;
        pernoite = _pernoite;
    }        
    string PacoteTurismo :: getNome(){
        return nome;
    }

   Evento :: ~Evento(){

    }
    Evento :: Evento(){
        nome = "";
        vagas = 0;
    }
    Evento :: Evento(string _nome, int _vagas) {
       nome = _nome;
       vagas = _vagas; 
    }
    string Evento :: getNome(){
        return nome;
    }


   Roteiro :: ~Roteiro(){

    }
   Roteiro :: Roteiro(){
        descricao = "";
    }
    Roteiro :: Roteiro(string _descricao){
        descricao = _descricao;
    } 

   Deslocamento ::  ~Deslocamento(){

    }
    Deslocamento :: Deslocamento(){
        meioDeTransporte = "";
    }
    Deslocamento :: Deslocamento(string _meioDeTransporte) {
        meioDeTransporte = _meioDeTransporte;
    }
Pernoite :: ~Pernoite(){

    }
   Pernoite ::  Pernoite(){
        hotel = "";
    }
   Pernoite ::  Pernoite(string _hotel){
        hotel = _hotel;
    } 

    Pessoa :: ~Pessoa(){

    }
    Pessoa :: Pessoa(){
        nome = "";
        idade = 0;
    }
    Pessoa :: Pessoa(string _nome, int _idade) {
        nome = _nome;
        idade = _idade;
    }

    Cliente :: ~Cliente(){

    }
    Cliente :: Cliente(){
        nome = "";
        idade = 0;
    }
    Cliente :: Cliente(string _nome, int _idade) {
        nome = _nome;
        idade = _idade;
    }
    void Cliente :: adicionarDependente(Dependente dependente) {
        dependentes.push_back(dependente); 
    }

    void Cliente :: adicionarPacote(PacoteTurismo pacote) {
        pacotes.push_back(pacote);
    }
    string Cliente :: getNome(){
        return nome;
    }
    int Cliente :: getIdade(){
        return idade;
    }

    Dependente :: ~Dependente(){

    }
    Dependente :: Dependente(){
        nome = "";
        idade = 0;
    }
    Dependente :: Dependente(string _nome, int _idade){
        nome = _nome;
        idade = _idade;
    }
