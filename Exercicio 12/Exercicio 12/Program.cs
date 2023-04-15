using System;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando a turma e os alunos
        Turma turma = new Turma();
        Aluno aluno1 = new Aluno("Aluno1");
        Aluno aluno2 = new Aluno("Aluno2");
        Aluno aluno3 = new Aluno("Aluno3");

        // Definindo notas para as provas
        aluno1.prova1.notaParte1 = 4.0;
        aluno1.prova1.notaParte2 = 2.5;
        aluno1.prova2.notaParte1 = 1.0;
        aluno1.prova2.notaParte2 = 7.0;

        aluno2.prova1.notaParte1 = 6.5;
        aluno2.prova1.notaParte2 = 3.5;
        aluno2.prova2.notaParte1 = 0.0;
        aluno2.prova2.notaParte2 = 3.0;

        aluno3.prova1.notaParte1 = 5.0;
        aluno3.prova1.notaParte2 = 4.0;
        aluno3.prova2.notaParte1 = 6.0;
        aluno3.prova2.notaParte2 = 1.5;

        // Adicionando os alunos na turma
        turma.aluno1 = aluno1;
        turma.aluno2 = aluno2;
        turma.aluno3 = aluno3;

        // Calculando médias da turma e dos alunos
        double mediaTurma = turma.CalcularMedia();
        double mediaAluno1 = aluno1.CalcularMedia();
        double mediaAluno2 = aluno2.CalcularMedia();
        double mediaAluno3 = aluno3.CalcularMedia();

        // Mostrando resultados
        Console.WriteLine("Média do Aluno1: " + mediaAluno1);
        Console.WriteLine("Média do Aluno2: " + mediaAluno2);
        Console.WriteLine("Média do Aluno3: " + mediaAluno3);
        Console.WriteLine("Média da Turma: " + mediaTurma);

        Console.ReadKey();
    }
}

class Turma
{
    public Aluno aluno1;
    public Aluno aluno2;
    public Aluno aluno3;

    public double CalcularMedia()
    {
        double media = (aluno1.CalcularMedia() + aluno2.CalcularMedia() + aluno3.CalcularMedia()) / 3;
        return media;
    }
}

class Aluno
{
    public string nome;
    public Prova prova1 = new Prova();
    public Prova prova2 = new Prova();

    public Aluno(string nome)
    {
        this.nome = nome;
    }

    public double CalcularMedia()
    {
        double media = (prova1.CalcularNotaTotal() + prova2.CalcularNotaTotal()) / 2;
        return media;
    }
}

class Prova
{
    public double notaParte1;
    public double notaParte2;

    public double CalcularNotaTotal()
    {
        double notaTotal = notaParte1 + notaParte2;
        notaTotal = Math.Min(notaTotal, 10.0);
        return notaTotal;
    }
}