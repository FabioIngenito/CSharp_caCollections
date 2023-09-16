namespace caCollections;

internal class OperadoresConjuntosLINQ
{
    public static void Inicio()
    {
        char? opcao = '0';

        // PROBLEMA: pegar o primeiro trimestre

        string[] seq1 = { "janeiro", "fevereiro", "março" };
        string[] seq2 = { "fevereiro", "MARÇO", "abril" };

        while (opcao != 'X' && opcao != 'x')
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("===      Operadores de Conjuntos LINQ C#       ===");
            Console.WriteLine("=== 1 - Concatenando duas sequências           ===");
            Console.WriteLine("=== 2 - Unindo duas sequencias                 ===");
            Console.WriteLine("=== 3 - Unindo duas sequencias com comparador  ===");
            Console.WriteLine("=== 4 - Interseção de duas sequências          ===");
            Console.WriteLine("=== 5 - Exceto Elementos da primeira sequência ===");
            Console.WriteLine("=== 6 - Sequência Union Diferença na Ordem     ===");
            Console.WriteLine("=== X - Sair do Sistema                        ===");
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()![0];

                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        ConcatenandoDuasSequencias(seq1, seq2);
                        break;
                    case '2':
                        UnindoDuasSequencias(seq1, seq2);
                        break;
                    case '3':
                        UnindoDuasSequenciasComComparador(seq1, seq2);
                        break;
                    case '4':
                        IntersecaoDuasSequencias(seq1, seq2);
                        break;
                    case '5':
                        ExcetoElementosPrimeiraSequencia(seq1, seq2);
                        break;
                    case '6':
                        SequenciaUnionDiferencaOrdem();
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

    private static void ConcatenandoDuasSequencias(string[] s1, string[] s2)
    {
        IEnumerable<string> consulta = s1.Concat(s2);

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    /// <summary>
    /// O método Union une os elementos da sequência S1 com os da sequência S2, 
    /// removendo as duplicidades.
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    private static void UnindoDuasSequencias(string[] s1, string[] s2)
    {
        IEnumerable<string> consulta = s1.Union(s2);

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    /// <summary>
    ///  O comparador StringComparer.CurrentCultureIgnoreCase faz com que 
    ///  as diferenças entre letras maiúsculas e minúsculas sejam ignoradas.
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    private static void UnindoDuasSequenciasComComparador(string[] s1, string[] s2)
    {
        IEnumerable<string> consulta = s1.Union(s2, StringComparer.InvariantCultureIgnoreCase);

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Somente o que é comum aos dois conjuntos ou em outras
    /// palavras: Somente o que existe de igual nos dois conjuntos.
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    private static void IntersecaoDuasSequencias(string[] s1, string[] s2)
    {
        IEnumerable<string> consulta = s1.Intersect(s2);

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Estão na sequência 1, mas não estão na sequência 2.
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    private static void ExcetoElementosPrimeiraSequencia(string[] s1, string[] s2)
    {
        IEnumerable<string> consulta = s1.Except(s2);

        Suporte.Imprimir(consulta);
        Suporte.Finaliza();
    }

    /// <summary>
    /// Comparando "S1 UNION S2" com "S2 UNION S1".
    /// </summary>
    private static void SequenciaUnionDiferencaOrdem()
    {
        string[] dias1 = { "segunda", "terça", "quarta" };
        string[] dias2 = { "terça", "QUARTA", "quinta" };

        IEnumerable<string> D1 = dias1.Union(dias2, StringComparer.CurrentCultureIgnoreCase);
        IEnumerable<string> D2 = dias2.Union(dias1, StringComparer.CurrentCultureIgnoreCase);

        Console.WriteLine("Veja que é DIFERENTE comparar S1 com S2 E S2 com S1: ");
        Console.WriteLine("---------------------");
        Suporte.Imprimir(D1);
        Console.WriteLine("---------------------");
        Suporte.Imprimir(D2);
        Console.WriteLine("---------------------");
        Console.WriteLine("Apesar do resultado ser 'igual', pois pegou 'os mesmos' valores, mas em outra ordem!");
        Suporte.Finaliza();
    }
}
