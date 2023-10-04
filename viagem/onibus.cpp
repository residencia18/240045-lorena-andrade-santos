#include <iostream>
#include <string>
#include <vector>
#include <iomanip>
#include <sstream>
#include "data.h"
#define PRECO 80
#define TRACO "------------------------------------------------------------------------"

using namespace std;
struct assento
{
    int numeroAssento;
    string nome;
    string cpf;
    int idade;
};
struct viagem
{
    string cidadeOrigem;
    string cidadeDestino;
    // dataS dataSaida;
    Data dataSaida;
    int hora = 0;
    // verifica se poltrona esta disponivel 0 ou 1
    int numero[40];
    vector<assento> passageiro;
};
int verificaSeViagemExiste(vector<viagem> onibus, string Origem, string Destino, Data dataSaida, int hora);
int inicializaViagem(vector<viagem> &onibus, string Origem, string Destino, Data dataSaida, int hora);
void venderPassagem(vector<viagem> &onibus);
void mostrarOnibus(vector<viagem> &onibus);
void totalArrecadadoViagem(vector<viagem> onibus);
void totalArrecadadoMes(vector<viagem> onibus);
void nomePassageiroPoltrona(vector<viagem> onibus);
void horarioMaisRentavel(vector<viagem> onibus);
void mediaIdadePassageirosDeUmaDeterminadaViagem(vector<viagem> &onibus);
void mediaIdadePassageiros(vector<viagem> &onibus);

int main()
{
    vector<viagem> onibus;

    int opcao;
    bool sair = false;
    do
    {
        cout << TRACO << endl;
        cout << "Menu" << endl;
        cout << TRACO << endl;
        cout << "Opcao 1: Vender passagem" << endl;
        cout << "Opcao 2: Total Arrecadado para uma determinada viagem" << endl;
        cout << "Opcao 3: Total Arrecadado para uma determinado mẽs" << endl;
        cout << "Opcao 4: Nome do passageiro de uma determinada poltrona P de uma determinada viagem" << endl;
        cout << "Opcao 5: Horário de viagem mais rentavel" << endl;
        cout << "Opcao 6: Media de idade dos passageiros" << endl;
        cout << "Opcao 0: Sair" << endl;
        cout << TRACO << endl;

        cin >> opcao;
        switch (opcao)
        {
        case (1):
            venderPassagem(onibus);
            mostrarOnibus(onibus);
            break;
        case (2):
            totalArrecadadoViagem(onibus);

            break;
        case (3):
            /*Total Arrecadado para uma determinado mẽs*/
            totalArrecadadoMes(onibus);
            break;
        case (4):
            /* Nome do passageiro de uma determinada poltrona P de uma determinada viagem */
            nomePassageiroPoltrona(onibus);
            break;

        case (5):
            /* Nome do passageiro de uma determinada poltrona P de uma determinada viagem */
            horarioMaisRentavel(onibus);
            break;

        case (6):
            /* Media de idade dos passageiros */
            mediaIdadePassageiros(onibus);
            break;
        case (0):
            sair = true;
            break;
        default:
            cout << "Opção invalida. Tente novamente." << endl;
            break;
        }
    } while (!sair);

    return 0;
}


int verificaSeViagemExiste(vector<viagem> onibus, string Origem, string Destino, Data dataSaida, int hora){
    int indice = -1;

    for (int i = 0; i < onibus.size(); i++)
    {
        if (onibus[i].cidadeOrigem.compare(Origem) == 0 &&
            onibus[i].cidadeDestino.compare(Destino) == 0 &&
            onibus[i].dataSaida.dataParaString().compare(dataSaida.dataParaString()) == 0 &&
            onibus[i].hora == hora)
            indice = i;
    }
    cout << "indice: " << indice << endl;
    return indice;
}

int inicializaViagem(vector<viagem> &onibus, string Origem, string Destino, Data dataSaida, int hora){
    viagem viagemAtual;
    viagemAtual.cidadeOrigem = Origem;
    viagemAtual.cidadeDestino = Destino;
    viagemAtual.dataSaida = dataSaida;
    viagemAtual.hora = hora;
    viagemAtual.passageiro = {};
    for (int i = 0; i < 40; i++)
    {
        viagemAtual.numero[i] = 0;
    }

    onibus.push_back(viagemAtual);

    return (onibus.size() - 1);
}

