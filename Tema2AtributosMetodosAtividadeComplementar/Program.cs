// implemente uma classe Pessoa que armazena os seguintes atributos:
// nome: do tipo texto e armazena o nome completo da pessoa,
// endereço: do tipo texto e armazena o endereço completo da pessoa,
// telefone: do tipo texto e armazena o ddd e o numero do telefone da pessoa
// e o seguinte metodo: primeiroNome(): retorna elemento do tipo texto
// este metodo retorna o primeiro nome da pesoa. por enqaunto nao se
// preocupe com o ocorrencia de nomes compostos.
// por enquanto, os atributos devem ser acessiveis diretamente, sem a
// necessidade de metodos de acesso.
// finalmente, implemente uma classe MainClass para mostrar o 
// funcionamento da sua classe Pessoa.

using System;

class Pessoa
{
    public string nome;
    public string endereco;
    public string telefone;

    public string primeiroNome()
    {
        return nome.Split(' ')[0];
    }

    public string modificarNome(string novoNome)
    {
        return nome = novoNome;
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        pessoa.nome = "Thais Gurgel";
        pessoa.endereco = "Joao Sousa Filho";
        pessoa.telefone = "85987806580";
        
        Console.WriteLine("Pessoa:");
        Console.WriteLine(" Atributos:");
        Console.WriteLine("Nome: {0}", pessoa.nome);
        Console.WriteLine("Endereço: {0}", pessoa.endereco);
        Console.WriteLine("Telefone: {0}", pessoa.telefone);
        Console.WriteLine(" Metodos:");
        Console.WriteLine(" primeiro Nome: {0}", (pessoa.primeiroNome()));
        Console.WriteLine("novo Nome: {0}", pessoa.modificarNome("ricardo de padua") );
        Console.WriteLine("Nome: {0}", pessoa.nome);
    }
}

