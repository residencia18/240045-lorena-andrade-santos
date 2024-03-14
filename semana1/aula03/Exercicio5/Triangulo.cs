
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03.Exercicio5
{
    public class Triangulo<T>
    {
        public Ponto<T>  P1 { get; set; }
        public Ponto<T>  P2 { get; set; }
        public Ponto<T>  P3 { get; set; }

        public Triangulo(Ponto<T>  p1, Ponto<T>  p2, Ponto<T>  p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

    }
}