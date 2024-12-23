namespace ScreenSound.Models;

class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<int> notas = new();
    public string Nome { get; }
    public double Media => notas.Average();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }

    public void AdicionarNota(int nota)
    {
        this.notas.Add(nota);
    }
}