using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03.Exceptions
{
   
  public class ValorInvalidoException: Exception
    {
        public ValorInvalidoException() :
           base("Valor inválido.")
        {
        }
    }

}