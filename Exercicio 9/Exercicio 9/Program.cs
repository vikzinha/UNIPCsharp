using System;

class Ponteiro
{
    public int posicao;

    public Ponteiro(int posicao)
    {
        this.posicao = posicao;
    }
}

class Relogio
{
    private Ponteiro ponteiroHora;
    private Ponteiro ponteiroMinuto;
    private Ponteiro ponteiroSegundo;

    public Relogio()
    {
        ponteiroHora = new Ponteiro(1);
        ponteiroMinuto = new Ponteiro(1);
        ponteiroSegundo = new Ponteiro(1);
    }

    public void AcertarRelogio(int hora, int minuto, int segundo)
    {
        if (hora < 0 || hora > 23)
        {
            Console.WriteLine("Hora inválida!");
            return;
        }

        if (minuto < 0 || minuto > 59)
        {
            Console.WriteLine("Minuto inválido!");
            return;
        }

        if (segundo < 0 || segundo > 59)
        {
            Console.WriteLine("Segundo inválido!");
            return;
        }

        ponteiroHora.posicao = hora % 12 == 0 ? 12 : hora % 12;
        ponteiroMinuto.posicao = minuto;
        ponteiroSegundo.posicao = segundo;
    }

    public int LerHora()
    {
        return ponteiroHora.posicao;
    }

    public int LerMinuto()
    {
        return ponteiroMinuto.posicao;
    }

    public int LerSegundo()
    {
        return ponteiroSegundo.posicao;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Relogio relogio = new Relogio();

        relogio.AcertarRelogio(9, 30, 0);

        Console.WriteLine("{0}:{1}:{2}", relogio.LerHora(), relogio.LerMinuto(), relogio.LerSegundo());
    }
}