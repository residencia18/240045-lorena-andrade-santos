
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pessoa
    {
        public Pessoa(string name, string document, DateTime birthDate)
        {
            Id = ++CodID;
            Nome = name;
            Documento = document;
            DtNascimento = birthDate;
        }
        private static int CodID { get; set; } = 2023000;
        public int Id { get; }
        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public DateTime DtNascimento { get; private set; }
    }
}