using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Application.ViewModel
{
    public class DocumentoViewModel
    {
        public int DocumentoId { get; set; }
        public DateTime Modificacao { get; set; }
        public string? Tipo { get; set; }
        public required string Descricao { get; set; }
    }
}