#include <iostream>
#include <cmath>

using namespace std;

struct Ponto{
    float x;
    float y;
};

float calculaDistancia(Ponto A, Ponto B){
    float Xa = A.x;
    float Xb = B.x;
    
    float Ya = A.y;
    float Yb = B.y;
    cout << "((Xa*Xa) - (Xb*Xb))" << " = " << ((Xa*Xa) - (Xb*Xb)) << endl;

    cout << "((Ya * Ya) - (Yb * Yb))" << " = " << ((Ya * Ya) - (Yb * Yb)) << endl;

    float distancia = sqrt(((Xa*Xa) - (Xb*Xb)) + ((Ya * Ya) - (Yb * Yb)));
    
    
    return distancia;
}
int main(){
    Ponto pontoA, pontoB;

    cout << "Digite as coordenadas do primeiro ponto (x y): ";
    cin >> pontoA.x >> pontoA.y;
    
    cout << "Digite as coordenadas do segundo ponto (x y): ";
    cin >> pontoB.x >> pontoB.y;

    double distancia = calculaDistancia(pontoA, pontoB);

    cout << "A distância entre o ponto A e o ponto B é: " << distancia << endl;
    
    return 0;
}