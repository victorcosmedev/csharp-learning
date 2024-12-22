class Titular
{

    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }

    public Titular(string nome, string cpf, DateTime dataNascimento, string telefone)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Telefone = telefone;
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
    }

    public void ExibirInformacoesDoTitular()
    {
        Console.WriteLine("======================================");
        Console.WriteLine($"Nome do titular: {this.Nome}");
        Console.WriteLine($"CPF: {this.Cpf}");
        Console.WriteLine($"Data de Nascimento: {this.DataNascimento}");
        Console.WriteLine($"Telefone: {this.Telefone}");
        Console.WriteLine("======================================");
    }
}