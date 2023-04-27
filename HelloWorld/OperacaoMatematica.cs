using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public abstract class OperacaoMatematica : IOperacaoMatematica
    {
        protected double x;
        protected double y;

        public OperacaoMatematica(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract double Calcular(double x, double y);

        public abstract string Nome { get; }
    }
}
