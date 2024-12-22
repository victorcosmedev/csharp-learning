namespace ScreenSound.Model;

class Album
{
    private List<Musica> musicas;
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nome)
    {
        this.Nome = nome;
        this.musicas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}: \n");
        foreach(var musica in musicas)
        {   
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este álbum inteiro, você precisa de {DuracaoTotal} segundos.");
    }
}