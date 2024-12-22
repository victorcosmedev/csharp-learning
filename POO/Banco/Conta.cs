class Conta
{
    public string Agencia { get; set; }
    public string NumeroDaConta { get; set; }
    public Titular Titular { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public double Limite { get; set; }

    public Conta(string agencia, string numeroDaConta, Titular titular, double saldo, string senha, double limite)
    {
        this.Agencia = agencia;
        this.NumeroDaConta = numeroDaConta;
        this.Titular = titular;
        this.Saldo = saldo;
        this.Senha = senha;
        this.Limite = limite;
    }


    public void ExibirInformacoes()
    {
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Número da Conta: {NumeroDaConta}");
        Titular.ExibirInformacoesDoTitular();
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
        Console.WriteLine($"Limite: {Limite}");
    }
}