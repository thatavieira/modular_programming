//cada objeto tem seu proprio id

namespace Tema2AtributosEstaticosPropriedadesContadorAutoincremento
{
    class Produto
    {
        public int id;
        public string descricao;
        public float preco;
        public int quantidade;

        public static int contador;

        public Produto(string descricao, float preco, int quantidade)
        {
            this.id = ++Produto.contador;

            if (descricao.Length >= 3)
                this.descricao = descricao;
            if (preco > 0)
                this.preco = preco;
            if (quantidade >= 0)
                this.quantidade = quantidade;
        }

        public Produto()
        {
            this.id = ++Produto.contador;
            this.descricao = "Novo Produto";
            this.preco = 0.01F;
            this.quantidade = 0;
        }

        public bool emEstoque()
        {
            return (quantidade > 0);
        }
    } 
}
class Produto
{
    public int id;
    public string descricao;
    public float preco;
    public int quantidade;

    public static int contador;

    public Produto(string descricao, float preco, int quantidade)
    {
        this.id = ++Produto.contador;

        if (descricao.Length >= 3)
            this.descricao = descricao;
        if (preco > 0)
            this.preco = preco;
        if (quantidade >= 0)
            this.quantidade = quantidade;
    }

    public Produto()
    {
        this.id = ++Produto.contador;
        this.descricao = "Novo Produto";
        this.preco = 0.01F;
        this.quantidade = 0;
    }

    public bool emEstoque()
    {
        return (quantidade > 0);
    }
}