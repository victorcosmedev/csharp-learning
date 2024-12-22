class Estoque
{
    List<Produto> listaDeProdutos;

    public Estoque()
    {
        this.listaDeProdutos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        this.listaDeProdutos.Add(produto);
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("ESTOQUE DE PRODUTOS");
        Console.WriteLine("===========================");
        foreach(Produto produto in listaDeProdutos)
        {
            Console.WriteLine(produto.DescricaoDetalhada);
            Console.WriteLine("============================================");
        }
    }
}