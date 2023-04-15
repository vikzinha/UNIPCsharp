using System;

class Data
{
    private readonly int dia;
    private readonly int mes;
    private readonly int ano;
    private readonly int hora;
    private readonly int minuto;
    private readonly int segundo;

    public const int FORMATO_12H = 12;
    public const int FORMATO_24H = 24;

    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo)
        : this(dia, mes, ano)
    {
        if (hora < 0 || hora > 23)
        {
            throw new ArgumentException("Hora deve estar entre 0 e 23");
        }

        this.hora = hora;
        this.minuto = minuto;
        this.segundo = segundo;
    }

    public int Dia
    {
        get { return dia; }
    }

    public int Mes
    {
        get { return mes; }
    }

    public int Ano
    {
        get { return ano; }
    }

    public int Hora
    {
        get { return hora; }
    }

    public int Minuto
    {
        get { return minuto; }
    }

    public int Segundo
    {
        get { return segundo; }
    }

    public void Imprimir(int formatoHora)
    {
        if (formatoHora != FORMATO_12H && formatoHora != FORMATO_24H)
        {
            throw new ArgumentException("Formato de hora inválido");
        }

        if (hora == 0)
        {
            Console.WriteLine("{0}/{1}/{2}", dia, mes, ano);
            return;
        }

        string amPm = hora < 12 ? "AM" : "PM";
        int horaFormatada = formatoHora == FORMATO_12H ? hora % 12 : hora;
        Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5} {6}",
            dia, mes, ano, horaFormatada, minuto, segundo, amPm);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Data d1 = new Data(10, 03, 2000, 10, 30, 10);
        d1.Imprimir(Data.FORMATO_12H);
        d1.Imprimir(Data.FORMATO_24H);

        Console.WriteLine("--------------");

        Data d2 = new Data(15, 06, 2000, 23, 15, 20);
        d2.Imprimir(Data.FORMATO_12H);
        d2.Imprimir(Data.FORMATO_24H);

        Console.WriteLine("---------------");

        Data d3 = new Data(5, 10, 2005);
        d3.Imprimir(Data.FORMATO_12H);
        d3.Imprimir(Data.FORMATO_24H);
    }
}