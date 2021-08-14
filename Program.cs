using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace CALCULADORA
    
{
    class Program
    {
        enum opcao { Adição = 1, Subtração, Multiplicação, Divisão, Tabuada, Potencia, Raiz, Sair }
        static void Soma()
        {
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a + b;
            Console.WriteLine($"Seu resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a - b;
            Console.WriteLine($"Seu resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine($"Seu resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a / b;
            Console.WriteLine($"Seu resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void Tabuada()
        {
            Console.WriteLine("Digite o número que deseja a tabuada");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + "*" + i + "=" + numero * i);
            }

            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.WriteLine("Potencia de um número");
            Console.WriteLine("Digite a base: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(a, b);
            Console.WriteLine($"A potência de {a} elevado a {b} é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz quadrada de um número");
            Console.WriteLine("Digite o número: ");
            double a = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"A raiz quadrada de {a} é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Main(string[] args)
            {
                bool escolheuSair = false; //Crio uma variavel bool falsa e depois coloco na condição do While com o "!" para ela se tornar verdadeira e executar
                while (!escolheuSair) // Já que o While só executa enquanto estiver dando true
                {
                    Console.WriteLine("Calculadora!");
                    Console.WriteLine("Escolha uma opção:\n1-Adição\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Tabuada\n6-Potencia\n7-Raiz\n8-Sair");
                    opcao menu = (opcao)int.Parse(Console.ReadLine());

                    Console.WriteLine(menu);


                    switch (menu)
                    {
                        case opcao.Sair:
                            escolheuSair = true;
                            break;
                        case opcao.Adição:
                            Soma();
                            break;
                        default:
                            Console.WriteLine("Opção invalida, tente novamente");
                            Console.ReadLine();
                            break;
                        case opcao.Divisão:
                            Divisao();
                            break;
                        case opcao.Multiplicação:
                            Multiplicacao();
                            break;
                        case opcao.Subtração:
                            Subtracao();
                            break;
                        case opcao.Tabuada:
                            Tabuada();
                            break;
                        case opcao.Potencia:
                            Potencia();
                            break;
                        case opcao.Raiz:
                        Raiz();
                        break;

                    }
                    Console.Clear();

                }                           
            }
    }
}








