using System;

public class Triangulo
{
    private double baseTriangulo;
    private double altura;

    public Triangulo(double b, double h)
    {
        baseTriangulo = b;
        altura = h;
    }

    public double CalcularArea()
    {
        return baseTriangulo * altura / 2;
    }
}

public class Quadrado
{
    private double lado;

    public Quadrado(double l)
    {
        lado = l;
    }

    public double CalcularArea()
    {
        return Math.Pow(lado, 2);
    }
}

public class Circunferencia
{
    private double raio;

    public Circunferencia(double r)
    {
        raio = r;
    }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(raio, 2);
    }
}

public class Trapezio
{
    private double baseMaior;
    private double baseMenor;
    private double altura;

    public Trapezio(double B, double b, double h)
    {
        baseMaior = B;
        baseMenor = b;
        altura = h;
    }

    public double CalcularArea()
    {
        return ((baseMaior + baseMenor) / 2) * altura;
    }
}

public class Program
{
    public static void Main()
    {
        Triangulo triangulo = new Triangulo(4, 6);
        Quadrado quadrado = new Quadrado(5);
        Circunferencia circunferencia = new Circunferencia(3);
        Trapezio trapezio = new Trapezio(6, 4, 8);

        Console.WriteLine("Área do Triângulo: " + triangulo.CalcularArea());
        Console.WriteLine("Área do Quadrado: " + quadrado.CalcularArea());
        Console.WriteLine("Área da Circunferência: " + circunferencia.CalcularArea());
        Console.WriteLine("Área do Trapézio: " + trapezio.CalcularArea());
    }
}