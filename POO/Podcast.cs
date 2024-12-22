class Podcast
{
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;
    private List<Episodio> episodios;

    public Podcast(string nome, string host)
    {
        this.Nome = nome;
        this.Host = host;
        this.episodios = new();
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        this.episodios.Add(episodio);
    }

    public void AdicionarEpisodio(List<Episodio> episodios)
    {
        this.episodios.AddRange(episodios);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("DETALHES DO PODCAST");
        Console.WriteLine($"Nome: {this.Nome}"); 
        Console.WriteLine($"Host: {this.Host}");
        Console.WriteLine("==================================\n");
        foreach (Episodio e in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(e.Resumo);
        }
        Console.WriteLine("\n==================================");
    }
}