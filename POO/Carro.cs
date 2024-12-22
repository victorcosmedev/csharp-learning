using System.IO.Pipes;

class Carro
{
    public string Montadora { get; set; }
    public string Modelo { get; set; }
    public float Velocidade { get; set; }
    private int ano;
    public int Ano
    {
        get => ano;
        set
        {
            if(value >= 1960 && value <= 2023)
            {
                ano = value;
            } else
            {
                ano = 0;
            }
        }
    }
    public string DescricaoDetalhada => $"{this.Montadora} {this.Modelo} ano {this.Ano}";

    public void acelerar(float aceleracao)
    {
        this.Velocidade = this.Velocidade + aceleracao;
    }

    public void frear(float desaceleracao)
    {
        this.Velocidade -= desaceleracao;
    }

    public void buzinar()
    {
        Console.WriteLine("BIIII BIIII");
    }
}