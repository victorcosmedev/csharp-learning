namespace POO.Models;

internal class Medico
{
    public Medico(string nome, string crm, int idade, string cpf)
    {
        this.Nome = nome;
        this.Crm = crm;
        this.Idade = idade;
        this.Cpf = cpf;
    }
    public string Nome { get; }
    public string Crm { get; }
    public int Idade { get; }
    public string Cpf { get; }
}