void venderPassagem(vector<viagem> &onibus){
    char rota;
    int hora;
    string origemStr, destinoStr, dataSaida;
    Data dt;
    int dia = 0, mes = 0, ano = 0;
    char barra;
    bool dataValida = false;
    cout << "Digite a cidade qual a rota: Rio para São Paulo=R ou São Paulo para o Rio=S" << endl;
    cin >> rota;

    if (rota == 'r' || rota == 'R')
    {
        origemStr = "Rio";
        destinoStr = "Sao Paulo";
    }
    else
    {
        origemStr = "Sao Paulo";
        destinoStr = "Rio";
    }
    do
    {
        cout << "Digite a data de saída (DD/MM/AAAA): ";
        cin >> dataSaida;

        stringstream ss(dataSaida);
        ss >> dia >> barra >> mes >> barra >> ano;

        if (dia > 0 && mes > 0 && ano > 0)
        {
            dt = Data(dia, mes, ano);
            if (dt.getErro() != "")
            {
                dataValida = false;
                cout << dt.getErro() << endl;
            }
            else
            {
                dataValida = true;
            }
        }
    } while (dataValida == false);
    do
    {
        cout << "Digite a hora de saída 1-5: ";
        cin >> hora;
    } while (hora < 1 || hora > 5);

    if (rota == 'r' || rota == 'R')
    {
        origemStr = "Rio";
        destinoStr = "Sao Paulo";
    }
    else
    {
        origemStr = "Sao Paulo";
        destinoStr = "Rio";
    }
    int indiceOnibusAtual = verificaSeViagemExiste(onibus, origemStr, destinoStr, dt, hora);
    if (indiceOnibusAtual == -1)
        indiceOnibusAtual = inicializaViagem(onibus, origemStr, destinoStr, dt, hora);

    int nAssento;
    int quantidadeAssentosVazios = 0;

    cout << "indiceOnibusAtual: " << indiceOnibusAtual << endl;
    for (int i = 0; i < 40; i++)
    {
        if (onibus[indiceOnibusAtual].numero[i] == 0)
        {
            quantidadeAssentosVazios++;
        }
    }
    cout << quantidadeAssentosVazios << endl;
    if (quantidadeAssentosVazios > 0)
    {
        do
        {
            cout << "Digite o número do assento disponíveis: " << endl;
            for (int i = 0; i < 40; i++)
                if (onibus[indiceOnibusAtual].numero[i] == 0)
                    cout << (i + 1) << " ";

            cout << endl;

            cin >> nAssento;
            if (nAssento < 1 || nAssento > 40)
            {
                cout << "Número de assento inválido. Deve estar entre 1 e 40." << endl;
            }

            if (onibus[indiceOnibusAtual].numero[nAssento - 1] != 0)
            {
                cout << "Assento já ocupado. Por favor, escolha outro assento." << endl;
            }
        } while ((nAssento < 1 || nAssento > 40) || (onibus[indiceOnibusAtual].numero[nAssento - 1] != 0));

        assento novoPassageiro;
        cout << "Digite o nome do passageiro: ";
        cin >> novoPassageiro.nome;
        cout << "Digite o CPF do passageiro: ";
        cin >> novoPassageiro.cpf;
        cout << "Digite a idade do passageiro: ";
        cin >> novoPassageiro.idade;
        novoPassageiro.numeroAssento = nAssento;

        cout << "indiceOnibusAtual: " << indiceOnibusAtual << " " << nAssento << "!" << endl;

        onibus[indiceOnibusAtual].numero[nAssento - 1] = 1;
        onibus[indiceOnibusAtual].passageiro.push_back(novoPassageiro);

        cout << "Passagem vendida com sucesso para o assento " << nAssento << "!" << endl;
    }
    else
    {
        cout << "Onibus cheio!" << endl;
    }
}

void mostrarOnibus(vector<viagem> &onibus){
    cout << "Lista de ônibus cadastrados com os passageiros:" << endl;
    string dataStr;
    for (int i = 0; i < onibus.size(); i++)
    {
        dataStr = onibus[i].dataSaida.dataParaString();
        cout << "Viagem de " << onibus[i].cidadeOrigem
             << " para " << onibus[i].cidadeDestino
             << " no dia: " << dataStr
             << " na hora: " << onibus[i].hora << ":" << endl;

        for (int j = 0; j < onibus[i].passageiro.size(); j++)
        {
            cout << "Assento " << onibus[i].passageiro[j].numeroAssento << ": " << onibus[i].passageiro[j].nome << " (CPF: " << onibus[i].passageiro[j].cpf << ")" << endl;
        }

        cout << endl;
    }
}

