using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Core.Entities
{
    public class Pessoa : BaseEntity
    {
         public required string Nome { get; set; }
         public string? CPF { get; set; }
        public DateTime DtNascimento;
    }
}