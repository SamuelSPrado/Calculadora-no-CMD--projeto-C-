using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class ValorAbsoluto : OperacaoMatematica
    {
        public ValorAbsoluto(double x) : base(x, 0)
        {
        }

        public override double Calcular(double x, double y)
        {
            return Math.Abs(x);
        }

        public override string Nome
        {
            get { return "Valor Absoluto"; }
        }
    }
}