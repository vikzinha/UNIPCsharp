using System;

class Ponto2D
{
    protected double x, y;

    public Ponto2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Coordenadas do ponto 2D: ({x}, {y})");
    }
}

class Ponto3D : Ponto2D
{
    private double z;

    public Ponto3D(double x, double y, double z) : base(x, y)
    {
        this.z = z;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Coordenadas do ponto 3D: ({x}, {y}, {z})");
    }
}
class Program
    {
        static void Main(string[] args)
        {
            Ponto2D p2d = new Ponto2D(2.5, 3.0);
            p2d.Imprimir(); // exibe "Coordenadas do ponto 2D: (2.5, 3)"

            Ponto3D p3d = new Ponto3D(1.0, 2.0, 3.0);
            p3d.Imprimir(); // exibe "Coordenadas do ponto 3D: (1, 2, 3)"

            Console.ReadKey(); // aguarda o usuário pressionar alguma tecla para encerrar o programa
        }
    }