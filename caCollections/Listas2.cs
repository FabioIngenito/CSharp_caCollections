namespace caCollections;

public class Listas2
{
    public static void Inicio()
    {
        char? opcao = '0';

        string aulaIntro = "Introdução às Coleções";
        string aulaModelando = "Modelando a Classe Aula";
        string aulaSets = "Trabalhando com Conjuntos";

        // Um forma de declarar um Array:
        List<Aula> aulas1 = new()
        {
            new(aulaIntro,20),
            new(aulaModelando,18),
            new(aulaSets,16)
        };

        // Outra forma de declarar um array:
        // Um array é uma coleção de tamanho FIXO.
        List<Aula> aulas2 = new();

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("===      Listas de Objetos Collection C#      ===");
            Console.WriteLine("=== 1 - Populando e imprimindo Aula 1, 2 e 3  ===");
            Console.WriteLine("=== 2 - Ordenando a List<Objeto>              ===");
            Console.WriteLine("=== 3 - Ordenando a c/ LAMBDA -> propr. Tempo ===");
            Console.WriteLine("=== 4 - Read Only Collection - List<Objeto>   ===");
            Console.WriteLine("=== 5 - Ordenando                             ===");
            Console.WriteLine("=== 6 - Totalizando                           ===");
            Console.WriteLine("=== X - Sair do Sistema                       ===");
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        PopulandoImprimindo(aulas2);
                        break;
                    case '2':
                        OrdenandoLista(aulas1);
                        break;
                    case '3':
                        OrdenandoListaLAMBDA(aulas1);
                        break;
                    case '4':
                        SomenteLeitura();
                        break;
                    case '5':
                        Ordenando();
                        break;
                    case '6':
                        Totalizando();
                        break;
                    case 'X':
                    case 'x':
                        break;
                    default:
                        Console.WriteLine("Opcao não implementada.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
                Console.ReadKey();
            }
        }
    }

    /// <summary>
    /// Populando e Imprimindo
    /// </summary>
    /// <param name="aulas">List<Aula></Aula></param>
    private static void PopulandoImprimindo(List<Aula> aulas1)
    {
        Aula aulaIntro = new("Introdução às Coleções", 20);
        Aula aulaModelando = new("Modelando a Classe Aula", 18);
        Aula aulaSets = new("Trabalhando com Conjuntos", 16);

        aulas1.Add(aulaIntro);
        aulas1.Add(aulaModelando);
        aulas1.Add(aulaSets);
        //ERRO, precisa ser um objeto ou herança do objeto:
        //aulas.Add("Conclusão");
        //CORRETO:
        //aulas1.Add(new("Conclusão", 0));

        //ERRO: (objeto.nomeDaClasse)
        //Imprimir(aulas1);
        //CORRETO: Depois de personalizar a propriedade ".ToString()": 
        Imprimir(aulas1);
        Finaliza();
    }

    /// <summary>
    /// Ordenando array
    /// </summary>
    /// <param name="aula">Array aula</param>
    private static void OrdenandoLista(List<Aula> aulas)
    {
        Console.WriteLine("---------- Ordenando ou 'Sort' uma coleção Array. Não é idempotente como o Reverse().");
        //ERRO: Esta operação exige que a nossa lista implemente uma interface iComparable
        //aulas.Sort();
        //CORRETO: Depois de impllementar a interface iComparable.
        aulas.Sort();
        Imprimir(aulas);
        Finaliza();
    }

    /// <summary>
    /// Ordenando array com LAMBDA
    /// </summary>
    /// <param name="aula">List<Aula> aula</param>
    private static void OrdenandoListaLAMBDA(List<Aula> aulas)
    {
        Console.WriteLine("---------- Ordenando com Lambda.");
        aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
        Imprimir(aulas);
        Finaliza();
    }

    /// <summary>
    /// Uma classe possui uma lista List<T>, que é um campo privado da classe, e essa 
    /// lista precisa ser protegida contra gravação de fora da classe. Então uma propriedade 
    /// pública pode expor para os clientes da classe uma nova instância de uma lista 
    /// somente-leitura (ReadOnlyCollection<T>), usando como origem de dados a lista interna 
    /// que precisa ser protegida.
    /// </summary>
    private static void SomenteLeitura()
    {
        Curso csharpColecoes = new("C# Colections", "Marcelo Oliveira");

        //Code Smell... Exposição indecente        
        //Bloquear a lista interna para que não possa ser manipulada por codigo exterior.
        // NÃO acessar AULAS dentro da coleção
        //csharpColecoes.Aulas.Add(new Aula("Trabalhando com Listas", 21));

        //Encapsular em um método, na classe Curso
        csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));

        Console.WriteLine("---------- Somente leitura.");

        Imprimir(csharpColecoes.Aulas);
        Finaliza();
    }

    private static void Ordenando()
    {
        Curso csharpColecoes = new("C# Colections", "Marcelo Oliveira");
        csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));

        //Adicionar duas aulas
        csharpColecoes.Adiciona(new Aula("Criando um aula", 20));
        csharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));

        Imprimir(csharpColecoes.Aulas);

        //Ordenar a lista
        //ERRO:
        //csharpColecoes.Aulas.Sort();

        //copia a lista para outra lista
        List<Aula> aulasCopiadas = new(csharpColecoes.Aulas);

        //ordenar a cópia
        aulasCopiadas.Sort();

        Imprimir(aulasCopiadas);
        Finaliza();
    }

    private static void Totalizando()
    {
        Curso csharpColecoes = new("C# Colections", "Marcelo Oliveira");
        csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
        csharpColecoes.Adiciona(new Aula("Criando um aula", 20));
        csharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));
        Imprimir(csharpColecoes.Aulas);

        //Totalizar o tempo do curso sem LINQ e com LINQ
        Console.WriteLine($"Tempo Total: {csharpColecoes.TempoTotal}");
        Console.WriteLine($"Tempo Total: {csharpColecoes.TempoTotal_LINQ}");
        Console.WriteLine(csharpColecoes);
        Finaliza();
    }

    #region SUPORTE
    /// <summary>
    /// Varrendo com "foreach"
    /// </summary>
    /// <param name="aulas">Uma Array Aulas</param>
    private static void Imprimir(IList<Aula> aulas)
    {
        Console.Clear();

        foreach (Aula aula in aulas)
            Console.WriteLine(aula);
    }

    /// <summary>
    /// Somente para finalizar.
    /// </summary>
    private static void Finaliza()
    {
        Console.WriteLine();
        Console.WriteLine("Digite QQ Tecla.");
        Console.ReadKey();
    }
    #endregion
}

//public class Aula : IComparable<Aula>
//{
//    private string titulo;
//    private int tempo;

//    public Aula(string titulo, int tempo)
//    {
//        this.titulo = titulo;
//        this.tempo = tempo;
//    }

//    public string Titulo 
//    { 
//        get => titulo; 
//        set => titulo = value; 
//    }
    
//    public int Tempo 
//    { 
//        get => tempo; 
//        set => tempo = value; 
//    }

//    public int CompareTo(Aula? other)
//    {
//        return this.titulo.CompareTo(other.titulo);
//    }

//    /// <summary>
//    /// Fazendo o Override (objeto.nomeDaClasse)
//    /// </summary>
//    /// <returns>Retorna Texto Personalizado</returns>
//    public override string ToString()
//    {
//        return $"[título: {titulo}, tempo: {tempo} minutos]";
//    }
//}
