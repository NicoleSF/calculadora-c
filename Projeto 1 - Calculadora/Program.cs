using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1___Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair };
        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC! Selecione uma das opções: ");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
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

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }

                Console.Clear();
            }
            

        }

        static void Soma()
        {
            Console.WriteLine("- Soma de dois Números -");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();

        }
        static void Sub()
        {
            Console.WriteLine("- Subtração de dois Números -");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();

        }

        static void Div()
        {
            Console.WriteLine("- Divisão de dois Números -");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b; //precisa ser float. Se é inteiro, o c# vai cortar numeros depois da ,
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();

        }

        static void Mult()
        {
            Console.WriteLine("- Multiplicação de dois Números -");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b; 
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();

        }

        static void Pot()
        {
            Console.WriteLine("- Potência de um número -");
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo); //math pow é de potencia. Como retorna double, precisamos fazer um cast.
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();

        }
        static void Raiz()
        {
            Console.WriteLine("- Raiz de um número -");
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a); 
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();

        }
    }
}
