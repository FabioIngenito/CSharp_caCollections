namespace caCollections;

internal class SortedList
{
    public static void Inicio()
    {
        char? opcao = '0';

        IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        IDictionary<string, Aluno> alunosDicionarioSorted = new SortedList<string, Aluno>
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("======================================================");
            Console.WriteLine("===          Sorted List Dictionary C#             ===");
            Console.WriteLine("=== 1 - Criar um IDictionary                       ===");
            Console.WriteLine("=== 2 - Remover e Adicionar um item do IDictionary ===");
            Console.WriteLine("=== 3 - SortedList implementa um IDictionary       ===");
            Console.WriteLine("=== 4 - Remover e Adicionar um item do SortedList  ===");
            Console.WriteLine("=== X - Sair do Sistema                            ===");
            Console.WriteLine("======================================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        CriarDicionario(ref alunos);
                        break;
                    case '2':
                        RemoverAdicionarItemDicionario();
                        break;
                    case '3':
                        SortedListIDictionary(alunos, alunosDicionarioSorted);
                        break;
                    case '4':
                        RemoverAdicionarItemSortedList();
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

    private static void CriarDicionario(ref IDictionary<string, Aluno> alunos)
    {
        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

    private static void RemoverAdicionarItemDicionario()
    {
        IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        Console.WriteLine("*** DICIONÁRIO ORIGINAL:");
        Suporte.Imprimir(alunos);
        Console.WriteLine();

        // Remover "AL"
        Console.WriteLine("*** REMOVER 'AL'");
        alunos.Remove("AL");
        Suporte.Imprimir(alunos);
        Console.WriteLine();

        // Adicionar
        Console.WriteLine("*** ADICIONAR 'MO'");
        alunos.Add("MO", new Aluno("Marcelo", 12345));

        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

    /// <summary>
    /// A classe SortedList funciona como um dicionário e implementa a 
    /// interface IDictionary <TKey, TValue>.
    /// 
    /// SortedList é uma coleção chave-valor que mantém internamente 2 
    /// listas, sendo uma lista para as chaves e outra lista para valores. 
    /// A lista de chaves está sempre ordenada e seus elementos apontam 
    /// para elementos da lista de valores. Já num SortedDictionary, 
    /// os elementos são mantidos internamente ordenados, através de 
    /// uma árvore binária balanceada.
    /// </summary>
    /// <param name="alunos"></param>
    private static void SortedListIDictionary(IDictionary<string, Aluno> alunos, IDictionary<string, Aluno> alunosDicionarioSorted)
    {
        Console.WriteLine("*** DICIONÁRIO ORIGINAL:");
        Suporte.Imprimir(alunos);
        Console.WriteLine();

        Console.WriteLine("*** IDictionary COM SortedList:");
        Suporte.Imprimir(alunosDicionarioSorted);
        Console.WriteLine();

        Console.WriteLine("*** SOMENTE SortedList:");
        SortedList<string, Aluno> alunosSorted = new()
        {
            { "VT", new Aluno("Vanessa", 34672) },
            { "AL", new Aluno("Ana", 5617) },
            { "RN", new Aluno("Rafael", 17645) },
            { "WM", new Aluno("Wanderson", 11287) }
        };

        Suporte.Imprimir(alunosSorted);
        Suporte.Finaliza();
    }

    private static void RemoverAdicionarItemSortedList()
    {
        IDictionary<string, Aluno> alunosSorted = new SortedList<string, Aluno>
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
