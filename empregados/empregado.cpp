#include <iostream>
#include <string>
#include <vector>
#include <iomanip>// std::setprecision
#define TRACO "------------------------------------------------------------------------"

using namespace std;

struct Empregado {
    string nome;
    string sobrenome;
    int ano_nascimento;
    string RG;
    int ano_admissao;
    double salario;
};

void Reajusta_dez_porcento(vector<Empregado>& empregados) {
    for (Empregado& e : empregados) {
        e.salario = e.salario + (e.salario * 0.10);
    }
}

int main() {
    vector<Empregado> empregados;

    //Incluindo dados
    empregados.push_back({"Lorena", "Andrade", 1982, "08805314-87", 2022, 10000.00});
    empregados.push_back({"Ademir", "Ferreira", 1983, "017721825-83", 2021, 9500.66});
    empregados.push_back({"Diego", "Ferreira", 1999, "0088025-89", 2023, 2800.99});

    Reajusta_dez_porcento(empregados);

    cout << TRACO << endl;
    cout << "Dados dos empregados após o reajuste:" << endl;
    cout << TRACO << endl;
    for (const Empregado& e : empregados) {
        cout << "Nome: " << e.nome << " " << e.sobrenome << endl;
        cout << "Ano de Nascimento: " << e.ano_nascimento << endl;
        cout << "RG: " << e.RG << endl;
        cout << "Ano de Admissão: " << e.ano_admissao << endl;
        cout << std::fixed;
        cout << "Salário: " << std::setprecision(2) << e.salario << endl;
        cout << TRACO << endl;
    }
    

    return 0;
}
