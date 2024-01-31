using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Core.Exceptions
{
    public class ClienteNotFoundException: Exception
{
   public ClienteNotFoundException() :
      base("Cliente não encontrado.")
   {
   }
}
}