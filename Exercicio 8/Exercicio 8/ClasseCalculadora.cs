using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Calculadora
    {
        public static void Exercicio1()
        {
            Console.WriteLine("Digite as três notas e seus pesos:");

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double peso1 = Convert.ToDouble(Console.ReadLine());

            double nota2 = Convert.ToDouble(Console.ReadLine());
            double peso2 = Convert.ToDouble(Console.ReadLine());

            double nota3 = Convert.ToDouble(Console.ReadLine());
            double peso3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

            Console.WriteLine("A média do aluno é: " + media);
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite as notas e seus pesos (para parar, digite -1):");

            double nota, peso, somaNotas = 0, somaPesos = 0;

            while (true)
            {
                nota = Convert.ToDouble(Console.ReadLine());

                if (nota == -1) break;

                peso = Convert.ToDouble(Console.ReadLine());

                somaNotas += nota * peso;
                somaPesos += peso;
            }

            double media = somaNotas / somaPesos;

            Console.WriteLine("A média do aluno é: " + media);

            Console.ReadKey();
        }

        public static void Exercicio3()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma das tarefas a seguir:");
                Console.WriteLine("a. Imprimir todos os números de 10 a 25");
                Console.WriteLine("b. Imprimir a soma dos números de 1 a 100, pulando de dois em dois");
                Console.WriteLine("c. Imprimir os números seguintes até que a soma dos números já impressos seja maior ou igual a 100");
                Console.WriteLine("d. Imprimir a tabuada do 9 até o décimo valor");
                Console.WriteLine("Digite 'sair' para encerrar o programa");

                string opcao = Console.ReadLine();

                if (opcao == "a")
                {
                    Console.WriteLine("Números de 10 a 25:");
                    for (int i = 10; i <= 25; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (opcao == "b")
                {
                    int soma = 0;
                    for (int i = 1; i <= 100; i += 2)
                    {
                        soma += i;
                    }
                    Console.WriteLine("A soma dos números de 1 a 100, pulando de dois em dois, é: " + soma);
                }
                else if (opcao == "c")
                {
                    int soma = 0, i = 0;
                    while (soma < 100)
                    {
                        i++;
                        Console.WriteLine(i);
                        soma += i;
                    }
                }
                else if (opcao == "d")
                {
                    Console.WriteLine("Tabuada do 9:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("9 x " + i + " = " + (9 * i));
                    }
                }
                else if (opcao == "sair")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Digite uma opção válida.");
                }

                Console.WriteLine();
            }
        }

        public static void Exercicio4()
        {
                int n = 10; // número fatorial q será calculado
                int fatorial = 1; // variavel p o resultado do fatorial

                // Loop que calcula o fatorial de n
                for (int i = 1; i <= n; i++)
                {
                    fatorial *= i; // multiplica fatorial por i a cada iteração do loop
                }

                // Exibe o resultado do fatorial na tela
                Console.WriteLine("O fatorial de " + n + " é igual a " + fatorial);
            
        }

        public static void Exercicio5()
        {
            int a = 0, b = 1, c;

            Console.WriteLine("Os primeiros 15 números da sequência de Fibonacci são:");
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < 15; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.ReadLine();
        }

        public static void Exercicio6()
        {
            // exercicio 6 com if / else
            // pede ao usuario um valor inicial para a variável x
            Console.Write("Digite um valor inteiro para x: ");
            int x = int.Parse(Console.ReadLine());

            // enquanto x for menor ou igual a 1000, loop
            while (x <= 1000)
            {
                // se x for par, adiciona 5 ao valor de x
                if (x % 2 == 0)
                {
                    x += 5;
                }
                // se x for ímpar, multiplica o valor de x por 2
                else
                {
                    x *= 2;
                }

                // imprime o valor atual de x
                Console.Write(x + " ");
            }

            // pausa a execução do programa
            Console.ReadKey();
        }

        public static void Exercicio7()
        {
            int dia, mes, ano;

            // leitura dos valores de dia, mês e ano
            Console.Write("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            // verifica se o ano é válido
            if (ano < 1900 || ano > 2999)
            {
                Console.WriteLine("Data inválida.");
            }
            else
            {
                // verifica o número de dias do mês
                int numDias;
                switch (mes)
                {
                    case 2:
                        if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0) // ano bissexto: div por 4, e não div por 100, ou se for div por 400 ele é bissexto
                        {
                            numDias = 29;
                        }
                        else
                        {
                            numDias = 28;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        numDias = 30;
                        break;
                    default:
                        numDias = 31;
                        break;
                }

                // verifica se o dia é válido
                if (dia < 1 || dia > numDias)
                {
                    Console.WriteLine("Data inválida.");
                }
                else
                {
                    Console.WriteLine("Data válida.");
                }
            }

            Console.ReadKey();
        }
    }
}
