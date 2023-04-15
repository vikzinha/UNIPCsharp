using System;

class Program
{
    static void Main(string[] args)
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
}