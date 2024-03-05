#include <iostream>
#include "data.h"
#include "hora.h"
#include <sstream>

using namespace std;

int main(){
    Data data;
    string dataStr;
    string msgErro;
    cout << "Digite uma data no formato dd/mm/aaaa. Pode ser com qualquer separador: ";
    cin >> dataStr;

    int dia=0, mes=0, ano=0;
    char barra;
    
    stringstream ss(dataStr);
    ss >> dia >> barra >> mes >> barra >> ano;
    
    if (dia >0 && mes > 0 && ano > 0){
        data = Data(dia, mes, ano);
        if (data.getErro() != "")
            cout << data.getErro() << endl;
        else{

            cout << endl << endl;
            cout << "Objeto Data criado com sucesso: " << endl;
            cout << "Data por extenso: " << data.dataPorExtenso() << endl;
            cout << "Data no formato aaaa/mm/dd: " << data.dataParaString("iso") << endl;
            cout << "Data no formato mm/aaaa/dd: " << data.dataParaString("en-us") << endl;
            cout << "Data no formato dd/mm/aaaa: " << data.dataParaString() << endl;
            cout << endl;
        }
        
        Hora hora;
        string horaStr;
        string hStr, mStr;
        int horaInt = 0, minuto = 0;
        cout << "Digite uma hora no formato hh:mm" << endl;
        cin >> horaStr;

        stringstream ss(horaStr);
        getline(ss, hStr, ':');
        getline(ss, mStr, ':');
        
        horaInt = stoi(hStr);
        minuto = stoi(mStr);

        if (horaInt >0 && minuto > 0){
            hora = Hora(horaInt, minuto);
            if (hora.getErroH() != "")
                cout << hora.getErroH() << endl;
            else{

                cout << endl << endl;
                cout << "Objeto Hora criado com sucesso: " << endl;
                cout << "Hora: " << hora.horaParaString() << endl;
                cout << endl;
            }
        }
    }
    else{
        cout <<"Data no formato inválido" << endl;
    }
    return 0;
}
