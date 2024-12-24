namespace POO.Models;
internal class Pet
{
    public Pet(string nome, double idade, Dono dono)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Dono = dono;
    }

    public string Nome { get; }
    public double Idade { get; }
    public Dono Dono { get; }
}
