using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Core.Entities
{
    public class Cliente:Pessoa
    {
        public int ClienteId { get; set; }
        public int CasoJuridicoId { get; set; }
        public CasoJuridico? CasoJuridico { get; set; }

    }
}