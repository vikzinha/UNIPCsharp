using System;

namespace Exercicio_8

{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("----- Escolha um dos exercícios: ");
                Console.WriteLine("-- 1. Programa para calcular média de aluno.");
                Console.WriteLine("-- 2. Programa para calcular várias médias de aluno, digite -1 para interromper.");
                Console.WriteLine("-- 3. Programa para completar 4 tarefas.");
                Console.WriteLine("-- 4. Programa para calcular a fatorial de 10");
                Console.WriteLine("-- 5. Programa para imprimir os 15 primeiros números da série de Fibonacci.");
                Console.WriteLine("-- 6. Programa para imprimir os valores assumidos por x.");
                Console.WriteLine("-- 7. Programa para verificar a validade de uma data entre 1900 e 2999.");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Calculadora.Exercicio1();
                        break;
                    case "2":
                        Calculadora.Exercicio2();
                        break;
                    case "3":
                        Calculadora.Exercicio3();
                        break;
                    case "4":
                        Calculadora.Exercicio4();
                        break;
                    case "5":
                        Calculadora.Exercicio5();
                        break;
                    case "6":
                        Calculadora.Exercicio6();
                        break;
                    case "7":
                        Calculadora.Exercicio7();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, escolha uma opção entre 1 e 7.");
                }
            }
        }
    }
}