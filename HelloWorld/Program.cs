using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, RaizQ, Sair }
        //Enumerador (criando menu com as opções);

        static void Main(string[] args) //Função principal
        {
            bool escolherSair = false;
            while (!escolherSair) //(loopin)"Enquanto" o usuário não (! - negação) escolher SAIR, exiba o menu.
            {
            //Exiba o menu na tela
            Console.WriteLine("PRIMEIRA CALCULADORA EM C#:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Escolha uma opção para começar seus calculos:");
            Console.WriteLine();
            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz Quadrada\n7-Sair");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
            Menu opcao = (Menu)int.Parse(Console.ReadLine());
            //Menu (enum) , opcao (variável), RECEBE (Menu)convertido de string para número inteiro.
            
            //Usamos o switch para fazer com que a opção digitada no Menu execute dentro da função escolhida.
            switch (opcao)
                {
                    case Menu.Soma: //Caso escolha a opção Soma do Menu (enum)
                        Soma(); // Executa a função Soma
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                         Mult();
                         break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.RaizQ:
                        RaizQ();
                        break;
                    case Menu.Sair:
                        escolherSair = true;
                        break;
                }
            Console.Clear(); // Limpar tela
            }
        }

        static void Soma() //Função Soma
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("---------------------------");
            Console.WriteLine($"O resultado final é: {result}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }

        static void Sub() //Subtração
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Subtração de dois números ");
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int result = a - b;
            Console.WriteLine("---------------------------");
            Console.WriteLine($"O resultado final é {result}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }

        static void Div() //Divisão
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Divisão de dois números ");
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float result = (float)a / (float)b; //Cast de int para float
            Console.WriteLine("---------------------------");
            Console.WriteLine($"O resultado final é {result}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
                
        static void Mult() //Multiplicação
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Multiplicação de dois números ");
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int result = a * b;
            Console.WriteLine("---------------------------");
            Console.WriteLine($"O resultado final é {result}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
                
        static void Pot() //Potenciação
        {
            //Base ^ Expoente
            Console.WriteLine("---------------------------");
            Console.WriteLine("Potência de um número ");
            Console.WriteLine();
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(baseNum, expo);
            Console.WriteLine("---------------------------");
            Console.WriteLine($"O resultado final é {result}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
            /*
             FLOAT   (Precisão: 6 a 9 dígitos  ) (Tamanho: 4 bytes )  1.000000000
             DOBLE   (Precisão: 15 a 17 dígitos) (Tamanho: 8 bytes )  1.000000000000000
             DECIMAL (Precisão: 28 a 29 dígitos) (Tamanho: 16 bytes)  1.0000000000000000000000000000
             */
        }
                
        static void RaizQ() //Raiz Quadrada
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Raiz quadrada de um número ");
            Console.WriteLine();
            Console.Write("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(a); //Square Root
            Console.WriteLine("---------------------------");
            Console.WriteLine($"A raiz quadrada de {a} é {result}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }

    }
}