void totalArrecadadoViagem(vector<viagem> onibus){
    char rota;
    int hora;
    string origemStr, destinoStr, dataSaida;
    Data dt;
    int dia = 0, mes = 0, ano = 0;
    char barra;
    bool dataValida = false;
    cout << "Digite a cidade qual a rota: Rio para São Paulo=R ou São Paulo para o Rio=S" << endl;
    cin >> rota;

    if (rota == 'r' || rota == 'R')
    {
        origemStr = "Rio";
        destinoStr = "Sao Paulo";
    }
    else
    {
        origemStr = "Sao Paulo";
        destinoStr = "Rio";
    }

    do
    {
        cout << "Digite a data de saída (DD/MM/AAAA): ";
        cin >> dataSaida;

        stringstream ss(dataSaida);
        ss >> dia >> barra >> mes >> barra >> ano;

        if (dia > 0 && mes > 0 && ano > 0)
        {
            dt = Data(dia, mes, ano);
            if (dt.getErro() != "")
            {
                dataValida = false;
                cout << dt.getErro() << endl;
            }
            else
            {
                dataValida = true;
            }
        }
    } while (dataValida == false);
    do
    {
        cout << "Digite a hora de saída 1-5: ";
        cin >> hora;
    } while (hora < 1 || hora > 5);

    int indiceOnibusAtual = verificaSeViagemExiste(onibus, origemStr, destinoStr, dt, hora);
    if (indiceOnibusAtual >= 0)
    {
        double totalViagem = static_cast<double>(PRECO) * onibus[indiceOnibusAtual].passageiro.size();
        if (totalViagem > 0)
        {
            cout << TRACO << endl;
            cout << "O total arrecadado na viagem foi: " << totalViagem << endl;
            cout << TRACO << endl;
        }
    }
}

void totalArrecadadoMes(vector<viagem> onibus){
    int mes;
    cout << "Digite o mês" << endl;
    cin >> mes;
    double totalViagem = 0;
    string data;
    int dia = 0, mesViagem = 0, ano = 0;
    char barra;
    for (int i = 0; i < onibus.size(); i++)
    {
        data = onibus[i].dataSaida.dataParaString();
        stringstream ss(data);
        ss >> dia >> barra >> mesViagem >> barra >> ano;
        if (mesViagem == mes)
        {
            totalViagem += static_cast<double>(PRECO) * onibus[i].passageiro.size();
        }
    }
    if (totalViagem > 0)
    {
        cout << TRACO << endl;
        cout << "O total arrecadado no mês " << mes << " foi: " << totalViagem << endl;
        cout << TRACO << endl;
    }
}

void nomePassageiroPoltrona(vector<viagem> onibus){
    int hora, poltrona;
    char rota;
    string origemStr, destinoStr, dataSaida;
    Data dt;
    int dia = 0, mes = 0, ano = 0;
    char barra;
    bool dataValida = false;
    cout << "Digite a cidade qual a rota: Rio para São Paulo=R ou São Paulo para o Rio=S" << endl;
    cin >> rota;

    if (rota == 'r' || rota == 'R')
    {
        origemStr = "Rio";
        destinoStr = "Sao Paulo";
    }
    else
    {
        origemStr = "Sao Paulo";
        destinoStr = "Rio";
    }

    do
    {
        cout << "Digite a data de saída (DD/MM/AAAA): ";
        cin >> dataSaida;

        stringstream ss(dataSaida);
        ss >> dia >> barra >> mes >> barra >> ano;

        if (dia > 0 && mes > 0 && ano > 0)
        {
            dt = Data(dia, mes, ano);
            if (dt.getErro() != "")
            {
                dataValida = false;
                cout << dt.getErro() << endl;
            }
            else
            {
                dataValida = true;
            }
        }
    } while (dataValida == false);
    do
    {
        cout << "Digite a hora de saída 1-5: ";
        cin >> hora;
    } while (hora < 1 || hora > 5);

    if (rota == 'r' || rota == 'R')
    {
        origemStr = "Rio";
        destinoStr = "Sao Paulo";
    }
    else
    {
        origemStr = "Sao Paulo";
        destinoStr = "Rio";
    }
    int indiceOnibusAtual = verificaSeViagemExiste(onibus, origemStr, destinoStr, dt, hora);

    if (indiceOnibusAtual >= 0)
    {
        cout << "Digite o número da poltrona (1-40): ";
        cin >> poltrona;

        if (poltrona >= 1 && poltrona <= 40 && onibus[indiceOnibusAtual].numero[poltrona - 1] == 1)
        {
            string nomePassageiro;
            for (const auto &passageiro : onibus[indiceOnibusAtual].passageiro)
            {
                if (passageiro.numeroAssento == poltrona)
                {
                    nomePassageiro = passageiro.nome;
                    break;
                }
            }
            
            cout << TRACO << endl;
            cout << "O passageiro da poltrona " << poltrona << " se chama: " << nomePassageiro << endl;
            cout << TRACO << endl;
        }
        else
        {
            cout << TRACO << endl;
            cout << "Poltrona não ocupada nesta viagem." << endl;
            cout << TRACO << endl;
        }
    }
    else
    {
        cout << "Viagem não encontrada." << endl;
    }
}

