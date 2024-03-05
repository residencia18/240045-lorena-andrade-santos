using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Core.Entities
{
    public class Cliente:Pessoa
    {
        public int ClienteId { get; set; }
        public ICollection<CasoJuridico>? CasosJuridicos { get; set; }
    }
}