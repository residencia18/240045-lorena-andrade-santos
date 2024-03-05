using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Application.ViewModel
{
    public class CasoJuridicoViewModel
    {
        
      public int CasoJuridicoId { get; set; }
      public required string Status { get; set; }
      public ClienteViewModel Cliente { get; set; } = null!;
      public AdvogadoViewModel Advogado { get; set; } = null!;
      public List<DocumentoViewModel> Documentos { get; set; } = null!;
    }
}