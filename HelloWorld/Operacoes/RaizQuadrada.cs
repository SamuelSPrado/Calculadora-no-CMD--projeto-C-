using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class RaizQuadrada : OperacaoMatematica
    {
        public RaizQuadrada(double x) : base(x, 2)
        {
        }

        public override double Calcular(double x, double y)
        {
            if (x < 0)
            {
                throw new ArgumentException("Não existe raiz quadrada de número negativo.");
            }

            return Math.Sqrt(x);
        }

        public override string Nome
        {
            get { return "Raiz Quadrada"; }
        }
    }
}
