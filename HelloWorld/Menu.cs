using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Menu
    {
            public static void Mostrar()
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("");

                Console.WriteLine("1. Soma (+)");
                Console.WriteLine("2. Subtração (-)");
                Console.WriteLine("3. Multiplicação (*)");
                Console.WriteLine("4. Divisão (/)");
                Console.WriteLine("5. Potência (^)");
                Console.WriteLine("6. Radiciação (√)");
                Console.WriteLine("7. Raiz Quadrada (√)");
                Console.WriteLine("8. Porcentagem (%)");
                Console.WriteLine("9. Valor Absoluto (|)");
                Console.WriteLine("10. Arredondamento (≈)");
                Console.WriteLine("11. Logaritmos (log b)");

                Console.WriteLine("");
            }

            public static int ObterOpcao()
            {
                int opcao;

                while (true)
                {
                    Console.Write("Digite a opção desejada: ");
                if (int.TryParse(Console.ReadLine(), out opcao) && opcao >= 1 && opcao <= 11)
                    {
                        return opcao;
                    }
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
                
            }
    }
    
}
