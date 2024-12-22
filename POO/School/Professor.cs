class Professor
{
    public string Nome { get; set; }
    List<Disciplina> DisciplinasLecionadas;

    public Professor(string nome, List<Disciplina> disciplinasLecionadas)
    {
        Nome = nome;
        DisciplinasLecionadas = disciplinasLecionadas;
    }

    public void AssignDisciplina(Disciplina disciplina)
    {
        this.DisciplinasLecionadas.Add(disciplina);
    }

    public void UnassignDisciplina(Disciplina disciplina)
    {
        if (this.DisciplinasLecionadas.Contains(disciplina))
        {
            this.DisciplinasLecionadas.Remove(disciplina);
        }
    }

    public void ExibirAlunosDoProfessor()
    {
        foreach (Disciplina disciplina in this.DisciplinasLecionadas )
        {
            Console.WriteLine($"Alunos matriculados na disciplina {disciplina.Nome}");
            disciplina.ExibirAlunosMatriculados();
        }
    }
}