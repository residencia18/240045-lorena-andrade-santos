#include <iostream>
#include <string>

using namespace std;
int main(void){
    int numero1;
    int numero2;
    cout<<"Digite dois numeros -> ";

    cout<<"Numero 1: ";
    cin>>numero1;
    cout<<"Numero 2: ";
    cin>>numero2;
    cout<<"----------------------------------"<<"\n";
    cout<<numero1<<" + "<<numero2<<" = "<<numero1 + numero2<<"\n";
    cout<<numero1<<" - "<<numero2<<" = "<<numero1 - numero2<<"\n";
    cout<<numero1<<" * "<<numero2<<" = "<<numero1 * numero2<<"\n";
    cout<<numero1<< "/" <<numero2<<" = "<<numero1 / numero2<<"\n";
    cout<<"Resto da divisao "<<numero1<<"/"<<numero2<<" = "<<numero1 % numero2<<"\n";
    cout<<"----------------------------------"<<"\n";
    return 0;
}
