#include <iostream>
#include <math.h>
#define TRACO "-------------------------------------"

using namespace std;

struct Calculadora
{
    float operando1;
    float operando2;
    char operacao;
};

float soma(Calculadora& calc);
float subtracao(Calculadora& calc);
float multiplicacao(Calculadora& calc);
float divisao(Calculadora& calc);

int main()
{

    Calculadora calc;

    cout << "========== CALCULADORA ==========" << endl;
    cout << endl;

    cout << "Insira o primeiro operador: ";
    cin >> calc.operando1;

    cout << "Insira o segundo operador: ";
    cin >> calc.operando2;
    cout << endl;
    cout << TRACO << endl;
    cout << "Qual operação deseja realizar:" << endl;
    cout << TRACO << endl;
    cout << "Soma [+]" << endl;
    cout << "Subtração [-]" << endl;
    cout << "Multiplicação [*]" << endl;
    cout << "Divisão [/]" << endl;
    cout << "Sair do programa [0]" << endl;
    cout << TRACO << endl;
    cout << "Insira o operador correspondente: ";
    cin >> calc.operacao;

    switch (calc.operacao)
    {
    case '+':
        cout << "Resultado: " << soma(calc) << endl;
        break;

    // case '-':
    //     subtracao(calc);
    //     break;

    // case '*':
    //     multiplicacao(calc);
    //     break;

    // case '/':
    //     divisao(calc);
    //     break;

    case '0':
        cout << "Programa finalizado.";
        return 0;

    default:
        cout << "Opção inválida.";
        break;
    }

    return 0;
}

// Função soma
float soma(Calculadora& calc)
{    
return calc.operando1 + calc.operando2;
}