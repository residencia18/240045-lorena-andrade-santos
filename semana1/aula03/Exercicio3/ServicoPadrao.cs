using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula03.Exercicio4.Interface;

namespace Aula03.Exercicio4
{
    public class ServicoPadrao : IServico
    {
        public void Executar()
        {
            Console.WriteLine("Executando o serviço padrão.");
        }
    }
}