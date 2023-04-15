using System;

class Program
{
    static void Main(string[] args)
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
}