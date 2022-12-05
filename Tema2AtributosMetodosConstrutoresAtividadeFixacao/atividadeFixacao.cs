// Implemente uma classe Pessoa em C# que armazena os seguintes atributos.
// Nome: do tipo texto e armazena o nome completo da pessoa,
// Endereço: do tipo texto e armazena o endereço completo da pessoa,
// Telefone: do tipo texto e armazena o DDD e o numero do telefone da pessoa,
// E o seguinte método:
// primeiroNome(): retorna elemento do tipo texto.
// Este método retorna o primeiro nome da pessoa. Por enquanto não
// se preocupe com a ocorrência de nomes compostos.
// Por enquanto, os atributos devem ser acessíveis diretamente,
// sem a necessidade de métodos de acesso.
// implemente um construtor default e um construtor com parâmentros que 
// inicialize os três atributos com valores fornecidos pelo usuario.
// Finalmente, implemente uma classe MainClass para mostrar o funcionamento da sua classe Pessoa

using System;


namespace Tema2AtributosMetodosConstrutoresAtividadeFixacao
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Pessoa 1: construtor default");
            Console.WriteLine("Atributos");
            Console.WriteLine("   Nome Completo: {0}", pessoa1.nomeCompleto);
            Console.WriteLine("   Endereço: {0}", pessoa1.endereco);
            Console.WriteLine("   Telefone: {0}", pessoa1.telefone);
            Console.WriteLine("Metódos");
            Console.WriteLine("Primeiro Nome: {0}", (pessoa1.primeiroNome()));

            Pessoa pessoa2 = new Pessoa("Ricardo Padua", "Rua B Conj Planalto", "8599875263");

            Console.WriteLine("Pessoa 2: construtor com parâmentros");
            Console.WriteLine("Atributos");
            Console.WriteLine("  Nome Completo: {0}", pessoa2.nomeCompleto);
            Console.WriteLine("  Endereço: {0}", pessoa2.endereco);
            Console.WriteLine("  Telefone: {0}", pessoa2.telefone);
            Console.WriteLine("Primeiro Nome: {0}", (pessoa2.primeiroNome()));

        }
    }

}