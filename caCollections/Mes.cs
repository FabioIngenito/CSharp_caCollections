namespace caCollections;

public class Mes : IComparable
{
    public string Nome { get; private set; }
    public int Dias { get; private set; }

    public Mes(string nome, int dias)
    {
        Nome = nome;
        Dias = dias;
    }

    public override string ToString()
    {
        return $"{Nome} - {Dias}";
    }

    public int CompareTo(object? obj)
    {
        if (obj is Mes outro)
            return Nome.CompareTo(outro.Nome);
        else
            return 0;
    }
}
