using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Porcentagem : OperacaoMatematica
    {
        public Porcentagem(double x, double y) : base(x, y)
        {
        }
        public override double Calcular(double x, double y)
        {
            return (x * y) / 100;
        }

        public override string Nome
        {
            get { return "Porcentagem"; }
        }
    }
}
