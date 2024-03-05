#include <iostream>
#include <string>
#include "hora.h"
using namespace std;

Hora :: ~Hora() {
    
}

Hora :: Hora() {
    hora = 0;
    minuto = 0;
    msgErro = "";
}

Hora :: Hora(int _hora, int _minuto) {
    msgErro = horaValida(_hora, _minuto);
    if (msgErro == "") {
        hora = _hora;
        minuto = _minuto;
    } else {
        hora = 0;
        minuto = 0;
    }
}

string Hora :: horaValida(int _hora, int _minuto) {
    msgErro = "";
    if (_hora < 0 || _hora > 23) {
        msgErro = "Hora inválida: deve estar no intervalo 0-23";
    } else if (_minuto < 0 || _minuto > 59) {
        msgErro = "Minuto inválido: deve estar no intervalo 0-59";
    }
    return msgErro;
}

string Hora :: alteraHora(int _hora, int _minuto) {
    string erro = horaValida(_hora, _minuto);
    if (erro == "") {
        hora = _hora;
        minuto = _minuto;
    }
    return erro;
}

string Hora :: to_string_zerosH(int numero) {
    string numero_string = to_string(numero);
    if (numero < 10) {
        numero_string = "0" + numero_string;
    }
    return numero_string;
}

string Hora :: horaParaString() {
    string horaStr = to_string_zerosH(hora);
    string minutoStr = to_string_zerosH(minuto);
    return horaStr + ":" + minutoStr;
}

string Hora :: getErroH() {
    return msgErro;
}