using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Arredondamento : OperacaoMatematica
    {
        public Arredondamento(double x, double d) : base(x, d)
        {
        }

        public override double Calcular(double x, double d)
        {
            return Math.Round(x, (int)d);
        }

        public override string Nome
        {
            get { return "Arredondamento"; }
        }
    }
}
