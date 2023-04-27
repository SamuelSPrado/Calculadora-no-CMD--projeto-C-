using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace HelloWorld
{
    class Program
    {
        public static void ExecutarOpcao(IOperacaoMatematica operacao, double x, double y)
        {
            double resultado = operacao.Calcular(x, y);
            Console.WriteLine($"Resultado: {resultado}\n");
        }

        static void Main(string[] args)
        {
            Menu.Mostrar();
            int opcao = Menu.ObterOpcao();
            Console.WriteLine("");
            IOperacaoMatematica operacao;
            double valor1, valor2;

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("SOMA");
                    Console.WriteLine("Em matemática, somatório ou somatória é a adição de uma sequência de quaisquer tipos de números, chamados parcelas ou somando; o resultado é sua soma ou total.\n");
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Soma(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 2:
                    Console.WriteLine("SUBTRAÇÃO");
                    Console.WriteLine("Subtração é uma operação matemática que indica quanto é um valor numérico se dele for removido outro valor numérico, em outras palavras, uma quantidade é retirada de outra, e o valor restante é o resultado dessa operação.\n");
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Subtracao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 3:
                    Console.WriteLine("MULTIPLICAÇÃO");
                    Console.WriteLine("Na matemática, a multiplicação é uma forma simples de se adicionar uma quantidade finita de números iguais. O resultado da multiplicação de dois números é chamado produto. Ao lado da adição, da divisão e da subtração, a multiplicação é uma das quatro operações fundamentais da aritmética.\n");
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Multiplicacao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 4:
                    Console.WriteLine("DIVISÃO");
                    Console.WriteLine("Divisão é a operação matemática inversa da multiplicação. O ato de dividir por algum elemento de um conjunto só faz sentido quando a multiplicação por aquele elemento for uma função bijetora. No anel dos números inteiros a hipótese da bijetividade não é satisfeita para o zero, assim, não se define divisão por zero.\n");
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Divisao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 5:
                    Console.WriteLine("POTÊNCIA");
                    Console.WriteLine("Exponenciação ou potenciação é uma operação matemática, escrita como aⁿ, envolvendo dois números: a base a e o expoente n.\n");
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Potenciacao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 6:
                    Console.WriteLine("RADIAÇÃO");
                    Console.WriteLine("A radiciação é uma operação matemática inversa à potenciação, assim como a divisão é o inverso da multiplicação. Para um número real a, a expressão \\sqrt[n]{a} representa o único número real x que verifica {//displaystyle x^{n}=a, } e tem o mesmo sinal que a.\n");
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Radiciacao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 7:
                    Console.WriteLine("RAIZ QUADRADA");
                    Console.WriteLine("Em matemática, a raiz quadrada de x é um número y que, multiplicado por si próprio, iguala-se a x. Todo número real não negativo possui uma única raiz quadrada não negativa, chamada de raiz quadrada principal, a qual é denotada pelo símbolo {displaystyle {sqrt {x}}}.\n");
                    Console.Write("Digite o valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    operacao = new RaizQuadrada(valor1);
                    ExecutarOpcao(operacao, valor1, 0);
                    break;

                case 8:
                    Console.WriteLine("PORCENTAGEM");
                    Console.WriteLine("Porcentagem ou percentagem é uma medida de razão com base 100. É um modo de expressar uma proporção ou uma relação entre 2 valores a partir de uma fração cujo denominador é 100, ou seja, é dividir um número por 100. É muitas vezes denotado utilizando o símbolo de porcentagem %.\n");
                    Console.Write("Digite o primeiro valor: (%)");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("% de: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Porcentagem(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 9:
                    Console.WriteLine("FUNÇÃO MODULAR");
                    Console.WriteLine("O módulo ou valor absoluto de um número real a é o seu valor numérico absoluto, ou seja, desconsiderando-se seu sinal. Está associado à ideia de distância de um ponto até sua origem, ou seja, a sua magnitude.\n");
                    Console.Write("Digite o valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    operacao = new ValorAbsoluto(valor1);
                    ExecutarOpcao(operacao, valor1, 0);
                    break;

                case 10:
                    Console.WriteLine("ARREDONDAMENTO");
                    Console.WriteLine("Arredondamento é o processo mediante o qual se eliminam algarismos de menor significância a um número real.\n");
                    Console.Write("Digite o valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o número de casas decimais para arredondar: ");
                    int casasDecimais = int.Parse(Console.ReadLine());
                    operacao = new Arredondamento(valor1, casasDecimais);
                    ExecutarOpcao(operacao, valor1, 0);
                    break;

                case 11:
                    Console.WriteLine("LOGARÍTMO");
                    Console.WriteLine("Na matemática, o logaritmo de um número é o expoente a que outro valor fixo, a base, deve ser elevado para produzir este número. Por exemplo, o logaritmo de 1 000 na base 10 é 3 porque 10 elevado ao cubo é 1 000.\n");
                    Console.Write("Digite a base: ");
                    double baseLog = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor: ");
                    double valorLog = double.Parse(Console.ReadLine());
                    operacao = new Logaritmo(baseLog, valorLog);
                    ExecutarOpcao(operacao, baseLog, valorLog);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
