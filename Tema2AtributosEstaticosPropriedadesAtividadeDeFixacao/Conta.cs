//Crie uma classe CONTA, que representa uma conta bancaria com um atributo
//SALDO do tipo FLOAT e um atributo CRIACAO do tipo DateTime.
//Em seguida, implemente um atributo chamado NUMERO, que representa o numero
//da conta bancaria, e deve ser um numero sequencial, gerado
//automaticamente, a cada vez que uma instância de CONTA é criada.
//Finalmente, implemente uma classe MainClass para mostrar o funcionamento
//da sua classe Conta.

using System;

namespace Tema2AtributosEstaticosPropriedadesAtividadeDeFixacao
{
    class Conta
    {
        public float saldo;
        public DateTime criacao;
        public int idConta;

        public static int numeroSequencial;

        public Conta(float saldo, DateTime criacao)
        {
            this.idConta = ++Conta.numeroSequencial;

            if (criacao >= DateTime.Now) ;
            this.criacao = criacao;

            if (saldo >= 0) ;
            this.saldo = saldo;
        
        }

        public Conta()
        {
            this.idConta = ++Conta.numeroSequencial;
            this.saldo = 20;
            this.criacao = new DateTime(03102022);
        }

        public bool NumeroConta()
        {
            return (idConta > 0);
        }
    }
}
class Conta
{
    public float saldo;
    public DateTime criacao;
    public int idConta;

    public static int numeroSequencial;

    public Conta(float saldo, DateTime criacao)
    {
        this.idConta = ++Conta.numeroSequencial;

        if (criacao >= DateTime.Now) ;
        this.criacao = criacao;

        if (saldo >= 0) ;
        this.saldo = saldo;
        
    }

    public Conta()
    {
        this.idConta = ++Conta.numeroSequencial;
        this.saldo = 20;
        this.criacao = new DateTime(03102022);
    }

    public bool NumeroConta()
    {
        return (idConta > 0);
    }
}