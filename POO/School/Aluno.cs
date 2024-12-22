class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; }

    public double Media 
    {
        get
        {
            return this.Notas.Average(x => x);
        }
    }
    
    public Aluno(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Notas = new List<double>();
    }

    public void AtribuirNota(int nota)
    {
        this.Notas.Add(nota);
    }

    public void AtribuirNota(List<double> notas)
    {
        foreach(double nota in notas)
        {
            this.Notas.Add(nota);
        }
    }

    public void ExibirInfoAluno()
    {
        Console.WriteLine("==============================");
        Console.WriteLine($"Nome do(a) aluno(a): {this.Nome}");
        Console.WriteLine($"Idade do(a) aluno(a): {this.Idade}");
        Console.WriteLine($"Média do aluno: {this.Media}");
        Console.WriteLine("==============================");
    }
}