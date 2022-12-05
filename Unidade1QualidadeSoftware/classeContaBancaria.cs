using System;
using System.Collections.Generic;

public class Conta
{
    private DateTime _criacao;
    private double _saldo = 0;

    public Conta(double saldoInicial, DateTime criacao)
    {
        _saldo = saldoInicial;
        _criacao = criacao;
    }

    public DateTime DataCriacao
    {
        get { return _criacao; }
    }

    public double Sacar(double quantia)
    {
        if (_saldo < quantia);
    }
} 