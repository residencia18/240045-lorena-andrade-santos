#ifndef DATA_H
#define DATA_H

#include <string>
using namespace std;
struct Data {
    private:
    int dia;
    int mes;
    int ano;

    public:
    Data inicializarData(int dia, int mes, int ano, string &erro);
    bool dataValida(int dia, int mes, int ano, string &erro);
    bool dataValida(Data data);
    void alteraData(Data *data, int dia, int mes, int ano);
    string to_string_zeros(int numero);
    string dataParaString(Data data);
    Data string_to_data(string strData, char op);
};


#endif // DATA_H