void horarioMaisRentavel(vector<viagem> onibus){
    char rota;
    string origemStr, destinoStr, dataSaida;

    cout << "Digite a cidade da rota: Rio para São Paulo (R) ou São Paulo para o Rio (S): ";
    cin >> rota;

    if (rota == 'r' || rota == 'R')
    {
        origemStr = "Rio";
        destinoStr = "Sao Paulo";
    }
    else
    {
        origemStr = "Sao Paulo";
        destinoStr = "Rio";
    }

    double maiorFaturamento = 0;
    int horarioMaisRentavel = 0;
    Data dtMaisRentavel;
    for (int i = 0; i < onibus.size(); i++)
    {
        if (onibus[i].cidadeOrigem.compare(origemStr) == 0 &&
            onibus[i].cidadeDestino.compare(destinoStr) == 0)
        {

            double faturamentoViagem = static_cast<double>(PRECO) * onibus[i].passageiro.size();

            if (faturamentoViagem > maiorFaturamento)
            {
                maiorFaturamento = faturamentoViagem;
                horarioMaisRentavel = onibus[i].hora;
                dtMaisRentavel = onibus[i].dataSaida;
            }
        }
    }

    if (maiorFaturamento > 0)
    {
        cout << TRACO << endl;
        cout << "O horário mais rentável é o horário " << horarioMaisRentavel << " do dia " << dtMaisRentavel.dataParaString() << " com faturamento de " << maiorFaturamento << " reais." << endl;
        cout << TRACO << endl;
    }
    else
    {
        cout << "Nenhuma viagem encontrada para essa rota." << endl;
    }
}

void mediaIdadePassageirosDeUmaDeterminadaViagem(vector<viagem> &onibus){
    char rota;
    int hora;
    string origemStr, destinoStr, dataSaida;
    Data dt;
    int dia = 0, mes = 0, ano = 0;
    char barra;
    bool dataValida = false;
    cout << "Digite a cidade qual a rota: Rio para São Paulo=R ou São Paulo para o Rio=S" << endl;
    cin >> rota;

    if (rota == 'r' || rota == 'R')
    {
        origemStr = "Rio";
        destinoStr = "Sao Paulo";
    }
    else
    {
        origemStr = "Sao Paulo";
        destinoStr = "Rio";
    }
    do
    {
        cout << "Digite a data de saída (DD/MM/AAAA): ";
        cin >> dataSaida;

        stringstream ss(dataSaida);
        ss >> dia >> barra >> mes >> barra >> ano;

        if (dia > 0 && mes > 0 && ano > 0)
        {
            dt = Data(dia, mes, ano);
            if (dt.getErro() != "")
            {
                dataValida = false;
                cout << dt.getErro() << endl;
            }
            else
            {
                dataValida = true;
            }
        }
    } while (dataValida == false);
    do
    {
        cout << "Digite a hora de saída 1-5: ";
        cin >> hora;
    } while (hora < 1 || hora > 5);

    if (rota == 'r' || rota == 'R')
    {
        origemStr = "Rio";
        destinoStr = "Sao Paulo";
    }
    else
    {
        origemStr = "Sao Paulo";
        destinoStr = "Rio";
    }
    int indiceOnibusAtual = verificaSeViagemExiste(onibus, origemStr, destinoStr, dt, hora);

    if (indiceOnibusAtual >= 0)
    {
        int totalIdades = 0;
        int numPassageiros = onibus[indiceOnibusAtual].passageiro.size();

        for (const auto &passageiro : onibus[indiceOnibusAtual].passageiro)
        {
            totalIdades += passageiro.idade;
        }

        if (numPassageiros > 0)
        {
            double mediaIdade = static_cast<double>(totalIdades) / numPassageiros;
            
            cout << TRACO << endl;
            cout << "A média de idade dos passageiros é: " << fixed << setprecision(2) << mediaIdade << " anos." << endl;
            cout << TRACO << endl;
        }
        else
        {
            cout << TRACO << endl;
            cout << "Nenhum passageiro registrado nesta viagem." << endl;
            cout << TRACO << endl;
        }
    }
    else
    {
        cout << "Viagem não encontrada." << endl;
    }
}

void mediaIdadePassageiros(vector<viagem> &onibus){
    int totalIdades = 0;
    int numPassageiros = 0;
    for (int i = 0; i < onibus.size(); i++)
    {
        for (const auto &passageiro : onibus[i].passageiro)
        {
            numPassageiros++;
            totalIdades += passageiro.idade;
        }
    }

    if (numPassageiros > 0)
    {
        double mediaIdade = static_cast<double>(totalIdades) / numPassageiros;
        
        cout << TRACO << endl;
        cout << "A média de idade dos passageiros é: " << fixed << setprecision(2) << mediaIdade << " anos." << endl;
        cout << TRACO << endl;
    }
    else
    {
        cout << "Não existe passageiro registrado em nenhuma viagem." << endl;
    }
}
