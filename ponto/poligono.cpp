#include <iostream>
#include <vector>
#include <math.h>
using namespace std;
    class Ponto
    {
    private:
        float x, y;

    public:
        Ponto();
        Ponto(float _x, float _y);
    
        float getX();
        float getY();
        void setX(float _x);
        void setY(float _y);
    };
    Ponto :: Ponto()
    {
        x = 0;
        y = 0;
    };
    Ponto :: Ponto(float _x, float _y)
    {
        x = _x;
        y = _y;
    };
    float Ponto :: getX()
    {
        return x;
    };
    float Ponto :: getY()
    {
        return y;
    };
    void Ponto :: setX(float _x)
    {
        x = _x;
    };
    void Ponto :: setY(float _y)
    {
        y = _y;
    };

    class Poligono
    {
        private:
        vector<Ponto> pontos;

        public:
        
    };
    int main()
    {
        Poligono poli;
        cout << "Criando um poligono!" << endl;
        char sn;
        do
        {
            cout << "Digite as coordenadas do ponto:" << endl;
            Ponto p;
            float _x, _y;
            cin >> _x >> _y;
            p.setX(_x);
            p.setY(_y);
            poli.pontos.push_back(p);

            cout << "Deseja inserir mais pontos? (s/n)";
            cin >> sn;

        } while (sn != 'n');

        cout << "As coordenadas digitadas foram" << endl;
        for (Ponto p : poli.pontos)
            cout << "(" << p.getX() << " , " << p.getY() << ")" << endl;
        return 0;
    }