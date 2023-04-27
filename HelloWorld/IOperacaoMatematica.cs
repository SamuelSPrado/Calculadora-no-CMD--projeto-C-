using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public interface IOperacaoMatematica
    {
        string Nome { get; }
        double Calcular(double x, double y);
    }
}
