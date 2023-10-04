#ifndef DATA_H
#define DATA_H

#include <string>
using namespace std;
class Data {
    private:
        int dia;
        int mes;
        int ano;
        string msgErro;
    public:
        Data();
        ~Data();
        Data(int dia, int mes, int ano);
        string dataValida(int dia, int mes, int ano);
        string alteraData(int dia, int mes, int ano);
        string to_string_zeros(int numero);
        string dataParaString(string format = "pt-br");
        string dataPorExtenso();
        string getErro();
};


#endif // DATA_H