using System;

class Program
{
    class Lampada
    {
        private bool ligada;

        public Lampada(bool estadoInicial)
        {
            ligada = estadoInicial;
        }

        public void Ligar()
        {
            ligada = true;
            Imprimir();
        }

        public void Desligar()
        {
            ligada = false;
            Imprimir();
        }

        private void Imprimir()
        {
            if (ligada)
                Console.WriteLine("Lâmpada ligada");
            else
                Console.WriteLine("Lâmpada desligada");
        }
    }

    static void Main(string[] args)
    {
        Lampada l = new Lampada(true); // cria uma lâmpada ligada
        l.Desligar(); // desliga a lâmpada
        l.Ligar(); // liga a lâmpada novamente
        Console.ReadKey(); // aguarda o usuário pressionar alguma tecla para encerrar o programa
    }
}