using System;

namespace MyNamespace
{
    
}

class MainClass
{

    public static void Main(string[] args)
    {
        Console.WriteLine("-\nContador de contas: {0}\n-", Conta.numeroSequencial);

        Conta conta1 = new Conta();

        Console.WriteLine("Conta1: construtor com parâmentros");
        Console.WriteLine("Atributos:");
        Console.WriteLine("saldo: {0}", conta1.saldo);
        Console.WriteLine("data: {0}", conta1.criacao);
        Console.WriteLine("Métodos");
        Console.WriteLine(" Numero Conta: {0}", (conta1.NumeroConta() ? "sim" : "não"));

        Conta conta2 = new Conta(30, DateTime.Now);
        
        Console.WriteLine("Conta2: construtor com parâmentros");
        Console.WriteLine("Atributos");
        Console.WriteLine("saldo: {0}", conta2.saldo);
        Console.WriteLine("data: {0}", conta2.criacao);
        Console.WriteLine("Métodos");
        Console.WriteLine("Numero Conta: {0}", (conta2.NumeroConta() ? "sim" : "não"));

    }
}