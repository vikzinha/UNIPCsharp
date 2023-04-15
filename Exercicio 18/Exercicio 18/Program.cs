using System;

class Colecao
{
    protected object[] dados;
    protected int posicao;

    public Colecao(int tamanho)
    {
        dados = new object[tamanho];
        posicao = -1;
    }

    public virtual void InserirItem(object item)
    {
        if (posicao < dados.Length - 1)
        {
            posicao++;
            dados[posicao] = item;
        }
        else
        {
            Console.WriteLine("A coleção está cheia!");
        }
    }

    public virtual object RemoverItem()
    {
        if (posicao >= 0)
        {
            object item = dados[posicao];
            posicao--;
            return item;
        }
        else
        {
            Console.WriteLine("A coleção está vazia!");
            return null;
        }
    }
}

class Pilha : Colecao
{
    public Pilha(int tamanho) : base(tamanho)
    {

    }

    public override void InserirItem(object item)
    {
        base.InserirItem(item);
    }

    public override object RemoverItem()
    {
        return base.RemoverItem();
    }
}

class Fila : Colecao
{
    public Fila(int tamanho) : base(tamanho)
    {

    }

    public override void InserirItem(object item)
    {
        if (posicao < dados.Length - 1)
        {
            posicao++;
            dados[posicao] = item;
        }
        else
        {
            Console.WriteLine("A coleção está cheia!");
        }
    }

    public override object RemoverItem()
    {
        if (posicao >= 0)
        {
            object item = dados[0];

            for (int i = 0; i < posicao; i++)
            {
                dados[i] = dados[i + 1];
            }

            posicao--;

            return item;
        }
        else
        {
            Console.WriteLine("A coleção está vazia!");
            return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Colecao colecao = new Colecao(5);
        Pilha pilha = new Pilha(5);
        Fila fila = new Fila(5);

        // Adicionando elementos na coleção
        colecao.InserirItem("Item 1");
        colecao.InserirItem("Item 2");
        colecao.InserirItem("Item 3");

        pilha.InserirItem("Item 1");
        pilha.InserirItem("Item 2");
        pilha.InserirItem("Item 3");

        fila.InserirItem("Item 1");
        fila.InserirItem("Item 2");
        fila.InserirItem("Item 3");

        // Removendo elementos da coleção e imprimindo o resultado
        Console.WriteLine("Coleção:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(colecao.RemoverItem());
        }

        Console.WriteLine("Pilha:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(pilha.RemoverItem());
        }

        Console.WriteLine("Fila:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(fila.RemoverItem());
        }
    }
}