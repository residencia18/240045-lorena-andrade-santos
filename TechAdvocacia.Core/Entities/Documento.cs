using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Core.Entities
{
    public class Documento: BaseEntity
    {
        public int DocumentoId { get; set; }
        public DateTime Modificacao { get; set; }
        public string? Tipo { get; set; }
        public required string Descricao { get; set; }

        public CasoJuridico? CasoJuridicos { get; set; }
        public int CasoJuridicoId { get; set; }

    }
}