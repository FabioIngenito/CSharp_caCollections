namespace caCollections;

public class Aula : IComparable<Aula>
{
    private string titulo;
    private int tempo;

    public Aula(string titulo, int tempo)
    {
        this.titulo = titulo;
        this.tempo = tempo;
    }

    public string Titulo
    {
        get => titulo;
        set => titulo = value;
    }

    public int Tempo
    {
        get => tempo;
        set => tempo = value;
    }

    public int CompareTo(Aula? other)
    {
        return this.titulo.CompareTo(other.titulo);
    }

    /// <summary>
    /// Fazendo o Override (objeto.nomeDaClasse)
    /// </summary>
    /// <returns>Retorna Texto Personalizado</returns>
    public override string ToString()
    {
        return $"[título: {titulo}, tempo: {tempo} minutos]";
    }

    /// <summary>
    /// Alterando os métodos Equals() e GetHashCode() para levar 
    /// em consideração os títulos em maiúsculo com ToUpper(), nós 
    /// podemos garantir que as diferenças entre maiúsculas e minúsculas 
    /// vão ser ignoradas na hora de comparar as aulas e assim evitaremos 
    /// a duplicidade no HashSet!
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        Aula? outra = obj as Aula;

        if (outra == null) return false;

        return titulo.ToUpper().Equals(outra.titulo.ToUpper());
    }

    public override int GetHashCode()
    {
        return titulo.GetHashCode();
    }
}