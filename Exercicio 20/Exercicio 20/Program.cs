using System;

public abstract class ContaBancaria
{
    private double saldo;

    protected double Saldo { get => saldo; set => saldo = value; }

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Depósito no valor de R$" + valor + " realizado com sucesso!");
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine("Saque no valor de R$" + valor + " realizado com sucesso!");
        }
    }

    public void Transferir(double valor, ContaBancaria contaDestino)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar a transferência.");
        }
        else
        {
            Saldo -= valor;
            contaDestino.Saldo += valor;
            Console.WriteLine("Transferência no valor de R$" + valor + " realizada com sucesso para a conta de destino.");
        }
    }

    public abstract double CalcularSaldo();
}

public class ContaCorrente : ContaBancaria
{
    public override double CalcularSaldo()
    {
        return Saldo - (Saldo * 0.1);
    }
}

public class ContaInvestimento : ContaBancaria
{
    public override double CalcularSaldo()
    {
        return Saldo + (Saldo * 0.05);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria contaCorrente = new ContaCorrente();
        ContaBancaria contaInvestimento = new ContaInvestimento();

        Console.WriteLine("Saldo atual da conta corrente: R$" + contaCorrente.CalcularSaldo());
        Console.WriteLine("Saldo atual da conta investimento: R$" + contaInvestimento.CalcularSaldo());

        contaCorrente.Depositar(1000);
        contaInvestimento.Depositar(500);

        Console.WriteLine("Saldo atual da conta corrente: R$" + contaCorrente.CalcularSaldo());
        Console.WriteLine("Saldo atual da conta investimento: R$" + contaInvestimento.CalcularSaldo());

        contaCorrente.Transferir(500, contaInvestimento);

        Console.WriteLine("Saldo atual da conta corrente: R$" + contaCorrente.CalcularSaldo());
        Console.WriteLine("Saldo atual da conta investimento: R$" + contaInvestimento.CalcularSaldo());

        contaInvestimento.Sacar(100);

        Console.WriteLine("Saldo atual da conta corrente: R$" + contaCorrente.CalcularSaldo());
        Console.WriteLine("Saldo atual da conta investimento: R$" + contaInvestimento.CalcularSaldo());
    }
}