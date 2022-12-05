using System;
namespace Tema2AtributosEstaticosPropriedadesContadorAutoincremento
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.contador);

            Produto produto1 = new Produto();
            
            Console.WriteLine("-\nContador de produtos: {0}\n-", global::Produto.contador);
            
            Console.WriteLine("Produto 1: construtor default");
            Console.WriteLine("Atributos");
            Console.WriteLine("Id: {0}", produto1.id);
            Console.WriteLine("Descrição: {0}", produto1.descricao);
            Console.WriteLine("Preco: {0}", produto1.preco);
            Console.WriteLine("Quantidade: {0}", produto1.quantidade);
            Console.WriteLine("Metodos");
            Console.WriteLine("Em estoque: {0}", (produto1.emEstoque() ? "sim" : "não"));

            Produto produto2 = new Produto("Leite", 3.59F, 12);
            
            Console.WriteLine("-\nContador de produtos: {0}\n-", global::Produto.contador);
            
            Console.WriteLine("Produto 2: construtor com parâmentros");
            Console.WriteLine("Atributos:");
            Console.WriteLine("Id: {0}", produto2.id);
            Console.WriteLine("Descrição: {0}", produto2.descricao);
            Console.WriteLine("Preço: {0}", produto2.preco);
            Console.WriteLine("Quantidade: {0}", produto2.quantidade);
            Console.WriteLine("Métodos");
            Console.WriteLine("Em estoque: {0}", (produto2.emEstoque() ? "sim" : "não"));
        }
    }
}