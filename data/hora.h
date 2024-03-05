#ifndef HORA_H
#define HORA_H

#include <string>
using namespace std;
class Hora {
    private:
        int hora;
        int minuto;
        string msgErro;
    public:
        Hora();
        ~Hora();
        Hora(int hora, int minuto);
        string horaValida(int hora, int minuto);
        string alteraHora(int hora, int minuto);
        string to_string_zerosH(int numero);
        string horaParaString();
        string getErroH();
};
#endif // HORA_H