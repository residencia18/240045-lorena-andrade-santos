#include <iostream>
#include <string>
#include "data.h"
using namespace std;

struct Data {
    private:
    int dia;
    int mes;
    int ano;

    public:
    Data inicializarData(int dia, int mes, int ano, string &erro){
        Data data;
        if(dataValida(dia, mes, ano, erro)){
            data.dia = dia;
            data.mes = mes;
            data.ano = ano;
            erro = "";
        }else{
            data.dia = 1;
            data.mes = 1;
            data.ano = 1900;
            erro = erro;
        }
        return data;
    }

    bool dataValida (int dia, int mes, int ano, string &erro) {
        erro = "";
        if (ano < 1900 || ano > 2100) { 
            erro = "Ano está fora no intervalo 1900-2100";
            return false; 
        }
        if (mes < 1 || mes > 12) { 
            erro = "Mês está fora no intervalo 1-12";
            return false; 
        }
        int dias_no_mes = 0;
        if (mes == 2) {
            dias_no_mes = 
            (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0)) ? 29 : 28;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) {
            dias_no_mes = 30;
        }
        else {
            dias_no_mes = 31;
        }
        if (dia < 1 || dia > dias_no_mes) { 
            erro = "Dia do mês está fora no intervalo";
            return false; 
        }

        return true;
    }

    bool dataValida(struct Data data) {
        string erro;
        return dataValida(data.dia, data.mes, data.ano, erro);
    }

    string alteraData(struct Data *data, int dia, int mes, int ano) {
        string erro = "";
        if(dataValida(dia, mes, ano, erro)) {
            data->dia = dia;
            data->mes = mes;
            data->ano = ano;
        }
        return erro;
    }

    string to_string_zeros(int numero) {
        string numero_string = to_string(numero);

        if (numero < 10){
            numero_string = "0" + numero_string;
        }

        return numero_string;
    }

    string dataParaString(struct Data data, string format = "pt-br")
    {
        string dia = to_string_zeros(data.dia);
        string mes = to_string_zeros(data.mes);
        string ano = to_string_zeros(data.ano);

        //Default
        if (format=="iso")
            return ano+"/"+mes+"/"+dia;
        else if (format=="en-us")
            return mes+"/"+dia+"/"+ano;
        else
            return dia+"/"+mes+"/"+ano;
        
    }

    Data string_to_data(string strData, string &erro)
    {
        int dia = stoi(strData.substr(0, 2));
        int mes = stoi(strData.substr(3, 2));
        int ano = stoi(strData.substr(6, 4));
        
        Data data = inicializarData(dia, mes, ano, erro);
        return data;
    }   
};