namespace caCollections;

public class Aluno
{
    private string nome;
    private int numeroMatricula;

    public Aluno(string nome, int numeroMatricula)
    {
        this.nome = nome;
        this.numeroMatricula = numeroMatricula;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int NumeroMatricula
    {
        get { return numeroMatricula; }
        set { numeroMatricula = value; }
    }

    public override string ToString()
    {
        return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
    }

    /// <summary>
    /// É preciso implementar (sobreescrever) o método Equals() da classe object na 
    /// classe Aula para retornar True se os títulos das duas instâncias da classe Aula 
    /// forem iguais, e implementar também o método GetHashCode() para retornar o mesmo 
    /// código de dispersão caso os títulos forem iguais.
    /// 
    /// O método Equals define se dois objetos são iguais, porém ele também depende da 
    /// implementação correta do método GetHashCode(), que deverá retornar o mesmo número 
    /// de dispersão para objetos considerados iguais.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        // MANDEI PROPOSITALMENTE SUPRIMIR ESTA MENSAGEM PARA MOSTRAR ESTA FORMA DE ESCREVER.
#pragma warning disable IDE0019 // Usar a correspondência de padrão
        Aluno? outro = obj as Aluno;
#pragma warning restore IDE0019 // Usar a correspondência de padrão

        if (outro == null) return false;

        return this.nome.Equals(outro.nome);
    }

    /// <summary>
    /// Importante: A rapidez da busca depende do CÓDIGO DE DISPERSÃO.
    /// 
    /// * Dois objetos que são iguais possuem o mesmo hash code.
    /// Porém, o contrário NÃO é verdadeiro.
    /// Dois objetos com mesmo hash code NÃO são iguais!
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public override int GetHashCode()
    {
        return this.nome.GetHashCode();
    }
}
