using System.Diagnostics.CodeAnalysis;

namespace caCollections;

internal class SortedSet
{
    public static void Inicio()
    {
        char? opcao = '0';

        //Conjunto de alunos:
        //Colocado propositalmente para mostrar outra forma de adicionar, usando (.add)
#pragma warning disable IDE0028 // Simplificar a inicialização de coleção
        ISet<string> alunos = new HashSet<string>()
            {
            "Vanessa Tonini",
            "Ana Losnak",
            "Rafael Nercessian",
            "Priscila Stuani"
            };
#pragma warning restore IDE0028 // Simplificar a inicialização de coleção

        alunos.Add("Rafael Rollo");
        alunos.Add("Fabio Gushiken");
        alunos.Add("Fabio Gushiken");
        alunos.Add("FABIO GUSHIKEN");

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("===                 SortedSet HasSet C#             ===");
            Console.WriteLine("=== 1 - Criar e imprimir uma coleção ISet HashSet   ===");
            Console.WriteLine("=== 1 - Criar e imprimir uma coleção ISet SortedSet ===");
            Console.WriteLine("=== 3 - Conjuntos usando conceitos da matemática    ===");
            Console.WriteLine("=== X - Sair do Sistema                             ===");
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        CriarImprimirISetHashSet(ref alunos);
                        break;
                    case '2':
                        CriarImprimirISetSortedSet();
                        break;
                    case '3':
                        ConjuntosMatematica(alunos);
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

    private static void CriarImprimirISetHashSet(ref ISet<string> alunos)
    {
        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

    /// <summary>
    /// O SortedSet deixou os elementos ordenados e evitou a duplicação do 
    /// elemento "Fabio Gushiken". 
    /// Observação: O outro "FABIO GUSHIKEN" é considerado diferente pelo
    /// SortedSet, pois é case sensitive.
    /// É possível trabalhar este 'problema' com um "IComparer string".
    /// </summary>
    private static void CriarImprimirISetSortedSet()
    {
        //Conjunto de alunos:
        //Colocado propositalmente para mostrar outra forma de adicionar, usando (.add)
#pragma warning disable IDE0028 // Simplificar a inicialização de coleção
        ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
            "Vanessa Tonini",
            "Ana Losnak",
            "Rafael Nercessian",
            "Priscila Stuani"
            };
#pragma warning restore IDE0028 // Simplificar a inicialização de coleção

        alunos.Add("Rafael Rollo");
        alunos.Add("Fabio Gushiken");
        alunos.Add("Fabio Gushiken");
        alunos.Add("FABIO GUSHIKEN");

        Suporte.Imprimir(alunos);
        Suporte.Finaliza();
    }

    private static void ConjuntosMatematica(ISet<string> alunos)
    {
        ISet<string> outroConjunto = new HashSet<string>()
        {
        "Vanessa Tonini",
        "Ana Losnak",
        "Rafael Nercessian",
        "Priscila Stuani"
        };

        // Este conjunto é subconjunto do outro? IsSubsetOf
        Console.WriteLine($"Este conjunto é subconjunto do outro? {alunos.IsSubsetOf(outroConjunto)}");
        Suporte.Imprimir(alunos);
        Console.WriteLine();
        Suporte.Imprimir(outroConjunto);
        Suporte.EmpacaTela();
        Console.WriteLine();

        // Este conjunto é superconjunto do outro? IsSupersetOf
        Console.WriteLine($"Este conjunto é superconjunto do outro? {alunos.IsSupersetOf(outroConjunto)}");
        Suporte.Imprimir(alunos);
        Console.WriteLine();
        Suporte.Imprimir(outroConjunto);
        Suporte.EmpacaTela();
        Console.WriteLine();

        // Os conjuntos contém os mesmo elementos? SetEquals
        Console.WriteLine($"Os conjuntos contém os mesmo elementos? {alunos.SetEquals(outroConjunto)}");
        Suporte.Imprimir(alunos);
        Console.WriteLine();
        Suporte.Imprimir(outroConjunto);
        Suporte.EmpacaTela();
        Console.WriteLine();

        //subtrai os elementos da outra coleção que também estão no conjunto. ExceptWith
        alunos.ExceptWith(outroConjunto);

        //interseccção dos conjutos - IntersectWith
        alunos.IntersectWith(outroConjunto);

        // somente em um ou outro conjunto - SymmetricExceptWith
        alunos.SymmetricExceptWith(outroConjunto);

        // união de conjutos - UnionWith
        alunos.UnionWith(outroConjunto);

        Suporte.Finaliza();
    }
}

internal class ComparadorMinusculo : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
    }
}