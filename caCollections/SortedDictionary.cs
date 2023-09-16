namespace caCollections;

internal class SortedDictionary
{
    public static void Inicio()
    {
        char? opcao = '0';

        IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine("===           SortedDictionary Dictionary C#            ===");
            Console.WriteLine("=== 1 - Criar um dicionário com SortedList              ===");
            Console.WriteLine("=== 2 - Criar um dicionário com SortedDictionary        ===");
            Console.WriteLine("=== 3 - SortedList implementa um IDictionary            ===");
            Console.WriteLine("=== 4 - Remover e Adicionar um item do SortedDictionary ===");
            Console.WriteLine("=== X - Sair do Sistema                                 ===");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        CriarDicionarioSortedList(ref sorted);
                        break;
                    case '2':
                        CriarDicionarioSortedDictionary();
                        break;
                    case '3':
                        SortedListIDictionary(sorted);
                        break;
                    case '4':
                        RemoverAdicionarItemSortedDictionary();
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

    private static void CriarDicionarioSortedList(ref IDictionary<string, Aluno> alunos)
    {
        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

    private static void CriarDicionarioSortedDictionary()
    {
        IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        Suporte.Imprimir(sorted);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Tanto a classe Sorted List quanto a Sorted Dictionary 
    /// implementam a inteface IDictionary<TKey, TValue>.
    /// 
    /// Uma SortedDictionary é mais adequada se você precisa inserir/remover 
    /// elementos com muita frequência, pois essas operações são otimizadas 
    /// pela sua estrutura interna de árvore binária balanceada.
    /// </summary>
    /// <param name="alunos"></param>
    private static void SortedListIDictionary(IDictionary<string, Aluno> alunos)
    {
        Console.WriteLine("*** DICIONÁRIO ORIGINAL:");
        Suporte.Imprimir(alunos);
        Console.WriteLine();

        Console.WriteLine("*** IDictionary COM SortedList:");
        IDictionary<string, Aluno> alunosDicionarioSorted = new SortedDictionary<string, Aluno>
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        Suporte.Imprimir(alunosDicionarioSorted);
        Console.WriteLine();

        Console.WriteLine("*** SOMENTE SortedDictionary:");
        SortedDictionary<string, Aluno> alunosSorted = new()
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        Suporte.Imprimir(alunosSorted);
        Suporte.Finaliza();
    }

    private static void RemoverAdicionarItemSortedDictionary()
    {
        SortedDictionary<string, Aluno> alunosSorted = new()
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        Console.WriteLine("*** DICIONÁRIO ORIGINAL:");
        Suporte.Imprimir(alunosSorted);
        Console.WriteLine();

        // Remover "AL"
        Console.WriteLine("*** REMOVER 'AL'");
        alunosSorted.Remove("AL");
        Suporte.Imprimir(alunosSorted);
        Console.WriteLine();

        // Adicionar
        Console.WriteLine("*** ADICIONAR 'MO'");
        alunosSorted.Add("MO", new Aluno("Marcelo", 12345));

        Suporte.Imprimir(alunosSorted);
        Suporte.Finaliza();
    }

}
