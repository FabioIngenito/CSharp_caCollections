using System.Collections.ObjectModel;

namespace caCollections;

public class Curso
{
    //Implementando um dicionário de Alunos para trabalhar paralelamente.
    internal IDictionary<int, Aluno> dicionarioAlunos = 
        new Dictionary<int, Aluno>();

    //alunos deve ser ISet. Alunos deve retornar ReadOnlyCollection
    private readonly ISet<Aluno> alunos = new HashSet<Aluno>();
    public IList<Aluno> Alunos
    {
        get
        {
            return new ReadOnlyCollection<Aluno>(alunos.ToList());

        }
    }

    //private List<Aula> aulas;
    private readonly IList<Aula> aulas;
    private string nome;
    private string instrutor;

    public Curso(string nome, string instrutor)
    {
        this.nome = nome;
        this.instrutor = instrutor;
        this.aulas = new List<Aula>();
    }

    //public List<Aula> Aulas
    //{
    //	get { return aulas; }
    //	set { aulas = value; }
    //}

    public IList<Aula> Aulas
    {
        //get { return aulas; }
        //set { aulas = value; }

        // Uma coleção somente leitura:
        get { return new ReadOnlyCollection<Aula>(aulas); }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Instrutor
    {
        get { return instrutor; }
        set { instrutor = value; }
    }

    internal void Adiciona(Aula aula)
    {
        aulas.Add(aula);
    }

    public int TempoTotal
    {
        get
        {
            int total = 0;

            foreach (Aula aula in aulas)
            {
                total += aula.Tempo;
            }

            return total;
        }
    }

    public int TempoTotal_LINQ
    {
        get
        {
            //LINQ = Language Integrated Query - Consulta Integrada a Linguagem
            return aulas.Sum(aula => aula.Tempo);
        }
    }

    public override string ToString()
    {
        return $"Curso: {nome}, Tempo: {TempoTotal_LINQ} , Aulas: {string.Join(",", aulas)}";
    }

    internal void Matricula(Aluno aluno)
    {
        alunos.Add(aluno);

        // Alimentar o dicionário
        dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
    }

    internal bool EstaMatriculado(Aluno aluno)
    {
        return alunos.Contains(aluno);
    }

    internal Aluno BuscaMatriculado1(int numeroMatricula)
    {
        foreach (Aluno aluno in alunos)
            if (aluno.NumeroMatricula == numeroMatricula) return aluno;

        throw new Exception($"Matrícula NÃO encontrada: {numeroMatricula}.");
    }

    internal Aluno? BuscaMatriculado(int numeroMatricula)
    {
        // SOMENTE SE TIVER CERTEZA QUE A MATRÍCULA EXISTE NA BASE DE DADOS (apresenta erro caso não exista):
        //return dicionarioAlunos[numeroMatricula];

        // TRATAR TMABÉM MATRÍCULAS QUE NÃO EXISTEM NA BASE DE DADOS:
        _ = dicionarioAlunos.TryGetValue(numeroMatricula, out Aluno? aluno);

        return aluno;
    }

    internal void SubstituiAluno(Aluno aluno)
    {
        dicionarioAlunos[aluno.NumeroMatricula] = aluno;
    }
}
