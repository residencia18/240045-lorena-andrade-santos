using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMed.Aplication.InputModel
{
    public class NewAtendimentoInputModel
    {
      public DateTime DataHora { get; set; }
      public int PacienteId { get; set; }
      public int MedicoId { get; set; }
    }
}