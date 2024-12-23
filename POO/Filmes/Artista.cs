namespace POO.Filmes;

class Artista
{
    public string Nome { get; }
    public int Idade { get; }
    private List<Filme> filmesEmQueAtuou;

    public Artista(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.filmesEmQueAtuou = new();
    }

    public void AdicionarFilme(Filme filme)
    {
        this.filmesEmQueAtuou.Add(filme);
    }

    public void AdicionarFilme(List<Filme> filmes)
    {
        this.filmesEmQueAtuou.AddRange(filmes);
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"{this.Nome} - {this.Idade} anos");
        Console.WriteLine("Filmes em que atuou");
        foreach(Filme f in filmesEmQueAtuou)
        {
            Console.WriteLine(f.DescricaoDetalhada);
            Console.WriteLine("========================");
        }
    }
}