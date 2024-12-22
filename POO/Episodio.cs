class Episodio
{

    public Episodio(int duracao, int ordem, string titulo)
    {
        this.Ordem = ordem;
        this.Titulo = titulo;
        this.Duracao = duracao;
        this.convidados = new();
    }
    
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} mins) - {string.Join(", ", this.convidados)}";

    private List<string> convidados;

    public void AdicionarConvidados(List<string> convidados)
    {
        this.convidados.AddRange(convidados);
    }

    public void AdicionarConvidados(string convidado)
    {
        this.convidados.Add(convidado);
    }
}