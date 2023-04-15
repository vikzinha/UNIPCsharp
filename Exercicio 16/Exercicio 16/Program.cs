using System;

class Porta : ICloneable
{
    private double altura;
    private double largura;
    private bool aberta;

    public Porta(double altura, double largura, bool aberta)
    {
        this.altura = altura;
        this.largura = largura;
        this.aberta = aberta;
    }

    public void Abrir()
    {
        aberta = true;
    }

    public void Fechar()
    {
        aberta = false;
    }

    public double Altura
    {
        get { return altura; }
    }

    public double Largura
    {
        get { return largura; }
    }

    public bool Aberta
    {
        get { return aberta; }
    }

    public object Clone()
    {
        return new Porta(altura, largura, aberta);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Porta porta1 = new Porta(2.10, 0.90, false);
        Console.WriteLine("Porta 1:");
        Console.WriteLine("Altura: {0}m, Largura: {1}m, Aberta: {2}", porta1.Altura, porta1.Largura, porta1.Aberta);

        Porta porta2 = (Porta)porta1.Clone();
        Console.WriteLine("\nPorta 2 (cópia da Porta 1):");
        Console.WriteLine("Altura: {0}m, Largura: {1}m, Aberta: {2}", porta2.Altura, porta2.Largura, porta2.Aberta);

        porta2.Abrir();
        Console.WriteLine("\nPorta 2 aberta:");
        Console.WriteLine("Altura: {0}m, Largura: {1}m, Aberta: {2}", porta2.Altura, porta2.Largura, porta2.Aberta);

        Console.WriteLine("\nPorta 1 continua fechada:");
        Console.WriteLine("Altura: {0}m, Largura: {1}m, Aberta: {2}", porta1.Altura, porta1.Largura, porta1.Aberta);
    }
}