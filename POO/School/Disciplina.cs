class Disciplina
{
    public string Nome { get; set; }
    List<Aluno> listaDeAlunos;

    public Disciplina(string nome)
    {
        Nome = nome;
        this.listaDeAlunos = new List<Aluno>();
    }

    public void MatricularAluno(Aluno aluno)
    {
        this.listaDeAlunos.Add(aluno);
    }

    public void MatricularAluno(List<Aluno> alunos)
    {
        foreach(Aluno aluno in alunos)
        {
            this.listaDeAlunos.Add(aluno);
        }
    }

    public void ExibirAlunosMatriculados()
    {
        foreach(Aluno a in this.listaDeAlunos)
        {
            a.ExibirInfoAluno();
        }
    }
}