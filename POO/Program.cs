using POO.Filmes;

Filme interstellar = new Filme("Interstellar", 169);
Filme carros = new Filme("Carros", 116);

Artista matthew = new Artista("Matthew McConaughey", 55);
Artista anneHathaway = new Artista("Anne Hathaway", 42);
Artista owenWilson = new Artista("Owen Wilson", 56);
Artista paulNewman = new Artista("Paul Newman", 83);
interstellar.AdicionarAoElenco(new List<Artista> { matthew, anneHathaway });
carros.AdicionarAoElenco(new List<Artista> { owenWilson, paulNewman });


List<Artista> artistas = new();
artistas.Add(matthew);
artistas.Add(anneHathaway);
artistas.Add(owenWilson);
artistas.Add(paulNewman);

foreach(Artista a in artistas)
{
    a.ExibirInformacoes();
}