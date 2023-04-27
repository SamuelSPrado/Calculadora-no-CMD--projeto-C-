using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Divisao : OperacaoMatematica
    {
        public Divisao(double x, double y) : base(x, y)
        {
        }

        public override double Calcular(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Divisão por zero.");
            }

            return x / y;
        }

        public override string Nome
        {
            get { return "Divisão"; }
        }
    }
}
