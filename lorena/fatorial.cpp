#include <iostream>
using namespace std;
int calculaFatorial(int n);

int main(){
    cout << "Fatorial de 5: " << calculaFatorial(5) << endl;
    cout << "Fatorial de 10: " << calculaFatorial(10) << endl;
    cout << "Fatorial de 12: " << calculaFatorial(12) << endl;
    
    return 0;
}

int calculaFatorial(int n){
    if (n == 0 || n ==1){
        return 1;
    } else{
        int resultado = 1;
        for (int i = n; i >= 2; i--)
        {
           resultado = resultado * i;
        }
        return resultado;
    }
}