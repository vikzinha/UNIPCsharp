using System;

class Fracao
{
    private int numerador;
    private int denominador;

    public Fracao(int numerador, int denominador)
    {
        this.numerador = numerador;
        this.denominador = denominador;
    }

    public Fracao Multiplicar(Fracao outra)
    {
        int novoNumerador = this.numerador * outra.numerador;
        int novoDenominador = this.denominador * outra.denominador;

        return new Fracao(novoNumerador, novoDenominador);
    }

    public override string ToString()
    {
        return $"{this.numerador}/{this.denominador}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fracao fracao1 = new Fracao(3, 4);
        Fracao fracao2 = new Fracao(5, 6);

        Fracao resultado = fracao1.Multiplicar(fracao2);

        Console.WriteLine($"Resultado: {resultado}");
    }
}