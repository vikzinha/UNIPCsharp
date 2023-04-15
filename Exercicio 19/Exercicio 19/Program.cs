using System;

class Veiculo
{
    private bool ligado = false;
    public bool Ligado
    {
        get { return ligado; }
    }

    public virtual void Ligar()
    {
        Console.WriteLine("Veiculo ligado");
        ligado = true;
    }

    public virtual void Desligar()
    {
        Console.WriteLine("Veiculo desligado");
        ligado = false;
    }
}

class Automovel : Veiculo
{
    public override void Ligar()
    {
        Console.WriteLine("Automovel ligado");
        base.Ligar();
    }

    public override void Desligar()
    {
        Console.WriteLine("Automovel desligado");
        base.Desligar();
    }
}

class Motocicleta : Veiculo
{
    public override void Ligar()
    {
        Console.WriteLine("Motocicleta ligada");
        base.Ligar();
    }

    public override void Desligar()
    {
        Console.WriteLine("Motocicleta desligada");
        base.Desligar();
    }
}

class Onibus : Veiculo
{
    public override void Ligar()
    {
        Console.WriteLine("Onibus ligado");
        base.Ligar();
    }

    public override void Desligar()
    {
        Console.WriteLine("Onibus desligado");
        base.Desligar();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Veiculo v1 = new Automovel();
        Veiculo v2 = new Motocicleta();
        Veiculo v3 = new Onibus();

        v1.Ligar();
        Console.WriteLine("v1.Ligado: " + v1.Ligado);

        v2.Desligar();
        Console.WriteLine("v2.Ligado: " + v2.Ligado);

        v3.Ligar();
        Console.WriteLine("v3.Ligado: " + v3.Ligado);
    }
}