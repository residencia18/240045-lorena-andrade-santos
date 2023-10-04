#include <iostream>
using namespace std;

double converterCelsiusParaFahrenheit(double celsius);
void solicitaTemperatura();

int main(){
   
    solicitaTemperatura();

    return 0;
}
double converterCelsiusParaFahrenheit(double celsius){
   double fahren;
   fahren = (celsius * 1.8) + 32;
   return fahren;
}
void solicitaTemperatura(){
    double tempCelsius;
    cout << "Digite a temperatura em Celsius para convertê-la em Fahrenheit:" << endl;
    cin >> tempCelsius;

    double tempFahrenheit = converterCelsiusParaFahrenheit(tempCelsius);

    cout << "A temperatura " << tempCelsius << "°C em Fahrenheit é : " << tempFahrenheit << "°F"<< endl;
}


