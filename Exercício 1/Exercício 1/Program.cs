using System;

class Program
{
    static void Main(string[] args)
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
}
