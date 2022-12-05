namespace Tema2AtributosMetodosConstrutoresAtividadeFixacao
{
    
class Pessoa
{
    public Pessoa()
    {
        this.nomeCompleto = "Thais Gurgel";
        this.endereco = "Rua A Conj Mondubim";
        this.telefone = "8584332985";
    }
    public Pessoa(string nomeCompleto, string endereco, string telefone)
    {
        this.nomeCompleto = nomeCompleto;
        this.endereco = endereco;
        this.telefone = telefone;
    }
    
    public string nomeCompleto;
    public string endereco;
    public string telefone;

    public string primeiroNome()
    {
        return nomeCompleto.Split(' ')[0];
    }



}

}
