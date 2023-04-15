using System;

class Program
{
    static void Main(string[] args)
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
}