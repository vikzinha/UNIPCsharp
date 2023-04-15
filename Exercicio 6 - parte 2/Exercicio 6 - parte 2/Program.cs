using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Console.Write("Digite um valor inteiro para x: ");
            int x = int.Parse(Console.ReadLine());

            // enquanto x for menor ou igual a 1000, loop
            while (x <= 1000)
            {
                // resto da divisão por 2 para verificar se x é par ou ímpar
                switch (x % 2)
                {
                    // se x for par, adiciona 5 ao valor de x
                    case 0:
                        x += 5;
                        break;
                    // se x for ímpar, multiplica o valor de x por 2
                    case 1:
                        x *= 2;
                        break;
                }

                // imprime o valor atual de x
                Console.Write(x + " ");
            }

            // pausa a execução do programa 
            Console.ReadKey();
        }
    }
}