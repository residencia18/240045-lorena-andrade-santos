using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04.Exercicio2
{
    public class ItemMercado
    {
        public required string Nome { get; set; }
        public string? Tipo { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return $"{Nome}, {Tipo}, {Preco}";
        }
    }
}