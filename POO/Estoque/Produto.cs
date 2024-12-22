class Produto
{

    private double preco;
    private int quantidade;

    public string Nome { get; set; }
    public string Marca { get; set; }

    public Produto(string nome, string marca, double preco, int estoque)
    {
        this.Nome = nome;
        this.Marca = marca;
        this.Preco = preco;
        this.Estoque = estoque;
    }
    
    public double Preco {
        get => preco;
        set
        {
            if (value < 0)
            {
                value = 0;
            } else
            {
                preco = value;
            }
        }
    }
    public int Estoque {
        get => quantidade;
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            else
            {
                quantidade = value;
            }
        }
    }

    public string DescricaoDetalhada {
        get
        {
            return @$"
            Marca: {this.Marca}
            Item: {this.Nome}
            Preco: {this.Preco}
            Quant. Itens: {this.quantidade}
            ";
        }
    }

}