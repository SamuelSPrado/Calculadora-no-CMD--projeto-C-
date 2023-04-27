using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Radiciacao : OperacaoMatematica
    {
        public Radiciacao(double x, double y) : base(x, y)
        {
        }

        public override double Calcular(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Índice da raiz não pode ser zero.");
            }
            if (x < 0 && y % 2 == 0)
            {
                throw new ArgumentException("Índice da raiz não pode ser par para radicandos negativos.");
            }

            return Math.Pow(x, 1.0 / y);
        }

        public override string Nome
        {
            get { return "Radiciação"; }
        }
    }
}
