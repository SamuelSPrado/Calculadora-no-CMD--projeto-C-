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
            IOperacaoMatematica operacao;
            double valor1, valor2;

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Soma(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 2:
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Subtracao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 3:
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Multiplicacao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 4:
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Divisao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 5:
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Potenciacao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 6:
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Radiciacao(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;

                case 7:
                    Console.Write("Digite o valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    operacao = new RaizQuadrada(valor1);
                    ExecutarOpcao(operacao, valor1, 0);
                    break;

                case 8:
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    valor2 = double.Parse(Console.ReadLine());
                    operacao = new Porcentagem(valor1, valor2);
                    ExecutarOpcao(operacao, valor1, valor2);
                    break;
                case 9:
                    Console.Write("Digite o valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    operacao = new ValorAbsoluto(valor1);
                    ExecutarOpcao(operacao, valor1, 0);
                    break;
                case 10:
                    Console.Write("Digite o valor: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o número de casas decimais para arredondar: ");
                    int casasDecimais = int.Parse(Console.ReadLine());
                    operacao = new Arredondamento(valor1, casasDecimais);
                    ExecutarOpcao(operacao, valor1, 0);
                    break;
                case 11:
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
