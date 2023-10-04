#include <iostream>
#include <string>
#include "data.h"
using namespace std;

    Data::~Data() {
        // Implementação do destrutor, se necessário
    }
    Data::Data()
    {
        dia = 1;
        mes = 1;
        ano = 1900;
        msgErro = "";
    }

    Data::Data(int _dia, int _mes, int _ano)
    {   
        
        if (_ano >= 1 && _ano <= 99)
            _ano = 2000 + _ano;
            
        msgErro = dataValida(_dia, _mes, _ano);
        if (msgErro == "")
        {
            dia = _dia;
            mes = _mes;
            ano = _ano;
        }
        else
        {
            dia = 1;
            mes = 1;
            ano = 1900;
        }
    }
    string Data :: dataValida(int dia, int mes, int ano)
    {
        msgErro = "";
        int ultimo_dia_mes = 0;
        if (ano < 1900 || ano > 2100)
            msgErro = "Ano está fora no intervalo 1900-2100";
        else if (mes < 1 || mes > 12)
            msgErro = "Mês está fora no intervalo 1-12";
        else
        {
            // Preenche a variavel ultimo_dia_mes a depender do mês
            if (mes == 2)
                ultimo_dia_mes =
                    (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0)) ? 29 : 28;

            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                ultimo_dia_mes = 30;
            else
                ultimo_dia_mes = 31;

            if (dia < 1 || dia > ultimo_dia_mes)
            {
                msgErro = "Data inválida: dia está fora no intervalo 1-" + to_string(ultimo_dia_mes);
            }
        }

        return msgErro;
    }
    string Data :: alteraData(int _dia, int _mes, int _ano)
    {
        string erro = dataValida(_dia, _mes, _ano);
        if (erro == "")
        {
            dia = _dia;
            mes = _mes;
            ano = _ano;
        }
        return erro;
    }

    string Data :: to_string_zeros(int numero)
    {
        string numero_string = to_string(numero);

        if (numero < 10)
        {
            numero_string = "0" + numero_string;
        }

        return numero_string;
    }

    string Data :: dataParaString(string format)
    {
        string diaStr = to_string_zeros(dia);
        string mesStr = to_string_zeros(mes);
        string anoStr = to_string_zeros(ano);

        // Default
        if (format == "iso")
            return to_string(ano) + "/" + to_string(mes) + "/" + to_string(dia);
        else if (format == "en-us")
            return to_string(mes) + "/" + to_string(dia) + "/" + to_string(ano);
        else
            return to_string(dia) + "/" + to_string(mes) + "/" + to_string(ano);
    }

   string Data :: dataPorExtenso()
    {
        string mesExtenso = "";
        string dataExtenso = "";
        switch (mes)
        {
        case 1:
            mesExtenso = "janeiro";
            break;
        case 2:
            mesExtenso = "fevereiro";
            break;
        case 3:
            mesExtenso = "março";
            break;
        case 4:
            mesExtenso = "abril";
            break;
        case 5:
            mesExtenso = "maio";
            break;
        case 6:
            mesExtenso = "junho";
            break;
        case 7:
            mesExtenso = "julho";
            break;
        case 8:
            mesExtenso = "agosto";
            break;
        case 9:
            mesExtenso = "setembro";
            break;
        case 10:
            mesExtenso = "outubro";
            break;
        case 11:
            mesExtenso = "novembro";
            break;
        case 12:
            mesExtenso = "dezembro";
            break;
        default:
            break;
        }
        dataExtenso = to_string(dia) + " de " + mesExtenso + " de " + to_string(ano);
        return dataExtenso;
    }
    string Data :: getErro(){
        return msgErro;
    }