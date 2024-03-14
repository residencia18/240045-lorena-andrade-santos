using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03.Exceptions
{
    public class SaldoInsuficienteException: Exception
    {
        public SaldoInsuficienteException() :
           base("Saldo insuficiente."){}
    }
}