using System;

class Program
{
    static void Main(string[] args)
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
}