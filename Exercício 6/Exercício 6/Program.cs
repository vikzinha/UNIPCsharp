using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}