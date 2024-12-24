namespace POO.Models;

internal class Dono
{
    public Dono(string nome, string cpf, int idade, string contato)
    {
        this.Nome = nome;
        this.Cpf = cpf;
        this.Idade = idade;
        this.Contato = contato;
    }

    public string Nome { get; }
    public string Cpf { get; }
    public int Idade { get; }
    public string Contato { get; }

}
