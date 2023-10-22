#ifndef CTRL_H
#define CTRL_H

#include "pacoteTurismo.h"

class ctrl_pacote
{
    public:
        static Evento criarEvento();
        static PacoteTurismo criarPacoteTurismo(std::vector<Evento>& eventos);
        static Cliente criarCliente();
        static void venderPacote(Cliente& cliente, PacoteTurismo pacote);
    
};
#endif