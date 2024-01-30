using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Core.Entities
{
    public class Advogado : Pessoa
    {
        public int AdvogadoId { get; set; }
        public string? CNA { get; set; }
        public int CasoJuridicoId { get; set; }
        public CasoJuridico? CasoJuridico { get; set; }
    }
}