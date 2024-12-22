// Screen Sound
Banda racionais = new Banda("Racionais MC's");

Album albumDoRacionais = new Album("Sobrevivendo no Inferno");

Musica musica1 = new Musica("Mágico de Oz", racionais)
{
    Duracao = 213, // Passando argumentos opcionais ao objeto
    Disponivel = true,
};
Musica musica2 = new Musica("Capítulo 4, Versículo 3", racionais)
{
    Duracao = 354,
    Disponivel = false,// Passando argumentos opcionais ao objeto (Inicializadores ou Initializers)
};

//albumDoRacionais.AdicionarMusica(musica1);
//albumDoRacionais.AdicionarMusica(musica2);

//racionais.AdicionarAlbum(albumDoRacionais);
//racionais.ExibirDiscografia();

// Conta
//Titular titular = new Titular("Victor", "43476250814", new DateTime(), "989808390");
//Conta contaBancaria = new Conta("1234", "4321", titular, 10000, "8456", 1000);
//contaBancaria.ExibirInformacoes();

// Estoque
//Estoque estoque = new Estoque();
//Produto notebook = new Produto("VivoBook 15", "Asus", 2500, 15);
//Produto celular = new Produto("S23", "Samsung", 2500, 10);
//estoque.AdicionarProduto(notebook);
//estoque.AdicionarProduto(celular);
//estoque.ExibirEstoque();

// Escola
//Aluno victor = new Aluno("Victor", 19);
//Aluno galoDoido = new Aluno("Yasmin", 18);
//victor.AtribuirNota(new List<double> { 10, 8.5, 7 });
//galoDoido.AtribuirNota(new List<double> { 9, 8, 5 });

//Disciplina aulaDoFlavioBolsonaro = new Disciplina("Fundamentos da Computação");
//Disciplina aulaDaNoemi = new Disciplina("Lógica");
//Disciplina aulaDaVania = new Disciplina("Esqueci o nome da matéria");

//aulaDoFlavioBolsonaro.MatricularAluno(new List<Aluno> { victor, galoDoido });
//aulaDaNoemi.MatricularAluno(new List<Aluno> { victor, galoDoido });
//aulaDaVania.MatricularAluno(new List<Aluno> { victor, galoDoido });

//Professor flavioBolsonaro = new Professor("Flávio Bolsonaro", new List<Disciplina> { aulaDoFlavioBolsonaro });
//Professor noemi = new Professor("Noemi", new List<Disciplina> { aulaDaNoemi });
//Professor vania = new Professor("Vania", new List<Disciplina> { aulaDaVania });

//List<Professor> professores = new List<Professor> { flavioBolsonaro, noemi, vania };

//foreach(Professor professor in professores)
//{
//    professor.ExibirAlunosDoProfessor();
//}

Podcast rodaSolta = new Podcast("Roda Solta", "Danilo Gentilli");
Episodio ep1 = new Episodio(1000, 1, "Roda Solta com Tiringa");
Episodio ep2 = new Episodio(2000, 2, "Roda Solta com Paula Fernandes");
Episodio ep3 = new Episodio(3000, 2, "Roda Solta com Rogério Skylab");

ep1.AdicionarConvidados(new List<string> { "Madruguinha", "Dilera", "Elvis Presley" });
ep2.AdicionarConvidados(new List<string> { "Madruguinha", "Dilera", "Elvis Presley" });
ep3.AdicionarConvidados(new List<string> { "Madruguinha", "Dilera", "Elvis Presley" });

rodaSolta.AdicionarEpisodio(new List<Episodio> { ep1, ep2, ep3 });
rodaSolta.ExibirDetalhes();