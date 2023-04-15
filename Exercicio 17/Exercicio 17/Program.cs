using System;
using System.Collections.Generic;

class Figura
{
    public virtual double CalcularArea()
    {
        return 0;
    }
}

class Quadrado : Figura
{
    private double lado;

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }
}

class Retangulo : Figura
{
    private double lado1;
    private double lado2;

    public Retangulo(double lado1, double lado2)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
    }

    public override double CalcularArea()
    {
        return lado1 * lado2;
    }
}

class FiguraComplexa : Figura
{
    private List<Figura> figuras;

    public FiguraComplexa()
    {
        figuras = new List<Figura>();
    }

    public void AdicionarFigura(Figura figura)
    {
        figuras.Add(figura);
    }

    public override double CalcularArea()
    {
        double areaTotal = 0;
        foreach (Figura figura in figuras)
        {
            areaTotal += figura.CalcularArea();
        }
        return areaTotal;
    }
}

class Program
{
    static void Main(string[] args)
    {
        FiguraComplexa figura = new FiguraComplexa();
        figura.AdicionarFigura(new Quadrado(3));
        figura.AdicionarFigura(new Quadrado(10));
        figura.AdicionarFigura(new Retangulo(2, 7));
        figura.AdicionarFigura(new Retangulo(5, 3));
        Console.WriteLine("Área da figura complexa: " + figura.CalcularArea());
        Console.ReadKey();
    }
}