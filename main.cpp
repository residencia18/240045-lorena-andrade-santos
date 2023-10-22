/*
2. Cadastramento de eventos.
3. Acrescente a funcionalidade de criar pacotes (acrescentando neles
alguns dos eventos já definidos antes
4. Acrescente a funcionalidade de criar clientes com seus dependentes
5. Acrescente a funcionalidade de vender pacotes a clientes.
6. Permita que se consulte a lista de clientes (com dependentes),
7. Permita que se consulte a lista de pacotes (com eventos)
8. Permita que se consulte os pacotes contratados por algum cliente específico
9. Permita que se consulte os clientes que contrataram algum pacote específico.
*/

//#include "BD.h"
#include "pacoteTurismo.h"
#include "interface.h"
#include "ctrl_pacote.h"

using namespace std;

int main(void)
{
  
    vector<Evento> eventos;
    vector<Cliente> clientes;
  
    int   opcao;
    
    vector<string> menu = {"1. Cadastrar evento", 
                           "2. Criar pacote de turismo",
                           "3. Criar cliente",
                           "4. Vender pacote a cliente",
                           "5. Listar clientes (com dependentes)",
                           "6. Listar pacotes (com eventos)",
                           "7. Consultar pacotes contratados por cliente",
                           "8. Consultar clientes que contrataram um pacote",
                           "9. Sair"};

    while(true)
    {
        monta_menu(menu, "Escolha uma opcao: \n");
        opcao = obter_opcao(7);
        switch (opcao)
        {
        //     case 1: 
        //         ctrl_pacote::criarEvento(
        //         break;
        //     case 2: 
        //         ctrl_pacote::criarPacoteTurismo(
        //          break;
        //    case 3:
        //         ctrl_pacote::criarCliente(
        //         break;
        //     case 4: 
        //         ctrl_pacote::venderPacote(
        //         break;
            
        //     case 5: 
        //         ctrl_pacote::listarClientes();
        //         break;
        //     case 6: 
        //         ctrl_pacote::listarPacotes();
        //         break;
        //     case 7: 
        //         ctrl_pacote::listarPacotesPorCliente();
        //         break;
        //     case 8: 
        //         ctrl_pacote::listarClientePorPacote();
        //         break;
                    
        //     case 9: exit(0);
        }
    }
    return 0;
}