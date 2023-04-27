using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Logaritmo : OperacaoMatematica
    {
        public Logaritmo(double x, double y) : base(x, y)
        {
        }

        public override double Calcular(double x, double y)
        {
            return Math.Log(x, y);
        }

        public override string Nome
        {
            get { return "Logaritmo"; }
        }
    }
}
