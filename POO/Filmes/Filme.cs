namespace POO.Filmes;

class Filme
{
    public string Nome { get; }
    public int Duracao { get; }
    private List<Artista> elenco;
    public string DescricaoDetalhada => $"{this.Nome} - {this.Duracao} mins";
    
    public Filme(string nome, int duracao)
    {
        this.Nome = nome;
        this.Duracao = duracao;
        this.elenco = new();
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"{this.Nome} - {this.Duracao} mins");
        Console.WriteLine("Elenco:");
        foreach(Artista ator in elenco)
        {
            Console.WriteLine(ator);
        }
        Console.WriteLine("========================");
    }

    public void AdicionarAoElenco(Artista artista)
    {
        this.elenco.Add(artista);
        artista.AdicionarFilme(this);
    }

    public void AdicionarAoElenco(List<Artista> artistas)
    {
        this.elenco.AddRange(artistas);
        foreach(Artista a in artistas)
        {
            a.AdicionarFilme(this);
        }
    }
}