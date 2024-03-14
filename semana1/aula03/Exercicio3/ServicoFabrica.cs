using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula03.Exercicio4.Interface;

namespace Aula03.Exercicio4
{
    public class ServicoFabrica<T> where T: IServico, new()
    {
        public ServicoFabrica(){

         
        }
        public T NovaInstancia() {
            return new T();
        }
        public void Executar()
        {
           Console.WriteLine("Executando o serviço.");
        }
    }
}