using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Core.Entities
{
    public class CasoJuridico: BaseEntity
    {
        public int CasoJuridicoId { get; set; }
        public required string Status { get; set; }
        public ICollection<Documento>? Documentos { get; set; }
        public Advogado? Advogado { get; set; } 
        public int AdvogadoId { get; set; }
        public Cliente? Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}